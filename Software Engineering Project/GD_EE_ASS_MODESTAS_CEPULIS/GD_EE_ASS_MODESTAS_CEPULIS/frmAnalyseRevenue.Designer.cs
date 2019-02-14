namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmAnalyseRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseRevenue));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblRemoveCustomer = new System.Windows.Forms.Label();
            this.pcbRemoveCustomerDetails = new System.Windows.Forms.PictureBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemoveCustomerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(863, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Total revenue";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(294, 191);
            this.dtpOrderDate.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 71;
            this.dtpOrderDate.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // lblRemoveCustomer
            // 
            this.lblRemoveCustomer.AutoSize = true;
            this.lblRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCustomer.Location = new System.Drawing.Point(278, 156);
            this.lblRemoveCustomer.Name = "lblRemoveCustomer";
            this.lblRemoveCustomer.Size = new System.Drawing.Size(246, 32);
            this.lblRemoveCustomer.TabIndex = 70;
            this.lblRemoveCustomer.Text = "Please choose what date revenue \r\nyou want to analyse";
            this.lblRemoveCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbRemoveCustomerDetails
            // 
            this.pcbRemoveCustomerDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbRemoveCustomerDetails.BackgroundImage")));
            this.pcbRemoveCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbRemoveCustomerDetails.Location = new System.Drawing.Point(322, 27);
            this.pcbRemoveCustomerDetails.Name = "pcbRemoveCustomerDetails";
            this.pcbRemoveCustomerDetails.Size = new System.Drawing.Size(136, 112);
            this.pcbRemoveCustomerDetails.TabIndex = 69;
            this.pcbRemoveCustomerDetails.TabStop = false;
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(79, 253);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(671, 356);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 75;
            this.picMain.TabStop = false;
            this.picMain.Visible = false;
            this.picMain.Click += new System.EventHandler(this.picMain_Click);
            // 
            // frmAnalyseRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 648);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblRemoveCustomer);
            this.Controls.Add(this.pcbRemoveCustomerDetails);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmAnalyseRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyse Revenue";
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRemoveCustomerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblRemoveCustomer;
        private System.Windows.Forms.PictureBox pcbRemoveCustomerDetails;
        private System.Windows.Forms.PictureBox picMain;
    }
}