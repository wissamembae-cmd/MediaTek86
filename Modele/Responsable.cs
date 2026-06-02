using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    /// <summary>
    /// Classe métier représentant le responsable de l'application.
    /// </summary>
    public class Responsable
    {
        private string login;
        private string pwd;

        /// <summary>
        /// Constructeur de la classe Responsable.
        /// </summary>
        /// <param name="login">Login du responsable.</param>
        /// <param name="pwd">Mot de passe hashé du responsable.</param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        public string GetLogin()
        {
            return login;
        }

        public string GetPwd()
        {
            return pwd;
        }
    }
}
