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
    public partial class AmbulancesListForm : Form
    {
        public AmbulancesListForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddAmbulanceForm a = new AddAmbulanceForm();
            a.ShowDialog();
            RefreshGrid();
            this.Visible = true;
        }

        private void ambulanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddAmbulanceForm f = new AddAmbulanceForm();

            if (ambulanceGrid.SelectedRows.Count > 0)
            {
                f.id = ambulanceGrid.SelectedRows[0].Cells[0].Value.ToString();
                f.station = ambulanceGrid.SelectedRows[0].Cells[1].Value.ToString();
                f.ShowDialog();
                RefreshGrid();

            }
            else
                MessageBox.Show("Highlight the row you wish to update by clicking on the lefthand column of the data grid.");
        }

        private void AmbulancesListForm_Load(object sender, EventArgs e)
        {

        }

        public void RefreshGrid()
        {
            using (AmbulancesContext db = new AmbulancesContext())
            {
                ambulanceGrid.Columns.Clear();
                ambulanceGrid.Rows.Clear();

                ambulanceGrid.Columns.Add("ID", "ID");
                ambulanceGrid.Columns.Add("Station", "Station");

                foreach (var x in db.Ambulances)
                {
                    int row = ambulanceGrid.Rows.Add();
                    DataGridViewRow newRow = ambulanceGrid.Rows[row];
                    newRow.Cells["ID"].Value = x.ambulance_ID;
                    newRow.Cells["Station"].Value = x.station;
                }
            }
        }
    }
}
