namespace CathedraUniversity.Forms
{
	partial class PreferencesForm
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
			this.lblSchoolYear = new System.Windows.Forms.Label();
			this.cbSchoolYear = new System.Windows.Forms.ComboBox();
			this.bsSchoolYear = new System.Windows.Forms.BindingSource(this.components);
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblLoadPercent = new System.Windows.Forms.Label();
			this.lblPochFondKodValue = new System.Windows.Forms.Label();
			this.lblFreeHoursEmployeeId = new System.Windows.Forms.Label();
			this.txtLoadPercent = new System.Windows.Forms.TextBox();
			this.txtPochFondKodValue = new System.Windows.Forms.TextBox();
			this.txtFreeHoursEmployeeId = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.bsSchoolYear)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSchoolYear
			// 
			this.lblSchoolYear.AutoSize = true;
			this.lblSchoolYear.Location = new System.Drawing.Point(16, 24);
			this.lblSchoolYear.Name = "lblSchoolYear";
			this.lblSchoolYear.Size = new System.Drawing.Size(75, 13);
			this.lblSchoolYear.TabIndex = 0;
			this.lblSchoolYear.Text = "Учебный год:";
			// 
			// cbSchoolYear
			// 
			this.cbSchoolYear.DataSource = this.bsSchoolYear;
			this.cbSchoolYear.FormattingEnabled = true;
			this.cbSchoolYear.Location = new System.Drawing.Point(288, 20);
			this.cbSchoolYear.Name = "cbSchoolYear";
			this.cbSchoolYear.Size = new System.Drawing.Size(248, 21);
			this.cbSchoolYear.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(366, 154);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(458, 154);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblLoadPercent
			// 
			this.lblLoadPercent.AutoSize = true;
			this.lblLoadPercent.Location = new System.Drawing.Point(16, 56);
			this.lblLoadPercent.Name = "lblLoadPercent";
			this.lblLoadPercent.Size = new System.Drawing.Size(164, 13);
			this.lblLoadPercent.TabIndex = 4;
			this.lblLoadPercent.Text = "Процент отклонения нагрузки:";
			// 
			// lblPochFondKodValue
			// 
			this.lblPochFondKodValue.AutoSize = true;
			this.lblPochFondKodValue.Location = new System.Drawing.Point(16, 84);
			this.lblPochFondKodValue.Name = "lblPochFondKodValue";
			this.lblPochFondKodValue.Size = new System.Drawing.Size(187, 13);
			this.lblPochFondKodValue.TabIndex = 5;
			this.lblPochFondKodValue.Text = "Код сотрудника \"Почасовой фонд\":";
			// 
			// lblFreeHoursEmployeeId
			// 
			this.lblFreeHoursEmployeeId.AutoSize = true;
			this.lblFreeHoursEmployeeId.Location = new System.Drawing.Point(16, 112);
			this.lblFreeHoursEmployeeId.Name = "lblFreeHoursEmployeeId";
			this.lblFreeHoursEmployeeId.Size = new System.Drawing.Size(250, 13);
			this.lblFreeHoursEmployeeId.TabIndex = 6;
			this.lblFreeHoursEmployeeId.Text = "Код сотрудника \"Нераспределенная нагрузка\":";
			// 
			// txtLoadPercent
			// 
			this.txtLoadPercent.Location = new System.Drawing.Point(288, 52);
			this.txtLoadPercent.Name = "txtLoadPercent";
			this.txtLoadPercent.Size = new System.Drawing.Size(248, 20);
			this.txtLoadPercent.TabIndex = 7;
			// 
			// txtPochFondKodValue
			// 
			this.txtPochFondKodValue.Location = new System.Drawing.Point(288, 80);
			this.txtPochFondKodValue.Name = "txtPochFondKodValue";
			this.txtPochFondKodValue.Size = new System.Drawing.Size(248, 20);
			this.txtPochFondKodValue.TabIndex = 8;
			// 
			// txtFreeHoursEmployeeId
			// 
			this.txtFreeHoursEmployeeId.Location = new System.Drawing.Point(288, 108);
			this.txtFreeHoursEmployeeId.Name = "txtFreeHoursEmployeeId";
			this.txtFreeHoursEmployeeId.Size = new System.Drawing.Size(248, 20);
			this.txtFreeHoursEmployeeId.TabIndex = 9;
			// 
			// PreferencesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 189);
			this.Controls.Add(this.txtFreeHoursEmployeeId);
			this.Controls.Add(this.txtPochFondKodValue);
			this.Controls.Add(this.txtLoadPercent);
			this.Controls.Add(this.lblFreeHoursEmployeeId);
			this.Controls.Add(this.lblPochFondKodValue);
			this.Controls.Add(this.lblLoadPercent);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cbSchoolYear);
			this.Controls.Add(this.lblSchoolYear);
			this.Name = "PreferencesForm";
			this.Text = "Установки";
			this.Load += new System.EventHandler(this.PreferencesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsSchoolYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSchoolYear;
		private System.Windows.Forms.ComboBox cbSchoolYear;
		private System.Windows.Forms.BindingSource bsSchoolYear;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblLoadPercent;
		private System.Windows.Forms.Label lblPochFondKodValue;
		private System.Windows.Forms.Label lblFreeHoursEmployeeId;
		private System.Windows.Forms.TextBox txtLoadPercent;
		private System.Windows.Forms.TextBox txtPochFondKodValue;
		private System.Windows.Forms.TextBox txtFreeHoursEmployeeId;
	}
}