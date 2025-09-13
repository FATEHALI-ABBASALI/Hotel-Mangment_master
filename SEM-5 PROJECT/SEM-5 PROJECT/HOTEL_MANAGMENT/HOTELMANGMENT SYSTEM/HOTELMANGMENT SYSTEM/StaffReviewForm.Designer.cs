namespace HOTELMANGMENT_SYSTEM
{
    partial class StaffReviewForm
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
            txtStaffName = new ComboBox();
            button1 = new Button();
            textBox3 = new TextBox();
            btnSubmit = new Button();
            cmbRating = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtComments = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtStaffName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(cmbRating);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtComments);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 467);
            panel1.TabIndex = 0;
            // 
            // txtStaffName
            // 
            txtStaffName.FormattingEnabled = true;
            txtStaffName.Items.AddRange(new object[] { "RAHUL", "PANKAJ", "AMAN", "DEVIKA", "SUMAN", "KULDEEP" });
            txtStaffName.Location = new Point(194, 121);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(182, 38);
            txtStaffName.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(125, 384);
            button1.Name = "button1";
            button1.Size = new Size(251, 54);
            button1.TabIndex = 14;
            button1.Text = "EXIT PROGRAM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(27, 28);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(349, 37);
            textBox3.TabIndex = 7;
            textBox3.Text = "👥STAFF REVIEW👥";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RoyalBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Location = new Point(194, 311);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(182, 53);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbRating.Location = new Point(194, 192);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(182, 38);
            cmbRating.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(27, 250);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 4;
            label3.Text = "COMMENTS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(27, 192);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 3;
            label2.Text = "RATING:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 124);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 2;
            label1.Text = "STAFF NAME:";
            // 
            // txtComments
            // 
            txtComments.Location = new Point(194, 250);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.PlaceholderText = "COMMENTS";
            txtComments.Size = new Size(182, 46);
            txtComments.TabIndex = 1;
            // 
            // StaffReviewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 491);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StaffReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffReviewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtComments;
        private TextBox textBox3;
        private Button btnSubmit;
        private ComboBox cmbRating;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox txtStaffName;
    }
}