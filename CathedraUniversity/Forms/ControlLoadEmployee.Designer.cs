namespace CathedraUniversity.Forms
{
    partial class ControlLoadEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlLoadEmployee));
            this.nvgEmployee = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripGeneralTable = new System.Windows.Forms.ToolStripButton();
            this.ctlEmployeeLoad = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workloadFormColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overloadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.underloadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateFormByHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateFormColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workloadFactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateFactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nvgEmployee)).BeginInit();
            this.nvgEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlEmployeeLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // nvgEmployee
            // 
            this.nvgEmployee.AddNewItem = null;
            this.nvgEmployee.BindingSource = this.bsEmployee;
            this.nvgEmployee.CountItem = this.bindingNavigatorCountItem;
            this.nvgEmployee.DeleteItem = null;
            this.nvgEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripGeneralTable});
            this.nvgEmployee.Location = new System.Drawing.Point(0, 0);
            this.nvgEmployee.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgEmployee.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgEmployee.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgEmployee.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgEmployee.Name = "nvgEmployee";
            this.nvgEmployee.PositionItem = this.bindingNavigatorPositionItem;
            this.nvgEmployee.Size = new System.Drawing.Size(950, 25);
            this.nvgEmployee.TabIndex = 12;
            this.nvgEmployee.Text = "bindingNavigator1";
            // 
            // bsEmployee
            // 
            this.bsEmployee.DataSource = typeof(CathedraUniversity.Employee);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Расшифровка по одному преподавателю";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Расшифровка по всем (в файл Employee.txt)";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripGeneralTable
            // 
            this.toolStripGeneralTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGeneralTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGeneralTable.Image")));
            this.toolStripGeneralTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGeneralTable.Name = "toolStripGeneralTable";
            this.toolStripGeneralTable.Size = new System.Drawing.Size(23, 22);
            this.toolStripGeneralTable.Text = "Сводная таблица";
            this.toolStripGeneralTable.Click += new System.EventHandler(this.toolStripGeneralTable_Click);
            // 
            // ctlEmployeeLoad
            // 
            this.ctlEmployeeLoad.AllowUserToAddRows = false;
            this.ctlEmployeeLoad.AllowUserToDeleteRows = false;
            this.ctlEmployeeLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlEmployeeLoad.AutoGenerateColumns = false;
            this.ctlEmployeeLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlEmployeeLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.workloadFormColumn,
            this.overloadColumn,
            this.underloadColumn,
            this.rateFormByHoursColumn,
            this.rateFormColumn,
            this.workloadFactColumn,
            this.rateFactColumn});
            this.ctlEmployeeLoad.DataSource = this.bsEmployee;
            this.ctlEmployeeLoad.Location = new System.Drawing.Point(0, 28);
            this.ctlEmployeeLoad.MultiSelect = false;
            this.ctlEmployeeLoad.Name = "ctlEmployeeLoad";
            this.ctlEmployeeLoad.ReadOnly = true;
            this.ctlEmployeeLoad.Size = new System.Drawing.Size(950, 346);
            this.ctlEmployeeLoad.TabIndex = 13;
            this.ctlEmployeeLoad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlEmployeeLoad_CellClick);
            this.ctlEmployeeLoad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlEmployeeLoad_CellDoubleClick);
            this.ctlEmployeeLoad.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ctlEmployeeLoad_DataBindingComplete);
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.FillWeight = 200F;
            this.fioDataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            this.postDataGridViewTextBoxColumn.Width = 150;
            // 
            // workloadFormColumn
            // 
            this.workloadFormColumn.DataPropertyName = "WorkloadForm";
            this.workloadFormColumn.HeaderText = "Формальная нагрузка";
            this.workloadFormColumn.Name = "workloadFormColumn";
            this.workloadFormColumn.ReadOnly = true;
            // 
            // overloadColumn
            // 
            this.overloadColumn.DataPropertyName = "Overload";
            this.overloadColumn.HeaderText = "Перегрузка";
            this.overloadColumn.Name = "overloadColumn";
            this.overloadColumn.ReadOnly = true;
            // 
            // underloadColumn
            // 
            this.underloadColumn.DataPropertyName = "Underload";
            this.underloadColumn.HeaderText = "Недогрузка";
            this.underloadColumn.Name = "underloadColumn";
            this.underloadColumn.ReadOnly = true;
            // 
            // rateFormByHoursColumn
            // 
            this.rateFormByHoursColumn.DataPropertyName = "RateFormByHours";
            this.rateFormByHoursColumn.HeaderText = "Формальная нагрузка по часам";
            this.rateFormByHoursColumn.Name = "rateFormByHoursColumn";
            this.rateFormByHoursColumn.ReadOnly = true;
            // 
            // rateFormColumn
            // 
            this.rateFormColumn.DataPropertyName = "RateForm";
            this.rateFormColumn.HeaderText = "Формальная ставка";
            this.rateFormColumn.Name = "rateFormColumn";
            this.rateFormColumn.ReadOnly = true;
            // 
            // workloadFactColumn
            // 
            this.workloadFactColumn.DataPropertyName = "WorkloadFact";
            this.workloadFactColumn.HeaderText = "Фактическая нагрузка";
            this.workloadFactColumn.Name = "workloadFactColumn";
            this.workloadFactColumn.ReadOnly = true;
            // 
            // rateFactColumn
            // 
            this.rateFactColumn.DataPropertyName = "RateFact";
            this.rateFactColumn.HeaderText = "Фактическая ставка";
            this.rateFactColumn.Name = "rateFactColumn";
            this.rateFactColumn.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(645, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClose.Location = new System.Drawing.Point(726, 389);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(123, 23);
            this.btnSaveClose.TabIndex = 15;
            this.btnSaveClose.Text = "Сохранить и выйти";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(855, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ControlLoadEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 424);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctlEmployeeLoad);
            this.Controls.Add(this.nvgEmployee);
            this.Name = "ControlLoadEmployee";
            this.Text = "Нагрузка преподавателей";
            this.Load += new System.EventHandler(this.ControlLoadEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvgEmployee)).EndInit();
            this.nvgEmployee.ResumeLayout(false);
            this.nvgEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlEmployeeLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator nvgEmployee;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripGeneralTable;
        private System.Windows.Forms.DataGridView ctlEmployeeLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.BindingSource bsEmployee;
		private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workloadFormColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn overloadColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn underloadColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateFormByHoursColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateFormColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workloadFactColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateFactColumn;
    }
}