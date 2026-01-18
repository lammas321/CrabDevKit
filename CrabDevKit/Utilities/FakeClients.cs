using CrabDevKit.Intermediary;
using HarmonyLib;
using SteamworksNative;
using System;
using System.Collections.Generic;

namespace CrabDevKit.Utilities
{
    public static class FakeClients
    {
        internal const ulong MIN_ID = 10ul;

        private static readonly Dictionary<ulong, FakeClient> fakeClientIds = [];
        private static readonly List<FakeClient> fakeClients = [];

        internal static void Init()
        {
            Harmony _harmony = new($"{MyPluginInfo.PLUGIN_NAME}.FakeClients");
            _harmony.PatchAll(typeof(Patches));
        }

        public static FakeClient Create(string name = default, bool streamerMode = false, bool forceSpawnActive = false)
        {
            if (!SteamManager.Instance.IsLobbyOwner())
                return null;

            ulong fakeClientId = MIN_ID;
            while (LobbyManager.steamIdToUID.ContainsKey(fakeClientId) || fakeClientIds.ContainsKey(fakeClientId))
                fakeClientId++;

            FakeClient fakeClient = new(fakeClientId, name, streamerMode, forceSpawnActive);
            fakeClientIds.Add(fakeClientId, fakeClient);
            fakeClients.Add(fakeClient);

            LobbyChatUpdate_t fakeEv = new()
            {
                m_ulSteamIDLobby = LobbyManager.Instance.get_currentLobby().m_SteamID,
                m_ulSteamIDUserChanged = fakeClientId,
                m_ulSteamIDMakingChange = fakeClientId,
                m_rgfChatMemberStateChange = (uint)EChatMemberStateChange.k_EChatMemberStateChangeEntered
            };

            SteamManager.Instance.PlayerJoinOrLeave(fakeEv);

            CrabDevKit.Instance.Log.LogInfo($"Created fake client: {fakeClientId}");

            return fakeClient;
        }

        public static void Remove(FakeClient fakeClient)
        {
            if (!SteamManager.Instance.IsLobbyOwner() || !fakeClientIds.ContainsKey(fakeClient.clientId))
                return;

            LobbyChatUpdate_t fakeEv = new()
            {
                m_ulSteamIDLobby = LobbyManager.Instance.get_currentLobby().m_SteamID,
                m_ulSteamIDUserChanged = fakeClient.clientId,
                m_ulSteamIDMakingChange = fakeClient.clientId,
                m_rgfChatMemberStateChange = (uint)EChatMemberStateChange.k_EChatMemberStateChangeLeft
            };

            SteamManager.Instance.PlayerJoinOrLeave(fakeEv);

            fakeClients.Remove(fakeClientIds[fakeClient.clientId]);
            fakeClientIds.Remove(fakeClient.clientId);

            CrabDevKit.Instance.Log.LogInfo($"Removed fake client: {fakeClient.clientId}");
        }



        internal static class Patches
        {
            // Fake client in SteamMatchmaking
            [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.LeaveLobby))]
            [HarmonyPostfix]
            internal static void PostSteamMatchmakingLeaveLobby()
            {
                fakeClientIds.Clear();
                fakeClients.Clear();
            }

