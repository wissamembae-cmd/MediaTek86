using MediaTek86.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    public class AbsenceAccess
    {
        private readonly Access access = null;

        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();

            string req = "select absence.datedebut, absence.datefin, motif.idmotif, motif.libelle ";
            req += "from absence join motif on absence.idmotif = motif.idmotif ";
            req += "where absence.idpersonnel = @idpersonnel ";
            req += "order by absence.datedebut;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req, parameters);

                foreach (object[] record in records)
                {
                    Motif motif = new Motif((int)record[2], (string)record[3]);

                    Absence absence = new Absence(
                        (DateTime)record[0],
                        (DateTime)record[1],
                        personnel,
                        motif
                    );

                    lesAbsences.Add(absence);
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return lesAbsences;
        }
        public void SupprimerAbsence(Absence absence)
        {
            string req = "delete from absence ";
            req += "where datedebut=@datedebut and idpersonnel=@idpersonnel;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idpersonnel", absence.GetPersonnel().Idpersonnel);

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        public void AjouterAbsence(Absence absence)
        {
            string req = "insert into absence(datedebut, idpersonnel, idmotif, datefin) ";
            req += "values(@datedebut, @idpersonnel, @idmotif, @datefin);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@idpersonnel", absence.GetPersonnel().Idpersonnel);
            parameters.Add("@idmotif", absence.LeMotif.GetIdmotif());
            parameters.Add("@datefin", absence.Datefin);

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        public bool ChevauchementAbsence(Absence absence)
        {
            string req = "select * from absence ";
            req += "where idpersonnel=@idpersonnel ";
            req += "and @datedebut <= datefin ";
            req += "and @datefin >= datedebut;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.GetPersonnel().Idpersonnel);
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req, parameters);

                if (records.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return false;
        }
        public void ModifierAbsence(Absence ancienneAbsence, Absence nouvelleAbsence)
        {
            string req = "update absence set datedebut=@nouvelleDateDebut, datefin=@datefin, idmotif=@idmotif ";
            req += "where datedebut=@ancienneDateDebut and idpersonnel=@idpersonnel;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nouvelleDateDebut", nouvelleAbsence.Datedebut);
            parameters.Add("@datefin", nouvelleAbsence.Datefin);
            parameters.Add("@idmotif", nouvelleAbsence.LeMotif.GetIdmotif());
            parameters.Add("@ancienneDateDebut", ancienneAbsence.Datedebut);
            parameters.Add("@idpersonnel", ancienneAbsence.GetPersonnel().Idpersonnel);

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

        }
        public bool ChevauchementModification(Absence ancienneAbsence, Absence nouvelleAbsence)
        {
            string req = "select * from absence ";
            req += "where idpersonnel=@idpersonnel ";
            req += "and not (datedebut=@ancienneDateDebut and idpersonnel=@idpersonnel) ";
            req += "and @datedebut <= datefin ";
            req += "and @datefin >= datedebut;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", ancienneAbsence.GetPersonnel().Idpersonnel);
            parameters.Add("@ancienneDateDebut", ancienneAbsence.Datedebut);
            parameters.Add("@datedebut", nouvelleAbsence.Datedebut);
            parameters.Add("@datefin", nouvelleAbsence.Datefin);

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req, parameters);

                if (records.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return false;
        }
    }
}