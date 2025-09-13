namespace HOTELMANGMENT_SYSTEM
{
    partial class CheckoutForm
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
            button1 = new Button();
            label1 = new Label();
            btnCheckout = new Button();
            txtRoomNo = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(txtRoomNo);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 471);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Location = new Point(203, 390);
            button1.Name = "button1";
            button1.Size = new Size(251, 52);
            button1.TabIndex = 14;
            button1.Text = "EXIT PROGRAM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 168);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 3;
            label1.Text = "ROOM NO:";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.RoyalBlue;
            btnCheckout.Location = new Point(186, 268);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(268, 76);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // txtRoomNo
            // 
            txtRoomNo.Location = new Point(186, 168);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.PlaceholderText = "        ROOM NUMBER";
            txtRoomNo.Size = new Size(268, 37);
            txtRoomNo.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(29, 55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(425, 37);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "©️ROOM CHECKOUT©️";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(504, 495);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckoutForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnCheckout;
        private TextBox txtRoomNo;
        private TextBox textBox1;
        private Button button1;
    }
}