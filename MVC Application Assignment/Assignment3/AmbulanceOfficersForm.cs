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
    public partial class AmbulanceOfficersForm : Form
    {
        public AmbulanceOfficersForm()
        {
            InitializeComponent();
            RefreshGrid();
        
            }
        

        private void addNewButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddOfficerForm a = new AddOfficerForm();
            a.ShowDialog();
            RefreshGrid();
            this.Visible = true;
        }



        private void ambulanceOfficersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AmbulanceOfficersForm_Load(object sender, EventArgs e)
        {

        }

        public void RefreshGrid()
        {
            using (StaffMembersContext db = new StaffMembersContext())
            {
                ambulanceOfficersGrid.Columns.Clear();
                ambulanceOfficersGrid.Rows.Clear();

                ambulanceOfficersGrid.Columns.Add("ID", "ID");
                ambulanceOfficersGrid.Columns.Add("Name", "Name");
                ambulanceOfficersGrid.Columns.Add("Skill", "Skill");
                ambulanceOfficersGrid.Columns.Add("Ambulance", "Ambulance");

                foreach (var x in db.StaffMembers)
                {
                    int row = ambulanceOfficersGrid.Rows.Add();
                    DataGridViewRow newRow = ambulanceOfficersGrid.Rows[row];
                    newRow.Cells["ID"].Value = x.officer_ID;
                    newRow.Cells["Name"].Value = x.first_name + " " + x.surname;
                    newRow.Cells["Skill"].Value = x.skill_level;
                    if (x.assigned_ambulance == null)
                    {
                        newRow.Cells["Ambulance"].Value = "None";
                    }
                    else
                    {
                        newRow.Cells["Ambulance"].Value = x.assigned_ambulance;
                    }
                }

            }
        }

        private void ambulanceOfficersGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                AddOfficerForm u = new AddOfficerForm();

                if (ambulanceOfficersGrid.SelectedRows.Count > 0)
                {
                    u.name = ambulanceOfficersGrid.SelectedRows[0].Cells[1].Value.ToString();
                    u.id = ambulanceOfficersGrid.SelectedRows[0].Cells[0].Value.ToString();
                    int rownum = ambulanceOfficersGrid.SelectedRows[0].Index;
                    u.ShowDialog();
                    RefreshGrid();
                    ambulanceOfficersGrid.Rows[rownum].Selected = true;
                }
                else
                    MessageBox.Show("Highlight the row you wish to update by clicking on the lefthand column of the data grid.");
            }
        }
    }
}
