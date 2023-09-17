using System;
using GTANetworkAPI;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Dv : Script
    {
        [Command(Utils.Commands.Staff.Dv.CommandName, Utils.Commands.Staff.Dv.CommandUsage, Description = Utils.Commands.Staff.Dv.CommandDescription)]
        public void DeleteCar(Player player)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            if (!NAPI.Player.IsPlayerInAnyVehicle(player))
            {
                player.SendChatMessage("~r~/dv:~w~ No estás montado en ningún vehículo.");
            }
            else
            {
                //NAPI.Player.WarpPlayerOutOfVehicle
                var vehicle = NAPI.Player.GetPlayerVehicle(player);
                NAPI.Entity.DeleteEntity(vehicle);
            }

            return;
        }
    }
}
