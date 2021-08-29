using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVP_DiabetesLog
{
    public partial class FormSearchMeasurements : Form
    {
        private List<TimeMeasurement> timeMeasurements;
        public FormSearchMeasurements()
        {
            InitializeComponent();

            timeMeasurements = new List<TimeMeasurement>();
            Initialize_dtp_Date();
        }
        private void Initialize_dtp_Date()
        {
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd MMM yyyy";
            dtp_Date.Value = DateTime.Now;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_Date.Value;
            timeMeasurements = DatabaseAccess.MeasurementsOnDate(date);
            
            DisplayMeasurements();

        }
        private void DisplayMeasurements() {
            listView_Measurements.Items.Clear();
            dgv_Meals.Rows.Clear();

            foreach (TimeMeasurement tmp in timeMeasurements) {


                ListViewItem listViewItem = new ListViewItem(tmp.time.ToString("HH:mm"));
                listViewItem.SubItems.Add(tmp.measurement == 0 ? "/" : tmp.measurement.ToString());
                listViewItem.SubItems.Add(tmp.insulinAdded.amount == 0 ? "/" : tmp.insulinAdded.amount.ToString());
                listViewItem.SubItems.Add(tmp.insulinAdded.insulin.name);
                listViewItem.SubItems.Add(tmp.insulinAdded.insulin.brand);

                listView_Measurements.Items.Add(listViewItem);
            }
            

        }

        private void listView_Measurements_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            dgv_Meals.Rows.Clear();
            DataGridViewRow emptyRow = dgv_Meals.Rows[0];
            if (listView_Measurements.SelectedIndices.Count == 1)
            {
                string time = listView_Measurements.SelectedItems[0].Text;

                TimeMeasurement tmp = timeMeasurements.Find(item => item.matchingTime(time));
                foreach (Meal meal in tmp.meals)
                {
                    DataGridViewRow rowToAdd = (DataGridViewRow)emptyRow.Clone();
                    rowToAdd.Cells[0].Value = meal.food.name;
                    rowToAdd.Cells[1].Value = meal.food.brand;
                    rowToAdd.Cells[2].Value = meal.food.carbs;
                    rowToAdd.Cells[3].Value = meal.amount;
                    dgv_Meals.Rows.Add(rowToAdd);
                }
            }
            
            

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
