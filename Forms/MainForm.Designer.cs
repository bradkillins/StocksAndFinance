namespace StocksAndFinance.Forms
{
    partial class MainForm
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
            this.pnlMaincontent = new System.Windows.Forms.Panel();
            this.pnlWidget = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMaincontent
            // 
            this.pnlMaincontent.Location = new System.Drawing.Point(262, 12);
            this.pnlMaincontent.Name = "pnlMaincontent";
            this.pnlMaincontent.Size = new System.Drawing.Size(913, 650);
            this.pnlMaincontent.TabIndex = 4;
            // 
            // pnlWidget
            // 
            this.pnlWidget.Location = new System.Drawing.Point(12, 13);
            this.pnlWidget.Name = "pnlWidget";
            this.pnlWidget.Size = new System.Drawing.Size(242, 650);
            this.pnlWidget.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1187, 675);
            this.Controls.Add(this.pnlMaincontent);
            this.Controls.Add(this.pnlWidget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Stocks and Finance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMaincontent;
        private System.Windows.Forms.Panel pnlWidget;
    }
}