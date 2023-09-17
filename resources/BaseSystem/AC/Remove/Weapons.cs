using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.AC.Remove
{
    internal class Weapons : Script
    {
        [ServerEvent(Event.PlayerWeaponSwitch)]
        public void RemoveBlackListedWeaponsOnSwitch(Player player, WeaponHash oldWeapon, WeaponHash currentWeapon)
        {
            if (currentWeapon == WeaponHash.Railgun || oldWeapon == WeaponHash.Railgun)
            {
                player.RemoveWeapon(currentWeapon);
                player.RemoveWeapon(oldWeapon);
            }
            //API.CreateBlip()
        }

        [ServerEvent(Event.PlayerPickup)]
        public void RemoveBlackListedWeaponsOnPickup(Player player, Pickup pickup)
        {
            WeaponHash[] weaponList = NAPI.Player.GetPlayerWeapons(player);
            foreach (var currentTarget in weaponList)
            {
                if (currentTarget == WeaponHash.Railgun)
                {
                    player.RemoveWeapon(currentTarget);
                }
            }
            return;
        }
    }
}
