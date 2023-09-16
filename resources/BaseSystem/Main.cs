using System;
using GTANetworkAPI;
using Player = GTANetworkAPI.Player;

namespace BaseSystem
{
    public class Main : Script
        {
            [ServerEvent(Event.ResourceStart)]
            public void OnResourceLoad()
            {
                //NAPI.Command.Register()
                NAPI.Server.SetAutoRespawnAfterDeath(true);
                NAPI.Util.ConsoleOutput("BaseSystem GTAlpha || Made by @github.com/ferrnnaando && Kev1n");
                return;
            }

            [ServerEvent(Event.PlayerConnected)]
            public void OnPlayerConnect(Player player)
            {
                //NAPI.Server.SetDefaultSpawnLocation(Values.defaultServerSpawnPos);
                NAPI.Util.ConsoleOutput($"Joined user:\n\nPlayer Ip: {NAPI.Player.GetPlayerAddress(player)}\nSocial Club Name: {NAPI.Player.GetPlayerSocialClubName(player)}\nPlayer Serial: {NAPI.Player.GetPlayerSerial(player)}\n");

                player.SendChatMessage($"Bienvenido/a ~g~{NAPI.Player.GetPlayerName(player)}~s~ a GTAlpha, la esencia del roleplay. Comienza escribiendo la primera página de tu historia.");
                player.SendChatMessage("~w~Donde las fantasías se convierten en realidad y la realidad es simple.");
                return;
            }
        }
}