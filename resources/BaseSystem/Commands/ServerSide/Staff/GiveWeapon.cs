using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class GiveWeapon : Script
    {
        [Command(Utils.Commands.Staff.GiveWeapon.CommandName, Utils.Commands.Staff.GiveWeapon.CommandUsage, Description = Utils.Commands.Staff.GiveWeapon.CommandDescription)]
        public void giveweapon(Player player, int targetId, string weaponName, int ammo)
        {

            Utils.CheckPermsSystem.CheckAdminPerms(player);
            WeaponHash weaponHash = NAPI.Util.WeaponNameToModel(weaponName);
            if (weaponHash == WeaponHash.Unarmed)
            {
                player.SendChatMessage("~r~Error:~w~ El arma indicada no existe.");
            }
            else
            {
                if (ammo < 0)
                {
                    player.SendChatMessage($"~y~/giveweapon:~w~ Has determinado un numero de balas incorrecto. (~b~{ammo}~w~)");
                }
                else
                {
                    NAPI.Player.GivePlayerWeapon(player, weaponHash, ammo);
                }
            }
            return;
        }
    }
}
