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
        //The current user
        private string _username;

        //A list containing each scheduled transactions information
        private List<string> _scheduledTransactions; //Think about this more it is never returned to the main form

        //Used to track transaction id preventing duplicates
        private int _idCount = -1;

        /// <summary>
        /// Creates a new ScheduledTransactionForm
        /// </summary>
        /// <param name="username">The current user</param>
        public ScheduleTransactionForm(string username)
        {
            InitializeComponent();
            _scheduledTransactions = DataManager.getScheduledTransactions(username);
            _username = username;

            //This is used to make sure no ids are duplicated
            for (int i = 0; i < _scheduledTransactions.Count; i++)
            {
                int id = Convert.ToInt32(_scheduledTransactions[i].Split(',')[0]);
                if (id > _idCount) _idCount = id;
            }
            _idCount++;

            //Load categories
            List<string> categories = DataManager.getCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                uxCategoryPicker.Items.Add(categories[i]);
            }

            updateDisplay();
        }

        /// <summary>
        /// Update view to display all transaction that are going to be taken out at a later date.
        /// </summary>
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
                if (Convert.ToDateTime(info[4]) != Convert.ToDateTime(newDate))
                {
                    item.SubItems.Add(startDate.ToString());
                }
                else {
                    item.SubItems.Add("");
                }
                item.SubItems.Add(newDate.ToString());
                item.SubItems.Add(description.ToString());
                item.SubItems.Add(frequency);
                uxScheduledTransactionListView.Items.Add(item);
            }
        }


        /// <summary>
        /// This is the remove button, removes a selected scheduled transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (uxScheduledTransactionListView.SelectedItems.Count > 0)
            {
                ListViewItem item = uxScheduledTransactionListView.SelectedItems[0];

                int id = Convert.ToInt32(item.SubItems[0].Text);

                List<string> tempTransactions = new List<string>();
                for (int i = 0; i < _scheduledTransactions.Count; i++)
                {
                    int checkID = Convert.ToInt32(_scheduledTransactions[i].Split(',')[0]);
                    if (id == checkID)
                    {

                    }
                    else
                    {
                        tempTransactions.Add(_scheduledTransactions[i]);
                    }
                }
                _scheduledTransactions = tempTransactions;

                uxScheduledTransactionListView.Items.Remove(item);
                DataManager.saveScheduledTransactions(_scheduledTransactions, _username);
            }
        }

        /// <summary>
        /// Adds a new scheduled transaction to the user list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddScheduledTransaction_Click(object sender, EventArgs e)
        {
            int id = 1;
            double amount = Convert.ToDouble(uxAmountBox.Text);
            string description = uxDescriptionBox.Text;
            string category = uxCategoryPicker.Text;
            DateTime startDate = uxStartDate.Value;
            DateTime newDate = getNextDate(startDate);
            string frequency = getFrequency();
            string info = id + "," + amount + "," + description + "," + category + "," + startDate.ToString() + "," + newDate.ToString() + "," + frequency;
            _scheduledTransactions.Add(info);
            DataManager.saveScheduledTransactions(_scheduledTransactions,_username);
            updateDisplay();
        }
        
        /// <summary>
        /// Determine how often the scheduled transaction will be performed.
        /// </summary>
        /// <returns></returns>
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
            else
            {
                result = "0/0";
            }
            return result;
        }

        /// <summary>
        /// Gets the next date when a transaction should be performed
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns></returns>
        private DateTime getNextDate(DateTime startDate)
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
                newDate = newDate.AddDays(7 * weeks);
            }
            return newDate;
        }

        private void checkAdd(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxAmountBox.Text);
                if(uxDescriptionBox.Text.Length > 0)
                {
                    if (uxOneTimeCheckBox.Checked)
                    {
                        uxFrequencyWeeks.Text = "";
                        uxFrequencyMonths.Text = "";
                        uxFrequencyWeeks.Enabled = false;
                        uxFrequencyMonths.Enabled = false;
                        uxAddScheduledTransaction.Enabled = true;
                    }
                    else
                    {
                        uxFrequencyWeeks.Enabled = true;
                        uxFrequencyMonths.Enabled = true;
                        try
                        {
                            if (uxFrequencyWeeks.Text.Length > 0)
                            {
                                Convert.ToDouble(uxFrequencyWeeks.Text);
                                uxAddScheduledTransaction.Enabled = true;
                            }
                            else if (uxFrequencyMonths.Text.Length > 0)
                            {
                                Convert.ToDouble(uxFrequencyMonths.Text);
                                uxAddScheduledTransaction.Enabled = true;
                            }
                            else
                            {
                                uxAddScheduledTransaction.Enabled = false;
                            }
                        }
                        catch(Exception ex)
                        {
                            uxAddScheduledTransaction.Enabled = false;
                        }
                    }
                }
                else
                {
                    uxAddScheduledTransaction.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                uxAddScheduledTransaction.Enabled = false;
            }
        }

        /// <summary>
        /// Used to verify data given by user is in the correct format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void uxOneTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxOneTimeCheckBox.Checked)
            {
                //uxFrequencyMonths.Enabled = false;
                //uxFrequencyWeeks.Enabled = false;
                uxFrequencyMonths.Text = "";
                uxFrequencyWeeks.Text = "";
                try
                {
                    Convert.ToInt32(uxAmountBox.Text);
                    //uxAddScheduledTransaction.Enabled = true;
                }
                catch(Exception ex)
                {
                    //uxAddScheduledTransaction.Enabled = false;
                }
            }
            else
            {
                uxFrequencyMonths.Enabled = true;
                uxFrequencyWeeks.Enabled = true;
            }
        }
    }
}
