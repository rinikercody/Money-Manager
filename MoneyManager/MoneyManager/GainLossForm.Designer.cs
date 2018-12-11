namespace MoneyManager
{
    partial class GainLossForm
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
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.uxEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.uxGainLoseListView = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Net = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxUseDatesBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxNetAmountLabel = new System.Windows.Forms.Label();
            this.uxLossAmountLabel = new System.Windows.Forms.Label();
            this.uxGainAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxStartDate
            // 
            this.uxStartDate.Enabled = false;
            this.uxStartDate.Location = new System.Drawing.Point(16, 92);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(250, 22);
            this.uxStartDate.TabIndex = 0;
            this.uxStartDate.ValueChanged += new System.EventHandler(this.uxUseDatesBox_CheckedChanged);
            // 
            // uxEndDate
            // 
            this.uxEndDate.Enabled = false;
            this.uxEndDate.Location = new System.Drawing.Point(347, 89);
            this.uxEndDate.Name = "uxEndDate";
            this.uxEndDate.Size = new System.Drawing.Size(253, 22);
            this.uxEndDate.TabIndex = 1;
            this.uxEndDate.ValueChanged += new System.EventHandler(this.uxUseDatesBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Totals:";
            // 
            // uxGainLoseListView
            // 
            this.uxGainLoseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.Gain,
            this.Loss,
            this.Net});
            this.uxGainLoseListView.GridLines = true;
            this.uxGainLoseListView.Location = new System.Drawing.Point(16, 130);
            this.uxGainLoseListView.Name = "uxGainLoseListView";
            this.uxGainLoseListView.Size = new System.Drawing.Size(757, 567);
            this.uxGainLoseListView.TabIndex = 3;
            this.uxGainLoseListView.UseCompatibleStateImageBehavior = false;
            this.uxGainLoseListView.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.Text = "Catergory";
            this.Category.Width = 100;
            // 
            // Gain
            // 
            this.Gain.Text = "Gain";
            this.Gain.Width = 100;
            // 
            // Loss
            // 
            this.Loss.Text = "Loss";
            this.Loss.Width = 100;
            // 
            // Net
            // 
            this.Net.Text = "Net";
            this.Net.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date:";
            // 
            // uxUseDatesBox
            // 
            this.uxUseDatesBox.AutoSize = true;
            this.uxUseDatesBox.Location = new System.Drawing.Point(677, 92);
            this.uxUseDatesBox.Name = "uxUseDatesBox";
            this.uxUseDatesBox.Size = new System.Drawing.Size(96, 21);
            this.uxUseDatesBox.TabIndex = 6;
            this.uxUseDatesBox.Text = "Use Dates";
            this.uxUseDatesBox.UseVisualStyleBackColor = true;
            this.uxUseDatesBox.CheckedChanged += new System.EventHandler(this.uxUseDatesBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loss:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Net:";
            // 
            // uxNetAmountLabel
            // 
            this.uxNetAmountLabel.AutoSize = true;
            this.uxNetAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNetAmountLabel.Location = new System.Drawing.Point(590, 33);
            this.uxNetAmountLabel.Name = "uxNetAmountLabel";
            this.uxNetAmountLabel.Size = new System.Drawing.Size(64, 25);
            this.uxNetAmountLabel.TabIndex = 10;
            this.uxNetAmountLabel.Text = "label7";
            // 
            // uxLossAmountLabel
            // 
            this.uxLossAmountLabel.AutoSize = true;
            this.uxLossAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLossAmountLabel.Location = new System.Drawing.Point(352, 33);
            this.uxLossAmountLabel.Name = "uxLossAmountLabel";
            this.uxLossAmountLabel.Size = new System.Drawing.Size(64, 25);
            this.uxLossAmountLabel.TabIndex = 11;
            this.uxLossAmountLabel.Text = "label8";
            // 
            // uxGainAmountLabel
            // 
            this.uxGainAmountLabel.AutoSize = true;
            this.uxGainAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGainAmountLabel.Location = new System.Drawing.Point(126, 33);
            this.uxGainAmountLabel.Name = "uxGainAmountLabel";
            this.uxGainAmountLabel.Size = new System.Drawing.Size(64, 25);
            this.uxGainAmountLabel.TabIndex = 12;
            this.uxGainAmountLabel.Text = "label9";
            // 
            // GainLossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.uxGainAmountLabel);
            this.Controls.Add(this.uxLossAmountLabel);
            this.Controls.Add(this.uxNetAmountLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxUseDatesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxGainLoseListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxEndDate);
            this.Controls.Add(this.uxStartDate);
            this.MaximizeBox = false;
            this.Name = "GainLossForm";
            this.Text = "Gain Loss Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.DateTimePicker uxEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView uxGainLoseListView;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Gain;
        private System.Windows.Forms.ColumnHeader Loss;
        private System.Windows.Forms.ColumnHeader Net;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox uxUseDatesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uxNetAmountLabel;
        private System.Windows.Forms.Label uxLossAmountLabel;
        private System.Windows.Forms.Label uxGainAmountLabel;
    }
}