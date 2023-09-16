using System;
using GTANetworkAPI;

namespace BaseSystem
{
    internal class PlayerEventHandling : Script
    {
            [ServerEvent(Event.ChatMessage)]
            public void OnChatMessage(Player player, string message)
            {
                NAPI.Chat.SendChatMessageToAll($"{player.Name} ({player.Handle}): {message}");
                return;
            }

            [ServerEvent(Event.PlayerDeath)]
            public void OnPlayerDies(Player player, GTANetworkAPI.Player killer, uint reason)
            {
                if(player.Health == 0)
            {
                player.Position = Utils.Coordinates.pillboxRespawn;
            }
                return;
            }
        }
    }
