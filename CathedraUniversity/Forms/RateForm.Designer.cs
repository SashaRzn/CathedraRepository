namespace CathedraUniversity.Forms
{
    partial class RateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateForm));
            this.nvgRate = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bsRate = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSchoolYear = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ctlRate = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolYearIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.schoolYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsPost = new System.Windows.Forms.BindingSource(this.components);
            this.isTradeUnionMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectedRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postSalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeSurchargeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postSurchargeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pochFondLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nvgRate)).BeginInit();
            this.nvgRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPost)).BeginInit();
            this.SuspendLayout();
            // 
            // nvgRate
            // 
            this.nvgRate.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nvgRate.BindingSource = this.bsRate;
            this.nvgRate.CountItem = this.bindingNavigatorCountItem;
            this.nvgRate.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nvgRate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSchoolYear,
            this.toolStripButton});
            this.nvgRate.Location = new System.Drawing.Point(0, 0);
            this.nvgRate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgRate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgRate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgRate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgRate.Name = "nvgRate";
            this.nvgRate.PositionItem = this.bindingNavigatorPositionItem;
            this.nvgRate.Size = new System.Drawing.Size(768, 25);
            this.nvgRate.TabIndex = 2;
            this.nvgRate.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bsRate
            // 
            this.bsRate.DataSource = typeof(CathedraUniversity.Rate);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // toolStripSchoolYear
            // 
            this.toolStripSchoolYear.Name = "toolStripSchoolYear";
            this.toolStripSchoolYear.Size = new System.Drawing.Size(121, 25);
            this.toolStripSchoolYear.SelectedIndexChanged += new System.EventHandler(this.toolStripSchoolYear_SelectedIndexChanged);
            // 
            // toolStripButton
            // 
            this.toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton.Image")));
            this.toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton.Name = "toolStripButton";
            this.toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton.Text = "Статистика";
            this.toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // ctlRate
            // 
            this.ctlRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlRate.AutoGenerateColumns = false;
            this.ctlRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.schoolYearIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.postIDDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.schoolYearColumn,
            this.postDataGridViewTextBoxColumn,
            this.isTradeUnionMemberDataGridViewTextBoxColumn,
            this.rate1DataGridViewTextBoxColumn,
            this.CorrectedRateColumn,
            this.baseSalaryColumn,
            this.postSalaryColumn,
            this.gradeSurchargeColumn,
            this.postSurchargeColumn1,
            this.pochFondLimitDataGridViewTextBoxColumn});
            this.ctlRate.DataSource = this.bsRate;
            this.ctlRate.Location = new System.Drawing.Point(0, 28);
            this.ctlRate.Name = "ctlRate";
            this.ctlRate.Size = new System.Drawing.Size(768, 327);
            this.ctlRate.TabIndex = 3;
            this.ctlRate.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlRate_CellEndEdit);
            this.ctlRate.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.ctlRate_CellParsing);
            this.ctlRate.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlRate_CellValueChanged);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // schoolYearIDDataGridViewTextBoxColumn
            // 
            this.schoolYearIDDataGridViewTextBoxColumn.DataPropertyName = "SchoolYearID";
            this.schoolYearIDDataGridViewTextBoxColumn.HeaderText = "SchoolYearID";
            this.schoolYearIDDataGridViewTextBoxColumn.Name = "schoolYearIDDataGridViewTextBoxColumn";
            this.schoolYearIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // postIDDataGridViewTextBoxColumn
            // 
            this.postIDDataGridViewTextBoxColumn.DataPropertyName = "PostID";
            this.postIDDataGridViewTextBoxColumn.HeaderText = "PostID";
            this.postIDDataGridViewTextBoxColumn.Name = "postIDDataGridViewTextBoxColumn";
            this.postIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.DataSource = this.bsEmployee;
            this.employeeDataGridViewTextBoxColumn.FillWeight = 150F;
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.employeeDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsEmployee
            // 
            this.bsEmployee.DataSource = typeof(CathedraUniversity.Employee);
            // 
            // schoolYearColumn
            // 
            this.schoolYearColumn.DataPropertyName = "SchoolYear";
            this.schoolYearColumn.HeaderText = "Учебный год";
            this.schoolYearColumn.Name = "schoolYearColumn";
            this.schoolYearColumn.Visible = false;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.DataSource = this.bsPost;
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.postDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsPost
            // 
            this.bsPost.DataSource = typeof(CathedraUniversity.Post);
            // 
            // isTradeUnionMemberDataGridViewTextBoxColumn
            // 
            this.isTradeUnionMemberDataGridViewTextBoxColumn.DataPropertyName = "IsTradeUnionMember";
            this.isTradeUnionMemberDataGridViewTextBoxColumn.HeaderText = "Член профсоюза";
            this.isTradeUnionMemberDataGridViewTextBoxColumn.Name = "isTradeUnionMemberDataGridViewTextBoxColumn";
            this.isTradeUnionMemberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isTradeUnionMemberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isTradeUnionMemberDataGridViewTextBoxColumn.Width = 80;
            // 
            // rate1DataGridViewTextBoxColumn
            // 
            this.rate1DataGridViewTextBoxColumn.DataPropertyName = "Rate1";
            this.rate1DataGridViewTextBoxColumn.HeaderText = "Ставка";
            this.rate1DataGridViewTextBoxColumn.Name = "rate1DataGridViewTextBoxColumn";
            // 
            // CorrectedRateColumn
            // 
            this.CorrectedRateColumn.DataPropertyName = "CorrectedRate";
            this.CorrectedRateColumn.HeaderText = "Приведенная ставка";
            this.CorrectedRateColumn.Name = "CorrectedRateColumn";
            // 
            // baseSalaryColumn
            // 
            this.baseSalaryColumn.DataPropertyName = "BaseSalary";
            this.baseSalaryColumn.HeaderText = "Базовый оклад";
            this.baseSalaryColumn.Name = "baseSalaryColumn";
            // 
            // postSalaryColumn
            // 
            this.postSalaryColumn.DataPropertyName = "PostSalary";
            this.postSalaryColumn.HeaderText = "Должностной оклад";
            this.postSalaryColumn.Name = "postSalaryColumn";
            // 
            // gradeSurchargeColumn
            // 
            this.gradeSurchargeColumn.DataPropertyName = "GradeSurcharge";
            this.gradeSurchargeColumn.HeaderText = "Доплата за степень";
            this.gradeSurchargeColumn.Name = "gradeSurchargeColumn";
            // 
            // postSurchargeColumn1
            // 
            this.postSurchargeColumn1.DataPropertyName = "PostSurcharge";
            this.postSurchargeColumn1.HeaderText = "Доплата за должность";
            this.postSurchargeColumn1.Name = "postSurchargeColumn1";
            // 
            // pochFondLimitDataGridViewTextBoxColumn
            // 
            this.pochFondLimitDataGridViewTextBoxColumn.DataPropertyName = "PochFondLimit";
            this.pochFondLimitDataGridViewTextBoxColumn.HeaderText = "Лимит почасового фонда";
            this.pochFondLimitDataGridViewTextBoxColumn.Name = "pochFondLimitDataGridViewTextBoxColumn";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(472, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClose.Location = new System.Drawing.Point(553, 361);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(122, 23);
            this.btnSaveClose.TabIndex = 10;
            this.btnSaveClose.Text = "Сохранить и выйти";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(681, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 396);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctlRate);
            this.Controls.Add(this.nvgRate);
            this.Name = "RateForm";
            this.Text = "Список ставок";
            this.Load += new System.EventHandler(this.RateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvgRate)).EndInit();
            this.nvgRate.ResumeLayout(false);
            this.nvgRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator nvgRate;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripSchoolYear;
        private System.Windows.Forms.ToolStripButton toolStripButton;
        private System.Windows.Forms.DataGridView ctlRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bsRate;
        private System.Windows.Forms.BindingSource bsEmployee;
		private System.Windows.Forms.BindingSource bsPost;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn schoolYearIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn postIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn employeeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn schoolYearColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn postDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isTradeUnionMemberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rate1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CorrectedRateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn baseSalaryColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn postSalaryColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gradeSurchargeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn postSurchargeColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn pochFondLimitDataGridViewTextBoxColumn;
    }
}