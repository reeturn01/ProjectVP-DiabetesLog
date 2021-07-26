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
    public partial class FormAddMeasurement : Form
    {
        InsulinType insulinType;
        public FormAddMeasurement()
        {
            InitializeComponent();

            //Moi initializacii
            Initialize_dtp_Date();
            Initialize_dtp_Time();
            insulinType = new InsulinType();
            Initialize_cb_InsulinType();

        }

        private void Initialize_cb_InsulinType()
        {
            cb_InsulinType.DataSource = insulinType.types;
        }

        private void Initialize_dtp_Date()
        {
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd MMM yyyy";
            dtp_Date.Value = DateTime.Now;
        }
        private void Initialize_dtp_Time()
        {
            dtp_Time.Format = DateTimePickerFormat.Custom;
            dtp_Time.CustomFormat = "HH:mm";
            dtp_Time.Value = DateTime.Now;
            dtp_Time.ShowUpDown = true;
        }

        private void checkBox_EnableInsulin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_EnableInsulin.Checked == true)
            {
                cb_InsulinType.Enabled = true;
                nud_InsulinAmount.Enabled = true;
            }
            else
            {
                cb_InsulinType.Enabled = false;
                nud_InsulinAmount.Enabled = false;
            }
        }

        private void checkBox_EnableMeasurement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_EnableMeasurement.Checked == true)
            {
                nud_MeasuredValue.Enabled = true;
            }
            else
            {
                nud_MeasuredValue.Enabled = false;
            }
        }
    }
}
