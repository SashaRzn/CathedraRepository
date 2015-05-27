namespace CathedraUniversity.Forms
{
	partial class SelectEmployeeForm
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
			this.lblSelectEmployee = new System.Windows.Forms.Label();
			this.cbChoiceEmployee = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSelectEmployee
			// 
			this.lblSelectEmployee.AutoSize = true;
			this.lblSelectEmployee.Location = new System.Drawing.Point(12, 12);
			this.lblSelectEmployee.Name = "lblSelectEmployee";
			this.lblSelectEmployee.Size = new System.Drawing.Size(140, 13);
			this.lblSelectEmployee.TabIndex = 0;
			this.lblSelectEmployee.Text = "Выберите преподавателя:";
			// 
			// cbChoiceEmployee
			// 
			this.cbChoiceEmployee.FormattingEnabled = true;
			this.cbChoiceEmployee.Location = new System.Drawing.Point(12, 28);
			this.cbChoiceEmployee.Name = "cbChoiceEmployee";
			this.cbChoiceEmployee.Size = new System.Drawing.Size(468, 21);
			this.cbChoiceEmployee.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(328, 56);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(408, 56);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// SelectEmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 87);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cbChoiceEmployee);
			this.Controls.Add(this.lblSelectEmployee);
			this.Name = "SelectEmployeeForm";
			this.Text = "Выбор преподавателя";
			this.Load += new System.EventHandler(this.SelectEmployeeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSelectEmployee;
		private System.Windows.Forms.ComboBox cbChoiceEmployee;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.BindingSource bsEmployee;
	}
}