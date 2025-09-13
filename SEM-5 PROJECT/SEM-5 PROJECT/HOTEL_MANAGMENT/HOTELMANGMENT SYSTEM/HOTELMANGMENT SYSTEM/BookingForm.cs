using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HOTELMANGMENT_SYSTEM
{
    public partial class BookingForm : Form
    {
        MySqlConnection con = new MySqlConnection(
            "Server=localhost;Database=hotel_management;Uid=root;Pwd=;");

        public BookingForm()
        {
            InitializeComponent();

            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.CustomFormat = "yyyy-MM-dd HH:mm";
            dtCheckOut.Format = DateTimePickerFormat.Custom;
            dtCheckOut.CustomFormat = "yyyy-MM-dd HH:mm";

            numFamilyMembers.ValueChanged += numFamilyMembers_ValueChanged;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadBookings();
        }

        // ✅ Load all bookings in DataGridView
        private void LoadBookings()
        {
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM booking ORDER BY CheckInDate", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        // ✅ Auto-fill room numbers based on family members
        private void numFamilyMembers_ValueChanged(object sender, EventArgs e)
        {
            int members = (int)numFamilyMembers.Value;
            cmbRoomNo.Items.Clear();

            if (members == 4)
            {
                lblCategory.Text = "Silver (101–105)";
                for (int i = 101; i <= 105; i++) cmbRoomNo.Items.Add(i);
            }
            else if (members >= 5 && members <= 9)
            {
                lblCategory.Text = "Gold (106–110)";
                for (int i = 106; i <= 110; i++) cmbRoomNo.Items.Add(i);
            }
            else if (members == 10)
            {
                lblCategory.Text = "Diamond (111–115)";
                for (int i = 111; i <= 115; i++) cmbRoomNo.Items.Add(i);
            }
            else if (members == 11 || members == 12)
            {
                lblCategory.Text = "Premium (116–120)";
                for (int i = 116; i <= 120; i++) cmbRoomNo.Items.Add(i);
            }
            else
            {
                lblCategory.Text = "❌ No rooms available for this family size.";
            }
        }

        // ✅ Availability check
        private bool IsRoomAvailable(int roomNo, DateTime checkIn, DateTime checkOut)
        {
            string query = @"
                SELECT COUNT(*) FROM booking
                WHERE RoomNo = @r
                AND @in < CheckOutDate
                AND @out > CheckInDate";

            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@r", roomNo);
                cmd.Parameters.AddWithValue("@in", checkIn);
                cmd.Parameters.AddWithValue("@out", checkOut);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }

        // ✅ Check availability button
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            if (cmbRoomNo.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Please select a room.");
                return;
            }

            DateTime checkIn = dtCheckIn.Value;
            DateTime checkOut = dtCheckOut.Value;
            int roomNo = Convert.ToInt32(cmbRoomNo.SelectedItem);

            if (checkIn >= checkOut)
            {
                MessageBox.Show("⚠️ Check-In must be earlier than Check-Out.");
                return;
            }

            con.Open();
            bool available = IsRoomAvailable(roomNo, checkIn, checkOut);
            con.Close();

            if (available)
                MessageBox.Show("✅ Room is available!");
            else
                MessageBox.Show("❌ Room is already booked.");
        }

        // ✅ Book room
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || cmbRoomNo.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Please fill all details.");
                return;
            }

            int members = (int)numFamilyMembers.Value;
            int roomNo = Convert.ToInt32(cmbRoomNo.SelectedItem);
            DateTime checkIn = dtCheckIn.Value;
            DateTime checkOut = dtCheckOut.Value;
            string category = lblCategory.Text;

            if (checkIn >= checkOut)
            {
                MessageBox.Show("⚠️ Check-In must be earlier than Check-Out.");
                return;
            }

            try
            {
                con.Open();
                if (!IsRoomAvailable(roomNo, checkIn, checkOut))
                {
                    MessageBox.Show("❌ Room is already booked in this range.");
                    con.Close();
                    return;
                }

                string query = "INSERT INTO booking (CustomerName, RoomNo, FamilyMembers, Category, CheckInDate, CheckOutDate) " +
                               "VALUES (@n, @r, @f, @c, @in, @out)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@r", roomNo);
                cmd.Parameters.AddWithValue("@f", members);
                cmd.Parameters.AddWithValue("@c", category);
                cmd.Parameters.AddWithValue("@in", checkIn);
                cmd.Parameters.AddWithValue("@out", checkOut);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("✅ Booking successful!");
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Database Error: " + ex.Message);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkout = new CheckoutForm();
            checkout.MdiParent = this.MdiParent; // put it inside MainForm
            checkout.Show();
            this.Close();
        }

        private void BookingForm_Load_1(object sender, EventArgs e)
        {
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadBookings();
        }
    }
}
