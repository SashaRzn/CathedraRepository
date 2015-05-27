namespace CathedraUniversity.Forms
{
	partial class ControlLoadCourse
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
			this.ctlCourseInWork = new System.Windows.Forms.DataGridView();
			this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.semestrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.formStudyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPlanHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDistribHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsCourseInWork = new System.Windows.Forms.BindingSource(this.components);
			this.bsGroupInCourse = new System.Windows.Forms.BindingSource(this.components);
			this.bsSemestr = new System.Windows.Forms.BindingSource(this.components);
			this.bsFormStudy = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbCourseType = new System.Windows.Forms.ComboBox();
			this.lblCourseType = new System.Windows.Forms.Label();
			this.cbFormStudy = new System.Windows.Forms.ComboBox();
			this.lblFormStudy = new System.Windows.Forms.Label();
			this.cbSemestr = new System.Windows.Forms.ComboBox();
			this.lblSemestr = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextAddCourse = new System.Windows.Forms.ToolStripMenuItem();
			this.contextEditCourse = new System.Windows.Forms.ToolStripMenuItem();
			this.contextDeleteCourse = new System.Windows.Forms.ToolStripMenuItem();
			this.bsCourseType = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ctlCourseInWork)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCourseInWork)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsGroupInCourse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSemestr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsFormStudy)).BeginInit();
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsCourseType)).BeginInit();
			this.SuspendLayout();
			// 
			// ctlCourseInWork
			// 
			this.ctlCourseInWork.AllowUserToAddRows = false;
			this.ctlCourseInWork.AllowUserToDeleteRows = false;
			this.ctlCourseInWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctlCourseInWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ctlCourseInWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.courseColumn,
            this.semestrColumn,
            this.formStudyColumn,
            this.employeeColumn,
            this.groupsColumn,
            this.totalPlanHoursColumn,
            this.totalDistribHoursColumn});
			this.ctlCourseInWork.Location = new System.Drawing.Point(0, 60);
			this.ctlCourseInWork.MultiSelect = false;
			this.ctlCourseInWork.Name = "ctlCourseInWork";
			this.ctlCourseInWork.ReadOnly = true;
			this.ctlCourseInWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ctlCourseInWork.Size = new System.Drawing.Size(1028, 284);
			this.ctlCourseInWork.TabIndex = 1;
			this.ctlCourseInWork.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlCourseInWork_CellMouseDoubleClick);
			// 
			// idColumn
			// 
			this.idColumn.HeaderText = "ID";
			this.idColumn.Name = "idColumn";
			this.idColumn.ReadOnly = true;
			this.idColumn.Visible = false;
			// 
			// courseColumn
			// 
			this.courseColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.courseColumn.HeaderText = "Название курса";
			this.courseColumn.Name = "courseColumn";
			this.courseColumn.ReadOnly = true;
			// 
			// semestrColumn
			// 
			this.semestrColumn.HeaderText = "Семестр";
			this.semestrColumn.Name = "semestrColumn";
			this.semestrColumn.ReadOnly = true;
			this.semestrColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// formStudyColumn
			// 
			this.formStudyColumn.HeaderText = "Форма обучения";
			this.formStudyColumn.Name = "formStudyColumn";
			this.formStudyColumn.ReadOnly = true;
			this.formStudyColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// employeeColumn
			// 
			this.employeeColumn.HeaderText = "Владелец";
			this.employeeColumn.Name = "employeeColumn";
			this.employeeColumn.ReadOnly = true;
			this.employeeColumn.Width = 180;
			// 
			// groupsColumn
			// 
			this.groupsColumn.HeaderText = "Группы";
			this.groupsColumn.Name = "groupsColumn";
			this.groupsColumn.ReadOnly = true;
			this.groupsColumn.Width = 160;
			// 
			// totalPlanHoursColumn
			// 
			this.totalPlanHoursColumn.HeaderText = "Всего запланировано часов";
			this.totalPlanHoursColumn.Name = "totalPlanHoursColumn";
			this.totalPlanHoursColumn.ReadOnly = true;
			// 
			// totalDistribHoursColumn
			// 
			this.totalDistribHoursColumn.HeaderText = "Всего распределено часов";
			this.totalDistribHoursColumn.Name = "totalDistribHoursColumn";
			this.totalDistribHoursColumn.ReadOnly = true;
			// 
			// bsCourseInWork
			// 
			this.bsCourseInWork.DataSource = typeof(CathedraUniversity.CourseInWork);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbCourseType);
			this.panel1.Controls.Add(this.lblCourseType);
			this.panel1.Controls.Add(this.cbFormStudy);
			this.panel1.Controls.Add(this.lblFormStudy);
			this.panel1.Controls.Add(this.cbSemestr);
			this.panel1.Controls.Add(this.lblSemestr);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 60);
			this.panel1.TabIndex = 3;
			// 
			// cbCourseType
			// 
			this.cbCourseType.FormattingEnabled = true;
			this.cbCourseType.Location = new System.Drawing.Point(88, 16);
			this.cbCourseType.Name = "cbCourseType";
			this.cbCourseType.Size = new System.Drawing.Size(189, 21);
			this.cbCourseType.TabIndex = 5;
			this.cbCourseType.SelectedIndexChanged += new System.EventHandler(this.cbCourseType_SelectedIndexChanged);
			// 
			// lblCourseType
			// 
			this.lblCourseType.AutoSize = true;
			this.lblCourseType.Location = new System.Drawing.Point(20, 20);
			this.lblCourseType.Name = "lblCourseType";
			this.lblCourseType.Size = new System.Drawing.Size(61, 13);
			this.lblCourseType.TabIndex = 4;
			this.lblCourseType.Text = "Тип курса:";
			// 
			// cbFormStudy
			// 
			this.cbFormStudy.FormattingEnabled = true;
			this.cbFormStudy.Location = new System.Drawing.Point(608, 16);
			this.cbFormStudy.Name = "cbFormStudy";
			this.cbFormStudy.Size = new System.Drawing.Size(121, 21);
			this.cbFormStudy.TabIndex = 3;
			this.cbFormStudy.SelectedIndexChanged += new System.EventHandler(this.cbFormStudy_SelectedIndexChanged);
			// 
			// lblFormStudy
			// 
			this.lblFormStudy.AutoSize = true;
			this.lblFormStudy.Location = new System.Drawing.Point(508, 20);
			this.lblFormStudy.Name = "lblFormStudy";
			this.lblFormStudy.Size = new System.Drawing.Size(96, 13);
			this.lblFormStudy.TabIndex = 2;
			this.lblFormStudy.Text = "Форма обучения:";
			// 
			// cbSemestr
			// 
			this.cbSemestr.FormattingEnabled = true;
			this.cbSemestr.Location = new System.Drawing.Point(368, 16);
			this.cbSemestr.Name = "cbSemestr";
			this.cbSemestr.Size = new System.Drawing.Size(121, 21);
			this.cbSemestr.TabIndex = 1;
			this.cbSemestr.SelectedIndexChanged += new System.EventHandler(this.cbSemestr_SelectedIndexChanged);
			// 
			// lblSemestr
			// 
			this.lblSemestr.AutoSize = true;
			this.lblSemestr.Location = new System.Drawing.Point(308, 20);
			this.lblSemestr.Name = "lblSemestr";
			this.lblSemestr.Size = new System.Drawing.Size(54, 13);
			this.lblSemestr.TabIndex = 0;
			this.lblSemestr.Text = "Семестр:";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(624, 368);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Добавить курс";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(756, 368);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(120, 23);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.Text = "Редактировать";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(888, 368);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 23);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Location = new System.Drawing.Point(888, 400);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 23);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Выйти";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAddCourse,
            this.contextEditCourse,
            this.contextDeleteCourse});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
			// 
			// contextAddCourse
			// 
			this.contextAddCourse.Name = "contextAddCourse";
			this.contextAddCourse.Size = new System.Drawing.Size(154, 22);
			this.contextAddCourse.Text = "Добавить";
			this.contextAddCourse.Click += new System.EventHandler(this.contextAddCourse_Click);
			// 
			// contextEditCourse
			// 
			this.contextEditCourse.Name = "contextEditCourse";
			this.contextEditCourse.Size = new System.Drawing.Size(154, 22);
			this.contextEditCourse.Text = "Редактировать";
			this.contextEditCourse.Click += new System.EventHandler(this.contextEditCourse_Click);
			// 
			// contextDeleteCourse
			// 
			this.contextDeleteCourse.Name = "contextDeleteCourse";
			this.contextDeleteCourse.Size = new System.Drawing.Size(154, 22);
			this.contextDeleteCourse.Text = "Удалить";
			this.contextDeleteCourse.Click += new System.EventHandler(this.contextDeleteCourse_Click);
			// 
			// ControlLoad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 427);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ctlCourseInWork);
			this.Name = "ControlLoad";
			this.Text = "ControlLoad";
			this.Load += new System.EventHandler(this.ControlLoad_Load);
			((System.ComponentModel.ISupportInitialize)(this.ctlCourseInWork)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsCourseInWork)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsGroupInCourse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSemestr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsFormStudy)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsCourseType)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ctlCourseInWork;
		private System.Windows.Forms.BindingSource bsCourseInWork;
		private System.Windows.Forms.BindingSource bsGroupInCourse;
		private System.Windows.Forms.BindingSource bsSemestr;
		private System.Windows.Forms.BindingSource bsFormStudy;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbFormStudy;
		private System.Windows.Forms.Label lblFormStudy;
		private System.Windows.Forms.ComboBox cbSemestr;
		private System.Windows.Forms.Label lblSemestr;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem contextDeleteCourse;
        private System.Windows.Forms.ToolStripMenuItem contextAddCourse;
        private System.Windows.Forms.ToolStripMenuItem contextEditCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formStudyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPlanHoursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDistribHoursColumn;
		private System.Windows.Forms.ComboBox cbCourseType;
		private System.Windows.Forms.Label lblCourseType;
		private System.Windows.Forms.BindingSource bsCourseType;
	}
}