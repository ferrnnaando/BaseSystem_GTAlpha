using GTANetworkAPI;
using System;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class DvAll : Script
    {
        [Command(Utils.Commands.Staff.DvAll.CommandName, Utils.Commands.Staff.DvAll.CommandUsage, Description = Utils.Commands.Staff.DvAll.CommandDescription)]
        public void DeleteAllCars(Player player)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            player.SendChatMessage("~y~Advertencia:~w~ Todos los vehículos presentes en el servidor serán eliminados en 30 segundos.");
            var vehicles = NAPI.Pools.GetAllVehicles();
            //pols?
            foreach (var vehicle in vehicles)
            {
                NAPI.Entity.DeleteEntity(vehicle);
            }
        }
    }
}
