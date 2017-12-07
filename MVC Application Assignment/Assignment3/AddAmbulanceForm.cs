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
    public partial class AddAmbulanceForm : Form
    {
        public string id;
        public string station;

        public AddAmbulanceForm()
        {
            InitializeComponent();

            using (AmbulancesContext db = new AmbulancesContext())
            {
                foreach (var x in db.Ambulances)
                {
                    addAmbulanceCBX.Items.Add(x.station);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ambulanceIDBox.Text.Length < 2 || !ambulanceIDBox.Text.StartsWith("A") || ambulanceIDBox.Text.Length > 4)
            {
                MessageBox.Show("Ambulance ID must consist of an A followed by a number");
            }
            else
            {
                if (id == null)
                {
                    Ambulance am1 = new Ambulance
                    {
                        ambulance_ID = ambulanceIDBox.Text,
                        station = addAmbulanceCBX.Text
                    };

                    using (AmbulancesContext db = new AmbulancesContext())
                    {
                        db.Ambulances.Add(am1);
                        db.SaveChanges();
                    }
                }
                else if (id != null)
                {
                    using (AmbulancesContext db = new AmbulancesContext())
                    {
                        db.Database.ExecuteSqlCommand("DELETE FROM Ambulances WHERE ambulance_ID = {0};", this.id);

                    }

                    Ambulance am1 = new Ambulance
                    {
                        ambulance_ID = ambulanceIDBox.Text,
                        station = addAmbulanceCBX.Text
                    };

                    using (AmbulancesContext db = new AmbulancesContext())
                    {
                        db.Ambulances.Add(am1);
                        db.SaveChanges();
                    }

                }

                this.Close();
            }
        }

        private void AmbulanceForm_Shown(object sender, EventArgs e)
        {
            if (id == null && station == null)
            {
                return;
            }
            else
            {
                ambulanceLabel.Text = ("Ambulance: " + this.id);
                using (AmbulancesContext db = new AmbulancesContext())
                using (StaffMembersContext db2 = new StaffMembersContext())

                {
                    var am = db.Ambulances.Where(x => x.ambulance_ID == this.id).First();
                    ambulanceIDBox.Text = am.ambulance_ID;
                    addAmbulanceCBX.SelectedIndex = addAmbulanceCBX.FindString(am.station);
                    foreach (var x in db2.StaffMembers)
                    {
                        if (x.assigned_ambulance == this.id)
                        {
                            crewMemberBox.AppendText(x.first_name + " " + x.surname + "\n");
                        }
                    }
                }
            }
        }

        private void AddAmbulanceForm_Load(object sender, EventArgs e)
        {

        }
    }
}