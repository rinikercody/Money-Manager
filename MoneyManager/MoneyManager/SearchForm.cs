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
        List<string> _userTransactions;
        public SearchForm(string username)
        {
            InitializeComponent();
            _userTransactions = DataManager.getTransactionInfo(username);
        }

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

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            uxSearchListView.Items.Clear();
            double checkAmount = 0.00;
            string keyword;
            string catagory;
       
            if (uxKeywordSearchBox.Text.Length > 0)
            {
                keyword = uxKeywordSearchBox.Text;
            }
            if (uxCatagorySearchBox.Text.Length > 0)
            {
                catagory = uxCatagorySearchBox.Text;
            }

            DateTime dt1 = uxStartDateSearch.Value;
            DateTime dt2 = uxEndDateSearch.Value;
            //Check in date value changed event if date 2 is after date 1

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

                if (uxCatagorySearchBox.Text.Length > 0)
                {
                    if (!info[4].Contains(uxCatagorySearchBox.Text))
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

                //updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
            }
        }

        private bool CheckDates(DateTime dt1, DateTime dt2, string [] info)
        {
            DateTime dt = Convert.ToDateTime(info[3]);
            if (dt >= dt1 && dt <= dt2)
            {
                return true;
            }
            return false;
        }

        private void amountCheck(string [] info)
        {

                double checkAmount = Convert.ToDouble(uxAmountSearchBox.Text);
                double amount = Convert.ToDouble(info[1]);
                if (uxAboveRadioButton.Checked)
                {
                    if (amount > checkAmount)
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
                else if (uxBelowRadioButton.Checked)
                {
                    if (amount < checkAmount)
                    {
                        updateSearchDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
                else if (uxRangeRadioButton.Checked)
                {
                    double range = Convert.ToDouble(uxRangeBox.Text);
                    if (amount < checkAmount + range && amount > checkAmount - range)
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
                uxSearchButton.Enabled = false;
            }
        }

        private void uxBelowRadioButton_CheckedChanged(object sender, EventArgs e)
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
