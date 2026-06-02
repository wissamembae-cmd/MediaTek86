using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.dal;

namespace MediaTek86.Controleur
{
    /// <summary>
    /// Controleur de la fenêtre de connexion.
    /// </summary>
    public class ControleConnexion
    {
        private ResponsableAccess responsableAccess;

        /// <summary>
        /// Constructeur du controleur.
        /// </summary>
        public ControleConnexion()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Controle les informations de connexion.
        /// </summary>
        public bool ControleAuthentification(string login, string pwd)
        {
            return responsableAccess.ControleAuthentification(login, pwd);
        }
    }
}
