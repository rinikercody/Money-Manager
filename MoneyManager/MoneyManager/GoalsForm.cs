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
    public partial class GoalsForm : Form
    {
        //All the current users goals in text format.
        private List<string> _userGoals;

        //The current user
        private string _username;

        /// <summary>
        /// Create a new GoalsForm
        /// </summary>
        /// <param name="username">The current user</param>
        public GoalsForm(string username)
        {
            InitializeComponent();
            _userGoals = DataManager.loadGoals(username); //Get users goals.
            _username = username;
            updateDisplay();
        }

        /// <summary>
        /// Update GoalsForm with the all the users current goals
        /// </summary>
        public void updateDisplay()
        {
            uxGoalsListView.Items.Clear();
            for(int i = 0; i < _userGoals.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                if(i <= 2)
                {
                    item.ForeColor = Color.Red;
                }
                else if(i > 2 && i <= 5)
                {
                    item.ForeColor = Color.Orange;
                }
                else
                {
                    item.ForeColor = Color.Blue;
                }
                string[] info = _userGoals[i].Split(',');
                double amount = Convert.ToDouble(info[0]);
                item.Text = amount.ToString("c");
                item.SubItems.Add(info[1]);
                item.SubItems.Add(info[2]);
                uxGoalsListView.Items.Add(item);
                //Want to highlight nearest goals
            }
        }

        private void GoalsForm_Load(object sender, EventArgs e)
        {

        }

        private void checkGoal(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxGoalAmountBox.Text);
                if(uxGoalDescriptionBox.Text.Length > 0)
                {
                    TimeSpan ts = new TimeSpan(6, 0, 0, 0); //A little less than a week
                    if (uxGoalDate.Value > DateTime.Now + ts)
                    {
                        uxAddGoalButton.Enabled = true;
                    }
                    else
                    {
                        uxAddGoalButton.Enabled = false;
                    }
                }
                else
                {
                    uxAddGoalButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                uxAddGoalButton.Enabled = false;
            }
        }

        /// <summary>
        /// Add a new goal to the users current goal list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddGoalButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(uxGoalAmountBox.Text);
            string description = uxGoalDescriptionBox.Text;
            //string date = uxGoalDate.Value.ToString();
            //_userGoals.Add(amount + "," + description + "," + date);
            //DataManager.saveGoals(_userGoals, _username);



            DateTime goalDate = uxGoalDate.Value;
            string saveInfo = amount + "," + description + "," + goalDate.ToString();


            if (_userGoals.Count == 0)
            {
                _userGoals.Add(saveInfo);
            }
            else if (goalDate >= Convert.ToDateTime(_userGoals[_userGoals.Count - 1].Split(',')[2]))
            {
                _userGoals.Add(saveInfo);
            }
            else
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < _userGoals.Count; i++)
                {
                    DateTime date = Convert.ToDateTime(_userGoals[i].Split(',')[2]);

                    if (goalDate < date)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            temp.Add(_userGoals[j]);
                        }

                        temp.Add(saveInfo);

                        for (int j = i; j < _userGoals.Count; j++)
                        {
                            temp.Add(_userGoals[j]);
                        }
                        break;
                    }
                }
                _userGoals = temp;
            }
            DataManager.saveGoals(_userGoals, _username);
            updateDisplay();
        }

        /// <summary>
        /// Remove a goal from the users current goal list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRemoveGoalButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = uxGoalsListView.SelectedItems[0];
            List<string> temp = new List<string>();
            for(int i = 0; i < _userGoals.Count; i++)
            {
                if (i != item.Index)
                {
                    temp.Add(_userGoals[i]);
                }
            }
            _userGoals = temp;
            DataManager.saveGoals(_userGoals, _username);
            updateDisplay();
        }

        /// <summary>
        /// Make sure the user has selected a goal before being allowed to press the remove button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGoalsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxGoalsListView.SelectedItems.Count > 0)
            {
                uxRemoveGoalButton.Enabled = true;
            }
            else
            {
                uxRemoveGoalButton.Enabled = false;
            }
        }
    }
}
