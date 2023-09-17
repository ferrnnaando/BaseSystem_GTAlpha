using GTANetworkAPI;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Time : Script
    {
        [Command(Utils.Commands.Staff.Time.CommandName, Utils.Commands.Staff.Time.CommandUsage, Description = Utils.Commands.Staff.Time.CommandDescription)]
        public void timeSet(Player player, string day_night)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            day_night.ToLower();
            if (day_night == "night")
            {
                NAPI.World.SetTime(0, 0, 0);
            }
            else if (day_night == "day")
            {
                NAPI.World.SetTime(14, 30, 15);
            }
            else
            {
                player.SendChatMessage("~r~/time:~w~ El valor introducido no es correcto, recuerda especificar entre day/night.");
            }
            return;
        }
    }
}
