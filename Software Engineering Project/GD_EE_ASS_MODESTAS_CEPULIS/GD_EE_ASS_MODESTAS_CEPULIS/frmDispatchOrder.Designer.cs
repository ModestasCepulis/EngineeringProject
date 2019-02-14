namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmDispatchOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDispatchOrder));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbChooseCustomer = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDispatchOrder = new System.Windows.Forms.Button();
            this.lblRemoveCustomer = new System.Windows.Forms.Label();
            this.pcbDispatchOrder = new System.Windows.Forms.PictureBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDispatchOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(444, 24);
            this.mnsGoBack.TabIndex = 19;
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
            // cmbChooseCustomer
            // 
            this.cmbChooseCustomer.FormattingEnabled = true;
            this.cmbChooseCustomer.Items.AddRange(new object[] {
            "Order #321",
            "Order #241",
            "Order #195",
            "Order #15"});
            this.cmbChooseCustomer.Location = new System.Drawing.Point(105, 184);
            this.cmbChooseCustomer.Name = "cmbChooseCustomer";
            this.cmbChooseCustomer.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseCustomer.TabIndex = 63;
            this.cmbChooseCustomer.Text = "Order #321";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 235);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(200, 20);
            this.tbPassword.TabIndex = 62;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(102, 216);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(242, 16);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Please enter the admin password:";
            // 
            // btnDispatchOrder
            // 
            this.btnDispatchOrder.BackColor = System.Drawing.Color.White;
            this.btnDispatchOrder.ForeColor = System.Drawing.Color.Black;
            this.btnDispatchOrder.Location = new System.Drawing.Point(140, 270);
            this.btnDispatchOrder.Name = "btnDispatchOrder";
            this.btnDispatchOrder.Size = new System.Drawing.Size(163, 30);
            this.btnDispatchOrder.TabIndex = 60;
            this.btnDispatchOrder.Text = "Dispatch";
            this.btnDispatchOrder.UseVisualStyleBackColor = false;
            this.btnDispatchOrder.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // lblRemoveCustomer
            // 
            this.lblRemoveCustomer.AutoSize = true;
            this.lblRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCustomer.Location = new System.Drawing.Point(57, 156);
            this.lblRemoveCustomer.Name = "lblRemoveCustomer";
            this.lblRemoveCustomer.Size = new System.Drawing.Size(347, 16);
            this.lblRemoveCustomer.TabIndex = 59;
            this.lblRemoveCustomer.Text = "Please choose an order that you want to dispatch";
            // 
            // pcbDispatchOrder
            // 
            this.pcbDispatchOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbDispatchOrder.BackgroundImage")));
            this.pcbDispatchOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbDispatchOrder.Location = new System.Drawing.Point(156, 41);
            this.pcbDispatchOrder.Name = "pcbDispatchOrder";
            this.pcbDispatchOrder.Size = new System.Drawing.Size(136, 112);
            this.pcbDispatchOrder.TabIndex = 58;
            this.pcbDispatchOrder.TabStop = false;
            // 
            // frmDispatchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 378);
            this.Controls.Add(this.cmbChooseCustomer);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnDispatchOrder);
            this.Controls.Add(this.lblRemoveCustomer);
            this.Controls.Add(this.pcbDispatchOrder);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmDispatchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatch Order";
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDispatchOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.ComboBox cmbChooseCustomer;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDispatchOrder;
        private System.Windows.Forms.Label lblRemoveCustomer;
        private System.Windows.Forms.PictureBox pcbDispatchOrder;
    }
}