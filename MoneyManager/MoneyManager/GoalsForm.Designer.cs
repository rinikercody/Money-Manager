namespace MoneyManager
{
    partial class GoalsForm
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
            this.uxGoalsListView = new System.Windows.Forms.ListView();
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxGoalDateLabel = new System.Windows.Forms.Label();
            this.uxAddGoalButton = new System.Windows.Forms.Button();
            this.uxGoalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxGoalDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxGoalAmountBox = new System.Windows.Forms.TextBox();
            this.uxRemoveGoalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGoalsListView
            // 
            this.uxGoalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amount,
            this.columnHeader1,
            this.columnHeader2});
            this.uxGoalsListView.FullRowSelect = true;
            this.uxGoalsListView.GridLines = true;
            this.uxGoalsListView.Location = new System.Drawing.Point(13, 13);
            this.uxGoalsListView.MultiSelect = false;
            this.uxGoalsListView.Name = "uxGoalsListView";
            this.uxGoalsListView.Size = new System.Drawing.Size(775, 575);
            this.uxGoalsListView.TabIndex = 0;
            this.uxGoalsListView.UseCompatibleStateImageBehavior = false;
            this.uxGoalsListView.View = System.Windows.Forms.View.Details;
            this.uxGoalsListView.SelectedIndexChanged += new System.EventHandler(this.uxGoalsListView_SelectedIndexChanged);
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 140;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Goal Date";
            this.columnHeader2.Width = 110;
            // 
            // uxGoalDateLabel
            // 
            this.uxGoalDateLabel.AutoSize = true;
            this.uxGoalDateLabel.Location = new System.Drawing.Point(12, 641);
            this.uxGoalDateLabel.Name = "uxGoalDateLabel";
            this.uxGoalDateLabel.Size = new System.Drawing.Size(72, 17);
            this.uxGoalDateLabel.TabIndex = 36;
            this.uxGoalDateLabel.Text = "Goal Date";
            // 
            // uxAddGoalButton
            // 
            this.uxAddGoalButton.Enabled = false;
            this.uxAddGoalButton.Location = new System.Drawing.Point(357, 635);
            this.uxAddGoalButton.Name = "uxAddGoalButton";
            this.uxAddGoalButton.Size = new System.Drawing.Size(289, 23);
            this.uxAddGoalButton.TabIndex = 35;
            this.uxAddGoalButton.Text = "Add Goal";
            this.uxAddGoalButton.UseVisualStyleBackColor = true;
            this.uxAddGoalButton.Click += new System.EventHandler(this.uxAddGoalButton_Click);
            // 
            // uxGoalDate
            // 
            this.uxGoalDate.Location = new System.Drawing.Point(108, 636);
            this.uxGoalDate.Name = "uxGoalDate";
            this.uxGoalDate.Size = new System.Drawing.Size(243, 22);
            this.uxGoalDate.TabIndex = 34;
            this.uxGoalDate.ValueChanged += new System.EventHandler(this.checkGoal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Goal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Goal Description";
            // 
            // uxGoalDescriptionBox
            // 
            this.uxGoalDescriptionBox.Location = new System.Drawing.Point(348, 598);
            this.uxGoalDescriptionBox.Name = "uxGoalDescriptionBox";
            this.uxGoalDescriptionBox.Size = new System.Drawing.Size(440, 22);
            this.uxGoalDescriptionBox.TabIndex = 31;
            this.uxGoalDescriptionBox.TextChanged += new System.EventHandler(this.checkGoal);
            // 
            // uxGoalAmountBox
            // 
            this.uxGoalAmountBox.Location = new System.Drawing.Point(108, 598);
            this.uxGoalAmountBox.Name = "uxGoalAmountBox";
            this.uxGoalAmountBox.Size = new System.Drawing.Size(100, 22);
            this.uxGoalAmountBox.TabIndex = 30;
            this.uxGoalAmountBox.TextChanged += new System.EventHandler(this.checkGoal);
            // 
            // uxRemoveGoalButton
            // 
            this.uxRemoveGoalButton.Enabled = false;
            this.uxRemoveGoalButton.Location = new System.Drawing.Point(652, 635);
            this.uxRemoveGoalButton.Name = "uxRemoveGoalButton";
            this.uxRemoveGoalButton.Size = new System.Drawing.Size(136, 23);
            this.uxRemoveGoalButton.TabIndex = 37;
            this.uxRemoveGoalButton.Text = "Remove Goal";
            this.uxRemoveGoalButton.UseVisualStyleBackColor = true;
            this.uxRemoveGoalButton.Click += new System.EventHandler(this.uxRemoveGoalButton_Click);
            // 
            // GoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.uxRemoveGoalButton);
            this.Controls.Add(this.uxGoalDateLabel);
            this.Controls.Add(this.uxAddGoalButton);
            this.Controls.Add(this.uxGoalDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxGoalDescriptionBox);
            this.Controls.Add(this.uxGoalAmountBox);
            this.Controls.Add(this.uxGoalsListView);
            this.MaximizeBox = false;
            this.Name = "GoalsForm";
            this.Text = "Goals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxGoalsListView;
        private System.Windows.Forms.Label uxGoalDateLabel;
        private System.Windows.Forms.Button uxAddGoalButton;
        private System.Windows.Forms.DateTimePicker uxGoalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxGoalDescriptionBox;
        private System.Windows.Forms.TextBox uxGoalAmountBox;
        private System.Windows.Forms.Button uxRemoveGoalButton;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}