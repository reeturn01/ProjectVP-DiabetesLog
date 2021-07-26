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
    public partial class FormAddNewInsulinType : Form
    {
        public FormAddNewInsulinType()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_InsulinName.Text))
            {
                ep_AddNewInsulinType.SetError(tb_InsulinName, "Полето е празно!");
            }
            else if (!FormAddMeasurement.insulinType.addType(tb_InsulinName.Text.Trim()))
            {
                ep_AddNewInsulinType.SetError(tb_InsulinName, "Веќе постоечко име!");
            }
            else
            {
                ep_AddNewInsulinType.SetError(tb_InsulinName, string.Empty);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
