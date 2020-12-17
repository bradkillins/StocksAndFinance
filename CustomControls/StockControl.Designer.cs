namespace StocksAndFinance
{
    partial class StockControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crtStocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChangeShare = new System.Windows.Forms.Button();
            this.lblShares = new System.Windows.Forms.Label();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.lblStocks = new System.Windows.Forms.Label();
            this.cmbStocks = new System.Windows.Forms.ComboBox();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtAddShares = new System.Windows.Forms.TextBox();
            this.lblAddShares = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnInterval1y = new System.Windows.Forms.Button();
            this.btnInterval6m = new System.Windows.Forms.Button();
            this.btnInterval3m = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnInterval1m = new System.Windows.Forms.Button();
            this.lblEditStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crtStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // crtStocks
            // 
            this.crtStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(131)))));
            chartArea1.Name = "ChartArea1";
            this.crtStocks.ChartAreas.Add(chartArea1);
            this.crtStocks.Location = new System.Drawing.Point(39, 24);
            this.crtStocks.Name = "crtStocks";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.crtStocks.Series.Add(series1);
            this.crtStocks.Size = new System.Drawing.Size(813, 307);
            this.crtStocks.TabIndex = 0;
            this.crtStocks.Text = "chart1";
            // 
            // btnChangeShare
            // 
            this.btnChangeShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeShare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeShare.Location = new System.Drawing.Point(306, 437);
            this.btnChangeShare.Name = "btnChangeShare";
            this.btnChangeShare.Size = new System.Drawing.Size(76, 32);
            this.btnChangeShare.TabIndex = 35;
            this.btnChangeShare.Text = "Update";
            this.btnChangeShare.UseVisualStyleBackColor = true;
            this.btnChangeShare.Click += new System.EventHandler(this.btnChangeShare_Click);
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShares.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblShares.Location = new System.Drawing.Point(38, 440);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(73, 23);
            this.lblShares.TabIndex = 34;
            this.lblShares.Text = "Shares:";
            // 
            // txtShares
            // 
            this.txtShares.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShares.ForeColor = System.Drawing.Color.Black;
            this.txtShares.Location = new System.Drawing.Point(153, 440);
            this.txtShares.Name = "txtShares";
            this.txtShares.Size = new System.Drawing.Size(139, 26);
            this.txtShares.TabIndex = 33;
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStocks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStocks.Location = new System.Drawing.Point(46, 394);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(63, 23);
            this.lblStocks.TabIndex = 32;
            this.lblStocks.Text = "Stock:";
            // 
            // cmbStocks
            // 
            this.cmbStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbStocks.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStocks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStocks.FormattingEnabled = true;
            this.cmbStocks.Location = new System.Drawing.Point(153, 395);
            this.cmbStocks.Name = "cmbStocks";
            this.cmbStocks.Size = new System.Drawing.Size(139, 26);
            this.cmbStocks.TabIndex = 31;
            this.cmbStocks.SelectedIndexChanged += new System.EventHandler(this.cmbStocks_SelectedIndexChanged);
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddStock.Location = new System.Drawing.Point(42, 494);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(116, 23);
            this.lblAddStock.TabIndex = 36;
            this.lblAddStock.Text = "Add Stock:";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSymbol.Location = new System.Drawing.Point(42, 538);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(79, 23);
            this.lblSymbol.TabIndex = 37;
            this.lblSymbol.Text = "Symbol:";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol.ForeColor = System.Drawing.Color.Black;
            this.txtSymbol.Location = new System.Drawing.Point(153, 539);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(139, 26);
            this.txtSymbol.TabIndex = 38;
            // 
            // txtAddShares
            // 
            this.txtAddShares.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddShares.ForeColor = System.Drawing.Color.Black;
            this.txtAddShares.Location = new System.Drawing.Point(153, 573);
            this.txtAddShares.Name = "txtAddShares";
            this.txtAddShares.Size = new System.Drawing.Size(139, 26);
            this.txtAddShares.TabIndex = 39;
            // 
            // lblAddShares
            // 
            this.lblAddShares.AutoSize = true;
            this.lblAddShares.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddShares.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddShares.Location = new System.Drawing.Point(46, 572);
            this.lblAddShares.Name = "lblAddShares";
            this.lblAddShares.Size = new System.Drawing.Size(73, 23);
            this.lblAddShares.TabIndex = 40;
            this.lblAddShares.Text = "Shares:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStock.Location = new System.Drawing.Point(306, 570);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 32);
            this.btnAddStock.TabIndex = 41;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnInterval1y
            // 
            this.btnInterval1y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterval1y.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterval1y.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInterval1y.Location = new System.Drawing.Point(478, 385);
            this.btnInterval1y.Name = "btnInterval1y";
            this.btnInterval1y.Size = new System.Drawing.Size(83, 32);
            this.btnInterval1y.TabIndex = 42;
            this.btnInterval1y.Text = "1 Y";
            this.btnInterval1y.UseVisualStyleBackColor = true;
            this.btnInterval1y.Click += new System.EventHandler(this.btnInterval1y_Click);
            // 
            // btnInterval6m
            // 
            this.btnInterval6m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterval6m.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterval6m.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInterval6m.Location = new System.Drawing.Point(567, 385);
            this.btnInterval6m.Name = "btnInterval6m";
            this.btnInterval6m.Size = new System.Drawing.Size(83, 32);
            this.btnInterval6m.TabIndex = 43;
            this.btnInterval6m.Text = "6 M";
            this.btnInterval6m.UseVisualStyleBackColor = true;
            this.btnInterval6m.Click += new System.EventHandler(this.btnInterval6m_Click);
            // 
            // btnInterval3m
            // 
            this.btnInterval3m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterval3m.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterval3m.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInterval3m.Location = new System.Drawing.Point(656, 385);
            this.btnInterval3m.Name = "btnInterval3m";
            this.btnInterval3m.Size = new System.Drawing.Size(83, 32);
            this.btnInterval3m.TabIndex = 44;
            this.btnInterval3m.Text = "3 M";
            this.btnInterval3m.UseVisualStyleBackColor = true;
            this.btnInterval3m.Click += new System.EventHandler(this.btnInterval3m_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInterval.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInterval.Location = new System.Drawing.Point(480, 352);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(157, 23);
            this.lblInterval.TabIndex = 45;
            this.lblInterval.Text = "Chart Interval:";
            // 
            // btnInterval1m
            // 
            this.btnInterval1m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterval1m.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterval1m.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInterval1m.Location = new System.Drawing.Point(745, 385);
            this.btnInterval1m.Name = "btnInterval1m";
            this.btnInterval1m.Size = new System.Drawing.Size(83, 32);
            this.btnInterval1m.TabIndex = 46;
            this.btnInterval1m.Text = "1 M";
            this.btnInterval1m.UseVisualStyleBackColor = true;
            this.btnInterval1m.Click += new System.EventHandler(this.btnInterval1m_Click);
            // 
            // lblEditStock
            // 
            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEditStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditStock.Location = new System.Drawing.Point(42, 349);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(118, 23);
            this.lblEditStock.TabIndex = 47;
            this.lblEditStock.Text = "Edit Stock:";
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblEditStock);
            this.Controls.Add(this.btnInterval1m);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.btnInterval3m);
            this.Controls.Add(this.btnInterval6m);
            this.Controls.Add(this.btnInterval1y);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.lblAddShares);
            this.Controls.Add(this.txtAddShares);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.btnChangeShare);
            this.Controls.Add(this.lblShares);
            this.Controls.Add(this.txtShares);
            this.Controls.Add(this.lblStocks);
            this.Controls.Add(this.cmbStocks);
            this.Controls.Add(this.crtStocks);
            this.Name = "StockControl";
            this.Size = new System.Drawing.Size(913, 650);
            this.Load += new System.EventHandler(this.StockControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtStocks;
        private System.Windows.Forms.Button btnChangeShare;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.ComboBox cmbStocks;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtAddShares;
        private System.Windows.Forms.Label lblAddShares;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnInterval1y;
        private System.Windows.Forms.Button btnInterval6m;
        private System.Windows.Forms.Button btnInterval3m;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Button btnInterval1m;
        private System.Windows.Forms.Label lblEditStock;
    }
}
