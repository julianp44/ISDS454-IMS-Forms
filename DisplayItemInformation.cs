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
        // gets all item information
        public DataTable getItemInformation()
        {
            MySqlCommand command = new MySqlCommand("SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location, item_description AS Description, item_expirationdate AS Expiration, inventory_type AS Category, supplier_info AS Supplier, cost_per_unit AS Cost, sellingprice_per_unit AS Price FROM inventory", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // gets sku, warehouseid, name, quantity, location
        public DataTable getItemDetails()
        {
            MySqlCommand command = new MySqlCommand("SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location FROM inventory", connect.getconnection);
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
