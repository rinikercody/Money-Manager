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
            this.uxGoalDateLabel = new System.Windows.Forms.Label();
            this.uxAddGoalButton = new System.Windows.Forms.Button();
            this.uxGoalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxGoalDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxGoalAmountBox = new System.Windows.Forms.TextBox();
            this.uxRemoveGoalButton = new System.Windows.Forms.Button();
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxGoalsListView
            // 
            this.uxGoalsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amount,
            this.columnHeader1,
            this.columnHeader2});
            this.uxGoalsListView.GridLines = true;
            this.uxGoalsListView.Location = new System.Drawing.Point(13, 13);
            this.uxGoalsListView.Name = "uxGoalsListView";
            this.uxGoalsListView.Size = new System.Drawing.Size(775, 575);
            this.uxGoalsListView.TabIndex = 0;
            this.uxGoalsListView.UseCompatibleStateImageBehavior = false;
            this.uxGoalsListView.View = System.Windows.Forms.View.Details;
            // 
            // uxGoalDateLabel
            // 
            this.uxGoalDateLabel.AutoSize = true;
            this.uxGoalDateLabel.Location = new System.Drawing.Point(12, 694);
            this.uxGoalDateLabel.Name = "uxGoalDateLabel";
            this.uxGoalDateLabel.Size = new System.Drawing.Size(72, 17);
            this.uxGoalDateLabel.TabIndex = 36;
            this.uxGoalDateLabel.Text = "Goal Date";
            // 
            // uxAddGoalButton
            // 
            this.uxAddGoalButton.Enabled = false;
            this.uxAddGoalButton.Location = new System.Drawing.Point(318, 691);
            this.uxAddGoalButton.Name = "uxAddGoalButton";
            this.uxAddGoalButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddGoalButton.TabIndex = 35;
            this.uxAddGoalButton.Text = "Add Goal";
            this.uxAddGoalButton.UseVisualStyleBackColor = true;
            // 
            // uxGoalDate
            // 
            this.uxGoalDate.Location = new System.Drawing.Point(104, 692);
            this.uxGoalDate.Name = "uxGoalDate";
            this.uxGoalDate.Size = new System.Drawing.Size(200, 22);
            this.uxGoalDate.TabIndex = 34;
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
            this.label2.Location = new System.Drawing.Point(10, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Goal Description";
            // 
            // uxGoalDescriptionBox
            // 
            this.uxGoalDescriptionBox.Location = new System.Drawing.Point(13, 652);
            this.uxGoalDescriptionBox.Name = "uxGoalDescriptionBox";
            this.uxGoalDescriptionBox.Size = new System.Drawing.Size(408, 22);
            this.uxGoalDescriptionBox.TabIndex = 31;
            // 
            // uxGoalAmountBox
            // 
            this.uxGoalAmountBox.Location = new System.Drawing.Point(108, 598);
            this.uxGoalAmountBox.Name = "uxGoalAmountBox";
            this.uxGoalAmountBox.Size = new System.Drawing.Size(100, 22);
            this.uxGoalAmountBox.TabIndex = 30;
            // 
            // uxRemoveGoalButton
            // 
            this.uxRemoveGoalButton.Location = new System.Drawing.Point(502, 632);
            this.uxRemoveGoalButton.Name = "uxRemoveGoalButton";
            this.uxRemoveGoalButton.Size = new System.Drawing.Size(136, 23);
            this.uxRemoveGoalButton.TabIndex = 37;
            this.uxRemoveGoalButton.Text = "Remove Goal";
            this.uxRemoveGoalButton.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Goal Date";
            // 
            // GoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.uxRemoveGoalButton);
            this.Controls.Add(this.uxGoalDateLabel);
            this.Controls.Add(this.uxAddGoalButton);
            this.Controls.Add(this.uxGoalDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxGoalDescriptionBox);
            this.Controls.Add(this.uxGoalAmountBox);
            this.Controls.Add(this.uxGoalsListView);
            this.Name = "GoalsForm";
            this.Text = "GoalsForm";
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