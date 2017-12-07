using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment3.DatabaseTables;

namespace Assignment3
{
    public partial class AddOfficerForm : Form
    {
        public string id;
        public string name;

        public AddOfficerForm()
        {
            InitializeComponent();

            using (AmbulancesContext db = new AmbulancesContext())
            {
                foreach (var x in db.Ambulances)
                {
                    ambulanceCBX.Items.Add(x.ambulance_ID);
                }
            }
            ambulanceCBX.Sorted = false;
            ambulanceCBX.Items.Insert(0, "None");
            ambulanceCBX.SelectedIndex = ambulanceCBX.Items.IndexOf("None");
        }

        private void Officer_Load(object sender, EventArgs e)
        {

        }

        private void OfficerForm_Shown(object sender, EventArgs e)
        {
            if (name == null || id == null)
            {
                return;
            }
            else
            {
                ambulanceOfficerLabel.Text = ("Ambulance Officer: " + this.name);
                using (StaffMembersContext db = new StaffMembersContext())
                {
                    var sm = db.StaffMembers.Where(x => x.officer_ID == this.id).First();
                    firstNamesBox.Text = sm.first_name;
                    surnameBox.Text = sm.surname;
                    officerIDBox.Text = sm.officer_ID;
                    skillLevelCB.SelectedIndex = skillLevelCB.FindString(sm.skill_level);
                    ambulanceCBX.SelectedIndex = ambulanceCBX.FindString(sm.assigned_ambulance);
                }
            }
        }

        private void ambulanceOfficerLabel_Click(object sender, EventArgs e)
        {

        }

        private void officerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNamesLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(firstNamesBox.Text)))
            {
                MessageBox.Show("First name is a required field.");
            }

            else if ((string.IsNullOrEmpty(surnameBox.Text)))
            {
                MessageBox.Show("Surname is a required field.");
            }

            else if (officerIDBox.Text.Length != 6 || !Regex.IsMatch(officerIDBox.Text, @"\d"))
            {
                MessageBox.Show("Officer ID must be a six digit number.");
            }
            else 
            {

                if (id == null)
                {
                    StaffMember sm1 = new StaffMember
                    {
                        first_name = firstNamesBox.Text,
                        surname = surnameBox.Text,
                        officer_ID = officerIDBox.Text,
                        skill_level = skillLevelCB.Text,
                        assigned_ambulance = ambulanceCBX.Text
                    };


                    using (StaffMembersContext db = new StaffMembersContext())
                    {
                        db.StaffMembers.Add(sm1);
                        db.SaveChanges();
                    }
                }
                else if (id != null)
                {

                    using (StaffMembersContext db = new StaffMembersContext())
                    {
                        var sm = db.StaffMembers.Where(x => x.officer_ID == this.id).First();
                        sm.surname = surnameBox.Text;
                        sm.first_name = firstNamesBox.Text;
                        sm.officer_ID = officerIDBox.Text;
                        sm.skill_level = skillLevelCB.Text;
                        sm.assigned_ambulance = ambulanceCBX.Text;

                        db.Database.ExecuteSqlCommand("DELETE FROM StaffMember WHERE officer_ID = {0};", this.id);
                    }

                    StaffMember sm1 = new StaffMember
                    {
                        first_name = firstNamesBox.Text,
                        surname = surnameBox.Text,
                        officer_ID = officerIDBox.Text,
                        skill_level = skillLevelCB.Text,
                        assigned_ambulance = ambulanceCBX.Text
                    };

                    using (StaffMembersContext db = new StaffMembersContext())
                    {
                        db.StaffMembers.Add(sm1);
                        db.SaveChanges();
                    }


                }
                this.Close();

            }


        }

        private void ambulanceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
