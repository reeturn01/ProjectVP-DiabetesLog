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
        public static List<InsulinType> insulinTypes;
        public FormAddMeasurement()
        {
            InitializeComponent();

            //Moi initializacii
            insulinTypes = new List<InsulinType>();

            Initialize_dtp_Date();
            Initialize_dtp_Time();

            Initialize_cb_InsulinType();

        }

        private void Initialize_cb_InsulinType()
        {
            cb_InsulinType.DataSource = insulinTypes;
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
                btn_InsulinAddType.Enabled = true;
            }
            else
            {
                cb_InsulinType.Enabled = false;
                nud_InsulinAmount.Enabled = false;
                btn_InsulinAddType.Enabled = false;
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
        private void checkBox_EnableMeal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_EnableMeal.Checked == true)
            {
                cb_Food.Enabled = true;
                nud_AmountMeal.Enabled = true;
                btn_AddFoodType.Enabled = true;
                btn_AddMeal.Enabled = true;
                btn_RemoveMeal.Enabled = true;
            }
            else
            {
                cb_Food.Enabled = false;
                nud_AmountMeal.Enabled = false;
                btn_AddFoodType.Enabled = false;
                btn_AddMeal.Enabled = false;
                btn_RemoveMeal.Enabled = false;
            }
        }

        private void btn_InsulinAddType_Click(object sender, EventArgs e)
        {
            FormAddNewInsulinType addNewInsulinType = new FormAddNewInsulinType();
            if (addNewInsulinType.ShowDialog() == DialogResult.OK)
            {
                cb_InsulinType.DataSource = null;
                Initialize_cb_InsulinType();
            }
        }

        private void btn_AddFoodType_Click(object sender, EventArgs e)
        {
            FormAddFoodType formAddFoodType = new FormAddFoodType();
            if (formAddFoodType.ShowDialog() == DialogResult.OK)
            {
                cb_Food.Items.Add(formAddFoodType.foodToAdd);
            }
        }

        private void btn_AddMeal_Click(object sender, EventArgs e)
        {
            if (cb_Food.SelectedIndex != -1)
            {
                Food tmp = (Food)cb_Food.SelectedItem;
                ListViewItem viewItem = new ListViewItem(tmp.ToArray());
                viewItem.SubItems.Add(nud_AmountMeal.Value.ToString());
                listView_Meals.Items.Add(viewItem);
            }
        }

        private void btn_RemoveMeal_Click(object sender, EventArgs e)
        {
            if (listView_Meals.SelectedIndices.Count != 0)
            {
                listView_Meals.Items.Remove(listView_Meals.SelectedItems[0]);
            }
        }
    }
}
