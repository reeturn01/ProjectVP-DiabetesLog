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
        public FormSearchMeasurements()
        {
            InitializeComponent();

            Initialize_dtp_Date();
        }
        private void Initialize_dtp_Date()
        {
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd MMM yyyy";
            dtp_Date.Value = DateTime.Now;
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtp_Date.Value.Date;
        }
    }
}
