using MediaTek86.Modele;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    public class ServiceAccess
    {
        private readonly Access access = null;

        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();

            string req = "select * from service;";

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req);

                foreach (object[] record in records)
                {
                    Service service = new Service(
                        (int)record[0],
                        (string)record[1]
                    );

                    lesServices.Add(service);
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }

            return lesServices;
        }
    }
}