//NAPI.Player.PlayPlayerAnimation(player, 1, "amb@world_human_stand_fishing@idle_a", "idle_c");

//using BaseSystem.SQL;
using GTANetworkAPI;
using RAGE;

namespace BaseSystem
{
    public class Main : Script
        {
        //NAPI.Command.Register()
        [ServerEvent(Event.ResourceStart)]
            public void OnResourceLoad()
            {
                //MySQL.LoadMySQLConnection();
                NAPI.World.SetWeather(Weather.SNOW);
                NAPI.Server.SetCommandErrorMessage("~r~Error:~w~ El comando indicado no existe. ¿Quisiste decir ~o~/ayuda~w~?");
                NAPI.Server.SetAutoRespawnAfterDeath(true);
                NAPI.Server.SetGlobalServerChat(false);

                NAPI.Util.ConsoleOutput("BaseSystem GTAlpha || Made by @github.com/ferrnnaando && Kev1n");
                return;
            }
    }
}