
namespace ProjectVP_DiabetesLog
{
    partial class FormAddNewInsulinType
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
            this.tb_InsulinName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_InsulinName = new System.Windows.Forms.Label();
            this.ep_AddNewInsulinType = new System.Windows.Forms.ErrorProvider(this.components);
            this.tb_Manufacturer = new System.Windows.Forms.TextBox();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddNewInsulinType)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_InsulinName
            // 
            this.tb_InsulinName.Location = new System.Drawing.Point(142, 43);
            this.tb_InsulinName.Name = "tb_InsulinName";
            this.tb_InsulinName.Size = new System.Drawing.Size(100, 20);
            this.tb_InsulinName.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(48, 114);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Додади";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(167, 114);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Откажи";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_InsulinName
            // 
            this.lbl_InsulinName.AutoSize = true;
            this.lbl_InsulinName.Location = new System.Drawing.Point(45, 46);
            this.lbl_InsulinName.Name = "lbl_InsulinName";
            this.lbl_InsulinName.Size = new System.Drawing.Size(91, 13);
            this.lbl_InsulinName.TabIndex = 3;
            this.lbl_InsulinName.Text = "Име на инсулин:";
            // 
            // ep_AddNewInsulinType
            // 
            this.ep_AddNewInsulinType.ContainerControl = this;
            // 
            // tb_Manufacturer
            // 
            this.tb_Manufacturer.Location = new System.Drawing.Point(142, 70);
            this.tb_Manufacturer.Name = "tb_Manufacturer";
            this.tb_Manufacturer.Size = new System.Drawing.Size(100, 20);
            this.tb_Manufacturer.TabIndex = 4;
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Location = new System.Drawing.Point(45, 73);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(83, 13);
            this.lbl_Manufacturer.TabIndex = 5;
            this.lbl_Manufacturer.Text = "Производител:";
            // 
            // FormAddNewInsulinType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 174);
            this.Controls.Add(this.lbl_Manufacturer);
            this.Controls.Add(this.tb_Manufacturer);
            this.Controls.Add(this.lbl_InsulinName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_InsulinName);
            this.Name = "FormAddNewInsulinType";
            this.Text = "Додади нов тип на инсулин";
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddNewInsulinType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_InsulinName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_InsulinName;
        private System.Windows.Forms.ErrorProvider ep_AddNewInsulinType;
        private System.Windows.Forms.Label lbl_Manufacturer;
        private System.Windows.Forms.TextBox tb_Manufacturer;
    }
}