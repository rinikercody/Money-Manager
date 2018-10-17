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
        public GoalsForm(List<string> userGoals)
        {
            InitializeComponent();
            _userGoals = userGoals;
        }

        public void updateDisplay()
        {
            for(int i = 0; i < _userGoals.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                string[] info = _userGoals[i].Split(',');
                item.SubItems.Add(info[0]);
                item.SubItems.Add(info[1]);
                item.SubItems.Add(info[2]);
            }
        }
    }
}
