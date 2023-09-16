using System;
using GTANetworkAPI;
using GTANetworkMethods;
using Player = GTANetworkAPI.Player;

namespace BaseSystem.Commands
{
    internal class StaffManagement : Script
    {
        [Command("time", "~r~Uso:~w~ /time [day/night]", Alias = "tiempo")]
        public void timeSet(Player player, string day_night)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            day_night.ToLower();
            if (day_night == "night")
            {
                NAPI.World.SetTime(0, 0, 0);
            }
            else if (day_night == "day")
            {
                NAPI.World.SetTime(14, 30, 15);
            }
            else
            {
                player.SendChatMessage("~r~El valor introducido no es correcto, recuerda especificar entre day/night.");
            }
            return;
        }

        [Command("car", "~r~Uso:~w~ /car [modelo]", Alias = "coche")]
        public void SpawnCar(Player player, string carModel)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            VehicleHash carHashModel = NAPI.Util.VehicleNameToModel(carModel); //Gets the hash of bus model
            if (carHashModel.GetHashCode() == 0)
            {
                player.SendChatMessage("~r~El modelo indicado no existe.");
            }
            else
            {
                var vehicle = NAPI.Vehicle.CreateVehicle(carHashModel, player.Position, 0, 0, 0); //Creates a bus on the player's position
                NAPI.Player.SetPlayerIntoVehicle(player, vehicle, 0);
            }
            return;
        }

        [Command("dv")]
        public void DeleteCar(Player player)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            if (!NAPI.Player.IsPlayerInAnyVehicle(player))
            {
                player.SendChatMessage("~r~No estás montado en ningún vehículo.");
            }
            else
            {
                //NAPI.Player.WarpPlayerOutOfVehicle
                var vehicle = NAPI.Player.GetPlayerVehicle(player);
                NAPI.Entity.DeleteEntity(vehicle);
            }

            return;
        }

        [Command("dvall")]
        public void DeleteAllCars(Player player)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            player.SendChatMessage("~y~Todos los vehículos presentes en el servidor serán eliminados en 30 segundos.");
            var vehicles = NAPI.Pools.GetAllVehicles();
            //pols?
            foreach (var vehicle in vehicles)
            {
                NAPI.Entity.DeleteEntity(vehicle);
            }
        }

        [Command("fix", Alias = "arreglarcoche")]
        public void FixCar(Player player)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            if (!NAPI.Player.IsPlayerInAnyVehicle(player))
            {
                player.SendChatMessage("~r~No te encuentras en ningun vehículo que quieras arreglar.");
            }
            else
            {
                NetHandle vehicle = NAPI.Player.GetPlayerVehicle(player);
                NAPI.Vehicle.RepairVehicle(vehicle);
            }
            return;
        }

        [Command("giveweapon")]
        public void GiveWeapon(Player player, string weaponName, int ammo)
        {

            Utils.CheckPermsSystem.checkAdminPerms(player);
            WeaponHash weaponHash = NAPI.Util.WeaponNameToModel(weaponName);
            if (weaponHash == WeaponHash.Unarmed)
            {
                player.SendChatMessage("~r~El arma indicada no existe.");
                return;
            }
            else
            {
                if (ammo < 0)
                {
                    player.SendChatMessage($"~y~/giveweapon: Has determinado un numero de balas incorrecto. ({ammo})");
                    return;
                }
                else
                {
                    NAPI.Player.GivePlayerWeapon(player, weaponHash, ammo);
                    return;
                }
            }
        }

        [Command("removeweapon")]
        public void RemoveWeapon(Player player, string weaponName)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            WeaponHash weaponHash = NAPI.Util.WeaponNameToModel(weaponName);
            if (weaponHash == WeaponHash.Unarmed)
            {
                player.SendChatMessage("~r~El arma indicada no existe.");
                return;
            }
            else
            {
                NAPI.Player.RemovePlayerWeapon(player, weaponHash);
                player.SendChatMessage($"~y~ Un miembro del equipo administrativo te ha confiscado el arma \"{weaponName}\", si no estas de acuerdo o tienes dudas por favor abre un reporte con las pruebas pertinentes en algunas de las plataformas de /redes.");
                return;
            }
        }

        [Command("tpcoords")]
        public void TeleportToCoords(Player player, int coordX, int coordY, int coordZ)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            player.Position = new Vector3(coordX, coordY, coordZ);
            return;
        }

        [Command("tp")]
        public void TeleportToSomeones(Player player, int coordX, int coordY, int coordZ)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            //TODO
            return;
        }

        [Command("showcoords")]
        public void ShowCoords(Player player)
        {
            Utils.CheckPermsSystem.checkAdminPerms(player);
            Vector3 playerPos = player.Position;
            player.SendChatMessage($"X: {playerPos.X}, Y: {playerPos.Y}, Z: {playerPos.Z}");
        }
    }
}
