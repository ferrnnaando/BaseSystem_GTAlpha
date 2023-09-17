using System;

namespace BaseSystem.Utils
{
    internal class Commands
    {
        internal class Staff
        {
            internal class Time
            {
                public const string CommandName = "time";
                public const string CommandDescription = "Establece la hora client-side del servidor.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /time [day/night]"; //cant use interporalization concatenating since is const, const required to evaluate it as a const command value

            }

            internal class Car
            {
                public const string CommandName = "car";
                public const string CommandDescription = "Suministra un vehículo en la posición del jugador que ejecuta el comando.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /car [modelo]";
            }

            internal class Dv
            {
                public const string CommandName = "dv";
                public const string CommandDescription = "Elimina el vehículo en el que te encuentras.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /dv";

            }

            internal class DvAll
            {
                public const string CommandName = "dvall";
                public const string CommandDescription = "Elimina todos los vehiculos presentes en el servidor.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /dvall";
            }

            internal class Fix
            {
                public const string CommandName = "fix";
                public const string CommandDescription = "Arregla el estado del vehículo en el que te encuentras montado.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /fix";
            }

            internal class Kill
            {
                public const string CommandName = "kill";
                public const string CommandDescription = "Arrebátale la vida a algun miembro del servidor presente.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /kill [ID/me]";
            }

            internal class Health
            {
                public const string CommandName = "health";
                public const string CommandDescription = "Cura la vida de alguien al máximo.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /health [ID/me]";
            }

            internal class Revive
            {
                public const string CommandName = "revive";
                public const string CommandDescription = "Revive a alguien muerto.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /revive [ID/me]";
            }

            internal class GiveWeapon
            {
                public const string CommandName = "giveweapon";
                public const string CommandDescription = "Otorga el arma especificada a el jugador especificado.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /giveweapon [ID/me] [weaponName] [ammo]";
            }

            internal class RemoveWeapon
            {
                public const string CommandName = "removeweapon";
                public const string CommandDescription = "Confisca el arma especificada de algún jugador.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /removeweapon [ID/me] [weaponName]";
            }

            internal class TpCoords
            {
                public const string CommandName = "tpcoords";
                public const string CommandDescription = "Teletransportáte a las coordenadas especificadas.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /tpcoords [X] [Y] [Z]";
            }

            internal class Tp
            {
                public const string CommandName = "tpcoords";
                public const string CommandDescription = "Teletransportáte a las coordenadas donde se encuentra un usuario.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /tp [targetId]";
            }

            internal class ShowCoords
            {
                public const string CommandName = "tpcoords";
                public const string CommandDescription = "Muestra las coordenadas del lugar en el que te encuentras.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /showcoords";
            }
            internal class Weather
            {
                public const string CommandName = "weather";
                public const string CommandDescription = "Establece el tiempo client-side del servidor.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /weather [0 - 9]";
            }
        }

        internal class Public
        {
            internal class Desc
            {
                public const string CommandName = "desc";
                public const string CommandDescription = "Obtén información sobre el comando indicado.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /desc [commandName]";
            }
            internal class Ame
            {
                public const string CommandName = "ame";
                public const string CommandDescription = "Realiza una acción.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /ame [action]";
            }

            internal class Oop
            {
                public const string CommandName = "oop";
                public const string CommandDescription = "Envia un mensaje fuera de rol con un alcance de 250 metros.";
                public const string CommandUsage = "~r~Sintaxis:~w~ /oop [message]"; //cant use interporalization concatenating since is const, const required to evaluate it as a const command value
            }
        }
    }
}
