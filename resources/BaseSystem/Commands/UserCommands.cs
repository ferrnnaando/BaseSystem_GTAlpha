using System;
using System.Linq;
using GTANetworkAPI;
using GTANetworkMethods;
using Player = GTANetworkAPI.Player;

namespace BaseSystem.Commands
{
    internal class UserCommands : Script
    {
        /*[Command(Utils.Commands.Health.CommandName, Utils.Commands.Health.CommandUsage, Description = Utils.Commands.Health.CommandDescription)]
        public void GiveHealthToSomeones(Player player, int targetPlayerId)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            NetHandle handlerTarget = NAPI.Pools.GetAllPlayers().FirstOrDefault(p => p.Value == targetPlayerId).Handle;
            Player PlayerTarget = NAPI.Player.GetPlayerFromHandle(handlerTarget);

            if (PlayerTarget.IsNull)
            {
                player.SendChatMessage("El jugador especificado no está en línea o no es válido.");
            }
            else
            {
                PlayerTarget.Health = 100;
            }
            return;
        }*/

        [Command(Utils.Commands.Kill.CommandName, Description = Utils.Commands.Kill.CommandDescription)]
        public void killSomeones(Player player, int targetId)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            /*targetID.ToLower;
            if(targetID == "me")
            {*/
            player.Kill();
            /*} else
            {

            }*/
            return;
        }

        [Command("revive")]
        public void reviveSomeones(Player player)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            //player.Id; diference between player id and handler id, and what is nethandle
            return;
        }


        /*[Command("freeze")]
        public void FreezeCommand(Player sender, bool frozen)
        {
            NAPI.Player.Freeze(sender, frozen); 
        }*/

        [Command("kick", Alias = "kickear, expulsar")]
        public void KickSomeones(Player player, int targetId, string reason)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            player.Kick(reason);
            return;
        }

        /*[Command("ban", Alias ="banear")]
        public void BanSomeones(Player player, int targetId, string reason)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            player.Ban($"Has sido baneado por el STAFF {reason}");
            return;
        }

        [Command("unban", Alias ="desbanear")]
        public void UnbanSomeones(Player player, int targetId, string reason)
        {
            
            return;
        }

        [Command("setwantedlevel")]
        public void SetWantedLevel(Player player, int targetId, string reason)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            return;
        }*/

    }
}
