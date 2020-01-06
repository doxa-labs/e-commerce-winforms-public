using System;
using MySql.Data.MySqlClient;
// Self
using N11Category.Models;

namespace N11Category
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect(ConnectionModelN11 modelN11)
        {
            if (String.IsNullOrEmpty(databaseName))
                return false;
            string connstring = string.Format("Server={0}; Port={1}; database={2}; UID={3}; password={4}", modelN11.server, modelN11.port, modelN11.databaseName, modelN11.username, modelN11.password);
            connection = new MySqlConnection(connstring);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error no: 1 -" + ex.Message);
                return false;
            }

            return true;
        }

        public bool IsConnect(ConnectionModelGG modelGG)
        {
            if (String.IsNullOrEmpty(databaseName))
                return false;
            string connstring = string.Format("Server={0}; Port={1}; database={2}; UID={3}; password={4}", modelGG.server, modelGG.port, modelGG.databaseName, modelGG.username, modelGG.password);
            connection = new MySqlConnection(connstring);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error no: 1 -" + ex.Message);
                return false;
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}