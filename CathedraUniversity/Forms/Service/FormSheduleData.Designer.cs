namespace CathedraUniversity.Forms.Service
{
    partial class FormSheduleData
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
            this.groupBoxWorkloadType = new System.Windows.Forms.GroupBox();
            this.radioButtonZaochniki = new System.Windows.Forms.RadioButton();
            this.radioButtonOchniki = new System.Windows.Forms.RadioButton();
            this.labelSemestr = new System.Windows.Forms.Label();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.comboBoxSchoolYear = new System.Windows.Forms.ComboBox();
            this.labelSchoolYear = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.schoolYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxWorkloadType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxWorkloadType
            // 
            this.groupBoxWorkloadType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxWorkloadType.Controls.Add(this.radioButtonZaochniki);
            this.groupBoxWorkloadType.Controls.Add(this.radioButtonOchniki);
            this.groupBoxWorkloadType.Location = new System.Drawing.Point(12, 60);
            this.groupBoxWorkloadType.Name = "groupBoxWorkloadType";
            this.groupBoxWorkloadType.Size = new System.Drawing.Size(343, 37);
            this.groupBoxWorkloadType.TabIndex = 16;
            this.groupBoxWorkloadType.TabStop = false;
            this.groupBoxWorkloadType.Text = "Тип нагрузки";
            // 
            // radioButtonZaochniki
            // 
            this.radioButtonZaochniki.AutoSize = true;
            this.radioButtonZaochniki.Location = new System.Drawing.Point(170, 14);
            this.radioButtonZaochniki.Name = "radioButtonZaochniki";
            this.radioButtonZaochniki.Size = new System.Drawing.Size(73, 17);
            this.radioButtonZaochniki.TabIndex = 0;
            this.radioButtonZaochniki.Text = "Заочники";
            this.radioButtonZaochniki.UseVisualStyleBackColor = true;
            // 
            // radioButtonOchniki
            // 
            this.radioButtonOchniki.AutoSize = true;
            this.radioButtonOchniki.Checked = true;
            this.radioButtonOchniki.Location = new System.Drawing.Point(17, 14);
            this.radioButtonOchniki.Name = "radioButtonOchniki";
            this.radioButtonOchniki.Size = new System.Drawing.Size(62, 17);
            this.radioButtonOchniki.TabIndex = 0;
            this.radioButtonOchniki.TabStop = true;
            this.radioButtonOchniki.Text = "Очники";
            this.radioButtonOchniki.UseVisualStyleBackColor = true;
            // 
            // labelSemestr
            // 
            this.labelSemestr.AutoSize = true;
            this.labelSemestr.Location = new System.Drawing.Point(12, 33);
            this.labelSemestr.Name = "labelSemestr";
            this.labelSemestr.Size = new System.Drawing.Size(54, 13);
            this.labelSemestr.TabIndex = 13;
            this.labelSemestr.Text = "Семестр:";
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Location = new System.Drawing.Point(182, 33);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSemestr.TabIndex = 11;
            // 
            // comboBoxSchoolYear
            // 
            this.comboBoxSchoolYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSchoolYear.DataSource = this.schoolYearBindingSource;
            this.comboBoxSchoolYear.FormattingEnabled = true;
            this.comboBoxSchoolYear.Location = new System.Drawing.Point(182, 6);
            this.comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            this.comboBoxSchoolYear.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSchoolYear.TabIndex = 12;
            // 
            // labelSchoolYear
            // 
            this.labelSchoolYear.AutoSize = true;
            this.labelSchoolYear.Location = new System.Drawing.Point(12, 9);
            this.labelSchoolYear.Name = "labelSchoolYear";
            this.labelSchoolYear.Size = new System.Drawing.Size(75, 13);
            this.labelSchoolYear.TabIndex = 10;
            this.labelSchoolYear.Text = "Учебный год:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(280, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(168, 120);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(106, 23);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // schoolYearBindingSource
            // 
            this.schoolYearBindingSource.DataSource = typeof(CathedraUniversity.SchoolYear);
            // 
            // FormSheduleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 155);
            this.Controls.Add(this.groupBoxWorkloadType);
            this.Controls.Add(this.labelSemestr);
            this.Controls.Add(this.comboBoxSemestr);
            this.Controls.Add(this.comboBoxSchoolYear);
            this.Controls.Add(this.labelSchoolYear);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FormSheduleData";
            this.Text = "Данные для расписаний";
            this.Load += new System.EventHandler(this.FormSheduleData_Load);
            this.groupBoxWorkloadType.ResumeLayout(false);
            this.groupBoxWorkloadType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWorkloadType;
        private System.Windows.Forms.RadioButton radioButtonZaochniki;
        private System.Windows.Forms.RadioButton radioButtonOchniki;
        private System.Windows.Forms.Label labelSemestr;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.ComboBox comboBoxSchoolYear;
        private System.Windows.Forms.Label labelSchoolYear;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.BindingSource schoolYearBindingSource;
    }
}