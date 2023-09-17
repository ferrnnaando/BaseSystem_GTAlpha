using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Public
{
    internal class Desc : Script
    {
        [Command(Utils.Commands.Public.Desc.CommandName, Utils.Commands.Public.Desc.CommandUsage, Description = Utils.Commands.Public.Desc.CommandDescription)]
        public void SeeCommandDescription(Player player, string commandName)
        {
                    
            return;
        }
    }
}
