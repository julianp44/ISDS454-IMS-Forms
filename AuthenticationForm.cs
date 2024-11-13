using MySql.Data.MySqlClient;
using sqlConnectionTest;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;

namespace ISDS454_IMS_Forms
{
    public partial class InventoryManagementSystem : Form
    {
        public InventoryManagementSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //This is the Authentication Cancel Button
        {
            this.Close(); //Closes the Authentication Page
        }
        
        private void button1_Click(object sender, EventArgs e) //Login Button
        {
            string usernameInput = EmployeeIDInputBox.Text;
            string passwordInput = PasswordInputBox.Text;

            MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase");
            string query = "SELECT * FROM employeeinfo WHERE employeeUsername = '" + usernameInput.Trim() + "' AND employeePassword = '" + passwordInput.Trim() + "'";
           
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                // Hide the current form
                this.Hide();
                // Create an instance of the main menu form
                MainMenuForm mainMenu = new MainMenuForm();
                // Show the main menu form
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
