
namespace StocksAndFinance
{
    partial class pnlGoalItem
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
            this.progressBarGoal = new System.Windows.Forms.ProgressBar();
            this.lblGoalItem = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblGoalItemAmount = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.GoalDescription = new System.Windows.Forms.Label();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarGoal
            // 
            this.progressBarGoal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarGoal.ForeColor = System.Drawing.Color.Green;
            this.progressBarGoal.Location = new System.Drawing.Point(17, 56);
            this.progressBarGoal.Name = "progressBarGoal";
            this.progressBarGoal.Size = new System.Drawing.Size(834, 10);
            this.progressBarGoal.TabIndex = 10;
            // 
            // lblGoalItem
            // 
            this.lblGoalItem.AutoSize = true;
            this.lblGoalItem.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalItem.Location = new System.Drawing.Point(13, 19);
            this.lblGoalItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoalItem.Name = "lblGoalItem";
            this.lblGoalItem.Size = new System.Drawing.Size(177, 21);
            this.lblGoalItem.TabIndex = 8;
            this.lblGoalItem.Text = "Financial Goal Title:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Controls.Add(this.lblGoalItemAmount);
            this.flowLayoutPanel1.Controls.Add(this.iconButton2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(350, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 36);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButtonMinus_Click);
            this.iconButton1.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButton1.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // lblGoalItemAmount
            // 
            this.lblGoalItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoalItemAmount.AutoSize = true;
            this.lblGoalItemAmount.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalItemAmount.Location = new System.Drawing.Point(39, 0);
            this.lblGoalItemAmount.Name = "lblGoalItemAmount";
            this.lblGoalItemAmount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblGoalItemAmount.Size = new System.Drawing.Size(72, 26);
            this.lblGoalItemAmount.TabIndex = 1;
            this.lblGoalItemAmount.Text = "$0 of $1";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(117, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(30, 30);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButtonPlus_Click);
            this.iconButton2.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButton2.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.GoalDescription);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(157, 87);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(694, 60);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // GoalDescription
            // 
            this.GoalDescription.AutoSize = true;
            this.GoalDescription.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalDescription.Location = new System.Drawing.Point(3, 0);
            this.GoalDescription.Name = "GoalDescription";
            this.GoalDescription.Size = new System.Drawing.Size(75, 18);
            this.GoalDescription.TabIndex = 0;
            this.GoalDescription.Text = "GoalNote";
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonDelete.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 30;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonDelete.Location = new System.Drawing.Point(835, 8);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(30, 30);
            this.iconButtonDelete.TabIndex = 12;
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            this.iconButtonDelete.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonDelete.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEdit.FlatAppearance.BorderSize = 0;
            this.iconButtonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButtonEdit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 30;
            this.iconButtonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonEdit.Location = new System.Drawing.Point(799, 8);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(37, 30);
            this.iconButtonEdit.TabIndex = 11;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.Click += new System.EventHandler(this.iconButtonEdit_Click);
            this.iconButtonEdit.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonEdit.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // DueDate
            // 
            this.DueDate.CalendarFont = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Location = new System.Drawing.Point(593, 15);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 25);
            this.DueDate.TabIndex = 19;
            this.DueDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pnlGoalItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.progressBarGoal);
            this.Controls.Add(this.lblGoalItem);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.iconButtonEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "pnlGoalItem";
            this.Size = new System.Drawing.Size(868, 150);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarGoal;
        private System.Windows.Forms.Label lblGoalItem;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblGoalItemAmount;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label GoalDescription;
        private System.Windows.Forms.DateTimePicker DueDate;
    }
}
