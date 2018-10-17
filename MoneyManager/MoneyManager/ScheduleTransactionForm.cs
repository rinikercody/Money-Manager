using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class ScheduleTransactionForm : Form
    {
        public ScheduleTransactionForm()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void uxAddScheduledTransaction_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(uxAmountBox.Text);
            string description = uxDescriptionBox.Text;
            string category = uxCategoryPicker.Text;
            DateTime startDate = uxStartDate.Value;
            DateTime newDate = getNextDay(startDate);
            ListViewItem item = new ListViewItem();
            item.Text = ("1");
            item.SubItems.Add(amount.ToString());
            item.SubItems.Add(startDate.ToString());
            item.SubItems.Add(newDate.ToString());
            item.SubItems.Add(description.ToString());
            uxScheduledTransactionListView.Items.Add(item);
        }
        
        private DateTime getNextDay(DateTime startDate)
        {
            DateTime newDate = startDate;
            if(uxFrequencyMonths.Text.Length > 0)
            {
                int months = Convert.ToInt32(uxFrequencyMonths.Text);
                newDate = newDate.AddMonths(months);
            }
            if (uxFrequencyWeeks.Text.Length > 0)
            {
                int weeks = Convert.ToInt32(uxFrequencyWeeks.Text);
                newDate = newDate.AddDays(7);
            }
            return newDate;
        }
        
        private void saveScheduledTransaction(string username)
        {

        }

        private void uxFrequencyWeeks_TextChanged(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                Convert.ToDouble(uxAmountBox.Text);
                check = true;
            }
            catch(Exception ex)
            {
                check = false;
            }
            if (uxFrequencyWeeks.Text.Length > 0)
            {
                try
                {
                    int weeks = Convert.ToInt32(uxFrequencyWeeks.Text);
                    if (weeks > 0 && weeks < 4)
                    {
                        check = (check && true);
                    }
                }
                catch (Exception ex)
                {
                    check = false;
                }
            }

            if(uxFrequencyMonths.Text.Length > 0)
            {
                try
                {
                    int months = Convert.ToInt32(uxFrequencyMonths.Text);
                    check = (check && true);
                }
                catch (Exception ex)
                {
                    check = false;
                }
            }

            if(uxFrequencyMonths.Text.Length == 0 && uxFrequencyWeeks.Text.Length == 0)
            {
                check = false;
            }

            uxAddScheduledTransaction.Enabled = check;
        }
    }
}
