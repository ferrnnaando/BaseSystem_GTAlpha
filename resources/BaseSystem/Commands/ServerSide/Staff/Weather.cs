using System;
using GTANetworkAPI;
using Player = GTANetworkAPI.Player;

namespace BaseSystem.Commands.ServerSide.Staff
{
    /*internal class Weather : Script
    {
        [Command(Utils.Commands.Staff.Weather.CommandName, Utils.Commands.Staff.Weather.CommandUsage, Description = Utils.Commands.Staff.Weather.CommandDescription)]
        public void SetWeather(Player player, char status)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            if (status == '0')
            {
                NAPI.World.SetWeather(Weather.EXTRASUNNY);
            }
            else if (status == '1')
            {
                NAPI.World.SetWeather(Weather.CLEAR);
            }
            else if (status == '2')
            {
                NAPI.World.SetWeather(Weather.CLOUDS);
            }
            else if (status == '3')
            {
                NAPI.World.SetWeather(Weather.OVERCAST);
            }
            else if (status == '4')
            {
                NAPI.World.SetWeather(Weather.SNOWLIGHT);
            }
            else if (status == '5')
            {
                NAPI.World.SetWeather(Weather.XMAS);
            }
            else if (status == '6')
            {
                NAPI.World.SetWeather(Weather.SMOG);
            }
            else if (status == '7')
            {
                NAPI.World.SetWeather(Weather.SNOW);
            }
            else
            {
                player.SendChatMessage("~r~/weather:~w~ El valor introducido no es correcto. (0 - 9)");
            }
            return;
        }

    }*/
}
