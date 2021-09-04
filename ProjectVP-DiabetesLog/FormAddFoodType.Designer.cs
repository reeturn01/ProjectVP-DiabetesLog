
namespace ProjectVP_DiabetesLog
{
    partial class FormAddFoodType
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            this.lbl_Carbs = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Manufacturer = new System.Windows.Forms.TextBox();
            this.nud_Carbs = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.ep_AddFoodType = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Carbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddFoodType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(22, 27);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(32, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Име:";
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Location = new System.Drawing.Point(22, 65);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(83, 13);
            this.lbl_Manufacturer.TabIndex = 2;
            this.lbl_Manufacturer.Text = "Производител:";
            // 
            // lbl_Carbs
            // 
            this.lbl_Carbs.AutoSize = true;
            this.lbl_Carbs.Location = new System.Drawing.Point(22, 103);
            this.lbl_Carbs.Name = "lbl_Carbs";
            this.lbl_Carbs.Size = new System.Drawing.Size(78, 13);
            this.lbl_Carbs.TabIndex = 4;
            this.lbl_Carbs.Text = "Јаглехидрати:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(121, 32);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(120, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Manufacturer
            // 
            this.tb_Manufacturer.Location = new System.Drawing.Point(121, 70);
            this.tb_Manufacturer.Name = "tb_Manufacturer";
            this.tb_Manufacturer.Size = new System.Drawing.Size(120, 20);
            this.tb_Manufacturer.TabIndex = 3;
            // 
            // nud_Carbs
            // 
            this.nud_Carbs.DecimalPlaces = 2;
            this.nud_Carbs.Location = new System.Drawing.Point(121, 103);
            this.nud_Carbs.Name = "nud_Carbs";
            this.nud_Carbs.Size = new System.Drawing.Size(120, 20);
            this.nud_Carbs.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(25, 152);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Додади";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(166, 152);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Откажи";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ep_AddFoodType
            // 
            this.ep_AddFoodType.ContainerControl = this;
            // 
            // FormAddFoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 219);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.nud_Carbs);
            this.Controls.Add(this.tb_Manufacturer);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Carbs);
            this.Controls.Add(this.lbl_Manufacturer);
            this.Controls.Add(this.lbl_Name);
            this.Name = "FormAddFoodType";
            this.Text = "Додади храна";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Carbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddFoodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Manufacturer;
        private System.Windows.Forms.Label lbl_Carbs;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Manufacturer;
        private System.Windows.Forms.NumericUpDown nud_Carbs;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ErrorProvider ep_AddFoodType;
    }
}