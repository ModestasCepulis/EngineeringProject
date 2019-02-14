namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmAnalyseDeliveries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseDeliveries));
            this.pcbListDailyDeliveries = new System.Windows.Forms.PictureBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDailyDeliveries = new System.Windows.Forms.Label();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.picMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbListDailyDeliveries)).BeginInit();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbListDailyDeliveries
            // 
            this.pcbListDailyDeliveries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbListDailyDeliveries.BackgroundImage")));
            this.pcbListDailyDeliveries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbListDailyDeliveries.Location = new System.Drawing.Point(317, 27);
            this.pcbListDailyDeliveries.Name = "pcbListDailyDeliveries";
            this.pcbListDailyDeliveries.Size = new System.Drawing.Size(136, 112);
            this.pcbListDailyDeliveries.TabIndex = 59;
            this.pcbListDailyDeliveries.TabStop = false;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(286, 156);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(203, 32);
            this.lblDeliveryDate.TabIndex = 64;
            this.lblDeliveryDate.Text = "Please choose what date \r\ndeliveries you want to check";
            this.lblDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(289, 191);
            this.dtpDeliveryDate.MaxDate = new System.DateTime(2018, 12, 4, 0, 0, 0, 0);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 65;
            this.dtpDeliveryDate.Value = new System.DateTime(2018, 12, 4, 0, 0, 0, 0);
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // lblDailyDeliveries
            // 
            this.lblDailyDeliveries.AutoSize = true;
            this.lblDailyDeliveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyDeliveries.Location = new System.Drawing.Point(324, 234);
            this.lblDailyDeliveries.Name = "lblDailyDeliveries";
            this.lblDailyDeliveries.Size = new System.Drawing.Size(117, 16);
            this.lblDailyDeliveries.TabIndex = 68;
            this.lblDailyDeliveries.Text = "Daily deliveries";
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
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(889, 24);
            this.mnsGoBack.TabIndex = 20;
            this.mnsGoBack.Text = "menuStrip1";
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(79, 268);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(671, 356);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 69;
            this.picMain.TabStop = false;
            this.picMain.Visible = false;
            // 
            // frmAnalyseDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 750);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.lblDailyDeliveries);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.pcbListDailyDeliveries);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmAnalyseDeliveries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyse Deliveries";
            ((System.ComponentModel.ISupportInitialize)(this.pcbListDailyDeliveries)).EndInit();
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbListDailyDeliveries;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblDailyDeliveries;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.PictureBox picMain;
    }
}