using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Freeze : Script
    {
        [Command("freeze")]
        public void freezePlayer(Player player)
        {
            NAPI.Player.FreezePlayerTime(player, true);
            NAPI.ClientEvent.TriggerClientEvent(player, "FreezePlayerClient");
        }
    }
}
