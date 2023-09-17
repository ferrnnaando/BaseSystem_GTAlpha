using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Fix : Script
    {
        [Command(Utils.Commands.Staff.Fix.CommandName, Utils.Commands.Staff.Fix.CommandUsage, Description = Utils.Commands.Staff.Fix.CommandDescription)]
        public void FixCar(Player player)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            if (!NAPI.Player.IsPlayerInAnyVehicle(player))
            {
                player.SendChatMessage("~r~/fix:~w~ No te encuentras en ningun vehículo que quieras arreglar.");
            }
            else
            {
                NetHandle vehicle = NAPI.Player.GetPlayerVehicle(player);
                NAPI.Vehicle.RepairVehicle(vehicle);
            }
            return;
        }
    }
}
