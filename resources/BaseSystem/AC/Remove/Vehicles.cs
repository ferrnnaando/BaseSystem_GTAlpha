using GTANetworkAPI;
using System;

namespace BaseSystem.AC.Remove
{
    internal class Vehicles : Script
    {
        [ServerEvent(Event.PlayerEnterVehicle)]
        public void RemoveBlackListedVehiclesOnEnter(Player player, Vehicle vehicle, sbyte seatID)
        {
            VehicleHash target = (VehicleHash)vehicle.Model;

            if (target == VehicleHash.Rhino)
            {
                NetHandle carNet = vehicle.Handle;
                NAPI.Entity.DeleteEntity(carNet);
            }
            {

            }
        }
    }
}
