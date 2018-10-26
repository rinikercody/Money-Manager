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
        private List<string> _userGoals;

        public GoalsForm(string pathToGoals, string username)
        {
            InitializeComponent();
            _userGoals = DataManager.loadGoals(username);
            updateDisplay();
        }

        public void updateDisplay()
        {
            for(int i = 0; i < _userGoals.Count; i++)
            {
                ListViewItem item = new ListViewItem();
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

        private void uxAddGoalButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(uxGoalAmountBox.Text);
            string description = uxGoalDescriptionBox.Text;
            string date = uxGoalDate.Value.ToString();
            _userGoals.Add(amount + "," + description + "," + date);
            //DataManager.saveGoals(_)
        }
    }
}
