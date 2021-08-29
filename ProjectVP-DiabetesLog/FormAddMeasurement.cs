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
        public static List<Food> foods;
        private List<Meal> meals;
        public FormAddMeasurement()
        {
            InitializeComponent();

            //Moi initializacii
            meals = new List<Meal>();
            insulinTypes = DatabaseAccess.LoadInsulinTypes();
            foods = DatabaseAccess.LoadFoodTypes();

            Initialize_dtp_Date();
            Initialize_dtp_Time();

            Initialize_cb_InsulinType();
            Initialize_cb_Food();
        }

        private void Initialize_cb_Food()
        {
            cb_Food.DataSource = foods;
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
                foods.Add(formAddFoodType.foodToAdd);
                cb_Food.DataSource = null;
                cb_Food.DataSource = foods;
            }
        }

        private void btn_AddMeal_Click(object sender, EventArgs e)
        {
            errorProvider_AddMeasurement.Clear();
            if (cb_Food.SelectedIndex != -1)
            {
                if (nud_AmountMeal.Value.Equals(0))
                {
                    errorProvider_AddMeasurement.SetError(nud_AmountMeal, "Внесете количина!");
                }
                else
                {
                    Food tmp = (Food)cb_Food.SelectedItem;
                    if (meals.Any(item => item.food.Equals(tmp))) {
                        MessageBox.Show("Типот на оброк веќе постои во листата!\nДоколку сакате да направите измена отстранете го од листата и додадете го повторно.");
                    }
                    else
                    {
                        
                        meals.Add(new Meal(tmp, Decimal.ToInt32(nud_AmountMeal.Value)));

                        ListViewItem viewItem = new ListViewItem(tmp.ToArray());
                        viewItem.SubItems.Add(nud_AmountMeal.Value.ToString());
                        listView_Meals.Items.Add(viewItem);
                    }

                }
                
            }
        }

        private void btn_RemoveMeal_Click(object sender, EventArgs e)
        {
            if (listView_Meals.SelectedIndices.Count != 0)
            {
                listView_Meals.Items.Remove(listView_Meals.SelectedItems[0]);
            }
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
           // DatabaseAccess.DateRecords(dtp_Date.Value.Date);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (!CheckForErrors())
            {
                
                int rowId = DatabaseAccess.InsertDateTime(dtp_Date.Value.Date, dtp_Time.Value);
                
                if (checkBox_EnableMeasurement.Checked.Equals(true))
                {
                    DatabaseAccess.InsertMeasurement( rowId, Decimal.ToDouble(nud_MeasuredValue.Value));
                }
                if (checkBox_EnableInsulin.Checked.Equals(true))
                {
                    DatabaseAccess.InsertInsulinMeasurement(rowId, Decimal.ToInt32(nud_InsulinAmount.Value), (InsulinType)cb_InsulinType.SelectedItem);
                }
                if (checkBox_EnableMeal.Checked.Equals(true))
                {
                    foreach (Meal meal in meals)
                    {
                        DatabaseAccess.insertMeal(rowId, meal);
                    }
                }
            }
            
        }

        private bool CheckForErrors()
        {
            errorProvider_AddMeasurement.Clear();
            bool ErrorSet = false;
            if (checkBox_EnableMeasurement.Checked == true && nud_MeasuredValue.Value.Equals(0))
            {
                errorProvider_AddMeasurement.SetError(nud_MeasuredValue, "Внесете вредност!");
                ErrorSet = true;
            }
            if (checkBox_EnableInsulin.Checked == true && nud_InsulinAmount.Value.Equals(0))
            {
                errorProvider_AddMeasurement.SetError(nud_InsulinAmount, "Внесете количина!");
                ErrorSet = true;
            }
            if (checkBox_EnableMeal.Checked == true && listView_Meals.Items.Count <= 0)
            {
                errorProvider_AddMeasurement.SetError(checkBox_EnableMeal, "Немате додадено оброци!");
                ErrorSet = true;
            }
            return ErrorSet;
        }
    }
}
