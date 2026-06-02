using MediaTek86.dal;
using MediaTek86.Modele;
using System.Collections.Generic;

namespace MediaTek86.Controleur
{
    public class ControleMotif
    {
        private MotifAccess motifAccess;

        public ControleMotif()
        {
            motifAccess = new MotifAccess();
        }

        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }
    }
}