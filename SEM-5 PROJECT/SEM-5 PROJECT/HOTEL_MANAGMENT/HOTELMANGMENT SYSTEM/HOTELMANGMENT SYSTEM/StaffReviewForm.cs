using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // ✅ Use MySQL provider

namespace HOTELMANGMENT_SYSTEM
{
    public partial class StaffReviewForm : Form
    {
        // ✅ MySQL connection
        MySqlConnection con = new MySqlConnection(
             "datasource = localhost; port=3306;username=root;password=;database=hotel_management");
        public StaffReviewForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO staffreview (StaffName, Rating, ReviewText) VALUES (@s, @r, @c)", con);

                cmd.Parameters.AddWithValue("@s", txtStaffName.Text);
                cmd.Parameters.AddWithValue("@r", cmbRating.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@c", txtComments.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Review submitted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset fields
                txtComments.Clear();
                cmbRating.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Database Error: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
