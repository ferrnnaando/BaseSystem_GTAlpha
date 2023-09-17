using GTANetworkAPI;
using System;

namespace BaseSystem.Chat
{
    internal class ChatSystem : Script
    {
        [ServerEvent(Event.ChatMessage)]
        public void OnChatMessage(Player player, string message)
        {
            if (message.StartsWith("/")) { }
            else if(message == ("/")) {
                player.SendChatMessage("~r~Error:~w~ Especifica el comando que deseas usar, ¿quisiste decir ~o~/oop~w~ o ~o~/duda~w~?");
            }
            else
            {
                player.SendChatMessage("~r~Error:~w~ Especifica el comando que deseas usar, ¿quisiste decir ~o~/oop~w~ o ~o~/duda~w~?");
            }
                //NAPI.Chat.SendChatMessageToAll($"{player.Name} ({player.Handle}): {message}");
            

            return;
        }
    }
}
