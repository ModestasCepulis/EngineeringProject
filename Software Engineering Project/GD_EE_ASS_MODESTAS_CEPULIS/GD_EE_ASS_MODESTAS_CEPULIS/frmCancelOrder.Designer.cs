namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmCancelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelOrder));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbChooseOrder = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblRemoveOrder = new System.Windows.Forms.Label();
            this.pcbCancelOrder = new System.Windows.Forms.PictureBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(430, 24);
            this.mnsGoBack.TabIndex = 12;
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
            // cmbChooseOrder
            // 
            this.cmbChooseOrder.FormattingEnabled = true;
            this.cmbChooseOrder.Items.AddRange(new object[] {
            "Order #321",
            "Order #241",
            "Order #195",
            "Order #15"});
            this.cmbChooseOrder.Location = new System.Drawing.Point(77, 180);
            this.cmbChooseOrder.Name = "cmbChooseOrder";
            this.cmbChooseOrder.Size = new System.Drawing.Size(226, 21);
            this.cmbChooseOrder.TabIndex = 63;
            this.cmbChooseOrder.Text = "Order #321";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(91, 231);
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
            this.lblPassword.Location = new System.Drawing.Point(88, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(205, 16);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Please enter your password:";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.White;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelOrder.Location = new System.Drawing.Point(112, 266);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(163, 30);
            this.btnCancelOrder.TabIndex = 60;
            this.btnCancelOrder.Text = "Remove";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // lblRemoveOrder
            // 
            this.lblRemoveOrder.AutoSize = true;
            this.lblRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveOrder.Location = new System.Drawing.Point(29, 152);
            this.lblRemoveOrder.Name = "lblRemoveOrder";
            this.lblRemoveOrder.Size = new System.Drawing.Size(340, 16);
            this.lblRemoveOrder.TabIndex = 59;
            this.lblRemoveOrder.Text = "Please choose an order that you want to remove";
            // 
            // pcbCancelOrder
            // 
            this.pcbCancelOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCancelOrder.BackgroundImage")));
            this.pcbCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbCancelOrder.Location = new System.Drawing.Point(128, 37);
            this.pcbCancelOrder.Name = "pcbCancelOrder";
            this.pcbCancelOrder.Size = new System.Drawing.Size(136, 112);
            this.pcbCancelOrder.TabIndex = 58;
            this.pcbCancelOrder.TabStop = false;
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 349);
            this.Controls.Add(this.cmbChooseOrder);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lblRemoveOrder);
            this.Controls.Add(this.pcbCancelOrder);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmCancelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Order";
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancelOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.ComboBox cmbChooseOrder;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblRemoveOrder;
        private System.Windows.Forms.PictureBox pcbCancelOrder;
    }
}