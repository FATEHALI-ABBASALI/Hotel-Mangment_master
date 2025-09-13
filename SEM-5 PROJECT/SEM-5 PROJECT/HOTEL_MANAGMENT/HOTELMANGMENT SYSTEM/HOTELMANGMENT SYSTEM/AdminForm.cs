using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // ✅ MySQL provider
using Timer = System.Windows.Forms.Timer;

namespace HOTELMANGMENT_SYSTEM
{
    public partial class AdminForm : Form
    {
        // ✅ MySQL connection
        MySqlConnection con = new MySqlConnection(
             "datasource=localhost;port=3306;username=root;password=;database=hotel_management");

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAllTables();

            // Auto-refresh every 10 seconds
            Timer timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += (s, ev) => LoadAllTables();
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllTables();
        }

        private void LoadAllTables()
        {
            try
            {
                con.Open();

                // Load Users
                MySqlDataAdapter daUsers = new MySqlDataAdapter("SELECT * FROM users", con);
                DataTable dtUsers = new DataTable();
                daUsers.Fill(dtUsers);
                dgvUsers.DataSource = dtUsers;

                // Load Bookings
                MySqlDataAdapter daBookings = new MySqlDataAdapter("SELECT * FROM booking", con);
                DataTable dtBookings = new DataTable();
                daBookings.Fill(dtBookings);
                dgvBookings.DataSource = dtBookings;

                // Load Food Orders
                MySqlDataAdapter daFood = new MySqlDataAdapter("SELECT * FROM foodorder", con);
                DataTable dtFood = new DataTable();
                daFood.Fill(dtFood);
                dgvFoodOrders.DataSource = dtFood;

                // 🔔 Count Pending Food Orders
                MySqlCommand cmdPending = new MySqlCommand(
                    "SELECT COUNT(*) FROM foodorder WHERE Status = 'Pending'", con);
                int pendingCount = Convert.ToInt32(cmdPending.ExecuteScalar());
                lblNotification.Text = $"🔔 Pending Food Orders: {pendingCount}";

                // Load Staff Reviews
                MySqlDataAdapter daReviews = new MySqlDataAdapter("SELECT * FROM staffreview", con);
                DataTable dtReviews = new DataTable();
                daReviews.Fill(dtReviews);
                dgvStaffReviews.DataSource = dtReviews;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // ❌ Exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 🗑 Delete selected food order
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFoodOrders.SelectedRows.Count > 0)
            {
                string customerName = dgvFoodOrders.SelectedRows[0].Cells["CustomerName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this food order for " + customerName + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlCommand cmd = new MySqlCommand(
                        "DELETE FROM foodorder WHERE CustomerName = @name", con))
                    {
                        cmd.Parameters.AddWithValue("@name", customerName);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    LoadAllTables();
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }

        // ✅ Mark selected order as Completed
        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvFoodOrders.SelectedRows.Count > 0)
            {
                string customerName = dgvFoodOrders.SelectedRows[0].Cells["CustomerName"].Value.ToString();

                using (MySqlCommand cmd = new MySqlCommand(
                    "UPDATE foodorder SET Status = 'Completed' WHERE CustomerName = @name", con))
                {
                    cmd.Parameters.AddWithValue("@name", customerName);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                LoadAllTables();
                MessageBox.Show("Order for " + customerName + " marked as Completed!");
            }
            else
            {
                MessageBox.Show("Please select an order to complete.");
            }
        }
    }
}
