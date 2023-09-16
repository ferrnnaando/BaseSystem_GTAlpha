using System;
using System.Threading;
using GTANetworkAPI;
using Player = GTANetworkAPI.Player;

namespace BaseSystem
{
    public class Main : Script
        {
            [ServerEvent(Event.ResourceStart)]
            public void OnResourceLoad()
            {
                //NAPI.Command.Register()
                NAPI.Server.SetCommandErrorMessage("~r~Error:~w~ El comando indicado no existe. ¿Quisiste decir ~o~/ayuda~w~?");
                NAPI.Server.SetAutoRespawnAfterDeath(true);
                NAPI.Server.SetGlobalServerChat(false);

                NAPI.Util.ConsoleOutput("BaseSystem GTAlpha || Made by @github.com/ferrnnaando && Kev1n");
                return;
            }  
    }
}