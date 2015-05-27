namespace CathedraUniversity.Forms
{
	partial class LoadsEmployeeForm
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
            this.ctlLoadInCourseFact = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pochFondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.courseInWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFormColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classRoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLoadInCourseInFact = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnMoveFormalPart = new System.Windows.Forms.Button();
            this.lblFormStudy = new System.Windows.Forms.Label();
            this.lblSemestr = new System.Windows.Forms.Label();
            this.btnMoveFactPart = new System.Windows.Forms.Button();
            this.panelGeneralLoad = new System.Windows.Forms.Panel();
            this.btnMoveFormAndFactPart = new System.Windows.Forms.Button();
            this.btnMoveToPochFond = new System.Windows.Forms.Button();
            this.panelFormLoad = new System.Windows.Forms.Panel();
            this.btnGoToFactEmployee = new System.Windows.Forms.Button();
            this.btnFormalChangeEmployee = new System.Windows.Forms.Button();
            this.btnMoveToFactEmployee = new System.Windows.Forms.Button();
            this.btnFormalMakeFact = new System.Windows.Forms.Button();
            this.panelFactLoad = new System.Windows.Forms.Panel();
            this.btnGoToFormalEmployee = new System.Windows.Forms.Button();
            this.btnFactChangeEmployee = new System.Windows.Forms.Button();
            this.btnMoveToFormalEmployee = new System.Windows.Forms.Button();
            this.btnFactMakeFormal = new System.Windows.Forms.Button();
            this.panelPochFondLoad = new System.Windows.Forms.Panel();
            this.btnPochFondGoToEmployee = new System.Windows.Forms.Button();
            this.btnPochFondMakeFormal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctlLoadInCourseFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadInCourseInFact)).BeginInit();
            this.panelGeneralLoad.SuspendLayout();
            this.panelFormLoad.SuspendLayout();
            this.panelFactLoad.SuspendLayout();
            this.panelPochFondLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlLoadInCourseFact
            // 
            this.ctlLoadInCourseFact.AllowUserToAddRows = false;
            this.ctlLoadInCourseFact.AllowUserToDeleteRows = false;
            this.ctlLoadInCourseFact.AutoGenerateColumns = false;
            this.ctlLoadInCourseFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlLoadInCourseFact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sortLoadColumn,
            this.countHoursDataGridViewTextBoxColumn,
            this.pochFondDataGridViewTextBoxColumn,
            this.courseInWorkDataGridViewTextBoxColumn,
            this.employeeFormColumn,
            this.employeeFactColumn,
            this.groupsColumn,
            this.classRoomColumn});
            this.ctlLoadInCourseFact.DataSource = this.bsLoadInCourseInFact;
            this.ctlLoadInCourseFact.Location = new System.Drawing.Point(8, 64);
            this.ctlLoadInCourseFact.MultiSelect = false;
            this.ctlLoadInCourseFact.Name = "ctlLoadInCourseFact";
            this.ctlLoadInCourseFact.ReadOnly = true;
            this.ctlLoadInCourseFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlLoadInCourseFact.Size = new System.Drawing.Size(592, 204);
            this.ctlLoadInCourseFact.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sortLoadColumn
            // 
            this.sortLoadColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sortLoadColumn.DataPropertyName = "SortLoadName";
            this.sortLoadColumn.HeaderText = "Вид нагрузки";
            this.sortLoadColumn.Name = "sortLoadColumn";
            this.sortLoadColumn.ReadOnly = true;
            // 
            // countHoursDataGridViewTextBoxColumn
            // 
            this.countHoursDataGridViewTextBoxColumn.DataPropertyName = "CountHours";
            this.countHoursDataGridViewTextBoxColumn.HeaderText = "Количество часов";
            this.countHoursDataGridViewTextBoxColumn.Name = "countHoursDataGridViewTextBoxColumn";
            this.countHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pochFondDataGridViewTextBoxColumn
            // 
            this.pochFondDataGridViewTextBoxColumn.DataPropertyName = "PochFond";
            this.pochFondDataGridViewTextBoxColumn.HeaderText = "PochFond";
            this.pochFondDataGridViewTextBoxColumn.Name = "pochFondDataGridViewTextBoxColumn";
            this.pochFondDataGridViewTextBoxColumn.ReadOnly = true;
            this.pochFondDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pochFondDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pochFondDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseInWorkDataGridViewTextBoxColumn
            // 
            this.courseInWorkDataGridViewTextBoxColumn.DataPropertyName = "CourseInWork";
            this.courseInWorkDataGridViewTextBoxColumn.HeaderText = "CourseInWork";
            this.courseInWorkDataGridViewTextBoxColumn.Name = "courseInWorkDataGridViewTextBoxColumn";
            this.courseInWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseInWorkDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeFormColumn
            // 
            this.employeeFormColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeFormColumn.DataPropertyName = "Employee";
            this.employeeFormColumn.HeaderText = "Ведёт формально";
            this.employeeFormColumn.Name = "employeeFormColumn";
            this.employeeFormColumn.ReadOnly = true;
            // 
            // employeeFactColumn
            // 
            this.employeeFactColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeFactColumn.DataPropertyName = "Employee1";
            this.employeeFactColumn.HeaderText = "Ведёт фактически";
            this.employeeFactColumn.Name = "employeeFactColumn";
            this.employeeFactColumn.ReadOnly = true;
            // 
            // groupsColumn
            // 
            this.groupsColumn.DataPropertyName = "Groups";
            this.groupsColumn.HeaderText = "Группы";
            this.groupsColumn.Name = "groupsColumn";
            this.groupsColumn.ReadOnly = true;
            // 
            // classRoomColumn
            // 
            this.classRoomColumn.DataPropertyName = "ClassRoomNumber";
            this.classRoomColumn.HeaderText = "Аудитория";
            this.classRoomColumn.Name = "classRoomColumn";
            this.classRoomColumn.ReadOnly = true;
            // 
            // bsLoadInCourseInFact
            // 
            this.bsLoadInCourseInFact.DataSource = typeof(CathedraUniversity.LoadInCourseFact);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(637, 280);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(12, 16);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(92, 13);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = "Название курса:";
            // 
            // btnMoveFormalPart
            // 
            this.btnMoveFormalPart.Location = new System.Drawing.Point(16, 64);
            this.btnMoveFormalPart.Name = "btnMoveFormalPart";
            this.btnMoveFormalPart.Size = new System.Drawing.Size(120, 36);
            this.btnMoveFormalPart.TabIndex = 5;
            this.btnMoveFormalPart.Text = "Перенести формальную часть";
            this.btnMoveFormalPart.UseVisualStyleBackColor = true;
            this.btnMoveFormalPart.Click += new System.EventHandler(this.btnMoveFormalPart_Click);
            // 
            // lblFormStudy
            // 
            this.lblFormStudy.AutoSize = true;
            this.lblFormStudy.Location = new System.Drawing.Point(12, 40);
            this.lblFormStudy.Name = "lblFormStudy";
            this.lblFormStudy.Size = new System.Drawing.Size(96, 13);
            this.lblFormStudy.TabIndex = 6;
            this.lblFormStudy.Text = "Форма обучения:";
            // 
            // lblSemestr
            // 
            this.lblSemestr.AutoSize = true;
            this.lblSemestr.Location = new System.Drawing.Point(236, 36);
            this.lblSemestr.Name = "lblSemestr";
            this.lblSemestr.Size = new System.Drawing.Size(54, 13);
            this.lblSemestr.TabIndex = 7;
            this.lblSemestr.Text = "Семестр:";
            // 
            // btnMoveFactPart
            // 
            this.btnMoveFactPart.Location = new System.Drawing.Point(16, 106);
            this.btnMoveFactPart.Name = "btnMoveFactPart";
            this.btnMoveFactPart.Size = new System.Drawing.Size(120, 40);
            this.btnMoveFactPart.TabIndex = 8;
            this.btnMoveFactPart.Text = "Перенести фактическую часть";
            this.btnMoveFactPart.UseVisualStyleBackColor = true;
            this.btnMoveFactPart.Click += new System.EventHandler(this.btnMoveFactPart_Click);
            // 
            // panelGeneralLoad
            // 
            this.panelGeneralLoad.Controls.Add(this.btnMoveFormAndFactPart);
            this.panelGeneralLoad.Controls.Add(this.btnMoveToPochFond);
            this.panelGeneralLoad.Controls.Add(this.btnMoveFactPart);
            this.panelGeneralLoad.Controls.Add(this.btnMoveFormalPart);
            this.panelGeneralLoad.Location = new System.Drawing.Point(604, 64);
            this.panelGeneralLoad.Name = "panelGeneralLoad";
            this.panelGeneralLoad.Size = new System.Drawing.Size(144, 204);
            this.panelGeneralLoad.TabIndex = 9;
            // 
            // btnMoveFormAndFactPart
            // 
            this.btnMoveFormAndFactPart.Location = new System.Drawing.Point(16, 3);
            this.btnMoveFormAndFactPart.Name = "btnMoveFormAndFactPart";
            this.btnMoveFormAndFactPart.Size = new System.Drawing.Size(120, 55);
            this.btnMoveFormAndFactPart.TabIndex = 10;
            this.btnMoveFormAndFactPart.Text = "Перенести формальную и фактическую часть";
            this.btnMoveFormAndFactPart.UseVisualStyleBackColor = true;
            this.btnMoveFormAndFactPart.Click += new System.EventHandler(this.btnMoveFormAndFactPart_Click);
            // 
            // btnMoveToPochFond
            // 
            this.btnMoveToPochFond.Location = new System.Drawing.Point(16, 152);
            this.btnMoveToPochFond.Name = "btnMoveToPochFond";
            this.btnMoveToPochFond.Size = new System.Drawing.Size(120, 40);
            this.btnMoveToPochFond.TabIndex = 9;
            this.btnMoveToPochFond.Text = "Перенести в почасовой фонд";
            this.btnMoveToPochFond.UseVisualStyleBackColor = true;
            this.btnMoveToPochFond.Click += new System.EventHandler(this.btnMoveToPochFond_Click);
            // 
            // panelFormLoad
            // 
            this.panelFormLoad.Controls.Add(this.btnGoToFactEmployee);
            this.panelFormLoad.Controls.Add(this.btnFormalChangeEmployee);
            this.panelFormLoad.Controls.Add(this.btnMoveToFactEmployee);
            this.panelFormLoad.Controls.Add(this.btnFormalMakeFact);
            this.panelFormLoad.Location = new System.Drawing.Point(611, 48);
            this.panelFormLoad.Name = "panelFormLoad";
            this.panelFormLoad.Size = new System.Drawing.Size(140, 214);
            this.panelFormLoad.TabIndex = 10;
            this.panelFormLoad.Visible = false;
            // 
            // btnGoToFactEmployee
            // 
            this.btnGoToFactEmployee.Location = new System.Drawing.Point(4, 148);
            this.btnGoToFactEmployee.Name = "btnGoToFactEmployee";
            this.btnGoToFactEmployee.Size = new System.Drawing.Size(120, 40);
            this.btnGoToFactEmployee.TabIndex = 3;
            this.btnGoToFactEmployee.Text = "Перейти к преподавателю";
            this.btnGoToFactEmployee.UseVisualStyleBackColor = true;
            this.btnGoToFactEmployee.Click += new System.EventHandler(this.btnGoToFactEmployee_Click);
            // 
            // btnFormalChangeEmployee
            // 
            this.btnFormalChangeEmployee.Location = new System.Drawing.Point(4, 96);
            this.btnFormalChangeEmployee.Name = "btnFormalChangeEmployee";
            this.btnFormalChangeEmployee.Size = new System.Drawing.Size(120, 48);
            this.btnFormalChangeEmployee.TabIndex = 2;
            this.btnFormalChangeEmployee.Text = "Перенести на другого преподавателя";
            this.btnFormalChangeEmployee.UseVisualStyleBackColor = true;
            this.btnFormalChangeEmployee.Click += new System.EventHandler(this.btnFormalChangeEmployee_Click);
            // 
            // btnMoveToFactEmployee
            // 
            this.btnMoveToFactEmployee.Location = new System.Drawing.Point(4, 52);
            this.btnMoveToFactEmployee.Name = "btnMoveToFactEmployee";
            this.btnMoveToFactEmployee.Size = new System.Drawing.Size(120, 36);
            this.btnMoveToFactEmployee.TabIndex = 1;
            this.btnMoveToFactEmployee.Text = "Отдать ведущему фактически";
            this.btnMoveToFactEmployee.UseVisualStyleBackColor = true;
            this.btnMoveToFactEmployee.Click += new System.EventHandler(this.btnMoveToFactEmployee_Click);
            // 
            // btnFormalMakeFact
            // 
            this.btnFormalMakeFact.Location = new System.Drawing.Point(4, 8);
            this.btnFormalMakeFact.Name = "btnFormalMakeFact";
            this.btnFormalMakeFact.Size = new System.Drawing.Size(120, 40);
            this.btnFormalMakeFact.TabIndex = 0;
            this.btnFormalMakeFact.Text = "Сделать и фактической";
            this.btnFormalMakeFact.UseVisualStyleBackColor = true;
            this.btnFormalMakeFact.Click += new System.EventHandler(this.btnFormalMakeFact_Click);
            // 
            // panelFactLoad
            // 
            this.panelFactLoad.Controls.Add(this.btnGoToFormalEmployee);
            this.panelFactLoad.Controls.Add(this.btnFactChangeEmployee);
            this.panelFactLoad.Controls.Add(this.btnMoveToFormalEmployee);
            this.panelFactLoad.Controls.Add(this.btnFactMakeFormal);
            this.panelFactLoad.Location = new System.Drawing.Point(607, 57);
            this.panelFactLoad.Name = "panelFactLoad";
            this.panelFactLoad.Size = new System.Drawing.Size(144, 208);
            this.panelFactLoad.TabIndex = 11;
            // 
            // btnGoToFormalEmployee
            // 
            this.btnGoToFormalEmployee.Location = new System.Drawing.Point(4, 160);
            this.btnGoToFormalEmployee.Name = "btnGoToFormalEmployee";
            this.btnGoToFormalEmployee.Size = new System.Drawing.Size(128, 40);
            this.btnGoToFormalEmployee.TabIndex = 3;
            this.btnGoToFormalEmployee.Text = "Перейти к преподавателю";
            this.btnGoToFormalEmployee.UseVisualStyleBackColor = true;
            this.btnGoToFormalEmployee.Click += new System.EventHandler(this.btnGoToFormalEmployee_Click);
            // 
            // btnFactChangeEmployee
            // 
            this.btnFactChangeEmployee.Location = new System.Drawing.Point(4, 104);
            this.btnFactChangeEmployee.Name = "btnFactChangeEmployee";
            this.btnFactChangeEmployee.Size = new System.Drawing.Size(128, 48);
            this.btnFactChangeEmployee.TabIndex = 2;
            this.btnFactChangeEmployee.Text = "Перенести на другого преподавателя";
            this.btnFactChangeEmployee.UseVisualStyleBackColor = true;
            this.btnFactChangeEmployee.Click += new System.EventHandler(this.btnFactChangeEmployee_Click);
            // 
            // btnMoveToFormalEmployee
            // 
            this.btnMoveToFormalEmployee.Location = new System.Drawing.Point(4, 60);
            this.btnMoveToFormalEmployee.Name = "btnMoveToFormalEmployee";
            this.btnMoveToFormalEmployee.Size = new System.Drawing.Size(128, 36);
            this.btnMoveToFormalEmployee.TabIndex = 1;
            this.btnMoveToFormalEmployee.Text = "Отдать ведущему формально";
            this.btnMoveToFormalEmployee.UseVisualStyleBackColor = true;
            this.btnMoveToFormalEmployee.Click += new System.EventHandler(this.btnMoveToFormalEmployee_Click);
            // 
            // btnFactMakeFormal
            // 
            this.btnFactMakeFormal.Location = new System.Drawing.Point(4, 12);
            this.btnFactMakeFormal.Name = "btnFactMakeFormal";
            this.btnFactMakeFormal.Size = new System.Drawing.Size(128, 40);
            this.btnFactMakeFormal.TabIndex = 0;
            this.btnFactMakeFormal.Text = "Сделать и формальной";
            this.btnFactMakeFormal.UseVisualStyleBackColor = true;
            this.btnFactMakeFormal.Click += new System.EventHandler(this.btnFactMakeFormal_Click);
            // 
            // panelPochFondLoad
            // 
            this.panelPochFondLoad.Controls.Add(this.btnPochFondGoToEmployee);
            this.panelPochFondLoad.Controls.Add(this.btnPochFondMakeFormal);
            this.panelPochFondLoad.Location = new System.Drawing.Point(620, 40);
            this.panelPochFondLoad.Name = "panelPochFondLoad";
            this.panelPochFondLoad.Size = new System.Drawing.Size(140, 180);
            this.panelPochFondLoad.TabIndex = 12;
            // 
            // btnPochFondGoToEmployee
            // 
            this.btnPochFondGoToEmployee.Location = new System.Drawing.Point(9, 77);
            this.btnPochFondGoToEmployee.Name = "btnPochFondGoToEmployee";
            this.btnPochFondGoToEmployee.Size = new System.Drawing.Size(116, 48);
            this.btnPochFondGoToEmployee.TabIndex = 1;
            this.btnPochFondGoToEmployee.Text = "Перенести на другого преподавателя";
            this.btnPochFondGoToEmployee.UseVisualStyleBackColor = true;
            this.btnPochFondGoToEmployee.Click += new System.EventHandler(this.btnPochFondGoToEmployee_Click);
            // 
            // btnPochFondMakeFormal
            // 
            this.btnPochFondMakeFormal.Location = new System.Drawing.Point(9, 25);
            this.btnPochFondMakeFormal.Name = "btnPochFondMakeFormal";
            this.btnPochFondMakeFormal.Size = new System.Drawing.Size(116, 44);
            this.btnPochFondMakeFormal.TabIndex = 0;
            this.btnPochFondMakeFormal.Text = "Сделать и формальной";
            this.btnPochFondMakeFormal.UseVisualStyleBackColor = true;
            this.btnPochFondMakeFormal.Click += new System.EventHandler(this.btnPochFondMakeFormal_Click);
            // 
            // LoadsEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 313);
            this.ControlBox = false;
            this.Controls.Add(this.panelPochFondLoad);
            this.Controls.Add(this.panelFactLoad);
            this.Controls.Add(this.panelFormLoad);
            this.Controls.Add(this.panelGeneralLoad);
            this.Controls.Add(this.lblSemestr);
            this.Controls.Add(this.lblFormStudy);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ctlLoadInCourseFact);
            this.Name = "LoadsEmployeeForm";
            this.Text = "LoadsEmployeeForm";
            this.Load += new System.EventHandler(this.LoadsEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlLoadInCourseFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadInCourseInFact)).EndInit();
            this.panelGeneralLoad.ResumeLayout(false);
            this.panelFormLoad.ResumeLayout(false);
            this.panelFactLoad.ResumeLayout(false);
            this.panelPochFondLoad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ctlLoadInCourseFact;
		private System.Windows.Forms.BindingSource bsLoadInCourseInFact;
		private System.Windows.Forms.DataGridViewTextBoxColumn loadInCoursePlanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classRoomDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lblCourseName;
		private System.Windows.Forms.Button btnMoveFormalPart;
		private System.Windows.Forms.Label lblFormStudy;
		private System.Windows.Forms.Label lblSemestr;
		private System.Windows.Forms.Button btnMoveFactPart;
		private System.Windows.Forms.Panel panelGeneralLoad;
		private System.Windows.Forms.Button btnMoveToPochFond;
		private System.Windows.Forms.Panel panelFormLoad;
		private System.Windows.Forms.Button btnFormalMakeFact;
		private System.Windows.Forms.Button btnMoveToFactEmployee;
		private System.Windows.Forms.Button btnFormalChangeEmployee;
		private System.Windows.Forms.Button btnGoToFactEmployee;
		private System.Windows.Forms.Panel panelFactLoad;
		private System.Windows.Forms.Button btnFactMakeFormal;
		private System.Windows.Forms.Button btnMoveToFormalEmployee;
		private System.Windows.Forms.Button btnFactChangeEmployee;
		private System.Windows.Forms.Button btnGoToFormalEmployee;
		private System.Windows.Forms.Panel panelPochFondLoad;
		private System.Windows.Forms.Button btnPochFondGoToEmployee;
		private System.Windows.Forms.Button btnPochFondMakeFormal;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sortLoadColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countHoursDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn pochFondDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseInWorkDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeFormColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeFactColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupsColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classRoomColumn;
        private System.Windows.Forms.Button btnMoveFormAndFactPart;
	}
}