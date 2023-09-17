using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Kill : Script
    {
        [Command(Utils.Commands.Staff.Kill.CommandName, Description = Utils.Commands.Staff.Kill.CommandDescription)]
        public void killSomeones(Player player, int targetId)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            /*targetID.ToLower;
            if(targetID == "me")
            {*/
            player.Kill();
            /*} else
            {

            }*/
            return;
        }
    }
}
