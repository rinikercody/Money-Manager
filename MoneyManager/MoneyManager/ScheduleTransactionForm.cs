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
        private int _idCount;

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
                DateTime newDate = Convert.ToDateTime(info[5]);
                string frequency = info[6];
                ListViewItem item = new ListViewItem();
                
                item.Text = amount.ToString();
                if(Convert.ToDateTime(info[4]).Date >= DateTime.Now.Date)
                {
                    item.SubItems.Add("");
                }
                else
                {
                    DateTime dt = Convert.ToDateTime(info[4]);
                    item.SubItems.Add(dt.ToString("MM/dd/yyyy"));
                }
                
                item.SubItems.Add(newDate.ToString("MM/dd/yyyy"));
                item.SubItems.Add(description.ToString());
                item.SubItems.Add(frequency);
                item.SubItems.Add(id.ToString());
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

                int id = Convert.ToInt32(item.SubItems[5].Text);

                List<string> tempTransactions = new List<string>();
                for (int i = 0; i < _scheduledTransactions.Count; i++)
                {
                    int checkID = Convert.ToInt32(_scheduledTransactions[i].Split(',')[0]);
                    //MessageBox.Show(checkID + "  " + id);
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
            int id = _idCount;
            double amount = Convert.ToDouble(uxAmountBox.Text);
            string description = uxDescriptionBox.Text;
            string category = uxCategoryPicker.Text;
            DateTime startDate = uxStartDate.Value;
            //DateTime startDate = new DateTime(2018, 11, 1);
            DateTime newDate = getNextDate(uxStartDate.Value);
            //DateTime newDate = uxStartDate.Value;
            //DateTime newDate = getNextDate(startDate);
            string frequency = getFrequency();

            string info = "";
            if (startDate.Date > DateTime.Now)
            {
                info = id + "," + amount + "," + description + "," + category + "," + startDate.ToString() + "," + startDate.ToString() + "," + frequency;
            }
            else
            {
                info = id + "," + amount + "," + description + "," + category + "," + startDate.ToString() + "," + newDate.ToString() + "," + frequency;
            }
                //_scheduledTransactions.Add(info);

            //If there are currently no transaction for the user.
            //Or the transaction date of the one being added is after all the previous transaction dates.
            if (_scheduledTransactions.Count == 0 || newDate >= Convert.ToDateTime(_scheduledTransactions[_scheduledTransactions.Count - 1].Split(',')[5]))
            {
                _scheduledTransactions.Add(info);
            }
            else //Add the transaction in the approiate spot according to date.
            {
                List<string> tempList = new List<string>(); //A temporay list used to transfer inforation
                for (int i = 0; i < _scheduledTransactions.Count; i++)
                {
                    //If the new transactions date is lower than date i.
                    if (newDate < Convert.ToDateTime(_scheduledTransactions[i].Split(',')[5]))
                    {
                        //Copy all transactions before date to temp list
                        for (int j = 0; j < i; j++)
                        {
                            tempList.Add(_scheduledTransactions[j]);
                        }

                        //Add new transation info in the correct spot
                        tempList.Add(info);

                        //Copy the rest of the transaction over.
                        for (int j = i; j < _scheduledTransactions.Count; j++)
                        {
                            tempList.Add(_scheduledTransactions[j]);
                        }

                        //transaction is in correct spot so exit loop
                        break;
                    }
                }
                //_userTransactions now equals the updated list with the new transaction.
                _scheduledTransactions = tempList;
            }

            DataManager.saveScheduledTransactions(_scheduledTransactions,_username);
            _idCount++;
            updateDisplay();
        }
        
        
        /// <summary>
        /// Determine how often the scheduled transaction will be performed.
        /// </summary>
        /// <returns></returns>
        private string getFrequency()
        {
            string result = "";

            if (uxMonthUpDown.Enabled)
            {
                result += uxMonthUpDown.Value + "/";// + "M";
            }
            else
            {
                result += "0/"; 
            }

            if (uxWeekUpDown.Enabled)
            {
                result += uxWeekUpDown.Value;// + "W";
            }
            else
            {
                result += "0";
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
            if(uxMonthUpDown.Enabled)
            {
                int months = Convert.ToInt32(uxMonthUpDown.Value);
                newDate = newDate.AddMonths(months);
            }
            if (uxWeekUpDown.Enabled)
            {
                int weeks = Convert.ToInt32(uxWeekUpDown.Value);
                newDate = newDate.AddDays(7 * weeks);
            }
            return newDate;
        }

        /// <summary>
        /// Determines if the scheduled transaction can be added based on given input and enables/disables buttons accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAdd(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxAmountBox.Text);
                //if (uxStartDate.Value > DateTime.Now.Date)
                //{
                    if (uxDescriptionBox.Text.Length > 0)
                    {
                        if (uxOneTimeCheckBox.Checked)
                        {
                            uxWeekUpDown.Value = 0;
                            uxWeekUpDown.Enabled = false;
                            uxMonthUpDown.Value = 0;
                            uxMonthUpDown.Enabled = false;
                            uxAddScheduledTransaction.Enabled = true;
                        }
                        else
                        {
                            uxWeekUpDown.Enabled = true;
                            uxMonthUpDown.Enabled = true;
                            try
                            {
                                if (uxWeekUpDown.Enabled)
                                {
                                    uxAddScheduledTransaction.Enabled = true;
                                }
                                else
                                {
                                    uxAddScheduledTransaction.Enabled = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                uxAddScheduledTransaction.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        uxAddScheduledTransaction.Enabled = false;
                    }
                /*}
                else
                {
                    uxAddScheduledTransaction.Enabled = false;
                }*/
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
            if (uxWeekUpDown.Enabled)
            {
                try
                {
                    int weeks = Convert.ToInt32(uxWeekUpDown.Value);
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

            if(uxMonthUpDown.Enabled)
            {
                try
                {
                    int months = Convert.ToInt32(uxMonthUpDown);
                    check = (check && true);
                }
                catch (Exception ex)
                {
                    check = false;
                }
            }
           
            uxAddScheduledTransaction.Enabled = check;
        }

        /// <summary>
        /// Enables frequency controls depending on if the one time box is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOneTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxOneTimeCheckBox.Checked)
            {
                //uxFrequencyMonths.Enabled = false;
                //uxFrequencyWeeks.Enabled = false;
                uxMonthUpDown.Value = 0;
                uxWeekUpDown.Value = 0;
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
                uxWeekUpDown.Enabled = true;
                uxMonthUpDown.Enabled = true;
            }
        }

        /// <summary>
        /// Helps with removing of scheduled transactions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxScheduledTransactionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxScheduledTransactionListView.SelectedItems.Count > 0)
            {
                uxRemoveTransactionButton.Enabled = true;
            }
            else
            {
                uxRemoveTransactionButton.Enabled = false;
            }
        }

        /// <summary>
        /// Used to check frequency info. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxMonthUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(uxMonthUpDown.Value == 0 && uxWeekUpDown.Value == 0)
            {
                uxOneTimeCheckBox.Checked = true;
                uxMonthUpDown.Enabled = false;
                uxWeekUpDown.Enabled = false;
            }
        }
    }
}
