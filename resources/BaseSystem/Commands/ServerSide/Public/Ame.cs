using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Public
{
    internal class Ame : Script
    {
        [Command(Utils.Commands.Public.Ame.CommandName, Utils.Commands.Public.Ame.CommandUsage, Description = Utils.Commands.Public.Ame.CommandDescription, GreedyArg = true)]
        public void AmeCommand(Player player, string action)
        {
            action = action.Trim();
            player.SendChatMessage($"~p~/me {action}");
            var targetRadius = NAPI.Player.GetPlayersInRadiusOfPlayer(5.0, player);
            foreach (Player target in targetRadius)
            {
                /*if (target == player) { } else*/
                target.SendChatMessage($"~r~[ME] - {player.Handle}: *{action}*");
            }

            Vector3 labelPosition = new Vector3(player.Position.X, player.Position.Y, player.Position.Z + 1.0f); // Adjust the Z position as needed

            Entity messageLabel = NAPI.TextLabel.CreateTextLabel($"{action}", labelPosition, 20.0f, 2.0f, 0, new Color(255, 255, 219), true, player.Dimension);

            NAPI.Entity.DeleteEntity(messageLabel);
            return;
        }
    }
}
