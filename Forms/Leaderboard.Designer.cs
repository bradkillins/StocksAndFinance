namespace StocksAndFinance
{
    partial class Leaderboard
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
            this.lblNumOfWeeks = new System.Windows.Forms.Label();
            this.pnlLeaderList = new System.Windows.Forms.Panel();
            this.NumOfWeeks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfWeeks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumOfWeeks
            // 
            this.lblNumOfWeeks.AutoSize = true;
            this.lblNumOfWeeks.Location = new System.Drawing.Point(484, 57);
            this.lblNumOfWeeks.Name = "lblNumOfWeeks";
            this.lblNumOfWeeks.Size = new System.Drawing.Size(272, 23);
            this.lblNumOfWeeks.TabIndex = 0;
            this.lblNumOfWeeks.Text = "Number of Weeks to Compare:";
            // 
            // pnlLeaderList
            // 
            this.pnlLeaderList.AutoScroll = true;
            this.pnlLeaderList.Location = new System.Drawing.Point(12, 124);
            this.pnlLeaderList.Name = "pnlLeaderList";
            this.pnlLeaderList.Size = new System.Drawing.Size(889, 514);
            this.pnlLeaderList.TabIndex = 1;
            // 
            // NumOfWeeks
            // 
            this.NumOfWeeks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NumOfWeeks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NumOfWeeks.Location = new System.Drawing.Point(773, 55);
            this.NumOfWeeks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfWeeks.Name = "NumOfWeeks";
            this.NumOfWeeks.Size = new System.Drawing.Size(59, 29);
            this.NumOfWeeks.TabIndex = 2;
            this.NumOfWeeks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Leaderboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(913, 650);
            this.Controls.Add(this.NumOfWeeks);
            this.Controls.Add(this.pnlLeaderList);
            this.Controls.Add(this.lblNumOfWeeks);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfWeeks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfWeeks;
        private System.Windows.Forms.Panel pnlLeaderList;
        private System.Windows.Forms.NumericUpDown NumOfWeeks;
    }
}