namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmNewStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewStock));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.pcmAddNewStock = new System.Windows.Forms.PictureBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.gbEnterDetails = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtDateAdded = new System.Windows.Forms.TextBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcmAddNewStock)).BeginInit();
            this.gbEnterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(765, 24);
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
            this.tlmnuBack.Click += new System.EventHandler(this.tlmnuBack_Click);
            // 
            // pcmAddNewStock
            // 
            this.pcmAddNewStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcmAddNewStock.BackgroundImage")));
            this.pcmAddNewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcmAddNewStock.Location = new System.Drawing.Point(316, 27);
            this.pcmAddNewStock.Name = "pcmAddNewStock";
            this.pcmAddNewStock.Size = new System.Drawing.Size(136, 112);
            this.pcmAddNewStock.TabIndex = 70;
            this.pcmAddNewStock.TabStop = false;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.Location = new System.Drawing.Point(87, 103);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(79, 16);
            this.lblCostPrice.TabIndex = 83;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Location = new System.Drawing.Point(238, 510);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(200, 20);
            this.dtpDateAdded.TabIndex = 82;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(87, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 16);
            this.lblDescription.TabIndex = 80;
            this.lblDescription.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(185, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 28);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(180, 67);
            this.txtDescription.MaxLength = 20;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(143, 20);
            this.txtDescription.TabIndex = 87;
            // 
            // txtStockID
            // 
            this.txtStockID.Enabled = false;
            this.txtStockID.Location = new System.Drawing.Point(180, 30);
            this.txtStockID.MaxLength = 15;
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(99, 20);
            this.txtStockID.TabIndex = 90;
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(107, 30);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(70, 16);
            this.lblStockID.TabIndex = 89;
            this.lblStockID.Text = "Stock ID:";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.Location = new System.Drawing.Point(87, 139);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(80, 16);
            this.lblSalePrice.TabIndex = 94;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(87, 171);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 96;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAdded.Location = new System.Drawing.Point(87, 209);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(90, 16);
            this.lblDateAdded.TabIndex = 98;
            this.lblDateAdded.Text = "Date added";
            // 
            // gbEnterDetails
            // 
            this.gbEnterDetails.Controls.Add(this.txtDateAdded);
            this.gbEnterDetails.Controls.Add(this.txtQty);
            this.gbEnterDetails.Controls.Add(this.txtSalePrice);
            this.gbEnterDetails.Controls.Add(this.btnAdd);
            this.gbEnterDetails.Controls.Add(this.txtCostPrice);
            this.gbEnterDetails.Controls.Add(this.lblDateAdded);
            this.gbEnterDetails.Controls.Add(this.lblDescription);
            this.gbEnterDetails.Controls.Add(this.lblQuantity);
            this.gbEnterDetails.Controls.Add(this.lblCostPrice);
            this.gbEnterDetails.Controls.Add(this.txtDescription);
            this.gbEnterDetails.Controls.Add(this.lblSalePrice);
            this.gbEnterDetails.Controls.Add(this.txtStockID);
            this.gbEnterDetails.Controls.Add(this.lblStockID);
            this.gbEnterDetails.Location = new System.Drawing.Point(159, 174);
            this.gbEnterDetails.Name = "gbEnterDetails";
            this.gbEnterDetails.Size = new System.Drawing.Size(447, 309);
            this.gbEnterDetails.TabIndex = 99;
            this.gbEnterDetails.TabStop = false;
            this.gbEnterDetails.Text = "Enter Stock Details";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(183, 171);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(72, 20);
            this.txtQty.TabIndex = 102;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(183, 136);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(72, 20);
            this.txtSalePrice.TabIndex = 101;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(183, 100);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(72, 20);
            this.txtCostPrice.TabIndex = 100;
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Location = new System.Drawing.Point(185, 208);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(72, 20);
            this.txtDateAdded.TabIndex = 103;
            // 
            // frmNewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 591);
            this.Controls.Add(this.gbEnterDetails);
            this.Controls.Add(this.pcmAddNewStock);
            this.Controls.Add(this.mnsGoBack);
            this.Controls.Add(this.dtpDateAdded);
            this.Name = "frmNewStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Stock";
            this.Load += new System.EventHandler(this.frmNewStock_Load);
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcmAddNewStock)).EndInit();
            this.gbEnterDetails.ResumeLayout(false);
            this.gbEnterDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.PictureBox pcmAddNewStock;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.GroupBox gbEnterDetails;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtDateAdded;
    }
}