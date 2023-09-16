using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSystem.Utils
{
    public class AdministratorsLicense
    {
        public static string[] licenses = { "D8903A045BA097902C662F70111859C075D0570CDBDE3F38F3F018C8DD22102032186554441E0C980C12B8BCDB7243B07DE608A056B6E980A9D4046479107AC0" };
    }

    public class CheckPermsSystem
    {
        public static bool checkAdminPerms(GTANetworkAPI.Player player)
        {
            if (NAPI.Player.GetPlayerSerial(player) != Utils.AdministratorsLicense.licenses[0])
            {
                player.SendChatMessage(Utils.ThrowErrors.WithoutPerms);
                return false;
            }
            else return true;
        }
    }
}
