namespace MoneyManager
{
    partial class ScheduleTransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxAmountBox = new System.Windows.Forms.TextBox();
            this.uxCategoryPicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.uxAddScheduledTransaction = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.uxDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxScheduledTransactionListView = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TakenOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxRemoveTransactionButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxOneTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.uxWeekUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxMonthUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxWeekUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // uxAmountBox
            // 
            this.uxAmountBox.Location = new System.Drawing.Point(101, 58);
            this.uxAmountBox.Name = "uxAmountBox";
            this.uxAmountBox.Size = new System.Drawing.Size(353, 22);
            this.uxAmountBox.TabIndex = 1;
            this.uxAmountBox.TextChanged += new System.EventHandler(this.checkAdd);
            // 
            // uxCategoryPicker
            // 
            this.uxCategoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCategoryPicker.FormattingEnabled = true;
            this.uxCategoryPicker.Location = new System.Drawing.Point(101, 126);
            this.uxCategoryPicker.Name = "uxCategoryPicker";
            this.uxCategoryPicker.Size = new System.Drawing.Size(353, 24);
            this.uxCategoryPicker.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category:";
            // 
            // uxStartDate
            // 
            this.uxStartDate.Location = new System.Drawing.Point(101, 156);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(353, 22);
            this.uxStartDate.TabIndex = 29;
            this.uxStartDate.ValueChanged += new System.EventHandler(this.checkAdd);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Start Date:";
            // 
            // uxAddScheduledTransaction
            // 
            this.uxAddScheduledTransaction.Enabled = false;
            this.uxAddScheduledTransaction.Location = new System.Drawing.Point(11, 289);
            this.uxAddScheduledTransaction.Name = "uxAddScheduledTransaction";
            this.uxAddScheduledTransaction.Size = new System.Drawing.Size(443, 82);
            this.uxAddScheduledTransaction.TabIndex = 38;
            this.uxAddScheduledTransaction.Text = "Add Scheduled Transaction";
            this.uxAddScheduledTransaction.UseVisualStyleBackColor = true;
            this.uxAddScheduledTransaction.Click += new System.EventHandler(this.uxAddScheduledTransaction_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Description:";
            // 
            // uxDescriptionBox
            // 
            this.uxDescriptionBox.Location = new System.Drawing.Point(101, 86);
            this.uxDescriptionBox.Name = "uxDescriptionBox";
            this.uxDescriptionBox.Size = new System.Drawing.Size(353, 22);
            this.uxDescriptionBox.TabIndex = 40;
            this.uxDescriptionBox.TextChanged += new System.EventHandler(this.checkAdd);
            // 
            // uxScheduledTransactionListView
            // 
            this.uxScheduledTransactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.TakenOut,
            this.columnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.ID});
            this.uxScheduledTransactionListView.FullRowSelect = true;
            this.uxScheduledTransactionListView.GridLines = true;
            this.uxScheduledTransactionListView.Location = new System.Drawing.Point(461, 8);
            this.uxScheduledTransactionListView.Name = "uxScheduledTransactionListView";
            this.uxScheduledTransactionListView.Size = new System.Drawing.Size(912, 430);
            this.uxScheduledTransactionListView.TabIndex = 41;
            this.uxScheduledTransactionListView.UseCompatibleStateImageBehavior = false;
            this.uxScheduledTransactionListView.View = System.Windows.Forms.View.Details;
            this.uxScheduledTransactionListView.SelectedIndexChanged += new System.EventHandler(this.uxScheduledTransactionListView_SelectedIndexChanged);
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 99;
            // 
            // TakenOut
            // 
            this.TakenOut.Text = "Taken Out";
            this.TakenOut.Width = 124;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Next Time";
            this.columnHeader.Width = 132;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 432;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Frequency";
            this.columnHeader2.Width = 100;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            // 
            // uxRemoveTransactionButton
            // 
            this.uxRemoveTransactionButton.Enabled = false;
            this.uxRemoveTransactionButton.Location = new System.Drawing.Point(11, 377);
            this.uxRemoveTransactionButton.Name = "uxRemoveTransactionButton";
            this.uxRemoveTransactionButton.Size = new System.Drawing.Size(443, 61);
            this.uxRemoveTransactionButton.TabIndex = 42;
            this.uxRemoveTransactionButton.Text = "Remove Transaction";
            this.uxRemoveTransactionButton.UseVisualStyleBackColor = true;
            this.uxRemoveTransactionButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Frequency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Months:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Weeks:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Schedule transactions to be taken out at a future time";
            // 
            // uxOneTimeCheckBox
            // 
            this.uxOneTimeCheckBox.AutoSize = true;
            this.uxOneTimeCheckBox.Checked = true;
            this.uxOneTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxOneTimeCheckBox.Location = new System.Drawing.Point(101, 195);
            this.uxOneTimeCheckBox.Name = "uxOneTimeCheckBox";
            this.uxOneTimeCheckBox.Size = new System.Drawing.Size(92, 21);
            this.uxOneTimeCheckBox.TabIndex = 49;
            this.uxOneTimeCheckBox.Text = "One Time";
            this.uxOneTimeCheckBox.UseVisualStyleBackColor = true;
            this.uxOneTimeCheckBox.CheckedChanged += new System.EventHandler(this.checkAdd);
            // 
            // uxWeekUpDown
            // 
            this.uxWeekUpDown.Enabled = false;
            this.uxWeekUpDown.Location = new System.Drawing.Point(101, 251);
            this.uxWeekUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.uxWeekUpDown.Name = "uxWeekUpDown";
            this.uxWeekUpDown.Size = new System.Drawing.Size(120, 22);
            this.uxWeekUpDown.TabIndex = 50;
            // 
            // uxMonthUpDown
            // 
            this.uxMonthUpDown.Enabled = false;
            this.uxMonthUpDown.Location = new System.Drawing.Point(101, 222);
            this.uxMonthUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.uxMonthUpDown.Name = "uxMonthUpDown";
            this.uxMonthUpDown.Size = new System.Drawing.Size(120, 22);
            this.uxMonthUpDown.TabIndex = 51;
            this.uxMonthUpDown.ValueChanged += new System.EventHandler(this.uxMonthUpDown_ValueChanged);
            // 
            // ScheduleTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1415, 450);
            this.Controls.Add(this.uxMonthUpDown);
            this.Controls.Add(this.uxWeekUpDown);
            this.Controls.Add(this.uxOneTimeCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uxRemoveTransactionButton);
            this.Controls.Add(this.uxScheduledTransactionListView);
            this.Controls.Add(this.uxDescriptionBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxAddScheduledTransaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxCategoryPicker);
            this.Controls.Add(this.uxAmountBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ScheduleTransactionForm";
            this.Text = "Scheduled Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.uxWeekUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxAmountBox;
        private System.Windows.Forms.ComboBox uxCategoryPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxAddScheduledTransaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxDescriptionBox;
        private System.Windows.Forms.ListView uxScheduledTransactionListView;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader TakenOut;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button uxRemoveTransactionButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox uxOneTimeCheckBox;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.NumericUpDown uxWeekUpDown;
        private System.Windows.Forms.NumericUpDown uxMonthUpDown;
    }
}