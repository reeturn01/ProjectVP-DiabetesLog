
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
            this.dgv_MeasurementsList = new System.Windows.Forms.DataGridView();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_InsulinAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Insulin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MeasurementsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(12, 30);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 0;
            // 
            // dgv_MeasurementsList
            // 
            this.dgv_MeasurementsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MeasurementsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Date,
            this.col_Time,
            this.col_Measurement,
            this.col_InsulinAmount,
            this.col_Insulin});
            this.dgv_MeasurementsList.Location = new System.Drawing.Point(224, 12);
            this.dgv_MeasurementsList.Name = "dgv_MeasurementsList";
            this.dgv_MeasurementsList.Size = new System.Drawing.Size(564, 426);
            this.dgv_MeasurementsList.TabIndex = 1;
            // 
            // col_Date
            // 
            this.col_Date.HeaderText = "Дата";
            this.col_Date.Name = "col_Date";
            // 
            // col_Time
            // 
            this.col_Time.HeaderText = "Време";
            this.col_Time.Name = "col_Time";
            // 
            // col_Measurement
            // 
            this.col_Measurement.HeaderText = "Мерење";
            this.col_Measurement.Name = "col_Measurement";
            // 
            // col_InsulinAmount
            // 
            this.col_InsulinAmount.HeaderText = "Инсулин кол.";
            this.col_InsulinAmount.Name = "col_InsulinAmount";
            // 
            // col_Insulin
            // 
            this.col_Insulin.HeaderText = "Инсулин";
            this.col_Insulin.Name = "col_Insulin";
            // 
            // FormSearchMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_MeasurementsList);
            this.Controls.Add(this.dtp_Date);
            this.Name = "FormSearchMeasurements";
            this.Text = "Пребарувај мерења";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MeasurementsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridView dgv_MeasurementsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_InsulinAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Insulin;
    }
}