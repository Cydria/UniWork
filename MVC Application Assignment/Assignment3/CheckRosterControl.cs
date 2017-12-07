using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment3.DatabaseTables;

namespace Assignment3
{
    public partial class CheckRosterControl : UserControl
    {
        public string ambulanceID;
        public CheckRosterControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void changeLabel(string s)
        {
            ambulanceIDLabel.Text = s;
        }

        public void populateTextBox(string s)
        {
            crewMemberBox.AppendText(s);
        }

        public void setBackColour(Color c)
        {
            BackColor = c;
        }
    }
}
