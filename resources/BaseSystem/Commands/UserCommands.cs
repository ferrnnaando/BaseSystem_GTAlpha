using GTANetworkAPI;
using System;

namespace BaseSystem.Commands
{
    internal class UserCommands : Script
    {
        [Command("ame", "~r~Uso:~w~ /ame [action]", GreedyArg = true)]
        public void MeCommand(Player player, string action)
        {
            action = action.Trim();
            Utils.CheckPermsSystem.checkAdminPerms(player);
            player.SendChatMessage($"~p~/me {action}");
            var targetRadius = NAPI.Player.GetPlayersInRadiusOfPlayer(5.0, player);
            //how to make a gta notify mobile sound replays
            foreach(Player target in targetRadius)
            {
                /*if (target == player) { } else*/ target.SendChatMessage($"~r~[ME] - {player.Handle}: *{action}*");
            }

            Vector3 labelPosition = new Vector3(player.Position.X, player.Position.Y, player.Position.Z + 1.0f); // Adjust the Z position as needed

            Entity messageLabel = NAPI.TextLabel.CreateTextLabel($"{action}", labelPosition, 20.0f, 2.0f, 0, new Color(255, 255, 219), true, player.Dimension);
            
            NAPI.Entity.DeleteEntity(messageLabel);
            return;
        }
    }
}
