
namespace StocksAndFinance.Forms
{
    partial class Goals
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
            this.panelGoalsMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGoalsMain
            // 
            this.panelGoalsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoalsMain.Location = new System.Drawing.Point(0, 0);
            this.panelGoalsMain.Name = "panelGoalsMain";
            this.panelGoalsMain.Size = new System.Drawing.Size(1100, 619);
            this.panelGoalsMain.TabIndex = 0;
            // 
            // Goals
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.panelGoalsMain);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Goals";
            this.Text = "Goals";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGoalsMain;
    }
}