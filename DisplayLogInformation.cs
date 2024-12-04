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
    internal class DisplayLogInformation
    {
        DBconnect connect = new DBconnect();
        // gets all log information
        public DataTable getLogInformation()
        {
            MySqlCommand command = new MySqlCommand("SELECT log_entry_id AS \"Entry ID\", employee_id AS \"Employee ID\", warehouse_id AS " +
                "\"Warehouse ID\", inventory_sku AS \"SKU\", log_entry_date AS \"Entry Date\", log_entry_type AS \"Modification Type\", last_update " +
                "AS \"Last Updated\" FROM ims_logs;", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
