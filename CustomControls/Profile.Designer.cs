namespace StocksAndFinance.CustomControls
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.pnlStocks = new System.Windows.Forms.Panel();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserAssets = new System.Windows.Forms.Label();
            this.lblUserCredentials = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblInvalidEmailEntry = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(277, 98);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 44;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Location = new System.Drawing.Point(277, 73);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(75, 23);
            this.btnChangeEmail.TabIndex = 43;
            this.btnChangeEmail.Text = "Change";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // pnlStocks
            // 
            this.pnlStocks.AutoScroll = true;
            this.pnlStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlStocks.Location = new System.Drawing.Point(62, 226);
            this.pnlStocks.Name = "pnlStocks";
            this.pnlStocks.Size = new System.Drawing.Size(610, 396);
            this.pnlStocks.TabIndex = 42;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserFullName.Location = new System.Drawing.Point(744, 26);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(133, 23);
            this.lblUserFullName.TabIndex = 41;
            this.lblUserFullName.Text = "FULL NAME";
            // 
            // lblUserAssets
            // 
            this.lblUserAssets.AutoSize = true;
            this.lblUserAssets.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserAssets.Location = new System.Drawing.Point(59, 191);
            this.lblUserAssets.Name = "lblUserAssets";
            this.lblUserAssets.Size = new System.Drawing.Size(218, 23);
            this.lblUserAssets.TabIndex = 40;
            this.lblUserAssets.Text = "List Of Assets Owned";
            // 
            // lblUserCredentials
            // 
            this.lblUserCredentials.AutoSize = true;
            this.lblUserCredentials.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUserCredentials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserCredentials.Location = new System.Drawing.Point(58, 26);
            this.lblUserCredentials.Name = "lblUserCredentials";
            this.lblUserCredentials.Size = new System.Drawing.Size(125, 23);
            this.lblUserCredentials.TabIndex = 37;
            this.lblUserCredentials.Text = "Credentials";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(158)))));
            this.txtEmail.Location = new System.Drawing.Point(171, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(158)))));
            this.txtPassword.Location = new System.Drawing.Point(171, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 35;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblEmailAddress.Location = new System.Drawing.Point(73, 76);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(88, 14);
            this.lblEmailAddress.TabIndex = 33;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserPassword.Location = new System.Drawing.Point(73, 102);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(59, 14);
            this.lblUserPassword.TabIndex = 32;
            this.lblUserPassword.Text = "Password";
            // 
            // lblInvalidEmailEntry
            // 
            this.lblInvalidEmailEntry.AutoSize = true;
            this.lblInvalidEmailEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidEmailEntry.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEmailEntry.Location = new System.Drawing.Point(358, 74);
            this.lblInvalidEmailEntry.Name = "lblInvalidEmailEntry";
            this.lblInvalidEmailEntry.Size = new System.Drawing.Size(0, 25);
            this.lblInvalidEmailEntry.TabIndex = 47;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPassword.Location = new System.Drawing.Point(358, 98);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(0, 25);
            this.lblInvalidPassword.TabIndex = 48;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidEmailEntry);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.pnlStocks);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.lblUserAssets);
            this.Controls.Add(this.lblUserCredentials);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblUserPassword);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(913, 650);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Panel pnlStocks;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblUserAssets;
        private System.Windows.Forms.Label lblUserCredentials;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblInvalidEmailEntry;
        private System.Windows.Forms.Label lblInvalidPassword;
    }
}
