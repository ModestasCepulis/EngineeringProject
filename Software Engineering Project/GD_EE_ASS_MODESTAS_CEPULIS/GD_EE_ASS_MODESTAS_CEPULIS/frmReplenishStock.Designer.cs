namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmReplenishStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplenishStock));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbReplenishStock = new System.Windows.Forms.PictureBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.cboStock = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.lblSelectStock = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReplenishStock)).BeginInit();
            this.grpStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(770, 24);
            this.mnsGoBack.TabIndex = 28;
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
            // pcbReplenishStock
            // 
            this.pcbReplenishStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbReplenishStock.BackgroundImage")));
            this.pcbReplenishStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbReplenishStock.Location = new System.Drawing.Point(321, 27);
            this.pcbReplenishStock.Name = "pcbReplenishStock";
            this.pcbReplenishStock.Size = new System.Drawing.Size(136, 112);
            this.pcbReplenishStock.TabIndex = 87;
            this.pcbReplenishStock.TabStop = false;
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockID.Location = new System.Drawing.Point(32, 27);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(70, 16);
            this.lblStockID.TabIndex = 88;
            this.lblStockID.Text = "Stock ID:";
            // 
            // cboStock
            // 
            this.cboStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStock.FormattingEnabled = true;
            this.cboStock.Location = new System.Drawing.Point(308, 209);
            this.cboStock.Name = "cboStock";
            this.cboStock.Size = new System.Drawing.Size(285, 21);
            this.cboStock.TabIndex = 97;
            this.cboStock.SelectedIndexChanged += new System.EventHandler(this.cboStock_SelectedIndexChanged_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 16);
            this.lblDescription.TabIndex = 99;
            this.lblDescription.Text = "Description:";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.Location = new System.Drawing.Point(19, 100);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(83, 16);
            this.lblCostPrice.TabIndex = 100;
            this.lblCostPrice.Text = "Cost Price:";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.Location = new System.Drawing.Point(19, 136);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(84, 16);
            this.lblSalePrice.TabIndex = 101;
            this.lblSalePrice.Text = "Sale Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(35, 177);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 16);
            this.lblQuantity.TabIndex = 102;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(116, 58);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(136, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(116, 100);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(55, 20);
            this.txtCostPrice.TabIndex = 3;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(116, 135);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(55, 20);
            this.txtSalePrice.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(116, 173);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 7;
            // 
            // txtStockNo
            // 
            this.txtStockNo.Enabled = false;
            this.txtStockNo.Location = new System.Drawing.Point(116, 23);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(57, 20);
            this.txtStockNo.TabIndex = 10;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.lblQuantity);
            this.grpStock.Controls.Add(this.lblSalePrice);
            this.grpStock.Controls.Add(this.txtStockNo);
            this.grpStock.Controls.Add(this.lblCostPrice);
            this.grpStock.Controls.Add(this.btnUpdate);
            this.grpStock.Controls.Add(this.txtQty);
            this.grpStock.Controls.Add(this.lblDescription);
            this.grpStock.Controls.Add(this.txtSalePrice);
            this.grpStock.Controls.Add(this.txtCostPrice);
            this.grpStock.Controls.Add(this.txtDescription);
            this.grpStock.Controls.Add(this.lblStockID);
            this.grpStock.Location = new System.Drawing.Point(209, 287);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(408, 283);
            this.grpStock.TabIndex = 96;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Edit Stock Details";
            this.grpStock.Visible = false;
            // 
            // lblSelectStock
            // 
            this.lblSelectStock.AutoSize = true;
            this.lblSelectStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStock.Location = new System.Drawing.Point(206, 210);
            this.lblSelectStock.Name = "lblSelectStock";
            this.lblSelectStock.Size = new System.Drawing.Size(84, 16);
            this.lblSelectStock.TabIndex = 103;
            this.lblSelectStock.Text = "Sale Price:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(112, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmReplenishStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 666);
            this.Controls.Add(this.lblSelectStock);
            this.Controls.Add(this.cboStock);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.pcbReplenishStock);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmReplenishStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replenish Stock";
            this.Load += new System.EventHandler(this.frmReplenishStock_Load);
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReplenishStock)).EndInit();
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.PictureBox pcbReplenishStock;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.ComboBox cboStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSelectStock;
    }
}