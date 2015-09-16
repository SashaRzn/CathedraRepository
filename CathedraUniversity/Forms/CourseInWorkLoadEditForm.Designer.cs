namespace CathedraUniversity.Forms
{
    partial class CourseInWorkLoadEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseInWorkLoadEditForm));
            this.labelCourseName = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelGroups = new System.Windows.Forms.Label();
            this.textBoxGroups = new System.Windows.Forms.TextBox();
            this.labelSemestr = new System.Windows.Forms.Label();
            this.textBoxSemestr = new System.Windows.Forms.TextBox();
            this.bindingSourceEmployeeFact = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEmployeeForm = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortLoadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pochFondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.formEmployeeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.factEmployeeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flagColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.classRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).BeginInit();
            this.bindingNavigatorMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployeeFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployeeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(12, 39);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(151, 13);
            this.labelCourseName.TabIndex = 0;
            this.labelCourseName.Text = "Наименование дисциплины:";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCourseName.Location = new System.Drawing.Point(169, 36);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.ReadOnly = true;
            this.textBoxCourseName.Size = new System.Drawing.Size(695, 20);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // bindingNavigatorMain
            // 
            this.bindingNavigatorMain.AddNewItem = null;
            this.bindingNavigatorMain.BindingSource = this.bindingSourceMain;
            this.bindingNavigatorMain.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorMain.DeleteItem = null;
            this.bindingNavigatorMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorMain.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorMain.Name = "bindingNavigatorMain";
            this.bindingNavigatorMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorMain.Size = new System.Drawing.Size(876, 25);
            this.bindingNavigatorMain.TabIndex = 2;
            this.bindingNavigatorMain.Text = "bindingNavigator1";
            // 
            // bindingSourceMain
            // 
            this.bindingSourceMain.AllowNew = false;
            this.bindingSourceMain.DataSource = typeof(CathedraUniversity.LoadInCourseFact);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoGenerateColumns = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.SortLoadName,
            this.countHoursDataGridViewTextBoxColumn,
            this.pochFondDataGridViewTextBoxColumn,
            this.formEmployeeColumn,
            this.factEmployeeColumn,
            this.flagColumn,
            this.classRoomDataGridViewTextBoxColumn});
            this.dataGridViewMain.DataSource = this.bindingSourceMain;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(852, 240);
            this.dataGridViewMain.TabIndex = 3;
            this.dataGridViewMain.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridViewMain_CellParsing);
            this.dataGridViewMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(708, 358);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(789, 358);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(12, 64);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(47, 13);
            this.labelGroups.TabIndex = 5;
            this.labelGroups.Text = "Группы:";
            // 
            // textBoxGroups
            // 
            this.textBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroups.Location = new System.Drawing.Point(169, 61);
            this.textBoxGroups.Name = "textBoxGroups";
            this.textBoxGroups.ReadOnly = true;
            this.textBoxGroups.Size = new System.Drawing.Size(695, 20);
            this.textBoxGroups.TabIndex = 1;
            // 
            // labelSemestr
            // 
            this.labelSemestr.AutoSize = true;
            this.labelSemestr.Location = new System.Drawing.Point(12, 89);
            this.labelSemestr.Name = "labelSemestr";
            this.labelSemestr.Size = new System.Drawing.Size(54, 13);
            this.labelSemestr.TabIndex = 5;
            this.labelSemestr.Text = "Семестр:";
            // 
            // textBoxSemestr
            // 
            this.textBoxSemestr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSemestr.Location = new System.Drawing.Point(169, 86);
            this.textBoxSemestr.Name = "textBoxSemestr";
            this.textBoxSemestr.ReadOnly = true;
            this.textBoxSemestr.Size = new System.Drawing.Size(695, 20);
            this.textBoxSemestr.TabIndex = 1;
            // 
            // bindingSourceEmployeeFact
            // 
            this.bindingSourceEmployeeFact.DataSource = typeof(CathedraUniversity.Employee);
            // 
            // bindingSourceEmployeeForm
            // 
            this.bindingSourceEmployeeForm.DataSource = typeof(CathedraUniversity.Employee);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // SortLoadName
            // 
            this.SortLoadName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SortLoadName.DataPropertyName = "SortLoadName";
            this.SortLoadName.HeaderText = "Вид нагрузки";
            this.SortLoadName.Name = "SortLoadName";
            this.SortLoadName.ReadOnly = true;
            // 
            // countHoursDataGridViewTextBoxColumn
            // 
            this.countHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.countHoursDataGridViewTextBoxColumn.DataPropertyName = "CountHours";
            this.countHoursDataGridViewTextBoxColumn.HeaderText = "Часов";
            this.countHoursDataGridViewTextBoxColumn.Name = "countHoursDataGridViewTextBoxColumn";
            this.countHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.countHoursDataGridViewTextBoxColumn.Width = 64;
            // 
            // pochFondDataGridViewTextBoxColumn
            // 
            this.pochFondDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pochFondDataGridViewTextBoxColumn.DataPropertyName = "PochFond";
            this.pochFondDataGridViewTextBoxColumn.HeaderText = "Поч.фонд";
            this.pochFondDataGridViewTextBoxColumn.Name = "pochFondDataGridViewTextBoxColumn";
            this.pochFondDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pochFondDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pochFondDataGridViewTextBoxColumn.Width = 80;
            // 
            // formEmployeeColumn
            // 
            this.formEmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.formEmployeeColumn.DataPropertyName = "Employee";
            this.formEmployeeColumn.DataSource = this.bindingSourceEmployeeForm;
            this.formEmployeeColumn.HeaderText = "Формальный преподаватель";
            this.formEmployeeColumn.Name = "formEmployeeColumn";
            this.formEmployeeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formEmployeeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.formEmployeeColumn.Width = 165;
            // 
            // factEmployeeColumn
            // 
            this.factEmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.factEmployeeColumn.DataPropertyName = "Employee1";
            this.factEmployeeColumn.DataSource = this.bindingSourceEmployeeFact;
            this.factEmployeeColumn.HeaderText = "Фактический преподаватель";
            this.factEmployeeColumn.Name = "factEmployeeColumn";
            this.factEmployeeColumn.ReadOnly = true;
            this.factEmployeeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factEmployeeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.factEmployeeColumn.Width = 165;
            // 
            // flagColumn
            // 
            this.flagColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.flagColumn.DataPropertyName = "FactFormDiffers";
            this.flagColumn.HeaderText = "Назначить другого фактического преподавателя";
            this.flagColumn.Name = "flagColumn";
            this.flagColumn.Width = 101;
            // 
            // classRoomDataGridViewTextBoxColumn
            // 
            this.classRoomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classRoomDataGridViewTextBoxColumn.DataPropertyName = "ClassRoomNumber";
            this.classRoomDataGridViewTextBoxColumn.HeaderText = "Аудитория";
            this.classRoomDataGridViewTextBoxColumn.Name = "classRoomDataGridViewTextBoxColumn";
            this.classRoomDataGridViewTextBoxColumn.ReadOnly = true;
            this.classRoomDataGridViewTextBoxColumn.Width = 85;
            // 
            // CourseInWorkLoadEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 392);
            this.Controls.Add(this.labelSemestr);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.textBoxSemestr);
            this.Controls.Add(this.textBoxGroups);
            this.Controls.Add(this.bindingNavigatorMain);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelCourseName);
            this.Name = "CourseInWorkLoadEditForm";
            this.Text = "Редактирование фактической нагрузки по дисциплине";
            this.Load += new System.EventHandler(this.CourseInWorkLoadEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMain)).EndInit();
            this.bindingNavigatorMain.ResumeLayout(false);
            this.bindingNavigatorMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployeeFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployeeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.BindingNavigator bindingNavigatorMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSourceMain;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.TextBox textBoxGroups;
        private System.Windows.Forms.Label labelSemestr;
        private System.Windows.Forms.TextBox textBoxSemestr;
        private System.Windows.Forms.BindingSource bindingSourceEmployeeFact;
        private System.Windows.Forms.BindingSource bindingSourceEmployeeForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortLoadName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pochFondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn formEmployeeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn factEmployeeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flagColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classRoomDataGridViewTextBoxColumn;
    }
}