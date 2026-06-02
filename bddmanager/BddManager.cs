using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.bddmanager
{
    /// <summary>
    /// Classe technique permettant de gérer la connexion à la base de données.
    /// </summary>
    public class BddManager
    {
        private static BddManager instance = null;
        private MySqlConnection cnx;

        /// <summary>
        /// Constructeur privé.
        /// </summary>
        private BddManager()
        {
            cnx = new MySqlConnection(dal.Access.GetConnectionString());
        }

        /// <summary>
        /// Récupère l'instance unique de BddManager.
        /// </summary>
        /// <returns>Instance unique de BddManager.</returns>
        public static BddManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BddManager();
            }
            return instance;
        }

        /// <summary>
        /// Ouvre la connexion à la base de données.
        /// </summary>
        public void OpenConnection()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
        }

        /// <summary>
        /// Ferme la connexion à la base de données.
        /// </summary>
        public void CloseConnection()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        /// <summary>
        /// Retourne la connexion MySQL.
        /// </summary>
        /// <returns>Connexion MySQL.</returns>
        public MySqlConnection GetConnection()
        {
            return cnx;
        }
    }
}


