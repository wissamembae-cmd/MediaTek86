using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MediaTek86.Modele
{
    /// <summary>
    /// Classe métier représentant une absence.
    /// </summary>
    public class Absence
    {
        public DateTime Datedebut { get { return datedebut; } }
        public DateTime Datefin { get { return datefin; } }
        public string Motif { get { return motif.GetLibelle(); } }
        private DateTime datedebut;
        private DateTime datefin;
        private Personnel personnel;
        private Motif motif;
        public Motif LeMotif { get { return motif; } }

        /// <summary>
        /// Constructeur de la classe Absence.
        /// </summary>
        /// <param name="datedebut">Date de début de l'absence.</param>
        /// <param name="datefin">Date de fin de l'absence.</param>
        /// <param name="personnel">Personnel concerné.</param>
        /// <param name="motif">Motif de l'absence.</param>
        public Absence(DateTime datedebut, DateTime datefin, Personnel personnel, Motif motif)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.personnel = personnel;
            this.motif = motif;
        }

        public DateTime GetDatedebut()
        {
            return datedebut;
        }

        public DateTime GetDatefin()
        {
            return datefin;
        }

        public Personnel GetPersonnel()
        {
            return personnel;
        }

        public Motif GetMotif()
        {
            return motif;
        }
    }
}
