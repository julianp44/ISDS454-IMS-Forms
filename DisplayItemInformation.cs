using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using sqlConnectionTest;

namespace ISDS454_IMS_Forms
{
    class DisplayItemInformation
    {
        DBconnect connect = new DBconnect();
        public DataTable getItemInformation()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM inventory_view", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getItemDetails()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM inventory", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getItemName()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT item_name AS Name FROM inventory", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
