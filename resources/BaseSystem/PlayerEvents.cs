using System;
using GTANetworkAPI;

namespace BaseSystem
{
    internal class PlayerEvents : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnect(Player player)
        {
            NAPI.Util.ConsoleOutput($"Joined user:\n\nPlayer Ip: {NAPI.Player.GetPlayerAddress(player)}\nSocial Club Name: {NAPI.Player.GetPlayerSocialClubName(player)}\nPlayer Serial: {NAPI.Player.GetPlayerSerial(player)}\n");
            player.SendChatMessage($"Bienvenido/a ~g~{NAPI.Player.GetPlayerName(player)}~s~ a GTAlpha, la esencia del roleplay. Comienza escribiendo la primera página de tu historia.");
            player.SendChatMessage("~w~Donde las fantasías se convierten en realidad y la realidad es simple.");
            return;
        }

        
        [ServerEvent(Event.PlayerDeath)]
        public void OnPlayerDies(Player player, GTANetworkAPI.Player killer, uint reason)
        {
            if (player.Health == 0)
            {
                player.Position = Utils.Coordinates.pillboxRespawn;
            }
            return;
        }
    }
}
