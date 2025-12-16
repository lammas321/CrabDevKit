using CrabDevKit.Intermediary;
using HarmonyLib;
using Il2CppSystem.Runtime.InteropServices;
using SteamworksNative;
using System;
using System.Collections.Generic;
using System.Linq;
using UnhollowerBaseLib;

namespace CrabDevKit.Utilities
{
    public sealed class CrabNet
    {
        public delegate void MessageHandler(ulong clientId, Packet packet);

        private uint _nextId = 0u;
        private readonly Dictionary<string, uint> _registeredMessageHandlers = [];
        private readonly Dictionary<uint, MessageHandler> _messageHandlers = [];

        private const int SendFlag = 8;
        private const int MessageChannel = 123;
        private const int MessagesPerFrame = 70;

        internal CrabNet()
        {
            Harmony _harmony = new($"{MyPluginInfo.PLUGIN_NAME}.CrabNet");
            _harmony.PatchAll(typeof(Patches));
        }


        public static bool RegisterMessageHandler(string messageId, MessageHandler messageHandler)
        {
            if (CrabDevKit.CrabNet == null)
                throw new InvalidOperationException("CrabNet has yet to be initialized. Ensure your plugin is depending on CrabDevKit, so that it initializes CrabNet before you use it!");

            if (string.IsNullOrEmpty(messageId))
                throw new ArgumentNullException(nameof(messageId), "messageId may not be null or empty.");

            if (!messageId.Contains(':'))
                throw new ArgumentException("A colon ':' separator character was expected in the messageId parameter. Your messageId should follow this format -> PluginName:MessageId", nameof(messageId));

            if (messageHandler == null)
                throw new ArgumentNullException(nameof(messageHandler));

            return CrabDevKit.CrabNet.RegisterMessageHandlerInternal(messageId, messageHandler);
        }
        
        private bool RegisterMessageHandlerInternal(string messageId, MessageHandler messageHandler)
        {
            if (string.IsNullOrEmpty(messageId))
                throw new ArgumentNullException(nameof(messageId), "messageId may not be null or empty.");

            if (messageHandler == null)
                throw new ArgumentNullException(nameof(messageHandler));

            if (SteamManager.Instance)
            {
                CrabDevKit.Instance.Log.LogWarning("Message handlers must be registered on plugin load!");
                return false;
            }

            if (_registeredMessageHandlers.ContainsKey(messageId))
            {
                CrabDevKit.Instance.Log.LogWarning($"Message handler '{messageId}' already exists!");
                return false;
            }

            uint id = _nextId;
            _nextId++;

            _registeredMessageHandlers.Add(messageId, id);
            _messageHandlers.Add(id, messageHandler);
            CrabDevKit.Instance.Log.LogInfo($"Registered message handler: {messageId} ({id})");

            return true;
        }


        private void RegisterMessageHandlers()
        {
            CSteamID lobbyId = LobbyManager.Instance.get_currentLobby();

            SteamMatchmaking.SetLobbyMemberData(lobbyId, "CrabNetVersion", MyPluginInfo.PLUGIN_VERSION);
            foreach ((string messageId, uint id) in _registeredMessageHandlers)
                SteamMatchmaking.SetLobbyMemberData(lobbyId, $"CrabNet:Message.{id}", messageId);

            CrabDevKit.Instance.Log.LogInfo("Registered message handlers for lobby.");
        }


        public static bool SendMessage(string messageId, Packet packet, params IEnumerable<ulong> clientIds)
        {
            if (CrabDevKit.CrabNet == null)
                throw new InvalidOperationException("CrabNet has yet to be initialized. Ensure your plugin is depending on CrabDevKit, so that it initializes CrabNet before you use it!");

            if (string.IsNullOrEmpty(messageId))
                throw new ArgumentNullException(nameof(messageId), "messageId may not be null or empty.");

            if (packet == null)
                throw new ArgumentNullException(nameof(packet));

            if (clientIds == null)
                throw new ArgumentNullException(nameof(clientIds));

            return CrabDevKit.CrabNet.SendMessageInternal(messageId, packet, clientIds.Select(clientId => new CSteamID(clientId)));
        }

        public static bool SendMessage(string messageId, Packet packet, params IEnumerable<CSteamID> steamIds)
        {
            if (CrabDevKit.CrabNet == null)
                throw new InvalidOperationException("CrabNet has yet to be initialized. Ensure your plugin is depending on CrabDevKit, so that it initializes CrabNet before you use it!");

            if (string.IsNullOrEmpty(messageId))
                throw new ArgumentNullException(nameof(messageId), "messageId may not be null or empty.");

            if (packet == null)
                throw new ArgumentNullException(nameof(packet));

            if (steamIds == null)
                throw new ArgumentNullException(nameof(steamIds));

            return CrabDevKit.CrabNet.SendMessageInternal(messageId, packet, steamIds);
        }

