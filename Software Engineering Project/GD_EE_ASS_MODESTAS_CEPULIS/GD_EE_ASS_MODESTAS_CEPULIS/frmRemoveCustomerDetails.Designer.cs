namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmRemoveCustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveCustomerDetails));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.lblChooseAccount = new System.Windows.Forms.Label();
            this.cmbRemoveCustomer = new System.Windows.Forms.ComboBox();
            this.pcbRemoveCustomer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemoveCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(521, 24);
            this.mnsGoBack.TabIndex = 27;
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(148, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(205, 16);
            this.lblPassword.TabIndex = 62;
            this.lblPassword.Text = "Please enter your password:";
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(175, 289);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(163, 30);
            this.btnRemoveCustomer.TabIndex = 61;
            this.btnRemoveCustomer.Text = "Remove";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblChooseAccount
            // 
            this.lblChooseAccount.AutoSize = true;
            this.lblChooseAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAccount.Location = new System.Drawing.Point(93, 159);
            this.lblChooseAccount.Name = "lblChooseAccount";
            this.lblChooseAccount.Size = new System.Drawing.Size(150, 32);
            this.lblChooseAccount.TabIndex = 60;
            this.lblChooseAccount.Text = "Please choose your \r\naccount for removal";
            // 
            // cmbRemoveCustomer
            // 
            this.cmbRemoveCustomer.FormattingEnabled = true;
            this.cmbRemoveCustomer.Items.AddRange(new object[] {
            "Customer 1",
            "Customer 2 ",
            "Customer 3",
            "Customer 4",
            "Customer 5"});
            this.cmbRemoveCustomer.Location = new System.Drawing.Point(96, 194);
            this.cmbRemoveCustomer.Name = "cmbRemoveCustomer";
            this.cmbRemoveCustomer.Size = new System.Drawing.Size(123, 21);
            this.cmbRemoveCustomer.TabIndex = 59;
            this.cmbRemoveCustomer.Text = "Customer 1";
            // 
            // pcbRemoveCustomer
            // 
            this.pcbRemoveCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbRemoveCustomer.BackgroundImage")));
            this.pcbRemoveCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbRemoveCustomer.Location = new System.Drawing.Point(175, 33);
            this.pcbRemoveCustomer.Name = "pcbRemoveCustomer";
            this.pcbRemoveCustomer.Size = new System.Drawing.Size(136, 112);
            this.pcbRemoveCustomer.TabIndex = 58;
            this.pcbRemoveCustomer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Customer ID\r\n";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(284, 194);
            this.txtCustomerID.MaxLength = 15;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(131, 20);
            this.txtCustomerID.TabIndex = 65;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(151, 249);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 20);
            this.txtPassword.TabIndex = 66;
            // 
            // frmRemoveCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 353);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.lblChooseAccount);
            this.Controls.Add(this.cmbRemoveCustomer);
            this.Controls.Add(this.pcbRemoveCustomer);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmRemoveCustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Customer Details";
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemoveCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Label lblChooseAccount;
        private System.Windows.Forms.ComboBox cmbRemoveCustomer;
        private System.Windows.Forms.PictureBox pcbRemoveCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtPassword;
    }
}