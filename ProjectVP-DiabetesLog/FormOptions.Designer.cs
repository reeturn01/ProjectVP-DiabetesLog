
namespace ProjectVP_DiabetesLog
{
    partial class FormOptions
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
            this.btn_AddNewMeasurement = new System.Windows.Forms.Button();
            this.btn_SearchMeasurements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddNewMeasurement
            // 
            this.btn_AddNewMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewMeasurement.Location = new System.Drawing.Point(46, 89);
            this.btn_AddNewMeasurement.Name = "btn_AddNewMeasurement";
            this.btn_AddNewMeasurement.Size = new System.Drawing.Size(212, 48);
            this.btn_AddNewMeasurement.TabIndex = 0;
            this.btn_AddNewMeasurement.Text = "Додади ново мерење";
            this.btn_AddNewMeasurement.UseVisualStyleBackColor = true;
            this.btn_AddNewMeasurement.Click += new System.EventHandler(this.btn_AddNewMeasurement_Click);
            // 
            // btn_SearchMeasurements
            // 
            this.btn_SearchMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchMeasurements.Location = new System.Drawing.Point(306, 89);
            this.btn_SearchMeasurements.Name = "btn_SearchMeasurements";
            this.btn_SearchMeasurements.Size = new System.Drawing.Size(207, 48);
            this.btn_SearchMeasurements.TabIndex = 1;
            this.btn_SearchMeasurements.Text = "Пребарување";
            this.btn_SearchMeasurements.UseVisualStyleBackColor = true;
            this.btn_SearchMeasurements.Click += new System.EventHandler(this.btn_SearchMeasurements_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 242);
            this.Controls.Add(this.btn_SearchMeasurements);
            this.Controls.Add(this.btn_AddNewMeasurement);
            this.Name = "FormOptions";
            this.Text = "Опции";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNewMeasurement;
        private System.Windows.Forms.Button btn_SearchMeasurements;
    }
}