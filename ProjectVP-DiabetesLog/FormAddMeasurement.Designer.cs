
namespace ProjectVP_DiabetesLog
{
    partial class FormAddMeasurement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_MeasuredValue = new System.Windows.Forms.Label();
            this.nud_MeasuredValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_InsulinType = new System.Windows.Forms.Label();
            this.lbl_InsulinAmount = new System.Windows.Forms.Label();
            this.cb_InsulinType = new System.Windows.Forms.ComboBox();
            this.nud_InsulinAmount = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_InsulinAddType = new System.Windows.Forms.Button();
            this.gb_Insulin = new System.Windows.Forms.GroupBox();
            this.checkBox_EnableInsulin = new System.Windows.Forms.CheckBox();
            this.gb_Measurement = new System.Windows.Forms.GroupBox();
            this.checkBox_EnableMeasurement = new System.Windows.Forms.CheckBox();
            this.gb_DateAndTime = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gb_Meal = new System.Windows.Forms.GroupBox();
            this.checkBox_EnableMeal = new System.Windows.Forms.CheckBox();
            this.lbl_Food = new System.Windows.Forms.Label();
            this.lbl_AmountMeal = new System.Windows.Forms.Label();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.nud_AmountMeal = new System.Windows.Forms.NumericUpDown();
            this.btn_AddMeal = new System.Windows.Forms.Button();
            this.btn_RemoveMeal = new System.Windows.Forms.Button();
            this.col_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Carbs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AddFoodType = new System.Windows.Forms.Button();
            this.col_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nud_MeasuredValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InsulinAmount)).BeginInit();
            this.gb_Insulin.SuspendLayout();
            this.gb_Measurement.SuspendLayout();
            this.gb_DateAndTime.SuspendLayout();
            this.gb_Meal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AmountMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(55, 22);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 0;
            // 
            // dtp_Time
            // 
            this.dtp_Time.Location = new System.Drawing.Point(55, 54);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(200, 20);
            this.dtp_Time.TabIndex = 1;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(6, 29);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(36, 13);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Дата:";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(6, 60);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(43, 13);
            this.lbl_Time.TabIndex = 3;
            this.lbl_Time.Text = "Време:";
            // 
            // lbl_MeasuredValue
            // 
            this.lbl_MeasuredValue.AutoSize = true;
            this.lbl_MeasuredValue.Location = new System.Drawing.Point(6, 48);
            this.lbl_MeasuredValue.Name = "lbl_MeasuredValue";
            this.lbl_MeasuredValue.Size = new System.Drawing.Size(112, 13);
            this.lbl_MeasuredValue.TabIndex = 4;
            this.lbl_MeasuredValue.Text = "Измерена вредност:";
            // 
            // nud_MeasuredValue
            // 
            this.nud_MeasuredValue.DecimalPlaces = 1;
            this.nud_MeasuredValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_MeasuredValue.Location = new System.Drawing.Point(135, 48);
            this.nud_MeasuredValue.Name = "nud_MeasuredValue";
            this.nud_MeasuredValue.Size = new System.Drawing.Size(120, 20);
            this.nud_MeasuredValue.TabIndex = 5;
            // 
            // lbl_InsulinType
            // 
            this.lbl_InsulinType.AutoSize = true;
            this.lbl_InsulinType.Location = new System.Drawing.Point(6, 45);
            this.lbl_InsulinType.Name = "lbl_InsulinType";
            this.lbl_InsulinType.Size = new System.Drawing.Size(88, 13);
            this.lbl_InsulinType.TabIndex = 6;
            this.lbl_InsulinType.Text = "Тип на инсулин:";
            // 
            // lbl_InsulinAmount
            // 
            this.lbl_InsulinAmount.AutoSize = true;
            this.lbl_InsulinAmount.Location = new System.Drawing.Point(6, 72);
            this.lbl_InsulinAmount.Name = "lbl_InsulinAmount";
            this.lbl_InsulinAmount.Size = new System.Drawing.Size(58, 13);
            this.lbl_InsulinAmount.TabIndex = 7;
            this.lbl_InsulinAmount.Text = "Количина:";
            // 
            // cb_InsulinType
            // 
            this.cb_InsulinType.Enabled = false;
            this.cb_InsulinType.FormattingEnabled = true;
            this.cb_InsulinType.Location = new System.Drawing.Point(134, 42);
            this.cb_InsulinType.Name = "cb_InsulinType";
            this.cb_InsulinType.Size = new System.Drawing.Size(121, 21);
            this.cb_InsulinType.TabIndex = 8;
            // 
            // nud_InsulinAmount
            // 
            this.nud_InsulinAmount.Enabled = false;
            this.nud_InsulinAmount.Location = new System.Drawing.Point(134, 70);
            this.nud_InsulinAmount.Name = "nud_InsulinAmount";
            this.nud_InsulinAmount.Size = new System.Drawing.Size(120, 20);
            this.nud_InsulinAmount.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 365);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(107, 23);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Додади";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(177, 365);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Затвори";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_InsulinAddType
            // 
            this.btn_InsulinAddType.Enabled = false;
            this.btn_InsulinAddType.Location = new System.Drawing.Point(9, 102);
            this.btn_InsulinAddType.Name = "btn_InsulinAddType";
            this.btn_InsulinAddType.Size = new System.Drawing.Size(103, 23);
            this.btn_InsulinAddType.TabIndex = 12;
            this.btn_InsulinAddType.Text = "Додади нов тип";
            this.btn_InsulinAddType.UseVisualStyleBackColor = true;
            this.btn_InsulinAddType.Click += new System.EventHandler(this.btn_InsulinAddType_Click);
            // 
            // gb_Insulin
            // 
            this.gb_Insulin.Controls.Add(this.checkBox_EnableInsulin);
            this.gb_Insulin.Controls.Add(this.lbl_InsulinType);
            this.gb_Insulin.Controls.Add(this.btn_InsulinAddType);
            this.gb_Insulin.Controls.Add(this.lbl_InsulinAmount);
            this.gb_Insulin.Controls.Add(this.nud_InsulinAmount);
            this.gb_Insulin.Controls.Add(this.cb_InsulinType);
            this.gb_Insulin.Location = new System.Drawing.Point(12, 208);
            this.gb_Insulin.Name = "gb_Insulin";
            this.gb_Insulin.Size = new System.Drawing.Size(278, 140);
            this.gb_Insulin.TabIndex = 13;
            this.gb_Insulin.TabStop = false;
            this.gb_Insulin.Text = "Инсулин";
            // 
            // checkBox_EnableInsulin
            // 
            this.checkBox_EnableInsulin.AutoSize = true;
            this.checkBox_EnableInsulin.Location = new System.Drawing.Point(6, 19);
            this.checkBox_EnableInsulin.Name = "checkBox_EnableInsulin";
            this.checkBox_EnableInsulin.Size = new System.Drawing.Size(80, 17);
            this.checkBox_EnableInsulin.TabIndex = 13;
            this.checkBox_EnableInsulin.Text = "Овозможи";
            this.checkBox_EnableInsulin.UseVisualStyleBackColor = true;
            this.checkBox_EnableInsulin.CheckedChanged += new System.EventHandler(this.checkBox_EnableInsulin_CheckedChanged);
            // 
            // gb_Measurement
            // 
            this.gb_Measurement.Controls.Add(this.checkBox_EnableMeasurement);
            this.gb_Measurement.Controls.Add(this.nud_MeasuredValue);
            this.gb_Measurement.Controls.Add(this.lbl_MeasuredValue);
            this.gb_Measurement.Location = new System.Drawing.Point(12, 118);
            this.gb_Measurement.Name = "gb_Measurement";
            this.gb_Measurement.Size = new System.Drawing.Size(278, 84);
            this.gb_Measurement.TabIndex = 14;
            this.gb_Measurement.TabStop = false;
            this.gb_Measurement.Text = "Мерење";
            // 
            // checkBox_EnableMeasurement
            // 
            this.checkBox_EnableMeasurement.AutoSize = true;
            this.checkBox_EnableMeasurement.Checked = true;
            this.checkBox_EnableMeasurement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EnableMeasurement.Location = new System.Drawing.Point(6, 19);
            this.checkBox_EnableMeasurement.Name = "checkBox_EnableMeasurement";
            this.checkBox_EnableMeasurement.Size = new System.Drawing.Size(80, 17);
            this.checkBox_EnableMeasurement.TabIndex = 6;
            this.checkBox_EnableMeasurement.Text = "Овозможи";
            this.checkBox_EnableMeasurement.UseVisualStyleBackColor = true;
            this.checkBox_EnableMeasurement.CheckedChanged += new System.EventHandler(this.checkBox_EnableMeasurement_CheckedChanged);
            // 
            // gb_DateAndTime
            // 
            this.gb_DateAndTime.Controls.Add(this.lbl_Date);
            this.gb_DateAndTime.Controls.Add(this.lbl_Time);
            this.gb_DateAndTime.Controls.Add(this.dtp_Date);
            this.gb_DateAndTime.Controls.Add(this.dtp_Time);
            this.gb_DateAndTime.Location = new System.Drawing.Point(12, 12);
            this.gb_DateAndTime.Name = "gb_DateAndTime";
            this.gb_DateAndTime.Size = new System.Drawing.Size(278, 100);
            this.gb_DateAndTime.TabIndex = 16;
            this.gb_DateAndTime.TabStop = false;
            this.gb_DateAndTime.Text = "Дата и време";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Type,
            this.col_Manufacturer,
            this.col_Carbs,
            this.col_Amount});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 170);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // gb_Meal
            // 
            this.gb_Meal.Controls.Add(this.btn_AddFoodType);
            this.gb_Meal.Controls.Add(this.btn_RemoveMeal);
            this.gb_Meal.Controls.Add(this.listView1);
            this.gb_Meal.Controls.Add(this.btn_AddMeal);
            this.gb_Meal.Controls.Add(this.nud_AmountMeal);
            this.gb_Meal.Controls.Add(this.cb_Food);
            this.gb_Meal.Controls.Add(this.lbl_AmountMeal);
            this.gb_Meal.Controls.Add(this.lbl_Food);
            this.gb_Meal.Controls.Add(this.checkBox_EnableMeal);
            this.gb_Meal.Location = new System.Drawing.Point(330, 12);
            this.gb_Meal.Name = "gb_Meal";
            this.gb_Meal.Size = new System.Drawing.Size(502, 336);
            this.gb_Meal.TabIndex = 18;
            this.gb_Meal.TabStop = false;
            this.gb_Meal.Text = "Оброк";
            // 
            // checkBox_EnableMeal
            // 
            this.checkBox_EnableMeal.AutoSize = true;
            this.checkBox_EnableMeal.Location = new System.Drawing.Point(7, 18);
            this.checkBox_EnableMeal.Name = "checkBox_EnableMeal";
            this.checkBox_EnableMeal.Size = new System.Drawing.Size(80, 17);
            this.checkBox_EnableMeal.TabIndex = 0;
            this.checkBox_EnableMeal.Text = "Овозможи";
            this.checkBox_EnableMeal.UseVisualStyleBackColor = true;
            this.checkBox_EnableMeal.CheckedChanged += new System.EventHandler(this.checkBox_EnableMeal_CheckedChanged);
            // 
            // lbl_Food
            // 
            this.lbl_Food.AutoSize = true;
            this.lbl_Food.Location = new System.Drawing.Point(6, 44);
            this.lbl_Food.Name = "lbl_Food";
            this.lbl_Food.Size = new System.Drawing.Size(41, 13);
            this.lbl_Food.TabIndex = 1;
            this.lbl_Food.Text = "Храна:";
            // 
            // lbl_AmountMeal
            // 
            this.lbl_AmountMeal.AutoSize = true;
            this.lbl_AmountMeal.Location = new System.Drawing.Point(7, 71);
            this.lbl_AmountMeal.Name = "lbl_AmountMeal";
            this.lbl_AmountMeal.Size = new System.Drawing.Size(58, 13);
            this.lbl_AmountMeal.TabIndex = 2;
            this.lbl_AmountMeal.Text = "Количина:";
            // 
            // cb_Food
            // 
            this.cb_Food.Enabled = false;
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(141, 41);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(121, 21);
            this.cb_Food.TabIndex = 5;
            // 
            // nud_AmountMeal
            // 
            this.nud_AmountMeal.Enabled = false;
            this.nud_AmountMeal.Location = new System.Drawing.Point(142, 69);
            this.nud_AmountMeal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_AmountMeal.Name = "nud_AmountMeal";
            this.nud_AmountMeal.Size = new System.Drawing.Size(120, 20);
            this.nud_AmountMeal.TabIndex = 6;
            // 
            // btn_AddMeal
            // 
            this.btn_AddMeal.Enabled = false;
            this.btn_AddMeal.Location = new System.Drawing.Point(10, 106);
            this.btn_AddMeal.Name = "btn_AddMeal";
            this.btn_AddMeal.Size = new System.Drawing.Size(110, 23);
            this.btn_AddMeal.TabIndex = 7;
            this.btn_AddMeal.Text = "Додади оброк";
            this.btn_AddMeal.UseVisualStyleBackColor = true;
            // 
            // btn_RemoveMeal
            // 
            this.btn_RemoveMeal.Enabled = false;
            this.btn_RemoveMeal.Location = new System.Drawing.Point(144, 106);
            this.btn_RemoveMeal.Name = "btn_RemoveMeal";
            this.btn_RemoveMeal.Size = new System.Drawing.Size(118, 23);
            this.btn_RemoveMeal.TabIndex = 8;
            this.btn_RemoveMeal.Text = "Отстрани оброк";
            this.btn_RemoveMeal.UseVisualStyleBackColor = true;
            // 
            // col_Type
            // 
            this.col_Type.Text = "Тип";
            this.col_Type.Width = 167;
            // 
            // col_Manufacturer
            // 
            this.col_Manufacturer.Text = "Производител";
            this.col_Manufacturer.Width = 106;
            // 
            // col_Carbs
            // 
            this.col_Carbs.Text = "Јаглехидрати(100г)";
            this.col_Carbs.Width = 109;
            // 
            // btn_AddFoodType
            // 
            this.btn_AddFoodType.Enabled = false;
            this.btn_AddFoodType.Location = new System.Drawing.Point(306, 39);
            this.btn_AddFoodType.Name = "btn_AddFoodType";
            this.btn_AddFoodType.Size = new System.Drawing.Size(88, 23);
            this.btn_AddFoodType.TabIndex = 18;
            this.btn_AddFoodType.Text = "Додади храна";
            this.btn_AddFoodType.UseVisualStyleBackColor = true;
            this.btn_AddFoodType.Click += new System.EventHandler(this.btn_AddFoodType_Click);
            // 
            // col_Amount
            // 
            this.col_Amount.Text = "Количина(грами)";
            this.col_Amount.Width = 97;
            // 
            // FormAddMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 483);
            this.Controls.Add(this.gb_Meal);
            this.Controls.Add(this.gb_DateAndTime);
            this.Controls.Add(this.gb_Measurement);
            this.Controls.Add(this.gb_Insulin);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add);
            this.Name = "FormAddMeasurement";
            this.Text = "Додади Мерење";
            ((System.ComponentModel.ISupportInitialize)(this.nud_MeasuredValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_InsulinAmount)).EndInit();
            this.gb_Insulin.ResumeLayout(false);
            this.gb_Insulin.PerformLayout();
            this.gb_Measurement.ResumeLayout(false);
            this.gb_Measurement.PerformLayout();
            this.gb_DateAndTime.ResumeLayout(false);
            this.gb_DateAndTime.PerformLayout();
            this.gb_Meal.ResumeLayout(false);
            this.gb_Meal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AmountMeal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_MeasuredValue;
        private System.Windows.Forms.NumericUpDown nud_MeasuredValue;
        private System.Windows.Forms.Label lbl_InsulinType;
        private System.Windows.Forms.Label lbl_InsulinAmount;
        private System.Windows.Forms.ComboBox cb_InsulinType;
        private System.Windows.Forms.NumericUpDown nud_InsulinAmount;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_InsulinAddType;
        private System.Windows.Forms.GroupBox gb_Insulin;
        private System.Windows.Forms.GroupBox gb_Measurement;
        private System.Windows.Forms.CheckBox checkBox_EnableInsulin;
        private System.Windows.Forms.CheckBox checkBox_EnableMeasurement;
        private System.Windows.Forms.GroupBox gb_DateAndTime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_Type;
        private System.Windows.Forms.ColumnHeader col_Manufacturer;
        private System.Windows.Forms.ColumnHeader col_Carbs;
        private System.Windows.Forms.GroupBox gb_Meal;
        private System.Windows.Forms.Button btn_RemoveMeal;
        private System.Windows.Forms.Button btn_AddMeal;
        private System.Windows.Forms.NumericUpDown nud_AmountMeal;
        private System.Windows.Forms.ComboBox cb_Food;
        private System.Windows.Forms.Label lbl_AmountMeal;
        private System.Windows.Forms.Label lbl_Food;
        private System.Windows.Forms.CheckBox checkBox_EnableMeal;
        private System.Windows.Forms.Button btn_AddFoodType;
        private System.Windows.Forms.ColumnHeader col_Amount;
    }
}

