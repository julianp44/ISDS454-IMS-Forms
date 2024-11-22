using MySql.Data.MySqlClient;

namespace sqlConnectionTest
{
    class DBconnect
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase;Convert Zero Datetime=True");

        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        public void openConnnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
