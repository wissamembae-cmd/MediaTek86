using MediaTek86.dal;
using MediaTek86.Modele;
using System.Collections.Generic;

namespace MediaTek86.Controleur
{
    public class ControleAbsence
    {
        private AbsenceAccess absenceAccess;

        public ControleAbsence()
        {
            absenceAccess = new AbsenceAccess();
        }

        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }
        public void SupprimerAbsence(Absence absence)
        {
            absenceAccess.SupprimerAbsence(absence);
        }
        public void AjouterAbsence(Absence absence)
        {
            absenceAccess.AjouterAbsence(absence);
        }
        public bool ChevauchementAbsence(Absence absence)
        {
            return absenceAccess.ChevauchementAbsence(absence);
        }
        public void ModifierAbsence(Absence ancienneAbsence, Absence nouvelleAbsence)
        {
            absenceAccess.ModifierAbsence(ancienneAbsence, nouvelleAbsence);
        }
        public bool ChevauchementModification(Absence ancienneAbsence, Absence nouvelleAbsence)
        {
            return absenceAccess.ChevauchementModification(ancienneAbsence, nouvelleAbsence);
        }
    }

}