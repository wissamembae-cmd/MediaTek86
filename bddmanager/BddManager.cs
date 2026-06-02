using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MediaTek86.bddmanager
{
    public class BddManager
    {
        private static BddManager instance = null;
        private MySqlConnection connection;

        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        public void ReqUpdate(string req, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(req, connection);

            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }

            command.Prepare();
            command.ExecuteNonQuery();
        }

        public List<object[]> ReqSelect(string req, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(req, connection);

            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }

            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();
            int nbCols = reader.FieldCount;
            List<object[]> records = new List<object[]>();

            while (reader.Read())
            {
                object[] valeurs = new object[nbCols];
                reader.GetValues(valeurs);
                records.Add(valeurs);
            }

            reader.Close();
            return records;
        }
    }
}