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
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void btn_AddNewMeasurement_Click(object sender, EventArgs e)
        {
            FormAddMeasurement formAddMeasurement = new FormAddMeasurement();
            formAddMeasurement.Show();
        }

        private void btn_SearchMeasurements_Click(object sender, EventArgs e)
        {
            FormSearchMeasurements formSearchMeasurements = new FormSearchMeasurements();
            formSearchMeasurements.Show();
        }
    }
}
