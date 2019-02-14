namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            this.pcbNewCustomer = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.btnNewCustomerAdd = new System.Windows.Forms.Button();
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblNewAdress = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.gbEnterDetails = new System.Windows.Forms.GroupBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNewCustomer)).BeginInit();
            this.mnsGoBack.SuspendLayout();
            this.gbEnterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbNewCustomer
            // 
            this.pcbNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbNewCustomer.BackgroundImage")));
            this.pcbNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbNewCustomer.Location = new System.Drawing.Point(123, 12);
            this.pcbNewCustomer.Name = "pcbNewCustomer";
            this.pcbNewCustomer.Size = new System.Drawing.Size(136, 112);
            this.pcbNewCustomer.TabIndex = 0;
            this.pcbNewCustomer.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(33, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(201, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Please enter your first name";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstAndSecondName_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(69, 108);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.tbFirstAndLastName_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(39, 355);
            this.txtPhoneNumber.MaxLength = 13;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(21, 324);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(232, 16);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Please enter your phone number";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(21, 262);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(217, 16);
            this.lblDob.TabIndex = 7;
            this.lblDob.Text = "Please enter your date or birth";
            // 
            // btnNewCustomerAdd
            // 
            this.btnNewCustomerAdd.BackColor = System.Drawing.Color.White;
            this.btnNewCustomerAdd.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomerAdd.Location = new System.Drawing.Point(64, 457);
            this.btnNewCustomerAdd.Name = "btnNewCustomerAdd";
            this.btnNewCustomerAdd.Size = new System.Drawing.Size(163, 33);
            this.btnNewCustomerAdd.TabIndex = 9;
            this.btnNewCustomerAdd.Text = "Add";
            this.btnNewCustomerAdd.UseVisualStyleBackColor = false;
            this.btnNewCustomerAdd.Click += new System.EventHandler(this.btnNewCustomerAdd_Click);
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(420, 24);
            this.mnsGoBack.TabIndex = 10;
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
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(93, 679);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 4;
            this.dtpDateOfBirth.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(24, 219);
            this.txtAddress.MaxLength = 10;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Street";
            // 
            // lblNewAdress
            // 
            this.lblNewAdress.AutoSize = true;
            this.lblNewAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAdress.Location = new System.Drawing.Point(36, 190);
            this.lblNewAdress.Name = "lblNewAdress";
            this.lblNewAdress.Size = new System.Drawing.Size(191, 16);
            this.lblNewAdress.TabIndex = 26;
            this.lblNewAdress.Text = "Please enter your address";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(69, 162);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(33, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(201, 16);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Please enter your last name";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(39, 419);
            this.txtEmailAddress.MaxLength = 13;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.txtEmailAddress.TabIndex = 6;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(21, 388);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(233, 16);
            this.lblEmailAddress.TabIndex = 33;
            this.lblEmailAddress.Text = "Please enter your email address";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(85, 25);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(96, 16);
            this.lblCustomerID.TabIndex = 35;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(69, 50);
            this.txtCustomerID.MaxLength = 15;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(131, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // gbEnterDetails
            // 
            this.gbEnterDetails.Controls.Add(this.txtDateOfBirth);
            this.gbEnterDetails.Controls.Add(this.btnNewCustomerAdd);
            this.gbEnterDetails.Controls.Add(this.txtCustomerID);
            this.gbEnterDetails.Controls.Add(this.lblFirstName);
            this.gbEnterDetails.Controls.Add(this.lblCustomerID);
            this.gbEnterDetails.Controls.Add(this.txtFirstName);
            this.gbEnterDetails.Controls.Add(this.txtEmailAddress);
            this.gbEnterDetails.Controls.Add(this.lblPhoneNumber);
            this.gbEnterDetails.Controls.Add(this.lblEmailAddress);
            this.gbEnterDetails.Controls.Add(this.txtPhoneNumber);
            this.gbEnterDetails.Controls.Add(this.txtLastName);
            this.gbEnterDetails.Controls.Add(this.lblDob);
            this.gbEnterDetails.Controls.Add(this.lblLastName);
            this.gbEnterDetails.Controls.Add(this.txtAddress);
            this.gbEnterDetails.Controls.Add(this.lblNewAdress);
            this.gbEnterDetails.Location = new System.Drawing.Point(54, 149);
            this.gbEnterDetails.Name = "gbEnterDetails";
            this.gbEnterDetails.Size = new System.Drawing.Size(303, 510);
            this.gbEnterDetails.TabIndex = 37;
            this.gbEnterDetails.TabStop = false;
            this.gbEnterDetails.Text = "Enter Customer Details";
            this.gbEnterDetails.Enter += new System.EventHandler(this.gbEnterDetails_Enter);
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(36, 281);
            this.txtDateOfBirth.MaxLength = 13;
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.txtDateOfBirth.TabIndex = 36;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 731);
            this.Controls.Add(this.gbEnterDetails);
            this.Controls.Add(this.pcbNewCustomer);
            this.Controls.Add(this.mnsGoBack);
            this.Controls.Add(this.dtpDateOfBirth);
            this.MainMenuStrip = this.mnsGoBack;
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbNewCustomer)).EndInit();
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            this.gbEnterDetails.ResumeLayout(false);
            this.gbEnterDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbNewCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Button btnNewCustomerAdd;
        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblNewAdress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.GroupBox gbEnterDetails;
        private System.Windows.Forms.TextBox txtDateOfBirth;
    }
}