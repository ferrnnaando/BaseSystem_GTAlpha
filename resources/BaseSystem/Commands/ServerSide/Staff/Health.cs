using GTANetworkAPI;
using System;
using System.Linq;

namespace BaseSystem.Commands.ServerSide.Staff
{
    internal class Health : Script
    {
        [Command(Utils.Commands.Staff.Health.CommandName, Utils.Commands.Staff.Health.CommandUsage, Description = Utils.Commands.Staff.Health.CommandDescription)]
        public void GiveHealthToSomeones(Player player, int targetPlayerId)
        {
            Utils.CheckPermsSystem.CheckAdminPerms(player);
            NetHandle handlerTarget = NAPI.Pools.GetAllPlayers().FirstOrDefault(p => p.Value == targetPlayerId).Handle;
            Player PlayerTarget = NAPI.Player.GetPlayerFromHandle(handlerTarget);

            if (PlayerTarget.IsNull)
            {
                player.SendChatMessage("El jugador especificado no está en línea o no es válido.");
            }
            else
            {
                PlayerTarget.Health = 100;
            }
            return;
        }
    }
}
