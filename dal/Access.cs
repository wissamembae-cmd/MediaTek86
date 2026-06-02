using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe contenant les informations d'accès à la base de données.
    /// </summary>
    public class Access
    {
        private static string connectionString = "server=localhost;database=mediatek86;uid=userMediatek;pwd=mdpMediatek86;";

        /// <summary>
        /// Retourne la chaîne de connexion à la base de données.
        /// </summary>
        /// <returns>Chaîne de connexion.</returns>
        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
