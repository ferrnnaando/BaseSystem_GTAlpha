using GTANetworkAPI;
using RAGE;

namespace BaseSystem.Commands.ClientSide.Staff
{
    internal class Freeze : Events.Script
    {
        public Freeze()
        {
            Events.Add("FreezePlayerClient", FreezePlayer);
        }
       
        public void FreezePlayer(object[] args)
        {
            RAGE.Elements.Player.LocalPlayer.FreezeCameraRotation();
            RAGE.Elements.Player.LocalPlayer.FreezePosition((bool)args[0]);
        }
    }
}
