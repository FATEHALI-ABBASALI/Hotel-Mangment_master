using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // ✅ Use MySQL provider

namespace HOTELMANGMENT_SYSTEM
{
    public partial class CheckoutForm : Form
    {
        // ✅ MySQL Connection String
        MySqlConnection con = new MySqlConnection(
             "datasource = localhost; port=3306;username=root;password=;database=hotel_management");
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM booking WHERE RoomNo=@r", con);
                cmd.Parameters.AddWithValue("@r", txtRoomNo.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                    MessageBox.Show("✅ Check-out successful!");
                else
                    MessageBox.Show("⚠️ Room not found!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