            [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.GetNumLobbyMembers))]
            [HarmonyPostfix]
            internal static void PostSteamMatchmakingGetNumLobbyMembers(ref int __result)
            {
                __result += fakeClients.Count;
            }

            [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.GetLobbyMemberByIndex))]
            [HarmonyPrefix]
            internal static bool PreSteamMatchmakingGetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember, ref CSteamID __result)
            {
                int totalMembers = SteamMatchmaking.GetNumLobbyMembers(steamIDLobby);
                int fakeMembers = fakeClients.Count;
                int realMembers = totalMembers - fakeMembers;

                if (iMember >= realMembers && iMember < totalMembers)
                {
                    __result = new(fakeClients[iMember - realMembers].clientId);
                    return false;
                }

                return true;
            }

            [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.GetLobbyMemberData))]
            [HarmonyPrefix]
            internal static bool PreSteamMatchmakingGetLobbyMemberData(CSteamID steamIDUser, string pchKey, ref string __result)
            {
                if (fakeClientIds.TryGetValue(steamIDUser.m_SteamID, out FakeClient fakeClient))
                {
                    __result = fakeClient.memberData.TryGetValue(pchKey, out string pchValue) ? pchValue : __result;
                    return false;
                }

                return true;
            }


            // Fake client in SteamFriends
            [HarmonyPatch(typeof(SteamFriends), nameof(SteamFriends.GetFriendPersonaName))]
            [HarmonyPrefix]
            internal static bool PreSteamFriendsGetFriendPersonaName(CSteamID steamIDFriend, ref string __result)
            {
                if (fakeClientIds.TryGetValue(steamIDFriend.m_SteamID, out FakeClient fakeClient))
                {
                    __result = fakeClient.name;
                    return false;
                }

                return true;
            }


            // Fake client in NewAcceptP2P
            [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(SteamNetworkingIdentity)])]
            [HarmonyPrefix]
            internal static bool PreSteamManagerNewAcceptP2PIdentityRemote(SteamNetworkingIdentity param_1)
            {
                return !fakeClientIds.ContainsKey(param_1.GetSteamID64());
            }
            [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(CSteamID)])]
            [HarmonyPrefix]
            internal static bool PreSteamManagerNewAcceptP2PCSteamID(CSteamID param_1)
            {
                return !fakeClientIds.ContainsKey(param_1.m_SteamID);
            }



            // Prevent actually sending packets to fake clients
            [HarmonyPatch(typeof(SteamPacketManager), nameof(SteamPacketManager.SendPacket))]
            [HarmonyPrefix]
            internal static bool PreSteamPacketManagerSendPacket(CSteamID param_0)
            {
                return !fakeClientIds.ContainsKey(param_0.m_SteamID);
            }

            // Fake client in ServerSends
            [HarmonyPatch(typeof(ServerSend), nameof(ServerSend.LoadMap), [typeof(int), typeof(int)])]
            [HarmonyPostfix]
            internal static void PostServerSendLoadMap()
            {
                foreach (FakeClient fakeClient in fakeClients)
                    fakeClient.FakeLoad();
            }
            [HarmonyPatch(typeof(ServerSend), nameof(ServerSend.LoadMap), [typeof(int), typeof(int), typeof(ulong)])]
            [HarmonyPrefix]
            internal static bool PreServerSendLoadMap(ulong param_2)
            {
                if (fakeClientIds.TryGetValue(param_2, out FakeClient fakeClient))
                {
                    fakeClient.FakeLoad();
                    return false;
                }

                return true;
            }


            // Spawn fake clients in GameManager
            [HarmonyPatch(typeof(GameManager), nameof(GameManager.Start))]
            [HarmonyPostfix]
            internal static void PostGameManagerStart()
            {
                foreach (FakeClient fakeClient in fakeClients)
                    fakeClient.FakeSpawn();
            }
        }
    }


    public sealed class FakeClient
    {
        public readonly ulong clientId;
        public readonly string name;
        public readonly bool streamerMode;
        private bool _forceSpawnActive;

        public readonly Dictionary<string, string> memberData = [];

        internal FakeClient(ulong fakeClientId, string name = default, bool streamerMode = false, bool forceSpawnActive = false)
        {
            clientId = fakeClientId;
            this.name = string.IsNullOrEmpty(name) ? $"FakeClient {clientId - FakeClients.MIN_ID + 1ul}" : name;
            this.streamerMode = streamerMode;
            _forceSpawnActive = forceSpawnActive;
        }

        internal void FakeLoad()
        {
            ServerHandle.StartedLoading(clientId, null); // Loading screen 'opened'
            ServerHandle.LoadingRequestEnterGame(clientId, null); // 'Finished loading' next scene

            if (GameManager.Instance)
                FakeSpawn(); // Host is on a map, we can spawn immediately
        }

        internal void FakeSpawn()
        {
            if (GameManager.Instance.activePlayers.ContainsKey(clientId) || GameManager.Instance.spectators.ContainsKey(clientId))
                return; // Already spawned

            ServerHandle.GameModeLoaded(clientId, null); // 'Loaded' next scene, and thus the next mode


            if (_forceSpawnActive)
            {
                _forceSpawnActive = false;

                Client client = LobbyManager.Instance.GetClient(clientId);
                GameServer.PlayerSpawnRequest(clientId, streamerMode, client.get_deobf_drip(), client.get_deobf_dripLength());
                return;
            }

            Packet packet = new(); // Request to spawn, either as player or spectator, account for streamer mode
            packet.SetBytes(BitConverter.GetBytes(streamerMode));
            ServerHandle.GameRequestToSpawn(clientId, packet);
            packet.Dispose();
        }
    }
}