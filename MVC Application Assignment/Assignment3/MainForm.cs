using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment3.DatabaseTables;

namespace Assignment3
{
    public partial class ASRS : Form
    {
        public ASRS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void asrsTitle_Click(object sender, EventArgs e)
        {

        }

        private void officersButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AmbulanceOfficersForm a = new AmbulanceOfficersForm();
            a.ShowDialog();
            this.Visible = true;
        }

        public static void refresh_grid(DataGridView d)
        {
            using (StaffMembersContext db = new StaffMembersContext())
            {
                d.DataSource = db.StaffMembers.ToArray();
            }
        }

        private void ambulancesButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AmbulancesListForm a = new AmbulancesListForm();
            a.ShowDialog();
            this.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkRostersButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CheckRosterForm a = new CheckRosterForm();
            a.ShowDialog();
            this.Visible = true;
            
        }
    }
}
