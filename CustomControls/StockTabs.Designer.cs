namespace StocksAndFinance.CustomControls
{
    partial class StockTabs
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
            this.lblShares = new System.Windows.Forms.Label();
            this.lblSharesOwned = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShares.Location = new System.Drawing.Point(475, 27);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(21, 23);
            this.lblShares.TabIndex = 7;
            this.lblShares.Text = "#";
            // 
            // lblSharesOwned
            // 
            this.lblSharesOwned.AutoSize = true;
            this.lblSharesOwned.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSharesOwned.Location = new System.Drawing.Point(304, 27);
            this.lblSharesOwned.Name = "lblSharesOwned";
            this.lblSharesOwned.Size = new System.Drawing.Size(152, 23);
            this.lblSharesOwned.TabIndex = 6;
            this.lblSharesOwned.Text = "Shares Owned :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(68, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(68, 12);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(79, 23);
            this.lblSymbol.TabIndex = 4;
            this.lblSymbol.Text = "Symbol";
            // 
            // StockTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.Controls.Add(this.lblShares);
            this.Controls.Add(this.lblSharesOwned);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSymbol);
            this.Name = "StockTabs";
            this.Size = new System.Drawing.Size(564, 83);
            this.Load += new System.EventHandler(this.StockTabs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Label lblSharesOwned;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSymbol;
    }
}
