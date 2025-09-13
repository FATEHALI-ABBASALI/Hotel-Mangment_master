namespace HOTELMANGMENT_SYSTEM
{
    partial class AdminForm
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
            dgvUsers = new DataGridView();
            dgvBookings = new DataGridView();
            dgvStaffReviews = new DataGridView();
            dgvFoodOrders = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            lblNotification = new Label();
            btnCompleteOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaffReviews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ControlLightLight;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 71);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(758, 225);
            dgvUsers.TabIndex = 0;
            // 
            // dgvBookings
            // 
            dgvBookings.BackgroundColor = SystemColors.ControlLightLight;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(837, 71);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 62;
            dgvBookings.Size = new Size(842, 225);
            dgvBookings.TabIndex = 1;
            // 
            // dgvStaffReviews
            // 
            dgvStaffReviews.BackgroundColor = SystemColors.ControlLightLight;
            dgvStaffReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffReviews.Location = new Point(837, 360);
            dgvStaffReviews.Name = "dgvStaffReviews";
            dgvStaffReviews.RowHeadersWidth = 62;
            dgvStaffReviews.Size = new Size(842, 225);
            dgvStaffReviews.TabIndex = 2;
            // 
            // dgvFoodOrders
            // 
            dgvFoodOrders.BackgroundColor = SystemColors.ControlLightLight;
            dgvFoodOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodOrders.Location = new Point(12, 360);
            dgvFoodOrders.Name = "dgvFoodOrders";
            dgvFoodOrders.RowHeadersWidth = 62;
            dgvFoodOrders.Size = new Size(758, 225);
            dgvFoodOrders.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(307, 22);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 4;
            label1.Text = "\U0001f9d1🏻‍💻USER TABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(1207, 22);
            label2.Name = "label2";
            label2.Size = new Size(215, 30);
            label2.TabIndex = 5;
            label2.Text = "🅱️BOOKING TABLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(307, 310);
            label3.Name = "label3";
            label3.Size = new Size(259, 30);
            label3.TabIndex = 6;
            label3.Text = "🍉FOODORDERS TABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1207, 310);
            label4.Name = "label4";
            label4.Size = new Size(261, 30);
            label4.TabIndex = 7;
            label4.Text = "👥STAFF REVIEW TABLE";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(212, 602);
            button2.Name = "button2";
            button2.Size = new Size(278, 52);
            button2.TabIndex = 15;
            button2.Text = "DELETE FOOD ORDER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.BackColor = Color.DarkRed;
            lblNotification.ForeColor = SystemColors.ControlLightLight;
            lblNotification.Location = new Point(764, 613);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(0, 30);
            lblNotification.TabIndex = 16;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.BackColor = Color.RoyalBlue;
            btnCompleteOrder.FlatStyle = FlatStyle.Popup;
            btnCompleteOrder.ForeColor = SystemColors.ActiveCaptionText;
            btnCompleteOrder.Location = new Point(1457, 602);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(222, 52);
            btnCompleteOrder.TabIndex = 17;
            btnCompleteOrder.Text = "COMPLETE ORDER";
            btnCompleteOrder.UseVisualStyleBackColor = false;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1725, 666);
            Controls.Add(btnCompleteOrder);
            Controls.Add(lblNotification);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvFoodOrders);
            Controls.Add(dgvStaffReviews);
            Controls.Add(dgvBookings);
            Controls.Add(dgvUsers);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaffReviews).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private DataGridView dgvBookings;
        private DataGridView dgvStaffReviews;
        private DataGridView dgvFoodOrders;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label lblNotification;
        private Button btnCompleteOrder;
    }
}