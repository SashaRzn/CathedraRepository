namespace CathedraUniversity.Forms
{
	partial class CourseInWorkForm
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCourseName = new System.Windows.Forms.Label();
			this.cbCourseName = new System.Windows.Forms.ComboBox();
			this.lblEmployee = new System.Windows.Forms.Label();
			this.cbEmployee = new System.Windows.Forms.ComboBox();
			this.lblSemestr = new System.Windows.Forms.Label();
			this.lblFormStudy = new System.Windows.Forms.Label();
			this.cbSemestr = new System.Windows.Forms.ComboBox();
			this.cbFormStudy = new System.Windows.Forms.ComboBox();
			this.bsCourse = new System.Windows.Forms.BindingSource(this.components);
			this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
			this.ctlSortLoads = new System.Windows.Forms.DataGridView();
			this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sortLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelGroups = new System.Windows.Forms.Panel();
			this.cbGroup1 = new System.Windows.Forms.ComboBox();
			this.btnGroupAdd = new System.Windows.Forms.Button();
			this.btnGroupDelete = new System.Windows.Forms.Button();
			this.btnCourseAdd = new System.Windows.Forms.Button();
			this.groupBoxStudyLoads = new System.Windows.Forms.GroupBox();
			this.bsFormStudyNew = new System.Windows.Forms.BindingSource(this.components);
			this.groupBoxGeneralnfo = new System.Windows.Forms.GroupBox();
			this.groupBoxGroups = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.bsCourse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ctlSortLoads)).BeginInit();
			this.panelGroups.SuspendLayout();
			this.groupBoxStudyLoads.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsFormStudyNew)).BeginInit();
			this.groupBoxGeneralnfo.SuspendLayout();
			this.groupBoxGroups.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(640, 397);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(84, 24);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Сохранить";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(730, 397);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(84, 24);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblCourseName
			// 
			this.lblCourseName.AutoSize = true;
			this.lblCourseName.Location = new System.Drawing.Point(8, 24);
			this.lblCourseName.Name = "lblCourseName";
			this.lblCourseName.Size = new System.Drawing.Size(89, 13);
			this.lblCourseName.TabIndex = 2;
			this.lblCourseName.Text = "Название курса";
			// 
			// cbCourseName
			// 
			this.cbCourseName.FormattingEnabled = true;
			this.cbCourseName.Location = new System.Drawing.Point(8, 40);
			this.cbCourseName.Name = "cbCourseName";
			this.cbCourseName.Size = new System.Drawing.Size(396, 21);
			this.cbCourseName.TabIndex = 3;
			// 
			// lblEmployee
			// 
			this.lblEmployee.AutoSize = true;
			this.lblEmployee.Location = new System.Drawing.Point(8, 72);
			this.lblEmployee.Name = "lblEmployee";
			this.lblEmployee.Size = new System.Drawing.Size(88, 13);
			this.lblEmployee.TabIndex = 4;
			this.lblEmployee.Text = "Владелец курса";
			// 
			// cbEmployee
			// 
			this.cbEmployee.FormattingEnabled = true;
			this.cbEmployee.Location = new System.Drawing.Point(8, 88);
			this.cbEmployee.Name = "cbEmployee";
			this.cbEmployee.Size = new System.Drawing.Size(308, 21);
			this.cbEmployee.TabIndex = 5;
			// 
			// lblSemestr
			// 
			this.lblSemestr.AutoSize = true;
			this.lblSemestr.Location = new System.Drawing.Point(8, 120);
			this.lblSemestr.Name = "lblSemestr";
			this.lblSemestr.Size = new System.Drawing.Size(51, 13);
			this.lblSemestr.TabIndex = 6;
			this.lblSemestr.Text = "Семестр";
			// 
			// lblFormStudy
			// 
			this.lblFormStudy.AutoSize = true;
			this.lblFormStudy.Location = new System.Drawing.Point(8, 168);
			this.lblFormStudy.Name = "lblFormStudy";
			this.lblFormStudy.Size = new System.Drawing.Size(93, 13);
			this.lblFormStudy.TabIndex = 7;
			this.lblFormStudy.Text = "Форма обучения";
			// 
			// cbSemestr
			// 
			this.cbSemestr.FormattingEnabled = true;
			this.cbSemestr.Location = new System.Drawing.Point(8, 136);
			this.cbSemestr.Name = "cbSemestr";
			this.cbSemestr.Size = new System.Drawing.Size(104, 21);
			this.cbSemestr.TabIndex = 8;
			// 
			// cbFormStudy
			// 
			this.cbFormStudy.FormattingEnabled = true;
			this.cbFormStudy.Location = new System.Drawing.Point(8, 180);
			this.cbFormStudy.Name = "cbFormStudy";
			this.cbFormStudy.Size = new System.Drawing.Size(100, 21);
			this.cbFormStudy.TabIndex = 9;
			// 
			// bsCourse
			// 
			this.bsCourse.DataSource = typeof(CathedraUniversity.Course);
			// 
			// bsEmployee
			// 
			this.bsEmployee.DataSource = typeof(CathedraUniversity.Employee);
			// 
			// ctlSortLoads
			// 
			this.ctlSortLoads.AllowUserToAddRows = false;
			this.ctlSortLoads.AllowUserToDeleteRows = false;
			this.ctlSortLoads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctlSortLoads.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ctlSortLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ctlSortLoads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.sortLoadColumn,
            this.countHoursColumn});
			this.ctlSortLoads.Location = new System.Drawing.Point(6, 13);
			this.ctlSortLoads.MultiSelect = false;
			this.ctlSortLoads.Name = "ctlSortLoads";
			this.ctlSortLoads.Size = new System.Drawing.Size(297, 345);
			this.ctlSortLoads.TabIndex = 10;
			this.ctlSortLoads.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlSortLoads_CellDoubleClick);
			this.ctlSortLoads.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlSortLoads_CellEndEdit);
			// 
			// idColumn
			// 
			this.idColumn.HeaderText = "Ид";
			this.idColumn.Name = "idColumn";
			this.idColumn.Visible = false;
			this.idColumn.Width = 46;
			// 
			// sortLoadColumn
			// 
			this.sortLoadColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.sortLoadColumn.HeaderText = "Вид нагрузки";
			this.sortLoadColumn.Name = "sortLoadColumn";
			this.sortLoadColumn.ReadOnly = true;
			// 
			// countHoursColumn
			// 
			this.countHoursColumn.HeaderText = "Количество часов";
			this.countHoursColumn.Name = "countHoursColumn";
			this.countHoursColumn.Width = 80;
			// 
			// panelGroups
			// 
			this.panelGroups.Controls.Add(this.cbGroup1);
			this.panelGroups.Location = new System.Drawing.Point(4, 20);
			this.panelGroups.Name = "panelGroups";
			this.panelGroups.Size = new System.Drawing.Size(124, 128);
			this.panelGroups.TabIndex = 12;
			// 
			// cbGroup1
			// 
			this.cbGroup1.FormattingEnabled = true;
			this.cbGroup1.ItemHeight = 13;
			this.cbGroup1.Location = new System.Drawing.Point(0, 0);
			this.cbGroup1.Name = "cbGroup1";
			this.cbGroup1.Size = new System.Drawing.Size(121, 21);
			this.cbGroup1.TabIndex = 0;
			// 
			// btnGroupAdd
			// 
			this.btnGroupAdd.Location = new System.Drawing.Point(132, 20);
			this.btnGroupAdd.Name = "btnGroupAdd";
			this.btnGroupAdd.Size = new System.Drawing.Size(68, 23);
			this.btnGroupAdd.TabIndex = 1;
			this.btnGroupAdd.Text = "Добавить";
			this.btnGroupAdd.UseVisualStyleBackColor = true;
			this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
			// 
			// btnGroupDelete
			// 
			this.btnGroupDelete.Location = new System.Drawing.Point(200, 20);
			this.btnGroupDelete.Name = "btnGroupDelete";
			this.btnGroupDelete.Size = new System.Drawing.Size(64, 23);
			this.btnGroupDelete.TabIndex = 13;
			this.btnGroupDelete.Text = "Удалить";
			this.btnGroupDelete.UseVisualStyleBackColor = true;
			this.btnGroupDelete.Click += new System.EventHandler(this.btnGroupDelete_Click);
			// 
			// btnCourseAdd
			// 
			this.btnCourseAdd.Location = new System.Drawing.Point(404, 40);
			this.btnCourseAdd.Name = "btnCourseAdd";
			this.btnCourseAdd.Size = new System.Drawing.Size(68, 23);
			this.btnCourseAdd.TabIndex = 15;
			this.btnCourseAdd.Text = "Добавить";
			this.btnCourseAdd.UseVisualStyleBackColor = true;
			this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
			// 
			// groupBoxStudyLoads
			// 
			this.groupBoxStudyLoads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxStudyLoads.Controls.Add(this.ctlSortLoads);
			this.groupBoxStudyLoads.Location = new System.Drawing.Point(508, 12);
			this.groupBoxStudyLoads.Name = "groupBoxStudyLoads";
			this.groupBoxStudyLoads.Size = new System.Drawing.Size(309, 364);
			this.groupBoxStudyLoads.TabIndex = 17;
			this.groupBoxStudyLoads.TabStop = false;
			this.groupBoxStudyLoads.Text = "Учебная нагрузка";
			// 
			// groupBoxGeneralnfo
			// 
			this.groupBoxGeneralnfo.Controls.Add(this.btnCourseAdd);
			this.groupBoxGeneralnfo.Controls.Add(this.lblCourseName);
			this.groupBoxGeneralnfo.Controls.Add(this.cbCourseName);
			this.groupBoxGeneralnfo.Controls.Add(this.lblEmployee);
			this.groupBoxGeneralnfo.Controls.Add(this.cbEmployee);
			this.groupBoxGeneralnfo.Controls.Add(this.lblSemestr);
			this.groupBoxGeneralnfo.Controls.Add(this.cbSemestr);
			this.groupBoxGeneralnfo.Controls.Add(this.lblFormStudy);
			this.groupBoxGeneralnfo.Controls.Add(this.cbFormStudy);
			this.groupBoxGeneralnfo.Location = new System.Drawing.Point(4, 12);
			this.groupBoxGeneralnfo.Name = "groupBoxGeneralnfo";
			this.groupBoxGeneralnfo.Size = new System.Drawing.Size(496, 216);
			this.groupBoxGeneralnfo.TabIndex = 18;
			this.groupBoxGeneralnfo.TabStop = false;
			this.groupBoxGeneralnfo.Text = "Общая информация";
			// 
			// groupBoxGroups
			// 
			this.groupBoxGroups.Controls.Add(this.panelGroups);
			this.groupBoxGroups.Controls.Add(this.btnGroupAdd);
			this.groupBoxGroups.Controls.Add(this.btnGroupDelete);
			this.groupBoxGroups.Location = new System.Drawing.Point(8, 244);
			this.groupBoxGroups.Name = "groupBoxGroups";
			this.groupBoxGroups.Size = new System.Drawing.Size(272, 160);
			this.groupBoxGroups.TabIndex = 19;
			this.groupBoxGroups.TabStop = false;
			this.groupBoxGroups.Text = "Группы";
			// 
			// CourseInWorkForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(826, 433);
			this.Controls.Add(this.groupBoxGroups);
			this.Controls.Add(this.groupBoxGeneralnfo);
			this.Controls.Add(this.groupBoxStudyLoads);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CourseInWorkForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CourseInWork";
			((System.ComponentModel.ISupportInitialize)(this.bsCourse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ctlSortLoads)).EndInit();
			this.panelGroups.ResumeLayout(false);
			this.groupBoxStudyLoads.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsFormStudyNew)).EndInit();
			this.groupBoxGeneralnfo.ResumeLayout(false);
			this.groupBoxGeneralnfo.PerformLayout();
			this.groupBoxGroups.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblCourseName;
		private System.Windows.Forms.ComboBox cbCourseName;
		private System.Windows.Forms.Label lblEmployee;
		private System.Windows.Forms.ComboBox cbEmployee;
		private System.Windows.Forms.Label lblSemestr;
		private System.Windows.Forms.Label lblFormStudy;
		private System.Windows.Forms.ComboBox cbSemestr;
		private System.Windows.Forms.ComboBox cbFormStudy;
		private System.Windows.Forms.BindingSource bsCourse;
		private System.Windows.Forms.BindingSource bsEmployee;
        private System.Windows.Forms.DataGridView ctlSortLoads;
		private System.Windows.Forms.Panel panelGroups;
		private System.Windows.Forms.Button btnGroupAdd;
		private System.Windows.Forms.ComboBox cbGroup1;
		private System.Windows.Forms.Button btnGroupDelete;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortLoadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countHoursColumn;
        private System.Windows.Forms.GroupBox groupBoxStudyLoads;
        private System.Windows.Forms.BindingSource bsFormStudyNew;
		private System.Windows.Forms.GroupBox groupBoxGeneralnfo;
		private System.Windows.Forms.GroupBox groupBoxGroups;
	}
}