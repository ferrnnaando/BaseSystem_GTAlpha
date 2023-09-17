using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class ShowCoords : Script
    {
        [Command("showcoords")]
        public void showcoords(Player player)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            Vector3 playerPos = player.Position;
            player.SendChatMessage($"X: {playerPos.X}, Y: {playerPos.Y}, Z: {playerPos.Z}");
            return;
        }
    }
}
