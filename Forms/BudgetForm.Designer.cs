
namespace StocksAndFinance.Forms
{
    partial class BudgetForm
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
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButtonCreateBudgetItem = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Controls.Add(this.comboBox1);
            this.panelTopBar.Controls.Add(this.iconButtonCreateBudgetItem);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(895, 100);
            this.panelTopBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(489, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 33);
            this.comboBox1.TabIndex = 1;
            // 
            // iconButtonCreateBudgetItem
            // 
            this.iconButtonCreateBudgetItem.FlatAppearance.BorderSize = 0;
            this.iconButtonCreateBudgetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCreateBudgetItem.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreateBudgetItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonCreateBudgetItem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonCreateBudgetItem.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonCreateBudgetItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreateBudgetItem.IconSize = 40;
            this.iconButtonCreateBudgetItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCreateBudgetItem.Location = new System.Drawing.Point(12, 36);
            this.iconButtonCreateBudgetItem.Name = "iconButtonCreateBudgetItem";
            this.iconButtonCreateBudgetItem.Size = new System.Drawing.Size(229, 54);
            this.iconButtonCreateBudgetItem.TabIndex = 0;
            this.iconButtonCreateBudgetItem.Text = "Create Budget Item";
            this.iconButtonCreateBudgetItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCreateBudgetItem.UseVisualStyleBackColor = true;
            this.iconButtonCreateBudgetItem.MouseEnter += new System.EventHandler(this.ChangeCreateItemColorOnMouseeEnter);
            this.iconButtonCreateBudgetItem.MouseLeave += new System.EventHandler(this.ChangeCreateItemColorOnMouseleave);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(895, 503);
            this.panelMain.TabIndex = 1;
            // 
            // BudgetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 603);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BudgetForm";
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButtonCreateBudgetItem;
    }
}