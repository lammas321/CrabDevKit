using CrabDevKit.Intermediary;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CrabDevKit.Utilities
{
    public static class ChatUtil
    {
        public static int MaxMessageLength
            => Chatbox.Instance != null ? Chatbox.Instance.get_maxMsgLength() : 80;

        public static int MaxConsecutiveChars
            => Chatbox.Instance != null ? Chatbox.Instance.get_deobf_maxConsecutiveChars() : 5;


        public static string FormatMessage(string str)
            => Regex.Replace(
                str,
                $"(.)(?<=\\1{{{MaxConsecutiveChars}}})", // Remove repeating characters (5 or more will truncate to 4, allowing it to appear in chat)
                string.Empty,
                RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled
             );


        public enum MessageType
        {
            Normal,
            Server,
            Styled
        }

        public static void SendMessage(ulong recipientClientId, string message, MessageType messageType = MessageType.Server, string displayName = null)
            => SendMessage(message, messageType, displayName, [recipientClientId]);

        public static void SendMessage(string message, MessageType messageType = MessageType.Server, string displayName = null, IEnumerable<ulong> recipientClientIds = null)
        {
            ulong senderClientId = 0UL;
            message = FormatMessage(message ?? string.Empty);
            if (messageType == MessageType.Server)
            {
                displayName = string.Empty;
                senderClientId = 1UL;
            }
            else
                displayName ??= string.Empty;

            Packet packet = new((int)ServerPackets.sendMessage);

            packet.Write(senderClientId);
            packet.Write(displayName);
            packet.Write(message);

            packet.WriteLength();


            foreach (ulong clientId in recipientClientIds ?? [.. LobbyManager.steamIdToUID.Keys])
            {
                if (messageType == MessageType.Styled)
                {
                    // Replaces senderClientId with clientId, making the text appear blue client side. More optimal than reconstructing a new Packet for each recipient if there's many

                    byte[] clientIdBytes = BitConverter.GetBytes(clientId);
                    for (int i = 0; i < clientIdBytes.Length; i++)
                        packet.field_Private_List_1_Byte_0[i + 8] = clientIdBytes[i];
                }

                SteamPacketManager.SendPacket(new(clientId), packet, ServerSendExtensions.get_deobf_reliable(), SteamPacketManager_NetworkChannel.ToClient);
            }

            packet.Dispose();
        }


        public static string[] FormatGameModeDescription(string description)
        {
            List<string> lines = [.. description.Split('\n', StringSplitOptions.RemoveEmptyEntries)];
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].Replace('•', '*');

                while (lines[i].Length > MaxMessageLength)
                {
                    int split = lines[i].LastIndexOf(' ', MaxMessageLength - 1, 20);
                    if (split == -1)
                        split = MaxMessageLength;

                    lines.Insert(i + 1, lines[i][split..]);
                    lines[i] = lines[i][..split];
                }
            }

            return [.. lines];
        }
    }
}