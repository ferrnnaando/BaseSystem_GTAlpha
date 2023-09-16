using System;

namespace BaseSystem.Utils
{
    internal class Commands
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
    }
}
