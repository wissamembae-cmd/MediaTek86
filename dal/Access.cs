using MediaTek86.bddmanager;
using System;

namespace MediaTek86.dal
{
    public class Access
    {
        private static readonly string connectionString = "server=localhost;user id=userMediatek;password=mdpMediatek86;database=mediatek86;AllowPublicKeyRetrieval=True;";
        private static Access instance = null;

        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}