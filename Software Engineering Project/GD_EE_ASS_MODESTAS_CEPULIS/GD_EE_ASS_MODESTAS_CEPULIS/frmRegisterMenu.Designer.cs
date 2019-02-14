namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmRegisterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterMenu));
            this.pcbRegisterMenu = new System.Windows.Forms.PictureBox();
            this.btnNewRegister = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegisterMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbRegisterMenu
            // 
            this.pcbRegisterMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbRegisterMenu.BackgroundImage")));
            this.pcbRegisterMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbRegisterMenu.Location = new System.Drawing.Point(173, 12);
            this.pcbRegisterMenu.Name = "pcbRegisterMenu";
            this.pcbRegisterMenu.Size = new System.Drawing.Size(58, 57);
            this.pcbRegisterMenu.TabIndex = 3;
            this.pcbRegisterMenu.TabStop = false;
            // 
            // btnNewRegister
            // 
            this.btnNewRegister.BackColor = System.Drawing.Color.White;
            this.btnNewRegister.ForeColor = System.Drawing.Color.Black;
            this.btnNewRegister.Location = new System.Drawing.Point(164, 170);
            this.btnNewRegister.Name = "btnNewRegister";
            this.btnNewRegister.Size = new System.Drawing.Size(76, 28);
            this.btnNewRegister.TabIndex = 25;
            this.btnNewRegister.Text = "Register";
            this.btnNewRegister.UseVisualStyleBackColor = false;
            this.btnNewRegister.Click += new System.EventHandler(this.btnNewRegister_Click);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(107, 144);
            this.tbNewPassword.MaxLength = 20;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(200, 20);
            this.tbNewPassword.TabIndex = 24;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(89, 125);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(236, 16);
            this.lblNewPassword.TabIndex = 23;
            this.lblNewPassword.Text = "Please enter your new password:";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Location = new System.Drawing.Point(107, 102);
            this.tbNewUsername.MaxLength = 20;
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(200, 20);
            this.tbNewUsername.TabIndex = 22;
            this.tbNewUsername.TextChanged += new System.EventHandler(this.tbNewUsername_TextChanged);
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.Location = new System.Drawing.Point(88, 80);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(237, 16);
            this.lblNewUsername.TabIndex = 21;
            this.lblNewUsername.Text = "Please enter your new username:";
            // 
            // frmRegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 237);
            this.Controls.Add(this.btnNewRegister);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbNewUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.pcbRegisterMenu);
            this.Name = "frmRegisterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegisterMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbRegisterMenu;
        private System.Windows.Forms.Button btnNewRegister;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbNewUsername;
        private System.Windows.Forms.Label lblNewUsername;
    }
}