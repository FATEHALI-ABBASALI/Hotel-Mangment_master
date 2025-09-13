namespace HOTELMANGMENT_SYSTEM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            menuFoodOrder = new ToolStripMenuItem();
            menuStaffReview = new ToolStripMenuItem();
            menuBooking = new ToolStripMenuItem();
            menuCheckout = new ToolStripMenuItem();
            menuAdmin = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFoodOrder, menuStaffReview, menuBooking, menuCheckout, menuAdmin, exitToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1301, 37);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // menuFoodOrder
            // 
            menuFoodOrder.Name = "menuFoodOrder";
            menuFoodOrder.Size = new Size(146, 29);
            menuFoodOrder.Text = "🍉Food Order";
            menuFoodOrder.ToolTipText = "FOOD ORDER";
            menuFoodOrder.Click += menuFoodOrder_Click;
            // 
            // menuStaffReview
            // 
            menuStaffReview.Name = "menuStaffReview";
            menuStaffReview.Size = new Size(139, 29);
            menuStaffReview.Text = "®️Staff Review";
            menuStaffReview.ToolTipText = "STAFF REVIEW";
            menuStaffReview.Click += menuStaffReview_Click;
            // 
            // menuBooking
            // 
            menuBooking.Name = "menuBooking";
            menuBooking.Size = new Size(119, 29);
            menuBooking.Text = "\U0001f9feBooking";
            menuBooking.ToolTipText = "BOOKING";
            menuBooking.Click += menuBooking_Click;
            // 
            // menuCheckout
            // 
            menuCheckout.Name = "menuCheckout";
            menuCheckout.Size = new Size(127, 29);
            menuCheckout.Text = "🛫Checkout";
            menuCheckout.ToolTipText = "CHECKOUT";
            menuCheckout.Click += menuCheckout_Click;
            // 
            // menuAdmin
            // 
            menuAdmin.Name = "menuAdmin";
            menuAdmin.Size = new Size(106, 29);
            menuAdmin.Text = "\U0001f9d1🏻‍💻Admin";
            menuAdmin.ToolTipText = "ADMIN";
            menuAdmin.Click += menuAdmin_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(79, 29);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1301, 999);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem menuBooking;
        private ToolStripMenuItem menuFoodOrder;
        private ToolStripMenuItem menuStaffReview;
        private ToolStripMenuItem menuCheckout;
        private ToolStripMenuItem menuAdmin;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}



