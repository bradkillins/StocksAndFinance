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
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.btnChangeLogin = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.pnlStocks = new System.Windows.Forms.Panel();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserAssets = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblUserCredentials = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserDisplayName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorEmail.Location = new System.Drawing.Point(358, 125);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 24);
            this.lblErrorEmail.TabIndex = 46;
            // 
            // btnChangeLogin
            // 
            this.btnChangeLogin.Location = new System.Drawing.Point(277, 72);
            this.btnChangeLogin.Name = "btnChangeLogin";
            this.btnChangeLogin.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLogin.TabIndex = 45;
            this.btnChangeLogin.Text = "Change";
            this.btnChangeLogin.UseVisualStyleBackColor = true;
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
            this.btnChangeEmail.Location = new System.Drawing.Point(277, 124);
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
            this.pnlStocks.Location = new System.Drawing.Point(62, 335);
            this.pnlStocks.Name = "pnlStocks";
            this.pnlStocks.Size = new System.Drawing.Size(610, 289);
            this.pnlStocks.TabIndex = 42;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserFullName.Location = new System.Drawing.Point(744, 26);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(111, 20);
            this.lblUserFullName.TabIndex = 41;
            this.lblUserFullName.Text = "FULL NAME";
            // 
            // lblUserAssets
            // 
            this.lblUserAssets.AutoSize = true;
            this.lblUserAssets.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserAssets.Location = new System.Drawing.Point(59, 300);
            this.lblUserAssets.Name = "lblUserAssets";
            this.lblUserAssets.Size = new System.Drawing.Size(164, 20);
            this.lblUserAssets.TabIndex = 40;
            this.lblUserAssets.Text = "List Of Assets Owned";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblMoney.Location = new System.Drawing.Point(87, 238);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(48, 13);
            this.lblMoney.TabIndex = 39;
            this.lblMoney.Text = "Money : ";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserInfo.Location = new System.Drawing.Point(58, 205);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(39, 20);
            this.lblUserInfo.TabIndex = 38;
            this.lblUserInfo.Text = "Info";
            // 
            // lblUserCredentials
            // 
            this.lblUserCredentials.AutoSize = true;
            this.lblUserCredentials.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCredentials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserCredentials.Location = new System.Drawing.Point(58, 26);
            this.lblUserCredentials.Name = "lblUserCredentials";
            this.lblUserCredentials.Size = new System.Drawing.Size(95, 20);
            this.lblUserCredentials.TabIndex = 37;
            this.lblUserCredentials.Text = "Credentials";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(158)))));
            this.txtEmail.Location = new System.Drawing.Point(171, 125);
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
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(160)))), ((int)(((byte)(158)))));
            this.txtLogin.Location = new System.Drawing.Point(171, 74);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 34;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Century", 8.25F);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblEmailAddress.Location = new System.Drawing.Point(92, 128);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(81, 15);
            this.lblEmailAddress.TabIndex = 33;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Century", 8.25F);
            this.lblUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserPassword.Location = new System.Drawing.Point(92, 103);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(56, 15);
            this.lblUserPassword.TabIndex = 32;
            this.lblUserPassword.Text = "Password";
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.AutoSize = true;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.lblUserDisplayName.Location = new System.Drawing.Point(92, 74);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(67, 15);
            this.lblUserDisplayName.TabIndex = 31;
            this.lblUserDisplayName.Text = "LoginName";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.btnChangeLogin);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.pnlStocks);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.lblUserAssets);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblUserCredentials);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserDisplayName);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(913, 650);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Button btnChangeLogin;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Panel pnlStocks;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblUserAssets;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblUserCredentials;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserDisplayName;
    }
}
