
namespace StocksAndFinance.Forms
{
    partial class Budget
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
            this.panelBudgetMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBudgetMain
            // 
            this.panelBudgetMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBudgetMain.Location = new System.Drawing.Point(0, 0);
            this.panelBudgetMain.Name = "panelBudgetMain";
            this.panelBudgetMain.Size = new System.Drawing.Size(1200, 703);
            this.panelBudgetMain.TabIndex = 0;
            // 
            // Budget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panelBudgetMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Budget";
            this.Text = "Budget";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBudgetMain;
    }
}