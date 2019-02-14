namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmChangeCustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeCustomerDetails));
            this.pcbChangeCustomer = new System.Windows.Forms.PictureBox();
            this.cmbChooseCustomer = new System.Windows.Forms.ComboBox();
            this.lblChooseCustomer = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblNewAdress = new System.Windows.Forms.Label();
            this.tbNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNewPhoneNumber = new System.Windows.Forms.Label();
            this.lblChooceToChange = new System.Windows.Forms.Label();
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbChooseToChange = new System.Windows.Forms.ComboBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.tbEircode = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChangeCustomer)).BeginInit();
            this.mnsGoBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbChangeCustomer
            // 
            this.pcbChangeCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbChangeCustomer.BackgroundImage")));
            this.pcbChangeCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbChangeCustomer.Location = new System.Drawing.Point(214, 27);
            this.pcbChangeCustomer.Name = "pcbChangeCustomer";
            this.pcbChangeCustomer.Size = new System.Drawing.Size(136, 112);
            this.pcbChangeCustomer.TabIndex = 2;
            this.pcbChangeCustomer.TabStop = false;
            this.pcbChangeCustomer.Click += new System.EventHandler(this.pcbChangeCustomer_Click);
            // 
            // cmbChooseCustomer
            // 
            this.cmbChooseCustomer.FormattingEnabled = true;
            this.cmbChooseCustomer.Items.AddRange(new object[] {
            "Customer 1",
            "Customer 2 ",
            "Customer 3",
            "Customer 4",
            "Customer 5"});
            this.cmbChooseCustomer.Location = new System.Drawing.Point(34, 178);
            this.cmbChooseCustomer.Name = "cmbChooseCustomer";
            this.cmbChooseCustomer.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseCustomer.TabIndex = 3;
            this.cmbChooseCustomer.Text = "Customer 1";
            this.cmbChooseCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChooseCustomer
            // 
            this.lblChooseCustomer.AutoSize = true;
            this.lblChooseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCustomer.Location = new System.Drawing.Point(43, 150);
            this.lblChooseCustomer.Name = "lblChooseCustomer";
            this.lblChooseCustomer.Size = new System.Drawing.Size(204, 16);
            this.lblChooseCustomer.TabIndex = 4;
            this.lblChooseCustomer.Text = "Please choose your account";
            this.lblChooseCustomer.Click += new System.EventHandler(this.lblFirstAndSecondName_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(354, 303);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(163, 30);
            this.btnUpdateCustomer.TabIndex = 16;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblNewAdress
            // 
            this.lblNewAdress.AutoSize = true;
            this.lblNewAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAdress.Location = new System.Drawing.Point(43, 216);
            this.lblNewAdress.Name = "lblNewAdress";
            this.lblNewAdress.Size = new System.Drawing.Size(170, 16);
            this.lblNewAdress.TabIndex = 14;
            this.lblNewAdress.Text = "Enter your new address";
            this.lblNewAdress.Click += new System.EventHandler(this.lblNewAdress_Click);
            // 
            // tbNewPhoneNumber
            // 
            this.tbNewPhoneNumber.Location = new System.Drawing.Point(474, 264);
            this.tbNewPhoneNumber.MaxLength = 13;
            this.tbNewPhoneNumber.Name = "tbNewPhoneNumber";
            this.tbNewPhoneNumber.Size = new System.Drawing.Size(140, 20);
            this.tbNewPhoneNumber.TabIndex = 13;
            // 
            // lblNewPhoneNumber
            // 
            this.lblNewPhoneNumber.AutoSize = true;
            this.lblNewPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPhoneNumber.Location = new System.Drawing.Point(303, 265);
            this.lblNewPhoneNumber.Name = "lblNewPhoneNumber";
            this.lblNewPhoneNumber.Size = new System.Drawing.Size(156, 16);
            this.lblNewPhoneNumber.TabIndex = 12;
            this.lblNewPhoneNumber.Text = "Enter your new phone";
            // 
            // lblChooceToChange
            // 
            this.lblChooceToChange.AutoSize = true;
            this.lblChooceToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooceToChange.Location = new System.Drawing.Point(303, 150);
            this.lblChooceToChange.Name = "lblChooceToChange";
            this.lblChooceToChange.Size = new System.Drawing.Size(283, 16);
            this.lblChooceToChange.TabIndex = 10;
            this.lblChooceToChange.Text = "Please choose what you want to change";
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(626, 24);
            this.mnsGoBack.TabIndex = 17;
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
            // cmbChooseToChange
            // 
            this.cmbChooseToChange.FormattingEnabled = true;
            this.cmbChooseToChange.Items.AddRange(new object[] {
            "Address",
            "Name",
            "Phone Number"});
            this.cmbChooseToChange.Location = new System.Drawing.Point(325, 182);
            this.cmbChooseToChange.Name = "cmbChooseToChange";
            this.cmbChooseToChange.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseToChange.TabIndex = 19;
            this.cmbChooseToChange.Text = "Address";
            this.cmbChooseToChange.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(34, 235);
            this.tbStreet.MaxLength = 10;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(113, 20);
            this.tbStreet.TabIndex = 20;
            this.tbStreet.Text = "Street";
            this.tbStreet.TextChanged += new System.EventHandler(this.tbNewInformation_TextChanged);
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.Location = new System.Drawing.Point(303, 216);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(120, 16);
            this.lblNewName.TabIndex = 21;
            this.lblNewName.Text = "Enter your name";
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(160, 235);
            this.tbTown.MaxLength = 10;
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(113, 20);
            this.tbTown.TabIndex = 23;
            this.tbTown.Text = "Town";
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(34, 261);
            this.tbCounty.MaxLength = 10;
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(113, 20);
            this.tbCounty.TabIndex = 24;
            this.tbCounty.Tag = "";
            this.tbCounty.Text = "County";
            // 
            // tbEircode
            // 
            this.tbEircode.Location = new System.Drawing.Point(160, 261);
            this.tbEircode.MaxLength = 10;
            this.tbEircode.Name = "tbEircode";
            this.tbEircode.Size = new System.Drawing.Size(113, 20);
            this.tbEircode.TabIndex = 25;
            this.tbEircode.Text = "Eircode";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(306, 235);
            this.tbFirstName.MaxLength = 10;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(71, 20);
            this.tbFirstName.TabIndex = 27;
            this.tbFirstName.Text = "First";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(383, 235);
            this.tbSecondName.MaxLength = 10;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(71, 20);
            this.tbSecondName.TabIndex = 28;
            this.tbSecondName.Text = "Last";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(60, 309);
            this.tbEmailAddress.MaxLength = 13;
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.tbEmailAddress.TabIndex = 36;
            this.tbEmailAddress.TextChanged += new System.EventHandler(this.tbEmailAddress_TextChanged);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(42, 290);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(233, 16);
            this.lblEmailAddress.TabIndex = 35;
            this.lblEmailAddress.Text = "Please enter your email address";
            // 
            // frmChangeCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 456);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbEircode);
            this.Controls.Add(this.tbCounty);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.cmbChooseToChange);
            this.Controls.Add(this.mnsGoBack);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.lblNewAdress);
            this.Controls.Add(this.tbNewPhoneNumber);
            this.Controls.Add(this.lblNewPhoneNumber);
            this.Controls.Add(this.lblChooceToChange);
            this.Controls.Add(this.lblChooseCustomer);
            this.Controls.Add(this.cmbChooseCustomer);
            this.Controls.Add(this.pcbChangeCustomer);
            this.Name = "frmChangeCustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Customer Details";
            this.Load += new System.EventHandler(this.frmChangeCustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbChangeCustomer)).EndInit();
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbChangeCustomer;
        private System.Windows.Forms.ComboBox cmbChooseCustomer;
        private System.Windows.Forms.Label lblChooseCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblNewAdress;
        private System.Windows.Forms.TextBox tbNewPhoneNumber;
        private System.Windows.Forms.Label lblNewPhoneNumber;
        private System.Windows.Forms.Label lblChooceToChange;
        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.ComboBox cmbChooseToChange;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.TextBox tbEircode;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
    }
}