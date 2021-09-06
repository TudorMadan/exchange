using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace proiect
{
    class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initializeaza valori
        private void Initialize()
        {
            server = "db-mysql-fra1-48131-do-user-9387047-0.b.db.ondigitalocean.com";
            database = "defaultdb";
            uid = "doadmin";
            password = "an49ug75v6kcwtp0";
            port = "25060";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Deschide conexiunea la baza de date
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Nu se poate conecta la server, contactati adminisitratorul!");
                        break;

                    case 1045:
                        MessageBox.Show("Nume de utilizator/parola invalide. Va rog incercati din nou!");
                        break;
                }
                return false;
            }
        }

        //Inchide conexiune
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
