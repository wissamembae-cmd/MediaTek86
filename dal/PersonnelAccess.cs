using MediaTek86.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    public class PersonnelAccess
    {
        private readonly Access access = null;

        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();

            string req = "select personnel.idpersonnel, personnel.nom, personnel.prenom, personnel.tel, personnel.mail, service.idservice, service.nom as nomservice ";
            req += "from personnel join service on personnel.idservice = service.idservice;";

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req);

                foreach (object[] record in records)
                {
                    Service service = new Service((int)record[5], (string)record[6]);

                    Personnel personnel = new Personnel(
                        (int)record[0],
                        (string)record[1],
                        (string)record[2],
                        (string)record[3],
                        (string)record[4],
                        service
                    );

                    lesPersonnels.Add(personnel);
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return lesPersonnels;
        }

        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idservice)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
            req += "values(@nom, @prenom, @tel, @mail, @idservice);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", nom);
            parameters.Add("@prenom", prenom);
            parameters.Add("@tel", tel);
            parameters.Add("@mail", mail);
            parameters.Add("@idservice", idservice);

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }


        }
        public void SupprimerPersonnel(int idpersonnel)
        {
            string req = "delete from personnel where idpersonnel=@idpersonnel;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        public void ModifierPersonnel(Personnel personnel)
        {
            string req = "update personnel set nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idservice=@idservice ";
            req += "where idpersonnel=@idpersonnel;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Service.GetIdservice());

            try
            {
                access.Manager.ReqUpdate(req, parameters);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
    }

}