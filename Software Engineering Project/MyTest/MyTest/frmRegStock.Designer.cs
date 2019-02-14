namespace MyTest
{
    partial class frmRegStock
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
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.lblStockNo = new System.Windows.Forms.Label();
            this.grpStockDetails = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpStockDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStockNo
            // 
            this.txtStockNo.Enabled = false;
            this.txtStockNo.Location = new System.Drawing.Point(345, 42);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(100, 20);
            this.txtStockNo.TabIndex = 0;
            // 
            // lblStockNo
            // 
            this.lblStockNo.AutoSize = true;
            this.lblStockNo.Location = new System.Drawing.Point(264, 45);
            this.lblStockNo.Name = "lblStockNo";
            this.lblStockNo.Size = new System.Drawing.Size(75, 13);
            this.lblStockNo.TabIndex = 1;
            this.lblStockNo.Text = "Stock Number";
            this.lblStockNo.Click += new System.EventHandler(this.lblStockNo_Click);
            // 
            // grpStockDetails
            // 
            this.grpStockDetails.Controls.Add(this.btnRegister);
            this.grpStockDetails.Controls.Add(this.txtQuantity);
            this.grpStockDetails.Controls.Add(this.txtSale);
            this.grpStockDetails.Controls.Add(this.txtCost);
            this.grpStockDetails.Controls.Add(this.txtDescription);
            this.grpStockDetails.Controls.Add(this.label4);
            this.grpStockDetails.Controls.Add(this.lblSalePrice);
            this.grpStockDetails.Controls.Add(this.lblCostPrice);
            this.grpStockDetails.Controls.Add(this.lblDescription);
            this.grpStockDetails.Location = new System.Drawing.Point(12, 78);
            this.grpStockDetails.Name = "grpStockDetails";
            this.grpStockDetails.Size = new System.Drawing.Size(756, 360);
            this.grpStockDetails.TabIndex = 2;
            this.grpStockDetails.TabStop = false;
            this.grpStockDetails.Text = "Enter Stock Details";
            this.grpStockDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(249, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(249, 134);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(28, 13);
            this.lblCostPrice.TabIndex = 3;
            this.lblCostPrice.Text = "Cost";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(249, 176);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(28, 13);
            this.lblSalePrice.TabIndex = 4;
            this.lblSalePrice.Text = "Sale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(330, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(330, 127);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 8;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(330, 173);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(100, 20);
            this.txtSale.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(330, 212);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(330, 315);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmRegStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpStockDetails);
            this.Controls.Add(this.txtStockNo);
            this.Controls.Add(this.lblStockNo);
            this.Name = "frmRegStock";
            this.Text = "frmRegStock";
            this.Load += new System.EventHandler(this.frmRegStock_Load);
            this.grpStockDetails.ResumeLayout(false);
            this.grpStockDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Label lblStockNo;
        private System.Windows.Forms.GroupBox grpStockDetails;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblDescription;
    }
}