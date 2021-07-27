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
            string insulinManufacturer = tb_Manufacturer.Text.Trim();
            if (!CheckIfTextBoxInputsEmpty(insulinName, insulinManufacturer))
            {
                InsulinType tmp = new InsulinType(insulinName.ToUpper(), insulinManufacturer.ToUpper());
                if (FormAddMeasurement.insulinTypes.Contains(tmp))
                {
                    DialogResult popUp = MessageBox.Show("Внесениот тип на инсулин веќе постои во листата.Дали сакате да додадете друг?", "Постоечки тип!", MessageBoxButtons.YesNo);
                    if (popUp.Equals(DialogResult.No))
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    ep_AddNewInsulinType.Clear();
                    FormAddMeasurement.insulinTypes.Add(tmp);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private bool CheckIfTextBoxInputsEmpty(string name, string manufacturer)
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