        private bool SendMessageInternal(string messageId, Packet packet, IEnumerable<CSteamID> steamIds)
        {
            if (string.IsNullOrEmpty(messageId))
                throw new ArgumentNullException(nameof(messageId), "messageId may not be null or empty.");

            if (packet == null)
                throw new ArgumentNullException(nameof(packet));

            if (steamIds == null)
                throw new ArgumentNullException(nameof(steamIds));

            if (!_registeredMessageHandlers.TryGetValue(messageId, out uint id))
            {
                CrabDevKit.Instance.Log.LogWarning($"Message handler '{messageId}' does not exist!");
                return false;
            }

            Packet sendPacket = new();
            sendPacket.Write((int)id);
            sendPacket.Write(packet.CloneBytes());

            foreach (CSteamID steamId in steamIds)
            {
                if (string.IsNullOrEmpty(SteamMatchmaking.GetLobbyMemberData(LobbyManager.Instance.get_currentLobby(), steamId, "CrabNetVersion")))
                {
                    CrabDevKit.Instance.Log.LogWarning($"{steamId.m_SteamID} does not have CrabNet, and cannot receive messages!");
                    continue;
                }

                if (steamId == SteamUser.GetSteamID())
                {
                    Packet readPacket = new(sendPacket.CloneBytes());
                    HandleMessage(steamId.m_SteamID, readPacket);
                }
                else
                    SteamPacketManager.SendPacket(steamId, sendPacket, SendFlag, (SteamPacketManager_NetworkChannel)MessageChannel);
            }

            sendPacket.Dispose();
            packet.Dispose();

            return true;
        }


        private void HandleMessage(SteamNetworkingMessage_t message)
        {
            ulong clientId = message.m_identityPeer.GetSteamID64();
            int size = message.m_cbSize;
            IntPtr dataPtr = message.m_pData;

            Il2CppStructArray<byte> data = new(size);
            Marshal.Copy(dataPtr, data, 0, size);

            Packet packet = new();
            packet.SetBytes(data);
            
            HandleMessage(clientId, packet);
        }

        private void HandleMessage(ulong clientId, Packet packet)
        {
            try
            {
                uint id = (uint)packet.ReadInt();
                string messageId = SteamMatchmaking.GetLobbyMemberData(LobbyManager.Instance.get_currentLobby(), new(clientId), $"CrabNet:Message.{id}");
                if (string.IsNullOrEmpty(messageId))
                {
                    CrabDevKit.Instance.Log.LogWarning($"Unable to identify messageId from '{id}'!");
                    return;
                }

                if (!_registeredMessageHandlers.TryGetValue(messageId, out id))
                {
                    CrabDevKit.Instance.Log.LogWarning($"{messageId} is not defined!");
                    return;
                }

                _messageHandlers[id](clientId, packet);

                packet.Dispose();
            }
            catch (Exception e)
            {
                CrabDevKit.Instance.Log.LogError($"An exception occurred handling a message:\n{e}");
            }
        }


        internal static class Patches
        {
            private readonly static Il2CppStructArray<IntPtr> _messagePtrs = new(MessagesPerFrame);

            [HarmonyPatch(typeof(SteamPacketManager), nameof(SteamPacketManager.CheckForPackets))]
            [HarmonyPostfix]
            internal static void PostSteamPacketManagerCheckForPackets()
            {
                int messages;
                do
                {
                    messages = SteamNetworkingMessages.ReceiveMessagesOnChannel(MessageChannel, _messagePtrs, MessagesPerFrame);
                    if (messages == 0)
                        return;

                    for (int messageIndex = 0; messageIndex < messages; messageIndex++)
                    {
                        SteamNetworkingMessage_t message = Marshal.PtrToStructure<SteamNetworkingMessage_t>(_messagePtrs[messageIndex]);

                        CrabDevKit.CrabNet.HandleMessage(message);
                    }
                }
                while (messages == MessagesPerFrame);
            }

            [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Method_Private_Void_LobbyEnter_t_PDM_1))]
            [HarmonyPostfix]
            [HarmonyPriority(int.MaxValue)]
            internal static void PostSteamManagerLobbyEnter(LobbyEnter_t param_1)
            {
                if (LobbyManager.Instance.get_currentLobby().m_SteamID == param_1.m_ulSteamIDLobby)
                    CrabDevKit.CrabNet.RegisterMessageHandlers();
            }
        }
    }
}