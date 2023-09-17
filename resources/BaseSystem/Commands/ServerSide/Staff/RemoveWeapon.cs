using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class RemoveWeapon : Script
    {
        [Command(Utils.Commands.Staff.RemoveWeapon.CommandName, Utils.Commands.Staff.RemoveWeapon.CommandUsage, Description = Utils.Commands.Staff.RemoveWeapon.CommandDescription)]
        public void removeweapon(Player player, string weaponName)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            WeaponHash weaponHash = NAPI.Util.WeaponNameToModel(weaponName);
            if (weaponHash == WeaponHash.Unarmed)
            {
                player.SendChatMessage("~r~Error:~w~ El arma indicada no existe.");
                return;
            }
            else
            {
                NAPI.Player.RemovePlayerWeapon(player, weaponHash);
                player.SendChatMessage($"~y~Advertencia:~w~ Un miembro del equipo administrativo te ha confiscado el arma \"{weaponName}\", si no estas de acuerdo o tienes dudas por favor abre un reporte con las pruebas pertinentes en algunas de las plataformas de /redes.");
                return;
            }
        }
    }
}
