namespace StocksAndFinance
{
    partial class LeaderboardStockView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTopStocks = new System.Windows.Forms.Label();
            this.lblAllStocks = new System.Windows.Forms.Label();
            this.lblTopStocksDisplay = new System.Windows.Forms.Label();
            this.lblAllStocksDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(561, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTopStocks
            // 
            this.lblTopStocks.AutoSize = true;
            this.lblTopStocks.Location = new System.Drawing.Point(62, 55);
            this.lblTopStocks.Name = "lblTopStocks";
            this.lblTopStocks.Size = new System.Drawing.Size(125, 23);
            this.lblTopStocks.TabIndex = 1;
            this.lblTopStocks.Text = "Top 2 Stocks:";
            // 
            // lblAllStocks
            // 
            this.lblAllStocks.AutoSize = true;
            this.lblAllStocks.Location = new System.Drawing.Point(88, 122);
            this.lblAllStocks.Name = "lblAllStocks";
            this.lblAllStocks.Size = new System.Drawing.Size(99, 23);
            this.lblAllStocks.TabIndex = 2;
            this.lblAllStocks.Text = "All Stocks:";
            // 
            // lblTopStocksDisplay
            // 
            this.lblTopStocksDisplay.AutoSize = true;
            this.lblTopStocksDisplay.Location = new System.Drawing.Point(224, 55);
            this.lblTopStocksDisplay.Name = "lblTopStocksDisplay";
            this.lblTopStocksDisplay.Size = new System.Drawing.Size(112, 23);
            this.lblTopStocksDisplay.TabIndex = 3;
            this.lblTopStocksDisplay.Text = "JUST, TWO";
            // 
            // lblAllStocksDisplay
            // 
            this.lblAllStocksDisplay.AutoSize = true;
            this.lblAllStocksDisplay.Location = new System.Drawing.Point(224, 122);
            this.lblAllStocksDisplay.MinimumSize = new System.Drawing.Size(350, 200);
            this.lblAllStocksDisplay.Name = "lblAllStocksDisplay";
            this.lblAllStocksDisplay.Size = new System.Drawing.Size(350, 200);
            this.lblAllStocksDisplay.TabIndex = 4;
            this.lblAllStocksDisplay.Text = "Many Stocks Here....";
            // 
            // LeaderboardStockView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(686, 414);
            this.Controls.Add(this.lblAllStocksDisplay);
            this.Controls.Add(this.lblTopStocksDisplay);
            this.Controls.Add(this.lblAllStocks);
            this.Controls.Add(this.lblTopStocks);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaderboardStockView";
            this.Text = "LeaderboardStockView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTopStocks;
        private System.Windows.Forms.Label lblAllStocks;
        private System.Windows.Forms.Label lblTopStocksDisplay;
        private System.Windows.Forms.Label lblAllStocksDisplay;
    }
}