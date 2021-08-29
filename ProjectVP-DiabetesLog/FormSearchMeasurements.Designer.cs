
namespace ProjectVP_DiabetesLog
{
    partial class FormSearchMeasurements
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.listView_Measurements = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeasuredValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsulinAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsulinName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsulinBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_Meals = new System.Windows.Forms.DataGridView();
            this.col_FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FoodBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FoodCarbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MealAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meals)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(12, 30);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Пребарај";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // listView_Measurements
            // 
            this.listView_Measurements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.MeasuredValue,
            this.InsulinAmount,
            this.InsulinName,
            this.InsulinBrand});
            this.listView_Measurements.FullRowSelect = true;
            this.listView_Measurements.GridLines = true;
            this.listView_Measurements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Measurements.HideSelection = false;
            this.listView_Measurements.Location = new System.Drawing.Point(239, 30);
            this.listView_Measurements.MultiSelect = false;
            this.listView_Measurements.Name = "listView_Measurements";
            this.listView_Measurements.Size = new System.Drawing.Size(549, 172);
            this.listView_Measurements.TabIndex = 3;
            this.listView_Measurements.UseCompatibleStateImageBehavior = false;
            this.listView_Measurements.View = System.Windows.Forms.View.Details;
            this.listView_Measurements.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Measurements_ItemSelectionChanged);
            // 
            // Time
            // 
            this.Time.Text = "Време";
            this.Time.Width = 83;
            // 
            // MeasuredValue
            // 
            this.MeasuredValue.Text = "Измерена вредност";
            this.MeasuredValue.Width = 136;
            // 
            // InsulinAmount
            // 
            this.InsulinAmount.Text = "Инсулин кол.";
            this.InsulinAmount.Width = 97;
            // 
            // InsulinName
            // 
            this.InsulinName.Text = "Име на инсулин";
            this.InsulinName.Width = 105;
            // 
            // InsulinBrand
            // 
            this.InsulinBrand.Text = "Бренд на инсулин";
            this.InsulinBrand.Width = 117;
            // 
            // dgv_Meals
            // 
            this.dgv_Meals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Meals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_FoodName,
            this.col_FoodBrand,
            this.col_FoodCarbs,
            this.col_MealAmount});
            this.dgv_Meals.Enabled = false;
            this.dgv_Meals.Location = new System.Drawing.Point(239, 249);
            this.dgv_Meals.Name = "dgv_Meals";
            this.dgv_Meals.Size = new System.Drawing.Size(549, 146);
            this.dgv_Meals.TabIndex = 4;
            // 
            // col_FoodName
            // 
            this.col_FoodName.HeaderText = "Име";
            this.col_FoodName.Name = "col_FoodName";
            // 
            // col_FoodBrand
            // 
            this.col_FoodBrand.HeaderText = "Бренд";
            this.col_FoodBrand.Name = "col_FoodBrand";
            // 
            // col_FoodCarbs
            // 
            this.col_FoodCarbs.HeaderText = "Јаглехидрати на 100г.";
            this.col_FoodCarbs.Name = "col_FoodCarbs";
            // 
            // col_MealAmount
            // 
            this.col_MealAmount.HeaderText = "Количина на оброк(грами)";
            this.col_MealAmount.Name = "col_MealAmount";
            // 
            // btn_Close
            // 
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Close.Location = new System.Drawing.Point(12, 372);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Затвори";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FormSearchMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_Meals);
            this.Controls.Add(this.listView_Measurements);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_Date);
            this.Name = "FormSearchMeasurements";
            this.Text = "Пребарувај мерења";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListView listView_Measurements;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader MeasuredValue;
        private System.Windows.Forms.ColumnHeader InsulinAmount;
        private System.Windows.Forms.ColumnHeader InsulinName;
        private System.Windows.Forms.ColumnHeader InsulinBrand;
        private System.Windows.Forms.DataGridView dgv_Meals;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FoodBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FoodCarbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MealAmount;
        private System.Windows.Forms.Button btn_Close;
    }
}