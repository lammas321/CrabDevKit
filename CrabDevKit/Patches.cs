using CrabDevKit.Intermediary;
using CrabDevKit.Utilities;
using HarmonyLib;
using SteamworksNative;
using System.Collections.Generic;
using UnityEngine;

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
    }
}