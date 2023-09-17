using System;
using GTANetworkAPI;
using Player = GTANetworkAPI.Player;

namespace BaseSystem.AM
{
    internal class AdminMenu : Script
    {
        [Command("AM")]
        public void OpenAM(Player player)
        {
            NAPI.ClientEvent.TriggerClientEvent(player, "GTAlpha_AdminMenu");
            return;
        }
    }
}
