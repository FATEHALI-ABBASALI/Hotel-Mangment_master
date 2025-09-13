using HOTELMANGMENT_SYSTEM;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HOTELMANGMENT_SYSTEM
{
    public partial class LoginForm : Form
    {
        // Property accessible from MainForm
        public static string LoggedInRole { get; private set; }

        // ✅ MySQL connection string
        MySqlConnection con = new MySqlConnection(
            "datasource = localhost; port=3306;username=root;password=;database=hotel_management");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT COUNT(*) FROM users 
                                     WHERE username = @u AND password = @p AND role = @r";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@r", role);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // ✅ Login successful from DB
                            LoggedInRole = role;

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close(); // Close login form → MainForm will apply role permissions
                            return;
                        }
                    }
                }

                // ✅ Fallback: Hardcoded credentials
                if (username == "admin" && password == "Admin@123" && role == "Admin")
                {
                    LoggedInRole = "Admin";
                    this.Close();
                }
                else if (username == "reception" && password == "Reception@123" && role == "Reception")
                {
                    LoggedInRole = "Reception";
                    this.Close();
                }
                else if (username == "customer" && password == "Customer@123" && role == "Customer")
                {
                    LoggedInRole = "Customer";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role!", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = cmbRole.Text.Trim();

            if (role == "Customer")
            {
                MessageBox.Show("👉 Default Credentials for Customer:\nUsername: customer\nPassword: Customer@123",
                                "Role Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
