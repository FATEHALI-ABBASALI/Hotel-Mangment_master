using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELMANGMENT_SYSTEM
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuFoodOrder.Visible = false;
            menuStaffReview.Visible = false;
            menuBooking.Visible = false;
            menuCheckout.Visible = false;
            menuAdmin.Visible = false;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(176, 196, 222); // pick any color
                }
            }

            // Show login form inside MDI
            LoginForm login = new LoginForm();
            login.MdiParent = this;

            // Attach event when login closes
            login.FormClosed += Login_FormClosed;
            login.Show();


        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginForm.LoggedInRole))
            {
                Application.Exit(); // Exit if login failed/cancelled
            }
            else
            {
                ApplyRolePermissions();
            }
        }


        private void ApplyRolePermissions()
        {
            string role = LoginForm.LoggedInRole;

            // Hide all menus first
            menuFoodOrder.Visible = false;
            menuStaffReview.Visible = false;
            menuBooking.Visible = false;
            menuCheckout.Visible = false;
            menuAdmin.Visible = false;

            // Show based on role
            if (role == "Customer")
            {
                menuFoodOrder.Visible = true;
                menuStaffReview.Visible = true;
            }
            else if (role == "Reception")
            {
                menuBooking.Visible = true;
                menuCheckout.Visible = true;
            }
            else if (role == "Admin")
            {
                menuAdmin.Visible = true;
            }
        }
        private void OpenChildForm(Form child)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();

            child.MdiParent = this;
            child.WindowState = FormWindowState.Normal;
            child.Show();
        }

        private void menuFoodOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodOrderForm());
        }

        private void menuStaffReview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffReviewForm());
        }

        private void menuBooking_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookingForm());
        }

        private void menuCheckout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckoutForm());
        }

        private void menuAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
