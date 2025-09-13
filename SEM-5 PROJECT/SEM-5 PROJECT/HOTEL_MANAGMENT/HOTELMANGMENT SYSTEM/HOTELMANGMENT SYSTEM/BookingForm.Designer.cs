namespace HOTELMANGMENT_SYSTEM
{
    partial class BookingForm
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
            panel1 = new Panel();
            numFamilyMembers = new NumericUpDown();
            label6 = new Label();
            lblCategory = new Label();
            cmbRoomNo = new ComboBox();
            btnCheckAvailability = new Button();
            btnCheckout = new Button();
            textBox1 = new TextBox();
            dtCheckOut = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBook = new Button();
            dtCheckIn = new DateTimePicker();
            txtCustomerName = new TextBox();
            label1 = new Label();
            dgvBookings = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFamilyMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(numFamilyMembers);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(cmbRoomNo);
            panel1.Controls.Add(btnCheckAvailability);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dtCheckOut);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(dtCheckIn);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(199, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 579);
            panel1.TabIndex = 0;
            // 
            // numFamilyMembers
            // 
            numFamilyMembers.Location = new Point(392, 148);
            numFamilyMembers.Name = "numFamilyMembers";
            numFamilyMembers.Size = new Size(234, 37);
            numFamilyMembers.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(188, 148);
            label6.Name = "label6";
            label6.Size = new Size(180, 28);
            label6.TabIndex = 23;
            label6.Text = "FAMILY-MEMBER:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ControlLightLight;
            lblCategory.Location = new Point(197, 197);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(0, 28);
            lblCategory.TabIndex = 22;
            // 
            // cmbRoomNo
            // 
            cmbRoomNo.FormattingEnabled = true;
            cmbRoomNo.Location = new Point(392, 242);
            cmbRoomNo.Name = "cmbRoomNo";
            cmbRoomNo.Size = new Size(234, 38);
            cmbRoomNo.TabIndex = 21;
            // 
            // btnCheckAvailability
            // 
            btnCheckAvailability.BackColor = Color.RoyalBlue;
            btnCheckAvailability.FlatStyle = FlatStyle.Popup;
            btnCheckAvailability.Location = new Point(188, 510);
            btnCheckAvailability.Name = "btnCheckAvailability";
            btnCheckAvailability.Size = new Size(438, 51);
            btnCheckAvailability.TabIndex = 19;
            btnCheckAvailability.Text = "CHECK IF ROOM IS FREE";
            btnCheckAvailability.UseVisualStyleBackColor = false;
            btnCheckAvailability.Click += btnCheckAvailability_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.RoyalBlue;
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Location = new Point(418, 452);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(208, 52);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(188, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(447, 37);
            textBox1.TabIndex = 18;
            textBox1.TabStop = false;
            textBox1.Text = "📑ROOM BOOK NOW\U0001f9fe";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dtCheckOut
            // 
            dtCheckOut.CustomFormat = "yyyy-MM-dd HH:mm";
            dtCheckOut.Format = DateTimePickerFormat.Custom;
            dtCheckOut.Location = new Point(392, 400);
            dtCheckOut.Name = "dtCheckOut";
            dtCheckOut.Size = new Size(234, 37);
            dtCheckOut.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(188, 400);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 16;
            label4.Text = "CHECK-OUT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(188, 312);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 14;
            label3.Text = "CHECK-IN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(188, 252);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 13;
            label2.Text = "ROOM NO:";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.RoyalBlue;
            btnBook.FlatStyle = FlatStyle.Popup;
            btnBook.Location = new Point(188, 452);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(214, 52);
            btnBook.TabIndex = 12;
            btnBook.Text = "BOOK NOW";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // dtCheckIn
            // 
            dtCheckIn.CustomFormat = "yyyy-MM-dd HH:mm";
            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.Location = new Point(392, 312);
            dtCheckIn.Name = "dtCheckIn";
            dtCheckIn.Size = new Size(234, 37);
            dtCheckIn.TabIndex = 11;
            dtCheckIn.Value = new DateTime(2025, 8, 27, 6, 6, 0, 0);
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(392, 89);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "CUSTOMER NAME";
            txtCustomerName.Size = new Size(234, 37);
            txtCustomerName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(188, 89);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 9;
            label1.Text = "CUSTOMER NAME:";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToResizeColumns = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBookings.BackgroundColor = SystemColors.ControlLightLight;
            dgvBookings.ColumnHeadersHeight = 40;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBookings.Location = new Point(49, 607);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 62;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1114, 271);
            dgvBookings.TabIndex = 21;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1201, 923);
            Controls.Add(dgvBookings);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookingForm";
            Load += BookingForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFamilyMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private NumericUpDown numFamilyMembers;
        private Label label6;
        private Label lblCategory;
        private ComboBox cmbRoomNo;
        private Button btnCheckAvailability;
        private Button btnCheckout;
        private TextBox textBox1;
        private DateTimePicker dtCheckOut;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBook;
        private DateTimePicker dtCheckIn;
        private TextBox txtCustomerName;
        private Label label1;
        private DataGridView dgvBookings;
    }
}