namespace MoneyManager
{
    partial class SearchForm
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
            this.uxSearchListView = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxStartDateSearch = new System.Windows.Forms.DateTimePicker();
            this.uxEndDateSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.uxAmountSearchBox = new System.Windows.Forms.TextBox();
            this.uxKeywordSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxRangeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxBelowRadioButton = new System.Windows.Forms.RadioButton();
            this.uxAboveRadioButton = new System.Windows.Forms.RadioButton();
            this.uxRangeRadioButton = new System.Windows.Forms.RadioButton();
            this.uxUseDatesBox = new System.Windows.Forms.CheckBox();
            this.uxEqualRadioButton = new System.Windows.Forms.RadioButton();
            this.uxCatagoryPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxSearchListView
            // 
            this.uxSearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.Date,
            this.Description,
            this.Category,
            this.Id});
            this.uxSearchListView.FullRowSelect = true;
            this.uxSearchListView.GridLines = true;
            this.uxSearchListView.Location = new System.Drawing.Point(34, 230);
            this.uxSearchListView.Name = "uxSearchListView";
            this.uxSearchListView.Size = new System.Drawing.Size(718, 493);
            this.uxSearchListView.TabIndex = 0;
            this.uxSearchListView.UseCompatibleStateImageBehavior = false;
            this.uxSearchListView.View = System.Windows.Forms.View.Details;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 140;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 80;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // uxStartDateSearch
            // 
            this.uxStartDateSearch.Enabled = false;
            this.uxStartDateSearch.Location = new System.Drawing.Point(34, 134);
            this.uxStartDateSearch.Name = "uxStartDateSearch";
            this.uxStartDateSearch.Size = new System.Drawing.Size(270, 22);
            this.uxStartDateSearch.TabIndex = 1;
            this.uxStartDateSearch.ValueChanged += new System.EventHandler(this.uxStartDateSearch_ValueChanged);
            // 
            // uxEndDateSearch
            // 
            this.uxEndDateSearch.Enabled = false;
            this.uxEndDateSearch.Location = new System.Drawing.Point(343, 134);
            this.uxEndDateSearch.Name = "uxEndDateSearch";
            this.uxEndDateSearch.Size = new System.Drawing.Size(262, 22);
            this.uxEndDateSearch.TabIndex = 2;
            this.uxEndDateSearch.ValueChanged += new System.EventHandler(this.uxStartDateSearch_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by amount:";
            // 
            // uxAmountSearchBox
            // 
            this.uxAmountSearchBox.Location = new System.Drawing.Point(186, 14);
            this.uxAmountSearchBox.Name = "uxAmountSearchBox";
            this.uxAmountSearchBox.Size = new System.Drawing.Size(100, 22);
            this.uxAmountSearchBox.TabIndex = 4;
            this.uxAmountSearchBox.TextChanged += new System.EventHandler(this.uxStartDateSearch_ValueChanged);
            // 
            // uxKeywordSearchBox
            // 
            this.uxKeywordSearchBox.Location = new System.Drawing.Point(186, 43);
            this.uxKeywordSearchBox.Name = "uxKeywordSearchBox";
            this.uxKeywordSearchBox.Size = new System.Drawing.Size(298, 22);
            this.uxKeywordSearchBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by keyword:";
            // 
            // uxRangeBox
            // 
            this.uxRangeBox.Enabled = false;
            this.uxRangeBox.Location = new System.Drawing.Point(646, 14);
            this.uxRangeBox.Name = "uxRangeBox";
            this.uxRangeBox.Size = new System.Drawing.Size(100, 22);
            this.uxRangeBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search by Catagory:";
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(34, 174);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(718, 50);
            this.uxSearchButton.TabIndex = 15;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxBelowRadioButton
            // 
            this.uxBelowRadioButton.AutoSize = true;
            this.uxBelowRadioButton.Location = new System.Drawing.Point(390, 14);
            this.uxBelowRadioButton.Name = "uxBelowRadioButton";
            this.uxBelowRadioButton.Size = new System.Drawing.Size(66, 21);
            this.uxBelowRadioButton.TabIndex = 16;
            this.uxBelowRadioButton.Text = "Below";
            this.uxBelowRadioButton.UseVisualStyleBackColor = true;
            this.uxBelowRadioButton.CheckedChanged += new System.EventHandler(this.uxRangeRadioButton_CheckedChanged);
            // 
            // uxAboveRadioButton
            // 
            this.uxAboveRadioButton.AutoSize = true;
            this.uxAboveRadioButton.Location = new System.Drawing.Point(474, 14);
            this.uxAboveRadioButton.Name = "uxAboveRadioButton";
            this.uxAboveRadioButton.Size = new System.Drawing.Size(69, 21);
            this.uxAboveRadioButton.TabIndex = 17;
            this.uxAboveRadioButton.Text = "Above";
            this.uxAboveRadioButton.UseVisualStyleBackColor = true;
            this.uxAboveRadioButton.CheckedChanged += new System.EventHandler(this.uxRangeRadioButton_CheckedChanged);
            // 
            // uxRangeRadioButton
            // 
            this.uxRangeRadioButton.AutoSize = true;
            this.uxRangeRadioButton.Location = new System.Drawing.Point(560, 14);
            this.uxRangeRadioButton.Name = "uxRangeRadioButton";
            this.uxRangeRadioButton.Size = new System.Drawing.Size(71, 21);
            this.uxRangeRadioButton.TabIndex = 18;
            this.uxRangeRadioButton.Text = "Range";
            this.uxRangeRadioButton.UseVisualStyleBackColor = true;
            this.uxRangeRadioButton.CheckedChanged += new System.EventHandler(this.uxRangeRadioButton_CheckedChanged);
            // 
            // uxUseDatesBox
            // 
            this.uxUseDatesBox.AutoSize = true;
            this.uxUseDatesBox.Location = new System.Drawing.Point(646, 134);
            this.uxUseDatesBox.Name = "uxUseDatesBox";
            this.uxUseDatesBox.Size = new System.Drawing.Size(96, 21);
            this.uxUseDatesBox.TabIndex = 19;
            this.uxUseDatesBox.Text = "Use Dates";
            this.uxUseDatesBox.UseVisualStyleBackColor = true;
            this.uxUseDatesBox.CheckedChanged += new System.EventHandler(this.uxUseDatesBox_CheckedChanged);
            // 
            // uxEqualRadioButton
            // 
            this.uxEqualRadioButton.AutoSize = true;
            this.uxEqualRadioButton.Checked = true;
            this.uxEqualRadioButton.Location = new System.Drawing.Point(312, 14);
            this.uxEqualRadioButton.Name = "uxEqualRadioButton";
            this.uxEqualRadioButton.Size = new System.Drawing.Size(63, 21);
            this.uxEqualRadioButton.TabIndex = 20;
            this.uxEqualRadioButton.TabStop = true;
            this.uxEqualRadioButton.Text = "Exact";
            this.uxEqualRadioButton.UseVisualStyleBackColor = true;
            // 
            // uxCatagoryPicker
            // 
            this.uxCatagoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCatagoryPicker.FormattingEnabled = true;
            this.uxCatagoryPicker.Location = new System.Drawing.Point(186, 75);
            this.uxCatagoryPicker.Name = "uxCatagoryPicker";
            this.uxCatagoryPicker.Size = new System.Drawing.Size(298, 24);
            this.uxCatagoryPicker.TabIndex = 27;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(779, 735);
            this.Controls.Add(this.uxCatagoryPicker);
            this.Controls.Add(this.uxEqualRadioButton);
            this.Controls.Add(this.uxUseDatesBox);
            this.Controls.Add(this.uxRangeRadioButton);
            this.Controls.Add(this.uxAboveRadioButton);
            this.Controls.Add(this.uxBelowRadioButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxRangeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxKeywordSearchBox);
            this.Controls.Add(this.uxAmountSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxEndDateSearch);
            this.Controls.Add(this.uxStartDateSearch);
            this.Controls.Add(this.uxSearchListView);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxSearchListView;
        private System.Windows.Forms.DateTimePicker uxStartDateSearch;
        private System.Windows.Forms.DateTimePicker uxEndDateSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxAmountSearchBox;
        private System.Windows.Forms.TextBox uxKeywordSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxRangeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.RadioButton uxBelowRadioButton;
        private System.Windows.Forms.RadioButton uxAboveRadioButton;
        private System.Windows.Forms.RadioButton uxRangeRadioButton;
        private System.Windows.Forms.CheckBox uxUseDatesBox;
        private System.Windows.Forms.RadioButton uxEqualRadioButton;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ComboBox uxCatagoryPicker;
    }
}