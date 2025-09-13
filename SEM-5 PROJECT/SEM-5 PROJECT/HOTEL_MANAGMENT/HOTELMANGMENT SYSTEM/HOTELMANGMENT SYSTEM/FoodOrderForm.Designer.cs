namespace HOTELMANGMENT_SYSTEM
{
    partial class FoodOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodOrderForm));
            dgvRooms = new DataGridView();
            colRoomNo = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            btnLoadRooms = new Button();
            lblFoodMenuTitle = new Label();
            btnLoadFoodMenu = new Button();
            lvFoodMenu = new ListView();
            colFoodItem = new ColumnHeader();
            colFoodPrice = new ColumnHeader();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAddToCart = new Button();
            lblCart = new Label();
            lstCart = new ListBox();
            lblTotalPriceCaption = new Label();
            txtTotalPrice = new TextBox();
            btnPlaceOrder = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colRoomNo, colCustomerName });
            dgvRooms.Location = new Point(20, 60);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 62;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(430, 360);
            dgvRooms.TabIndex = 0;
            // 
            // colRoomNo
            // 
            colRoomNo.HeaderText = "RoomNo";
            colRoomNo.MinimumWidth = 8;
            colRoomNo.Name = "colRoomNo";
            colRoomNo.ReadOnly = true;
            colRoomNo.Width = 120;
            // 
            // colCustomerName
            // 
            colCustomerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCustomerName.HeaderText = "CustomerName";
            colCustomerName.MinimumWidth = 8;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // btnLoadRooms
            // 
            btnLoadRooms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadRooms.BackColor = Color.RoyalBlue;
            btnLoadRooms.FlatStyle = FlatStyle.Popup;
            btnLoadRooms.Location = new Point(20, 440);
            btnLoadRooms.Name = "btnLoadRooms";
            btnLoadRooms.Size = new Size(430, 57);
            btnLoadRooms.TabIndex = 1;
            btnLoadRooms.Text = "Load Rooms";
            btnLoadRooms.UseVisualStyleBackColor = false;
            btnLoadRooms.Click += btnLoadRooms_Click;
            // 
            // lblFoodMenuTitle
            // 
            lblFoodMenuTitle.AutoSize = true;
            lblFoodMenuTitle.BackColor = Color.Transparent;
            lblFoodMenuTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodMenuTitle.ForeColor = SystemColors.ControlLightLight;
            lblFoodMenuTitle.Location = new Point(470, 20);
            lblFoodMenuTitle.Name = "lblFoodMenuTitle";
            lblFoodMenuTitle.Size = new Size(160, 25);
            lblFoodMenuTitle.TabIndex = 2;
            lblFoodMenuTitle.Text = "🍉Food Menu🍓";
            // 
            // btnLoadFoodMenu
            // 
            btnLoadFoodMenu.BackColor = Color.RoyalBlue;
            btnLoadFoodMenu.FlatStyle = FlatStyle.Popup;
            btnLoadFoodMenu.Location = new Point(700, 20);
            btnLoadFoodMenu.Name = "btnLoadFoodMenu";
            btnLoadFoodMenu.Size = new Size(250, 37);
            btnLoadFoodMenu.TabIndex = 3;
            btnLoadFoodMenu.Text = "Load Food Menu";
            btnLoadFoodMenu.UseVisualStyleBackColor = false;
            btnLoadFoodMenu.Click += btnLoadFoodMenu_Click;
            // 
            // lvFoodMenu
            // 
            lvFoodMenu.Columns.AddRange(new ColumnHeader[] { colFoodItem, colFoodPrice });
            lvFoodMenu.FullRowSelect = true;
            lvFoodMenu.GridLines = true;
            lvFoodMenu.Location = new Point(470, 60);
            lvFoodMenu.Name = "lvFoodMenu";
            lvFoodMenu.Size = new Size(220, 210);
            lvFoodMenu.TabIndex = 4;
            lvFoodMenu.UseCompatibleStateImageBehavior = false;
            lvFoodMenu.View = View.Details;
            // 
            // colFoodItem
            // 
            colFoodItem.Text = "Food Item";
            colFoodItem.Width = 100;
            // 
            // colFoodPrice
            // 
            colFoodPrice.Text = "Price";
            colFoodPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ControlLightLight;
            lblQuantity.Location = new Point(470, 285);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(103, 25);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "©️Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(470, 310);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(220, 31);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.RoyalBlue;
            btnAddToCart.FlatStyle = FlatStyle.Popup;
            btnAddToCart.Location = new Point(470, 350);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(220, 52);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.BackColor = Color.Transparent;
            lblCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCart.ForeColor = SystemColors.ControlLightLight;
            lblCart.Location = new Point(710, 60);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(74, 25);
            lblCart.TabIndex = 8;
            lblCart.Text = "\U0001f6d2Cart";
            // 
            // lstCart
            // 
            lstCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lstCart.FormattingEnabled = true;
            lstCart.ItemHeight = 25;
            lstCart.Location = new Point(710, 88);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(240, 229);
            lstCart.TabIndex = 9;
            // 
            // lblTotalPriceCaption
            // 
            lblTotalPriceCaption.AutoSize = true;
            lblTotalPriceCaption.BackColor = Color.Transparent;
            lblTotalPriceCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPriceCaption.ForeColor = SystemColors.ControlLightLight;
            lblTotalPriceCaption.Location = new Point(696, 343);
            lblTotalPriceCaption.Name = "lblTotalPriceCaption";
            lblTotalPriceCaption.Size = new Size(127, 25);
            lblTotalPriceCaption.TabIndex = 10;
            lblTotalPriceCaption.Text = "💵Total Price";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(820, 340);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(130, 31);
            txtTotalPrice.TabIndex = 11;
            txtTotalPrice.Text = "0.00";
            txtTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPlaceOrder.BackColor = Color.RoyalBlue;
            btnPlaceOrder.FlatStyle = FlatStyle.Popup;
            btnPlaceOrder.Location = new Point(710, 440);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(240, 57);
            btnPlaceOrder.TabIndex = 12;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(452, 498);
            button1.Name = "button1";
            button1.Size = new Size(251, 34);
            button1.TabIndex = 13;
            button1.Text = "EXIT PROGRAM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FoodOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 544);
            Controls.Add(button1);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtTotalPrice);
            Controls.Add(lblTotalPriceCaption);
            Controls.Add(lstCart);
            Controls.Add(lblCart);
            Controls.Add(btnAddToCart);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lvFoodMenu);
            Controls.Add(btnLoadFoodMenu);
            Controls.Add(lblFoodMenuTitle);
            Controls.Add(btnLoadRooms);
            Controls.Add(dgvRooms);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoodOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodOrder";
            Load += FoodOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomNo;
        private DataGridViewTextBoxColumn colCustomerName;
        private Button btnLoadRooms;
        private Label lblFoodMenuTitle;
        private Button btnLoadFoodMenu;
        private ListView lvFoodMenu;
        private ColumnHeader colFoodItem;
        private ColumnHeader colFoodPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnAddToCart;
        private Label lblCart;
        private ListBox lstCart;
        private Label lblTotalPriceCaption;
        private TextBox txtTotalPrice;
        private Button btnPlaceOrder;
        private Button button1;
    }
}