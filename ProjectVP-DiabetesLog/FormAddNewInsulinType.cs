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
            string insulinName = tb_InsulinName.Text.Trim();
            string insulinBrand = tb_Manufacturer.Text.Trim();
            if (!CheckIfFormFieldsEmpty(insulinName, insulinBrand))
            {
                InsulinType tmp = new InsulinType(insulinName.ToUpper(), insulinBrand.ToUpper());
                if (FormAddMeasurement.insulinTypes.Contains(tmp))
                {
                    MessageBox.Show("Внесениот тип на инсулин веќе постои во листата.", "Постоечки тип!", MessageBoxButtons.OK);
                }
                else
                {
                    ep_AddNewInsulinType.Clear();
                    FormAddMeasurement.insulinTypes.Add(tmp);
                    DatabaseAccess.InsertInsulinType(tmp);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private bool CheckIfFormFieldsEmpty(string name, string manufacturer)
        {
            ep_AddNewInsulinType.Clear();
            bool errorSet = false;
            if (String.IsNullOrEmpty(name))
            {
                ep_AddNewInsulinType.SetError(tb_InsulinName, "Полето е задолжително!");
                errorSet = true;

            }
            if (String.IsNullOrEmpty(manufacturer))
            {
                ep_AddNewInsulinType.SetError(tb_Manufacturer, "Полето е задолжително!");
                errorSet = true;
            }
            return errorSet;
        }
    }
}
