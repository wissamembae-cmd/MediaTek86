using MediaTek86.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    public class ResponsableAccess
    {
        private readonly Access access = null;

        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        public bool ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable ";
            req += "where login=@login and pwd=SHA2(@pwd, 256);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);

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