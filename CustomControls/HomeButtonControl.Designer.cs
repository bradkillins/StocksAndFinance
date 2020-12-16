namespace StocksAndFinance.CustomControls
{
    partial class HomeButtonControl
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
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logoImage.Location = new System.Drawing.Point(0, 2);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(242, 84);
            this.logoImage.TabIndex = 14;
            this.logoImage.TabStop = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.lblProfileName);
            this.pnlProfile.Controls.Add(this.profileImage);
            this.pnlProfile.Location = new System.Drawing.Point(21, 606);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(200, 43);
            this.pnlProfile.TabIndex = 20;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProfileName.Location = new System.Drawing.Point(9, 8);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(129, 25);
            this.lblProfileName.TabIndex = 1;
            this.lblProfileName.Text = "ProfileName";
            // 
            // profileImage
            // 
            this.profileImage.Location = new System.Drawing.Point(160, 0);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(37, 37);
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            // 
            // btnGoals
            // 
            this.btnGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.btnGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoals.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnGoals.Location = new System.Drawing.Point(0, 486);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(242, 105);
            this.btnGoals.TabIndex = 19;
            this.btnGoals.Text = "Goals";
            this.btnGoals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoals.UseVisualStyleBackColor = false;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.btnBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudget.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnBudget.Location = new System.Drawing.Point(0, 385);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(242, 105);
            this.btnBudget.TabIndex = 18;
            this.btnBudget.Text = "Budget";
            this.btnBudget.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBudget.UseVisualStyleBackColor = false;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocks.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnStocks.Location = new System.Drawing.Point(0, 286);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(242, 105);
            this.btnStocks.TabIndex = 17;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStocks.UseVisualStyleBackColor = false;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.btnLeaderBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderBoard.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnLeaderBoard.Location = new System.Drawing.Point(0, 185);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(242, 105);
            this.btnLeaderBoard.TabIndex = 16;
            this.btnLeaderBoard.Text = "Leaderboard";
            this.btnLeaderBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeaderBoard.UseVisualStyleBackColor = false;
            this.btnLeaderBoard.Click += new System.EventHandler(this.btnLeaderBoard_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(0, 83);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(242, 105);
            this.btnUser.TabIndex = 15;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // HomeButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.btnLeaderBoard);
            this.Controls.Add(this.btnUser);
            this.Name = "HomeButtonControl";
            this.Size = new System.Drawing.Size(242, 650);
            this.Load += new System.EventHandler(this.HomeButtonControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnLeaderBoard;
        private System.Windows.Forms.Button btnUser;
    }
}
