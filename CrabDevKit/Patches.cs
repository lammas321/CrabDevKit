//using CrabDevKit.Intermediary;
using CrabDevKit.Utilities;
using HarmonyLib;
using SteamworksNative;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

namespace CrabDevKit
{
    internal static class Patches
    {
        // Testing CrabNet

        /*[HarmonyPatch(typeof(PlayerInput), nameof(PlayerInput.Update))]
        [HarmonyPostfix]
        internal static void PostPlayerInputUpdate()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                CrabDevKit.Instance.Log.LogInfo("Sending messages...");

                static IEnumerable<CSteamID> GetAllSteamIds()
                {
                    int members = SteamMatchmaking.GetNumLobbyMembers(LobbyManager.Instance.get_currentLobby());
                    for (int i = 0; i < members; i++)
                    {
                        CSteamID steamId = SteamMatchmaking.GetLobbyMemberByIndex(LobbyManager.Instance.get_currentLobby(), i);
                        yield return steamId;
                        CrabDevKit.Instance.Log.LogInfo($"Sent message to {steamId.m_SteamID}!");
                    }
                }

                Packet packet = new();
                packet.Write("Hello!");

                CrabNet.SendMessage($"{MyPluginInfo.PLUGIN_NAME}:Test", packet, GetAllSteamIds());
            }
        }*/



        // Create/Remove FakeClients
        /*[HarmonyPatch(typeof(PlayerInput), nameof(PlayerInput.Update))]
        [HarmonyPostfix]
        internal static void PostPlayerInputUpdate()
        {
            if (!SteamManager.Instance.IsLobbyOwner() || !Input.GetKey(KeyCode.LeftAlt))
                return;

            if (Input.GetKeyDown(KeyCode.P))
            {
                CrabDevKit.Instance.Log.LogInfo("Creating fake player...");

                FakeClients.Create(forceSpawnActive: true);
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                CrabDevKit.Instance.Log.LogInfo("Removing fake player...");

                FakeClients.Remove(FakeClients.fakeClients.LastOrDefault()?.clientId ?? 0ul);
            }
        }*/


        // Fake client in SteamMatchmaking
        [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.LeaveLobby))]
        [HarmonyPostfix]
        internal static void PostSteamMatchmakingLeaveLobby()
        {
            FakeClients.fakeClientIds.Clear();
            FakeClients.fakeClients.Clear();
        }

        [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.GetNumLobbyMembers))]
        [HarmonyPostfix]
        internal static void PostSteamMatchmakingGetNumLobbyMembers(ref int __result)
        {
            __result += FakeClients.fakeClients.Count;
        }

        [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.GetLobbyMemberByIndex))]
        [HarmonyPrefix]
        internal static bool PreSteamMatchmakingGetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember, ref CSteamID __result)
        {
            int totalMembers = SteamMatchmaking.GetNumLobbyMembers(steamIDLobby);
            int fakeMembers = FakeClients.fakeClients.Count;
            int realMembers = totalMembers - fakeMembers;

            if (iMember >= realMembers && iMember < totalMembers)
            {
                __result = new(FakeClients.fakeClients[iMember - realMembers].clientId);
                return false;
            }

            return true;
        }

        [HarmonyPatch(typeof(SteamMatchmaking), nameof(SteamMatchmaking.GetLobbyMemberData))]
        [HarmonyPrefix]
        internal static bool PreSteamMatchmakingGetLobbyMemberData(CSteamID steamIDUser, string pchKey, ref string __result)
        {
            if (FakeClients.fakeClientIds.TryGetValue(steamIDUser.m_SteamID, out FakeClient fakeClient))
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
            if (FakeClients.fakeClientIds.TryGetValue(steamIDFriend.m_SteamID, out FakeClient fakeClient))
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
            return !FakeClients.fakeClientIds.ContainsKey(param_1.GetSteamID64());
        }
        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(CSteamID)])]
        [HarmonyPrefix]
        internal static bool PreSteamManagerNewAcceptP2PCSteamID(CSteamID param_1)
        {
            return !FakeClients.fakeClientIds.ContainsKey(param_1.m_SteamID);
        }



        // Prevent actually sending packets to fake clients
        [HarmonyPatch(typeof(SteamPacketManager), nameof(SteamPacketManager.SendPacket))]
        [HarmonyPrefix]
        internal static bool PreSteamPacketManagerSendPacket(CSteamID param_0)
        {
            return !FakeClients.fakeClientIds.ContainsKey(param_0.m_SteamID);
        }

        // Fake client in ServerSends
        [HarmonyPatch(typeof(ServerSend), nameof(ServerSend.LoadMap), [typeof(int), typeof(int)])]
        [HarmonyPostfix]
        internal static void PostServerSendLoadMap()
        {
            foreach (FakeClient fakeClient in FakeClients.fakeClients)
                fakeClient.FakeLoad();
        }
        [HarmonyPatch(typeof(ServerSend), nameof(ServerSend.LoadMap), [typeof(int), typeof(int), typeof(ulong)])]
        [HarmonyPrefix]
        internal static bool PreServerSendLoadMap(ulong param_2)
        {
            if (FakeClients.fakeClientIds.TryGetValue(param_2, out FakeClient fakeClient))
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
            foreach (FakeClient fakeClient in FakeClients.fakeClients)
                fakeClient.FakeSpawn();
        }
    }
}