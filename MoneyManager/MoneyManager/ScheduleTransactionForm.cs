using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MoneyManager
{
    public partial class ScheduleTransactionForm : Form
    {
        private string _pathToScheduledTransactions;
        private string _username;
        private List<string> _scheduledTransactions; //Think about this more it is never returned to the main form

        public ScheduleTransactionForm(string pathToScheduledTransactions, string username)
        {
            InitializeComponent();
            _pathToScheduledTransactions = pathToScheduledTransactions;
            _scheduledTransactions = DataManager.getScheduledTransactions(username);
            _username = username;

            //Load categories
            List<string> categories = DataManager.getCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                uxCategoryPicker.Items.Add(categories[i]);
            }

            updateDisplay();
        }

        private void updateDisplay()
        {
            uxScheduledTransactionListView.Items.Clear();
            string[] info;
            for(int i = 0; i < _scheduledTransactions.Count; i++)
            {
                info = _scheduledTransactions[i].Split(',');
                int id = Convert.ToInt32(info[0]);
                double amount = Convert.ToDouble(info[1]);
                string description = info[2];
                string category = info[3];
                string startDate = info[4];
                string newDate = info[5];
                string frequency = info[6];
                ListViewItem item = new ListViewItem();
                item.Text = ("1");
                item.SubItems.Add(amount.ToString());
                item.SubItems.Add(startDate.ToString());
                item.SubItems.Add(newDate.ToString());
                item.SubItems.Add(description.ToString());
                item.SubItems.Add(frequency);
                uxScheduledTransactionListView.Items.Add(item);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void uxAddScheduledTransaction_Click(object sender, EventArgs e)
        {
            int id = 1;
            double amount = Convert.ToDouble(uxAmountBox.Text);
            string description = uxDescriptionBox.Text;
            string category = uxCategoryPicker.Text;
            DateTime startDate = uxStartDate.Value;
            DateTime newDate = getNextDay(startDate);
            string frequency = getFrequency();
            string info = id + "," + amount + "," + description + "," + category + "," + startDate.ToString() + "," + newDate.ToString() + "," + frequency;
            _scheduledTransactions.Add(info);
            DataManager.saveScheduledTransactions(_scheduledTransactions,_username);
            updateDisplay();
        }
        
        private string getFrequency()
        {
            string result = "";
            if (uxFrequencyMonths.Text.Length > 0)
            {
                result += uxFrequencyMonths.Text;// + "M";
            }
            if (uxFrequencyWeeks.Text.Length > 0)
            {
                result += "/" + uxFrequencyWeeks.Text;// + "W";
            }
            return result;
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
