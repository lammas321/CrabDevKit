using BepInEx.IL2CPP.Utils;
using CrabDevKit.Intermediary;
using System;
using System.Collections;
using UnityEngine;

namespace CrabDevKit.Utilities
{
    public static class GiveUtil
    {
        public static void GiveItem(ulong clientId, int itemId, int ammo = -1)
        {
            if (!GameManager.Instance.activePlayers.ContainsKey(clientId) || GameManager.Instance.activePlayers[clientId].dead || !ItemManager.idToItem.ContainsKey(itemId))
                return;

            if (ItemManager.idToItem[itemId].type == ItemData_ItemType.Other || ItemManager.idToItem[itemId].type == ItemData_ItemType.Ammo)
            {
                ServerSend.DropItem(clientId, itemId, SharedObjectManager.Instance.GetNextId(), ammo < 0 ? ItemManager.idToItem[itemId].maxAmmo : ammo);
                return;
            }

            if (ItemManager.idToItem[itemId].type == ItemData_ItemType.Melee || ItemManager.idToItem[itemId].type == ItemData_ItemType.Throwable || ammo < 0 || ammo == ItemManager.idToItem[itemId].maxAmmo)
            {
                GameServer.ForceGiveWeapon(clientId, itemId, SharedObjectManager.Instance.GetNextId());
                return;
            }

            GameServer.Instance.StartCoroutine(GiveItemCoroutine(clientId, itemId, ammo < 0 ? ItemManager.idToItem[itemId].maxAmmo : ammo));
        }

        private static IEnumerator GiveItemCoroutine(ulong clientId, int itemId, int ammo)
        {
            int uniqueObjectId = SharedObjectManager.Instance.GetNextId();
            ServerSend.DropItem(clientId, itemId, uniqueObjectId, ammo);

            yield return new WaitForSeconds(Mathf.Min((LobbyManager.Instance.get_clients()[LobbyManager.steamIdToUID[clientId]].get_ping() + 50) / 1000f, 1f));
            if (!GameManager.Instance.activePlayers.ContainsKey(clientId) || GameManager.Instance.activePlayers[clientId].dead || !LobbyManager.steamIdToUID.ContainsKey(clientId) || !SharedObjectManager.Instance.get_sharedObjects().ContainsKey(uniqueObjectId))
                yield break;

            Packet packet = new();
            packet.SetBytes(BitConverter.GetBytes(uniqueObjectId));

            ServerHandle.TryInteract(clientId, packet);

            packet.Dispose();
        }
    }
}