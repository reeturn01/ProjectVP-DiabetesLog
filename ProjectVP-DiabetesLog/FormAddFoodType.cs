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
    public partial class FormAddFoodType : Form
    {
        public Food foodToAdd { get; set; }
        public FormAddFoodType()
        {
            InitializeComponent();
        }

        private bool CheckIfFormFieldsEmpty(string name, string manufacturer) {
            bool errorSet = false;
            ep_AddFoodType.Clear();
            if (string.IsNullOrEmpty(name))
            {
                ep_AddFoodType.SetError(tb_Name, "Полето е задолжително!");
                errorSet = true;
            }
            if (string.IsNullOrEmpty(manufacturer))
            {
                ep_AddFoodType.SetError(tb_Manufacturer, "Полето е задолжително!");
                errorSet = true;
            }
            return errorSet;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text.Trim();
            string manufacturer = tb_Manufacturer.Text.Trim();

            if (!CheckIfFormFieldsEmpty(name, manufacturer))
            {
                foodToAdd = new Food(name, manufacturer, Decimal.ToDouble(nud_Carbs.Value));
                ep_AddFoodType.Clear();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
