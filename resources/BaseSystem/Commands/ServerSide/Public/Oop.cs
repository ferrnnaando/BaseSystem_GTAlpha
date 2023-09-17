using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Public
{
    internal class oop : Script
    {
        [Command(Utils.Commands.Public.Oop.CommandName, Utils.Commands.Public.Oop.CommandUsage, Description = Utils.Commands.Public.Oop.CommandDescription, GreedyArg = true)]
        public void SendOopMessage(Player player, string message)
        {
            List<Player> TargetList = NAPI.Player.GetPlayersInRadiusOfPlayer(250, player);

            foreach (Player currentTarget in TargetList)
            {
                currentTarget.SendChatMessage($"~c~#{player.Handle} dice: (( {message} ))");
            }
            return;
        }
    }
}
