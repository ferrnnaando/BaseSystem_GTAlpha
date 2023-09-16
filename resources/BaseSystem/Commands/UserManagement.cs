using System;
using GTANetworkAPI;
using GTANetworkMethods;
using Player = GTANetworkAPI.Player;

namespace BaseSystem.Commands
{
    internal class UserManagement : Script
    {
        [Command("kill")]
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

        [Command("health")]
        public void GiveHealthToSomeones(Player player, int targetId)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            player.Health = 100;
            return;
        }
    }
}
