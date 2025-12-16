using CrabDevKit.Intermediary;
using SteamworksNative;
using System;
using System.Collections.Generic;

namespace CrabDevKit.Utilities
{
    public static class FakeClients
    {
        internal const ulong MIN_ID = 10ul;

        internal static readonly Dictionary<ulong, FakeClient> fakeClientIds = [];
        internal static readonly List<FakeClient> fakeClients = [];

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