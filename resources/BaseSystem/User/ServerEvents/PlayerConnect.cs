using System;
using RAGE;
using GTANetworkAPI;
using Player = GTANetworkAPI.Player;

namespace BaseSystem.User.Events
{
    internal class PlayerConnect : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        public void OnPlayerConnect(Player player)
        {
            NAPI.Util.ConsoleOutput(Blips.BaseBlips.AirportBlip(player));
            NAPI.Util.ConsoleOutput($"Joined user:\n\nPlayer Ip: {NAPI.Player.GetPlayerAddress(player)}\nSocial Club Name: {NAPI.Player.GetPlayerSocialClubName(player)}\nPlayer Serial: {NAPI.Player.GetPlayerSerial(player)}\n");
            player.SendChatMessage($"Bienvenido/a ~g~{NAPI.Player.GetPlayerName(player)}~s~ a GTAlpha, la esencia del roleplay.~n~");
            player.SendChatMessage("~n~Comienza escribiendo la primera página de tu historia.");
            player.SendChatMessage("~w~Donde las fantasías se convierten en realidad y la realidad es simple.");

            return;
        }

    }
}