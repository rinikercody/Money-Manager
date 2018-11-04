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
    public partial class GainLossForm : Form
    {
        //The current user
        private string _username;

        //All the currently available categories that transactions can be.
        private List<string> _categories = new List<string>();

        //All the users transactions in text format
        private List<string> _userTransactions = new List<string>();

        /// <summary>
        /// Creates a new GainLossForm
        /// </summary>
        /// <param name="username">The current user</param>
        public GainLossForm(string username)
        {
            InitializeComponent();
            _username = username;
            _categories = DataManager.getCategories();
            _userTransactions = DataManager.getTransactionInfo(_username);
            uxGainAmountLabel.ForeColor = Color.Green;
            uxLossAmountLabel.ForeColor = Color.Red;
            updateDisplay();
        }

        /// <summary>
        /// Update the display to show all gain loss information for the current user
        /// </summary>
        public void updateDisplay()
        {
            uxGainLoseListView.Items.Clear();
            double totalGain = 0;
            double totalLoss = 0;
            for(int i = 0; i < _categories.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _categories[i];
                item.UseItemStyleForSubItems = false;
                double[] gl = new double [2];
                if (uxUseDatesBox.Checked)
                {
                    gl = getGainLoss(_categories[i], uxStartDate.Value, uxEndDate.Value); //CONSIDER DATES
                }
                else
                {
                    gl = getGainLoss(_categories[i]);
                }
                item.SubItems.Add(gl[1].ToString("c"));
                item.SubItems.Add(gl[0].ToString("c"));
                totalGain += gl[1];
                totalLoss += gl[0];
                double net = gl[1] + gl[0];
                item.SubItems.Add(net.ToString("c"));
                item.SubItems[1].ForeColor = Color.Green;
                item.SubItems[2].ForeColor = Color.Red;
                if(net < 0)
                {
                    item.SubItems[3].ForeColor = Color.Red;
                }
                else
                {
                    item.SubItems[3].ForeColor = Color.Green;
                }

                uxGainLoseListView.Items.Add(item);

                
                
            }
            uxGainAmountLabel.Text = totalGain.ToString("c");
            uxLossAmountLabel.Text = totalLoss.ToString("c");
            double totalNet = totalGain + totalLoss;
            if(totalNet < 0)
            {
                uxNetAmountLabel.ForeColor = Color.Red;
            }
            else
            {
                uxNetAmountLabel.ForeColor = Color.Green;
            }
            uxNetAmountLabel.Text = totalNet.ToString("c");
        }

        public double[] getGainLoss(string category)
        {
            double[] gl = new double[2];
            for (int i = 0; i < _userTransactions.Count; i++)
            {
                string[] info = _userTransactions[i].Split(',');
                if (info[4] == category)
                {
                    double d = Convert.ToDouble(info[1]);
                    if (d < 0)
                    {
                        gl[0] += d;
                    }
                    if (d > 0)
                    {
                        gl[1] += d;
                    }
                }
            }
            return gl;
        }

        /// <summary>
        /// Gets the amount of money spent and gained over a specified time period
        /// </summary>
        /// <param name="dt1">Start date</param>
        /// <param name="dt2">End date</param>
        /// <returns>A dobule array with [0] being loss and [1] being gain</returns>
        public double[] getGainLoss(string category,DateTime dt1, DateTime dt2)
        {
            double[] gl = new double[2];
            gl[0] = 0;
            gl[1] = 0;

            for (int i = 0; i < _userTransactions.Count; i++)
            {
                string[] info = _userTransactions[i].Split(',');
                DateTime dt3 = Convert.ToDateTime(info[3]);
                if (dt3 > dt1 && dt3 < dt2)
                {
                    if (info[4] == category)
                    {
                        double d = Convert.ToDouble(info[1]);
                        if (d < 0)
                        {
                            gl[0] += d;
                        }
                        if (d > 0)
                        {
                            gl[1] += d;
                        }
                    }
                }
            }
            return gl;
        }

        private void uxUseDatesBox_CheckedChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
