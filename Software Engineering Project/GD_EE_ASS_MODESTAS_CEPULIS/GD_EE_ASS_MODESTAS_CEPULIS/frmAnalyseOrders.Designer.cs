namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmAnalyseOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseOrders));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbChooseOrder = new System.Windows.Forms.ComboBox();
            this.lblChooceOrder = new System.Windows.Forms.Label();
            this.pcbAnalyseOrders = new System.Windows.Forms.PictureBox();
            this.lblOrderDeliveryDate = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderAddress = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmountOfItems = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.cmbAmountOfITems = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryHouse = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryStreet = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryTown = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryCounty = new System.Windows.Forms.ComboBox();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.dgwItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.cmbTown = new System.Windows.Forms.ComboBox();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.cmbHouse = new System.Windows.Forms.ComboBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.cmbLastName = new System.Windows.Forms.ComboBox();
            this.cmbFirstName = new System.Windows.Forms.ComboBox();
            this.cmbPhoneNumber = new System.Windows.Forms.ComboBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnAnalyseOrders = new System.Windows.Forms.Button();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnalyseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).BeginInit();
            this.gbOrderDetails.SuspendLayout();
            this.gbCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(995, 24);
            this.mnsGoBack.TabIndex = 11;
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
            this.tlmnuBack.Click += new System.EventHandler(this.tlmnuBack_Click_1);
            // 
            // cmbChooseOrder
            // 
            this.cmbChooseOrder.FormattingEnabled = true;
            this.cmbChooseOrder.Items.AddRange(new object[] {
            "Order #321",
            "Order #241",
            "Order #195",
            "Order #15"});
            this.cmbChooseOrder.Location = new System.Drawing.Point(259, 181);
            this.cmbChooseOrder.Name = "cmbChooseOrder";
            this.cmbChooseOrder.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseOrder.TabIndex = 65;
            this.cmbChooseOrder.Text = "Order #321";
            // 
            // lblChooceOrder
            // 
            this.lblChooceOrder.AutoSize = true;
            this.lblChooceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooceOrder.Location = new System.Drawing.Point(211, 153);
            this.lblChooceOrder.Name = "lblChooceOrder";
            this.lblChooceOrder.Size = new System.Drawing.Size(343, 16);
            this.lblChooceOrder.TabIndex = 64;
            this.lblChooceOrder.Text = "Please choose an order that you want to analyse";
            // 
            // pcbAnalyseOrders
            // 
            this.pcbAnalyseOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbAnalyseOrders.BackgroundImage")));
            this.pcbAnalyseOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbAnalyseOrders.Location = new System.Drawing.Point(317, 27);
            this.pcbAnalyseOrders.Name = "pcbAnalyseOrders";
            this.pcbAnalyseOrders.Size = new System.Drawing.Size(136, 112);
            this.pcbAnalyseOrders.TabIndex = 66;
            this.pcbAnalyseOrders.TabStop = false;
            // 
            // lblOrderDeliveryDate
            // 
            this.lblOrderDeliveryDate.AutoSize = true;
            this.lblOrderDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDeliveryDate.Location = new System.Drawing.Point(7, 123);
            this.lblOrderDeliveryDate.Name = "lblOrderDeliveryDate";
            this.lblOrderDeliveryDate.Size = new System.Drawing.Size(195, 32);
            this.lblOrderDeliveryDate.TabIndex = 71;
            this.lblOrderDeliveryDate.Text = "The date the order is going\r\n to be delivered";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(12, 80);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(156, 16);
            this.lblSecondName.TabIndex = 90;
            this.lblSecondName.Text = "Customer\'s last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(156, 16);
            this.lblFirstName.TabIndex = 88;
            this.lblFirstName.Text = "Customer\'s first name";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(12, 37);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(110, 16);
            this.lblOrderType.TabIndex = 67;
            this.lblOrderType.Text = "The order type";
            // 
            // lblOrderAddress
            // 
            this.lblOrderAddress.AutoSize = true;
            this.lblOrderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAddress.Location = new System.Drawing.Point(262, 123);
            this.lblOrderAddress.Name = "lblOrderAddress";
            this.lblOrderAddress.Size = new System.Drawing.Size(156, 16);
            this.lblOrderAddress.TabIndex = 69;
            this.lblOrderAddress.Text = "The delivery address";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(10, 158);
            this.dtpOrderDate.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 76;
            this.dtpOrderDate.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // lblAmountOfItems
            // 
            this.lblAmountOfItems.AutoSize = true;
            this.lblAmountOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfItems.Location = new System.Drawing.Point(259, 37);
            this.lblAmountOfItems.Name = "lblAmountOfItems";
            this.lblAmountOfItems.Size = new System.Drawing.Size(147, 16);
            this.lblAmountOfItems.TabIndex = 77;
            this.lblAmountOfItems.Text = "The amount of items";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Jeans",
            "Shirts"});
            this.cmbOrderType.Location = new System.Drawing.Point(18, 66);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(144, 21);
            this.cmbOrderType.TabIndex = 78;
            this.cmbOrderType.Text = "Jeans";
            // 
            // cmbAmountOfITems
            // 
            this.cmbAmountOfITems.FormattingEnabled = true;
            this.cmbAmountOfITems.Items.AddRange(new object[] {
            "1462"});
            this.cmbAmountOfITems.Location = new System.Drawing.Point(265, 66);
            this.cmbAmountOfITems.Name = "cmbAmountOfITems";
            this.cmbAmountOfITems.Size = new System.Drawing.Size(144, 21);
            this.cmbAmountOfITems.TabIndex = 79;
            this.cmbAmountOfITems.Text = "1462";
            // 
            // cmbDeliveryHouse
            // 
            this.cmbDeliveryHouse.FormattingEnabled = true;
            this.cmbDeliveryHouse.Items.AddRange(new object[] {
            "Cahillane House"});
            this.cmbDeliveryHouse.Location = new System.Drawing.Point(265, 157);
            this.cmbDeliveryHouse.Name = "cmbDeliveryHouse";
            this.cmbDeliveryHouse.Size = new System.Drawing.Size(102, 21);
            this.cmbDeliveryHouse.TabIndex = 80;
            this.cmbDeliveryHouse.Text = "Cahillane House";
            // 
            // cmbDeliveryStreet
            // 
            this.cmbDeliveryStreet.FormattingEnabled = true;
            this.cmbDeliveryStreet.Items.AddRange(new object[] {
            "Mill road"});
            this.cmbDeliveryStreet.Location = new System.Drawing.Point(383, 157);
            this.cmbDeliveryStreet.Name = "cmbDeliveryStreet";
            this.cmbDeliveryStreet.Size = new System.Drawing.Size(116, 21);
            this.cmbDeliveryStreet.TabIndex = 81;
            this.cmbDeliveryStreet.Text = "Mill road";
            // 
            // cmbDeliveryTown
            // 
            this.cmbDeliveryTown.FormattingEnabled = true;
            this.cmbDeliveryTown.Items.AddRange(new object[] {
            "Killorglin"});
            this.cmbDeliveryTown.Location = new System.Drawing.Point(265, 184);
            this.cmbDeliveryTown.Name = "cmbDeliveryTown";
            this.cmbDeliveryTown.Size = new System.Drawing.Size(102, 21);
            this.cmbDeliveryTown.TabIndex = 82;
            this.cmbDeliveryTown.Text = "Killorglin";
            // 
            // cmbDeliveryCounty
            // 
            this.cmbDeliveryCounty.FormattingEnabled = true;
            this.cmbDeliveryCounty.Items.AddRange(new object[] {
            "Co. Kerry"});
            this.cmbDeliveryCounty.Location = new System.Drawing.Point(383, 184);
            this.cmbDeliveryCounty.Name = "cmbDeliveryCounty";
            this.cmbDeliveryCounty.Size = new System.Drawing.Size(116, 21);
            this.cmbDeliveryCounty.TabIndex = 83;
            this.cmbDeliveryCounty.Text = "Co. Kerry";
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.AutoSize = true;
            this.lblItemsOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsOrdered.Location = new System.Drawing.Point(543, 36);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(106, 16);
            this.lblItemsOrdered.TabIndex = 84;
            this.lblItemsOrdered.Text = "Items Ordered";
            // 
            // dgwItems
            // 
            this.dgwItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgwItems.Location = new System.Drawing.Point(546, 66);
            this.dgwItems.Name = "dgwItems";
            this.dgwItems.Size = new System.Drawing.Size(240, 150);
            this.dgwItems.TabIndex = 85;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Items";
            this.Column1.Name = "Column1";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(426, 37);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 16);
            this.lblTotalPrice.TabIndex = 86;
            this.lblTotalPrice.Text = "Total price";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(429, 66);
            this.tbTotalPrice.MaxLength = 20;
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.tbTotalPrice.TabIndex = 87;
            this.tbTotalPrice.Text = "1561.15";
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.Controls.Add(this.cmbOrderID);
            this.gbOrderDetails.Controls.Add(this.lblOrderID);
            this.gbOrderDetails.Controls.Add(this.tbTotalPrice);
            this.gbOrderDetails.Controls.Add(this.lblTotalPrice);
            this.gbOrderDetails.Controls.Add(this.dgwItems);
            this.gbOrderDetails.Controls.Add(this.lblItemsOrdered);
            this.gbOrderDetails.Controls.Add(this.cmbDeliveryCounty);
            this.gbOrderDetails.Controls.Add(this.cmbDeliveryTown);
            this.gbOrderDetails.Controls.Add(this.cmbDeliveryStreet);
            this.gbOrderDetails.Controls.Add(this.cmbDeliveryHouse);
            this.gbOrderDetails.Controls.Add(this.cmbAmountOfITems);
            this.gbOrderDetails.Controls.Add(this.cmbOrderType);
            this.gbOrderDetails.Controls.Add(this.lblAmountOfItems);
            this.gbOrderDetails.Controls.Add(this.dtpOrderDate);
            this.gbOrderDetails.Controls.Add(this.lblOrderDeliveryDate);
            this.gbOrderDetails.Controls.Add(this.lblOrderAddress);
            this.gbOrderDetails.Controls.Add(this.lblOrderType);
            this.gbOrderDetails.Location = new System.Drawing.Point(30, 513);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(879, 274);
            this.gbOrderDetails.TabIndex = 92;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "Order Details";
            this.gbOrderDetails.Visible = false;
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Items.AddRange(new object[] {
            "#351"});
            this.cmbOrderID.Location = new System.Drawing.Point(179, 66);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(74, 21);
            this.cmbOrderID.TabIndex = 89;
            this.cmbOrderID.Text = "#351";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(176, 37);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(66, 16);
            this.lblOrderID.TabIndex = 88;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(185, 29);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(187, 16);
            this.lblCustomerPhone.TabIndex = 93;
            this.lblCustomerPhone.Text = "Customer\'s phone number";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(185, 80);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerID.TabIndex = 95;
            this.lblCustomerID.Text = "Customer\'s ID";
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Items.AddRange(new object[] {
            "Co. Kerry"});
            this.cmbCounty.Location = new System.Drawing.Point(515, 89);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(116, 21);
            this.cmbCounty.TabIndex = 92;
            this.cmbCounty.Text = "Co. Kerry";
            // 
            // cmbTown
            // 
            this.cmbTown.FormattingEnabled = true;
            this.cmbTown.Items.AddRange(new object[] {
            "Killorglin"});
            this.cmbTown.Location = new System.Drawing.Point(397, 89);
            this.cmbTown.Name = "cmbTown";
            this.cmbTown.Size = new System.Drawing.Size(102, 21);
            this.cmbTown.TabIndex = 91;
            this.cmbTown.Text = "Killorglin";
            // 
            // cmbStreet
            // 
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Items.AddRange(new object[] {
            "Mill road"});
            this.cmbStreet.Location = new System.Drawing.Point(515, 62);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(116, 21);
            this.cmbStreet.TabIndex = 90;
            this.cmbStreet.Text = "Mill road";
            // 
            // cmbHouse
            // 
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.Items.AddRange(new object[] {
            "Cahillane House"});
            this.cmbHouse.Location = new System.Drawing.Point(397, 62);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(102, 21);
            this.cmbHouse.TabIndex = 89;
            this.cmbHouse.Text = "Cahillane House";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(393, 31);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(146, 16);
            this.lblCustomerAddress.TabIndex = 88;
            this.lblCustomerAddress.Text = "Customer\'s address";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Items.AddRange(new object[] {
            "#25"});
            this.cmbCustomerID.Location = new System.Drawing.Point(187, 110);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(102, 21);
            this.cmbCustomerID.TabIndex = 96;
            this.cmbCustomerID.Text = "#25";
            // 
            // cmbLastName
            // 
            this.cmbLastName.FormattingEnabled = true;
            this.cmbLastName.Items.AddRange(new object[] {
            "Cepulis"});
            this.cmbLastName.Location = new System.Drawing.Point(15, 110);
            this.cmbLastName.Name = "cmbLastName";
            this.cmbLastName.Size = new System.Drawing.Size(153, 21);
            this.cmbLastName.TabIndex = 97;
            this.cmbLastName.Text = "Cepulis";
            // 
            // cmbFirstName
            // 
            this.cmbFirstName.FormattingEnabled = true;
            this.cmbFirstName.Items.AddRange(new object[] {
            "Modestas"});
            this.cmbFirstName.Location = new System.Drawing.Point(15, 52);
            this.cmbFirstName.Name = "cmbFirstName";
            this.cmbFirstName.Size = new System.Drawing.Size(153, 21);
            this.cmbFirstName.TabIndex = 98;
            this.cmbFirstName.Text = "Modestas";
            // 
            // cmbPhoneNumber
            // 
            this.cmbPhoneNumber.FormattingEnabled = true;
            this.cmbPhoneNumber.Items.AddRange(new object[] {
            "+353 83 882 2148"});
            this.cmbPhoneNumber.Location = new System.Drawing.Point(187, 52);
            this.cmbPhoneNumber.Name = "cmbPhoneNumber";
            this.cmbPhoneNumber.Size = new System.Drawing.Size(185, 21);
            this.cmbPhoneNumber.TabIndex = 99;
            this.cmbPhoneNumber.Text = "+353 83 882 2148";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(650, 31);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(171, 16);
            this.lblDateOfBirth.TabIndex = 100;
            this.lblDateOfBirth.Text = "Customer\'s date of birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(653, 59);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 101;
            this.dtpDateOfBirth.Value = new System.DateTime(1998, 6, 14, 0, 0, 0, 0);
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.dtpDateOfBirth);
            this.gbCustomerDetails.Controls.Add(this.lblDateOfBirth);
            this.gbCustomerDetails.Controls.Add(this.cmbPhoneNumber);
            this.gbCustomerDetails.Controls.Add(this.cmbFirstName);
            this.gbCustomerDetails.Controls.Add(this.cmbLastName);
            this.gbCustomerDetails.Controls.Add(this.cmbCustomerID);
            this.gbCustomerDetails.Controls.Add(this.cmbCounty);
            this.gbCustomerDetails.Controls.Add(this.cmbTown);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerID);
            this.gbCustomerDetails.Controls.Add(this.cmbStreet);
            this.gbCustomerDetails.Controls.Add(this.cmbHouse);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerAddress);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerPhone);
            this.gbCustomerDetails.Controls.Add(this.lblSecondName);
            this.gbCustomerDetails.Controls.Add(this.lblFirstName);
            this.gbCustomerDetails.Location = new System.Drawing.Point(30, 277);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(879, 197);
            this.gbCustomerDetails.TabIndex = 102;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            this.gbCustomerDetails.Visible = false;
            // 
            // btnAnalyseOrders
            // 
            this.btnAnalyseOrders.BackColor = System.Drawing.Color.White;
            this.btnAnalyseOrders.ForeColor = System.Drawing.Color.Black;
            this.btnAnalyseOrders.Location = new System.Drawing.Point(299, 218);
            this.btnAnalyseOrders.Name = "btnAnalyseOrders";
            this.btnAnalyseOrders.Size = new System.Drawing.Size(163, 30);
            this.btnAnalyseOrders.TabIndex = 103;
            this.btnAnalyseOrders.Text = "Analyse";
            this.btnAnalyseOrders.UseVisualStyleBackColor = false;
            this.btnAnalyseOrders.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // frmAnalyseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 797);
            this.Controls.Add(this.btnAnalyseOrders);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.gbOrderDetails);
            this.Controls.Add(this.pcbAnalyseOrders);
            this.Controls.Add(this.cmbChooseOrder);
            this.Controls.Add(this.lblChooceOrder);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmAnalyseOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyse Orders";
            this.Load += new System.EventHandler(this.frmAnalyseOrders_Load);
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnalyseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).EndInit();
            this.gbOrderDetails.ResumeLayout(false);
            this.gbOrderDetails.PerformLayout();
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.ComboBox cmbChooseOrder;
        private System.Windows.Forms.Label lblChooceOrder;
        private System.Windows.Forms.PictureBox pcbAnalyseOrders;
        private System.Windows.Forms.Label lblOrderDeliveryDate;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderAddress;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblAmountOfItems;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.ComboBox cmbAmountOfITems;
        private System.Windows.Forms.ComboBox cmbDeliveryHouse;
        private System.Windows.Forms.ComboBox cmbDeliveryStreet;
        private System.Windows.Forms.ComboBox cmbDeliveryTown;
        private System.Windows.Forms.ComboBox cmbDeliveryCounty;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.DataGridView dgwItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.ComboBox cmbOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ComboBox cmbTown;
        private System.Windows.Forms.ComboBox cmbStreet;
        private System.Windows.Forms.ComboBox cmbHouse;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.ComboBox cmbLastName;
        private System.Windows.Forms.ComboBox cmbFirstName;
        private System.Windows.Forms.ComboBox cmbPhoneNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Button btnAnalyseOrders;
    }
}