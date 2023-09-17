using GTANetworkAPI;
using System;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Car : Script
    {
        [Command(Utils.Commands.Staff.Car.CommandName, Utils.Commands.Staff.Car.CommandUsage, Description = Utils.Commands.Staff.Car.CommandDescription)]
        public void SpawnCar(Player player, string carModel)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            VehicleHash carHashModel = NAPI.Util.VehicleNameToModel(carModel);
            if (carHashModel.GetHashCode() == 0)
            {
                player.SendChatMessage("~r~/car:~w~ El modelo indicado no existe.");
            }
            else
            {
                Vector3 vehiclePos = new Vector3(player.Position.X + 1.0f, player.Position.Y, player.Position.Z);
                var vehicle = NAPI.Vehicle.CreateVehicle(carHashModel, vehiclePos, 0, 0, 0);
                //NAPI.Player.SetPlayerIntoVehicle(player, vehicle, 0);
                player.SendNotification("Vehiculo generado con ~h~~g~éxito~s~.");
            }
            return;
        }
    }
}
