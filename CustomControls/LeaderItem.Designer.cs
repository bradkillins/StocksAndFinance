namespace StocksAndFinance
{
    partial class LeaderItem
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnViewWeeks = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.lblPercentDiff = new System.Windows.Forms.Label();
            this.PercentDiffDisplay = new System.Windows.Forms.Label();
            this.btnViewStocks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(17, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User:";
            // 
            // btnViewWeeks
            // 
            this.btnViewWeeks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewWeeks.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWeeks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewWeeks.Location = new System.Drawing.Point(703, 20);
            this.btnViewWeeks.Name = "btnViewWeeks";
            this.btnViewWeeks.Size = new System.Drawing.Size(161, 44);
            this.btnViewWeeks.TabIndex = 17;
            this.btnViewWeeks.Text = "Weekly Breakdown";
            this.btnViewWeeks.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(78, 29);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(79, 23);
            this.UserName.TabIndex = 18;
            this.UserName.Text = "Bob-Joe";
            // 
            // lblPercentDiff
            // 
            this.lblPercentDiff.AutoSize = true;
            this.lblPercentDiff.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentDiff.Location = new System.Drawing.Point(230, 29);
            this.lblPercentDiff.Name = "lblPercentDiff";
            this.lblPercentDiff.Size = new System.Drawing.Size(173, 23);
            this.lblPercentDiff.TabIndex = 19;
            this.lblPercentDiff.Text = "Percent Difference:";
            // 
            // PercentDiff
            // 
            this.PercentDiffDisplay.AutoSize = true;
            this.PercentDiffDisplay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentDiffDisplay.ForeColor = System.Drawing.Color.Green;
            this.PercentDiffDisplay.Location = new System.Drawing.Point(409, 29);
            this.PercentDiffDisplay.Name = "PercentDiff";
            this.PercentDiffDisplay.Size = new System.Drawing.Size(72, 23);
            this.PercentDiffDisplay.TabIndex = 20;
            this.PercentDiffDisplay.Text = "10.36%";
            // 
            // btnViewStocks
            // 
            this.btnViewStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStocks.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStocks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewStocks.Location = new System.Drawing.Point(576, 20);
            this.btnViewStocks.Name = "btnViewStocks";
            this.btnViewStocks.Size = new System.Drawing.Size(121, 44);
            this.btnViewStocks.TabIndex = 21;
            this.btnViewStocks.Text = "View Stocks";
            this.btnViewStocks.UseVisualStyleBackColor = true;
            // 
            // LeaderItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnViewStocks);
            this.Controls.Add(this.PercentDiffDisplay);
            this.Controls.Add(this.lblPercentDiff);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.btnViewWeeks);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "LeaderItem";
            this.Size = new System.Drawing.Size(880, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnViewWeeks;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label lblPercentDiff;
        private System.Windows.Forms.Label PercentDiffDisplay;
        private System.Windows.Forms.Button btnViewStocks;
    }
}
