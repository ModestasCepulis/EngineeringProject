namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmChangeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeOrder));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblBasket = new System.Windows.Forms.Label();
            this.dagvItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.tbEircode = new System.Windows.Forms.TextBox();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblOrderDeliveryDate2 = new System.Windows.Forms.Label();
            this.btnChangeOrderAdd = new System.Windows.Forms.Button();
            this.lblOrderDeliveryDate1 = new System.Windows.Forms.Label();
            this.lblOrderAddress = new System.Windows.Forms.Label();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblChoseOrder = new System.Windows.Forms.Label();
            this.cmbChooseCustomer = new System.Windows.Forms.ComboBox();
            this.pcbChangeOrder = new System.Windows.Forms.PictureBox();
            this.cmbChooseToChange = new System.Windows.Forms.ComboBox();
            this.lblChooceToChange = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChangeOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(1015, 24);
            this.mnsGoBack.TabIndex = 18;
            this.mnsGoBack.Text = "menuStrip1";
            // 
            // tlmnuGoBack
            // 
            this.tlmnuGoBack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuBack});
            this.tlmnuGoBack.Name = "tlmnuGoBack";
            this.tlmnuGoBack.Size = new System.Drawing.Size(62, 20);
            this.tlmnuGoBack.Text = "Go back";
            // 
            // tlmnuBack
            // 
            this.tlmnuBack.Name = "tlmnuBack";
            this.tlmnuBack.Size = new System.Drawing.Size(99, 22);
            this.tlmnuBack.Text = "Back";
            this.tlmnuBack.Click += new System.EventHandler(this.tlmnuBack_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.Location = new System.Drawing.Point(691, 392);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(163, 30);
            this.btnCheckOut.TabIndex = 54;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(691, 355);
            this.tbTotalPrice.MaxLength = 20;
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.tbTotalPrice.TabIndex = 53;
            this.tbTotalPrice.Text = "1656.50";
            this.tbTotalPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(688, 336);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 16);
            this.lblTotalPrice.TabIndex = 52;
            this.lblTotalPrice.Text = "Total price";
            this.lblTotalPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasket.Location = new System.Drawing.Point(771, 111);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(56, 16);
            this.lblBasket.TabIndex = 51;
            this.lblBasket.Text = "Basket";
            this.lblBasket.Click += new System.EventHandler(this.label2_Click);
            // 
            // dagvItems
            // 
            this.dagvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dagvItems.Location = new System.Drawing.Point(691, 168);
            this.dagvItems.Name = "dagvItems";
            this.dagvItems.Size = new System.Drawing.Size(240, 150);
            this.dagvItems.TabIndex = 50;
            this.dagvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Items";
            this.Column1.Name = "Column1";
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.AutoSize = true;
            this.lblItemsOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsOrdered.Location = new System.Drawing.Point(688, 138);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(106, 16);
            this.lblItemsOrdered.TabIndex = 49;
            this.lblItemsOrdered.Text = "Items Ordered";
            this.lblItemsOrdered.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(69, 379);
            this.dtpOrderDate.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 48;
            this.dtpOrderDate.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // tbEircode
            // 
            this.tbEircode.Location = new System.Drawing.Point(454, 382);
            this.tbEircode.MaxLength = 10;
            this.tbEircode.Name = "tbEircode";
            this.tbEircode.Size = new System.Drawing.Size(113, 20);
            this.tbEircode.TabIndex = 47;
            this.tbEircode.Text = "Eircode";
            this.tbEircode.TextChanged += new System.EventHandler(this.tbEircode_TextChanged);
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(328, 382);
            this.tbCounty.MaxLength = 10;
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(113, 20);
            this.tbCounty.TabIndex = 46;
            this.tbCounty.Tag = "";
            this.tbCounty.Text = "County";
            this.tbCounty.TextChanged += new System.EventHandler(this.tbCounty_TextChanged);
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(454, 356);
            this.tbTown.MaxLength = 10;
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(113, 20);
            this.tbTown.TabIndex = 45;
            this.tbTown.Text = "Town";
            this.tbTown.TextChanged += new System.EventHandler(this.tbTown_TextChanged);
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(328, 356);
            this.tbStreet.MaxLength = 10;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(113, 20);
            this.tbStreet.TabIndex = 44;
            this.tbStreet.Text = "Street";
            this.tbStreet.TextChanged += new System.EventHandler(this.tbStreet_TextChanged);
            // 
            // lblOrderDeliveryDate2
            // 
            this.lblOrderDeliveryDate2.AutoSize = true;
            this.lblOrderDeliveryDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDeliveryDate2.Location = new System.Drawing.Point(73, 349);
            this.lblOrderDeliveryDate2.Name = "lblOrderDeliveryDate2";
            this.lblOrderDeliveryDate2.Size = new System.Drawing.Size(179, 16);
            this.lblOrderDeliveryDate2.TabIndex = 43;
            this.lblOrderDeliveryDate2.Text = "the order to be delivered";
            // 
            // btnChangeOrderAdd
            // 
            this.btnChangeOrderAdd.BackColor = System.Drawing.Color.White;
            this.btnChangeOrderAdd.ForeColor = System.Drawing.Color.Black;
            this.btnChangeOrderAdd.Location = new System.Drawing.Point(221, 425);
            this.btnChangeOrderAdd.Name = "btnChangeOrderAdd";
            this.btnChangeOrderAdd.Size = new System.Drawing.Size(163, 30);
            this.btnChangeOrderAdd.TabIndex = 42;
            this.btnChangeOrderAdd.Text = "Add";
            this.btnChangeOrderAdd.UseVisualStyleBackColor = false;
            this.btnChangeOrderAdd.Click += new System.EventHandler(this.btnNewOrderAdd_Click);
            // 
            // lblOrderDeliveryDate1
            // 
            this.lblOrderDeliveryDate1.AutoSize = true;
            this.lblOrderDeliveryDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDeliveryDate1.Location = new System.Drawing.Point(44, 333);
            this.lblOrderDeliveryDate1.Name = "lblOrderDeliveryDate1";
            this.lblOrderDeliveryDate1.Size = new System.Drawing.Size(259, 16);
            this.lblOrderDeliveryDate1.TabIndex = 41;
            this.lblOrderDeliveryDate1.Text = "Please enter the date when you want";
            // 
            // lblOrderAddress
            // 
            this.lblOrderAddress.AutoSize = true;
            this.lblOrderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAddress.Location = new System.Drawing.Point(325, 329);
            this.lblOrderAddress.Name = "lblOrderAddress";
            this.lblOrderAddress.Size = new System.Drawing.Size(273, 16);
            this.lblOrderAddress.TabIndex = 40;
            this.lblOrderAddress.Text = "Please enter the new delivery address";
            this.lblOrderAddress.Click += new System.EventHandler(this.lblOrderAddress_Click);
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(80, 285);
            this.tbOrderType.MaxLength = 20;
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(200, 20);
            this.tbOrderType.TabIndex = 39;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(71, 258);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(236, 16);
            this.lblOrderType.TabIndex = 38;
            this.lblOrderType.Text = "Please enter your new order type";
            // 
            // lblChoseOrder
            // 
            this.lblChoseOrder.AutoSize = true;
            this.lblChoseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseOrder.Location = new System.Drawing.Point(83, 165);
            this.lblChoseOrder.Name = "lblChoseOrder";
            this.lblChoseOrder.Size = new System.Drawing.Size(178, 32);
            this.lblChoseOrder.TabIndex = 55;
            this.lblChoseOrder.Text = "Please choose an order \r\nthat you want to change";
            this.lblChoseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoseOrder.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbChooseCustomer
            // 
            this.cmbChooseCustomer.FormattingEnabled = true;
            this.cmbChooseCustomer.Items.AddRange(new object[] {
            "Order #321",
            "Order #241",
            "Order #195",
            "Order #15"});
            this.cmbChooseCustomer.Location = new System.Drawing.Point(67, 208);
            this.cmbChooseCustomer.Name = "cmbChooseCustomer";
            this.cmbChooseCustomer.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseCustomer.TabIndex = 56;
            this.cmbChooseCustomer.Text = "Order #321";
            // 
            // pcbChangeOrder
            // 
            this.pcbChangeOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbChangeOrder.BackgroundImage")));
            this.pcbChangeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbChangeOrder.Location = new System.Drawing.Point(260, 53);
            this.pcbChangeOrder.Name = "pcbChangeOrder";
            this.pcbChangeOrder.Size = new System.Drawing.Size(124, 101);
            this.pcbChangeOrder.TabIndex = 57;
            this.pcbChangeOrder.TabStop = false;
            // 
            // cmbChooseToChange
            // 
            this.cmbChooseToChange.FormattingEnabled = true;
            this.cmbChooseToChange.Items.AddRange(new object[] {
            "Address",
            "Order Type",
            "Order Items"});
            this.cmbChooseToChange.Location = new System.Drawing.Point(341, 200);
            this.cmbChooseToChange.Name = "cmbChooseToChange";
            this.cmbChooseToChange.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseToChange.TabIndex = 59;
            this.cmbChooseToChange.Text = "Address";
            this.cmbChooseToChange.SelectedIndexChanged += new System.EventHandler(this.cmbChooseToChange_SelectedIndexChanged);
            // 
            // lblChooceToChange
            // 
            this.lblChooceToChange.AutoSize = true;
            this.lblChooceToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooceToChange.Location = new System.Drawing.Point(319, 168);
            this.lblChooceToChange.Name = "lblChooceToChange";
            this.lblChooceToChange.Size = new System.Drawing.Size(283, 16);
            this.lblChooceToChange.TabIndex = 58;
            this.lblChooceToChange.Text = "Please choose what you want to change";
            this.lblChooceToChange.Click += new System.EventHandler(this.lblChooceToChange_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(375, 258);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(175, 16);
            this.lblAmount.TabIndex = 60;
            this.lblAmount.Text = "Please enter the amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(401, 285);
            this.tbAmount.MaxLength = 20;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(101, 20);
            this.tbAmount.TabIndex = 61;
            // 
            // frmChangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 522);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbChooseToChange);
            this.Controls.Add(this.lblChooceToChange);
            this.Controls.Add(this.pcbChangeOrder);
            this.Controls.Add(this.cmbChooseCustomer);
            this.Controls.Add(this.lblChoseOrder);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.dagvItems);
            this.Controls.Add(this.lblItemsOrdered);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.tbEircode);
            this.Controls.Add(this.tbCounty);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.lblOrderDeliveryDate2);
            this.Controls.Add(this.btnChangeOrderAdd);
            this.Controls.Add(this.lblOrderDeliveryDate1);
            this.Controls.Add(this.lblOrderAddress);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmChangeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Order";
            this.Load += new System.EventHandler(this.frmChangeOrder_Load);
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChangeOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.DataGridView dagvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox tbEircode;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblOrderDeliveryDate2;
        private System.Windows.Forms.Button btnChangeOrderAdd;
        private System.Windows.Forms.Label lblOrderDeliveryDate1;
        private System.Windows.Forms.Label lblOrderAddress;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblChoseOrder;
        private System.Windows.Forms.ComboBox cmbChooseCustomer;
        private System.Windows.Forms.PictureBox pcbChangeOrder;
        private System.Windows.Forms.ComboBox cmbChooseToChange;
        private System.Windows.Forms.Label lblChooceToChange;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbAmount;
    }
}