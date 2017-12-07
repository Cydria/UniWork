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
    public partial class CheckRosterForm : Form
    {
        string staffMemberDetails;
        int memberCount;
        bool hasIntOrAdv;

        public CheckRosterForm()
        {
            InitializeComponent();
            using (AmbulancesContext db = new AmbulancesContext())
            {
                foreach (var x in db.Ambulances)
                {
                    CheckRosterControl cr = new CheckRosterControl();
                    cr.ambulanceID = x.ambulance_ID;
                    cr.changeLabel(x.ambulance_ID);

                    using (StaffMembersContext db2 = new StaffMembersContext())
                    {
                        foreach (var a in db2.StaffMembers)
                        {
                            if (x.ambulance_ID == a.assigned_ambulance)
                            {
                                staffMemberDetails = (a.officer_ID + " (" + a.skill_level + ") \n");
                                memberCount += 1;
                                if (a.skill_level.Contains("Intermediate") || a.skill_level.Contains("Advanced"))
                                {
                                    hasIntOrAdv = true;
                                }
                                cr.populateTextBox(staffMemberDetails);

                            }
                        }
                    }
                    if ((memberCount == 3 || memberCount == 2) && hasIntOrAdv)
                    {
                        cr.setBackColour(Color.OliveDrab);
                        memberCount = 0;
                        hasIntOrAdv = false;
                    } else
                    {
                        cr.setBackColour(Color.Red);
                        memberCount = 0;
                        hasIntOrAdv = false;
                    }
                    checkRosterLayout.Controls.Add(cr);

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
