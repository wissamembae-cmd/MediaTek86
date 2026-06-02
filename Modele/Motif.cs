using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    /// <summary>
    /// Classe métier représentant un motif d'absence.
    /// </summary>
    public class Motif
    {
        private int idmotif;
        private string libelle;

        /// <summary>
        /// Constructeur de la classe Motif.
        /// </summary>
        /// <param name="idmotif">Identifiant du motif.</param>
        /// <param name="libelle">Libellé du motif.</param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        public int GetIdmotif()
        {
            return idmotif;
        }

        public string GetLibelle()
        {
            return libelle;
        }
    }
}
