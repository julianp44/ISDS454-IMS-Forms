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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check credentials (you can add logic here for real authentication)
            bool isAuthenticated = true; // Placeholder for actual authentication

            if (isAuthenticated)
            {
                // Hide the current form
                this.Hide();

                // Create an instance of the main menu form
                MainMenuForm mainMenu = new MainMenuForm();

                // Show the main menu form
                mainMenu.Show();

                // Optional: Close the authentication form when the main menu is closed
                mainMenu.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }
    }
}
