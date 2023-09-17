using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class TpCoords : Script
    {
        [Command("tpcoords")]
        public void TeleportToCoords(Player player, int X, int Y, int Z)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            player.Position = new Vector3(X, Y, Z);
            return;
        }
    }
}
