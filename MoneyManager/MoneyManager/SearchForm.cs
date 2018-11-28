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
    public partial class SearchForm : Form
    {
        /// <summary>
        /// All the users transactions
        /// </summary>
        List<string> _userTransactions;

        /// <summary>
        /// Creates a new SearchForm
        /// </summary>
        /// <param name="username">The current user of the program</param>
        public SearchForm(string username)
        {
            InitializeComponent();
            _userTransactions = DataManager.getTransactionInfo(username);

            List<string> categories = DataManager.getCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                uxCatagoryPicker.Items.Add(categories[i]);
            }
            
        }

        /// <summary>
        /// Display all the transactions that fit the search criteria
        /// </summary>
        /// <param name="id">The transaction id</param>
        /// <param name="amount">The transaction amount</param>
        /// <param name="description">The transactions description</param>
        /// <param name="date">The date of the transaction</param>
        /// <param name="catagory">The catagory the transaction is in</param>
        public void updateSearchDisplay(int id, double amount, string description, string date, string catagory)
        {
            ListViewItem item = new ListViewItem();
            item.Text = amount.ToString("c"); //First column of list view is set to amount
            item.SubItems.Add(date);
            item.SubItems.Add(description);
            item.SubItems.Add(catagory);
            item.SubItems.Add(id.ToString());
            if (amount < 0)
            {
                item.ForeColor = Color.Red;
            }
            if (amount > 0)
            {
                item.ForeColor = Color.Green;
            }
            uxSearchListView.Items.Add(item);
        }

        /// <summary>
        /// Filters transaction based on serch criteria.
        /// Calls updateSearchDisplay several times.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            uxSearchListView.Items.Clear();
            string keyword;
            string catagory;
       
            if (uxKeywordSearchBox.Text.Length > 0)
            {
                keyword = uxKeywordSearchBox.Text;
            }
            if (uxCatagoryPicker.Text.Length > 0)
            {
                catagory = uxCatagoryPicker.Text;
            }

            DateTime dt1 = uxStartDateSearch.Value;
            DateTime dt2 = uxEndDateSearch.Value;

            for (int i = 0; i < _userTransactions.Count; i++)
            {
                string[] info = _userTransactions[i].Split(',');

                bool addResult = true;

                if (uxUseDatesBox.Checked)
                {
                    addResult = CheckDates(dt1, dt2, info);
                }

                if(uxKeywordSearchBox.Text.Length > 0)
                {
                    if (!info[2].Contains(uxKeywordSearchBox.Text))
                    {
                        addResult = false;
                    }
                }

                if (uxCatagoryPicker.Text.Length > 0)
                {
                    if (!info[4].Contains(uxCatagoryPicker.Text))
                    {
                        addResult = false;
                    }
                }

                if (addResult == true)
                {
                    if (uxAmountSearchBox.Text.Length > 0)
                    {
                        amountCheck(info);
                    }
                    else
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
            }
        }

        

        /// <summary>
        /// Check if transaction date is between start date and end date
        /// </summary>
        /// <param name="dt1">Start date</param>
        /// <param name="dt2">End date</param>
        /// <param name="info">Single transaction information</param>
        /// <returns></returns>
        private bool CheckDates(DateTime dt1, DateTime dt2, string [] info)
        {
            DateTime dt = Convert.ToDateTime(info[3]);
            
            if (dt.Date >= dt1.Date && dt.Date <= dt2.Date)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if the amount is below,above,the same, or withen a range depending on selected criteria.
        /// </summary>
        /// <param name="info">The transaction information</param>
        private void amountCheck(string [] info)
        {

                double checkAmount = Convert.ToDouble(uxAmountSearchBox.Text);
                double amount = Convert.ToDouble(info[1]);
                if (uxAboveRadioButton.Checked)
                {
                    if (amount >= checkAmount)
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
                else if (uxBelowRadioButton.Checked)
                {
                    if (amount <= checkAmount)
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
                else if (uxRangeRadioButton.Checked)
                {
                    double range;
                    try
                    {
                        range = Convert.ToDouble(uxRangeBox.Text);
                    }
                    catch(Exception ex)
                    {
                        range = 0;
                    }
                    
                    if (amount <= checkAmount + range && amount >= checkAmount - range)
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
                else
                { //Check only for amounts that are equal
                    if (checkAmount == amount)
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
        }

        /// <summary>
        /// Checks to see if amount box and range box are in the correct format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAmounts(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks to make sure the start date is before the end date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStartDateSearch_ValueChanged(object sender, EventArgs e)
        {
            if(uxStartDateSearch.Value < uxEndDateSearch.Value)
            {
                uxSearchButton.Enabled = true;
                if(uxAmountSearchBox.Text.Length > 0)
                {
                    try
                    {
                        Convert.ToDouble(uxAmountSearchBox.Text);
                        uxSearchButton.Enabled = true;
                        if(uxRangeBox.Text.Length > 0)
                        {
                            try
                            {
                                Convert.ToDouble(uxRangeBox.Text);
                                uxSearchButton.Enabled = true;
                            }
                            catch(Exception ex)
                            {
                                uxSearchButton.Enabled = false;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        uxSearchButton.Enabled = false;
                    }
                }
            }
            else
            {
                if (uxAmountSearchBox.Text.Length > 0)
                {
                    try
                    {
                        Convert.ToDouble(uxAmountSearchBox.Text);
                        uxSearchButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        uxSearchButton.Enabled = false;
                    }
                }
                //uxSearchButton.Enabled = false;
            }
        }

        /// <summary>
        /// Enable range box if rangeRadioButton is checked and disable if another radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (uxRangeRadioButton.Checked)
            {
                uxRangeBox.Enabled = true;
            }
            else
            {
                uxRangeBox.Enabled = false;
            }
        }

        /// <summary>
        /// Enables date selection if the user wants to use dates as criteria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxUseDatesBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxUseDatesBox.Checked)
            {
                uxStartDateSearch.Enabled = true;
                uxEndDateSearch.Enabled = true;
            }
            else
            {
                uxStartDateSearch.Enabled = false;
                uxEndDateSearch.Enabled = false;
            }
        }
    }
}
