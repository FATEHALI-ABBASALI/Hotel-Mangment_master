namespace HOTELMANGMENT_SYSTEM
{
    partial class LoginForm
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
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 388);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(22, 34);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(499, 37);
            textBox1.TabIndex = 7;
            textBox1.TabStop = false;
            textBox1.Text = "👤LOGIN";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(22, 250);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 6;
            label3.Text = "®️ROLE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 186);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 5;
            label2.Text = "🔑PASSWORD:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(188, 124);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ENTER USERNAME";
            txtUsername.Size = new Size(289, 37);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(188, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(289, 49);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Reception", "Customer" });
            cmbRole.Location = new Point(188, 242);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(289, 38);
            cmbRole.TabIndex = 2;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "ENTER PASSWORD";
            txtPassword.Size = new Size(289, 37);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 124);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "👥USERNAME:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(569, 418);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private Button btnLogin;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private Label label1;
    }
}