using GTANetworkAPI;
using System;

namespace BaseSystem.Blips
{
    internal class BaseBlips : Script
    {
        public static string AirportBlip(Player player)
        {
            int counterSuccess = 0;
            int totalBlips = 1;

            Vector3 airportPosition = new Vector3(Utils.Coordinates.pillboxRespawn.X, Utils.Coordinates.pillboxRespawn.Y, Utils.Coordinates.pillboxRespawn.Z);
            
            Blip airportBlip = NAPI.Blip.CreateBlip(90, airportPosition, 1f, 255, "Aeropuerto", 255, 0f, false, 0, player.Dimension);
            counterSuccess++;

            string Result = $"{counterSuccess} blip(s) de {totalBlips} han sido cargados con éxito.";
            return Result;
        }
    }

    
}
