using MediaTek86.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    public class MotifAccess
    {
        private readonly Access access = null;

        public MotifAccess()
        {
            access = Access.GetInstance();
        }

        public List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();

            string req = "select * from motif order by libelle;";

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req);

                foreach (object[] record in records)
                {
                    Motif motif = new Motif(
                        (int)record[0],
                        (string)record[1]
                    );

                    lesMotifs.Add(motif);
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return lesMotifs;
        }
    }
}