using GTANetworkAPI;
using System;

namespace BaseSystem.Chat
{
    internal class ChatSystem : Script
    {
        [ServerEvent(Event.ChatMessage)]
        public void OnChatMessage(Player player, string message)
        {
            //if (message.Contains(Utils.BlockedWords.blockedWords[0]))
            NAPI.Chat.SendChatMessageToAll($"{player.Name} ({player.Handle}): {message}");
            return;
        }
    }
}
