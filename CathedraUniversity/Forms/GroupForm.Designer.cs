namespace CathedraUniversity.Forms
{
    partial class GroupForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
			this.nvgGroup = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bsGroup = new System.Windows.Forms.BindingSource(this.components);
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
			this.ctlGroup = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.group1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.specialityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isOchnikiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ctlGroupInSemestr = new System.Windows.Forms.DataGridView();
			this.bsSchoolYear = new System.Windows.Forms.BindingSource(this.components);
			this.bsGroupInSemestr = new System.Windows.Forms.BindingSource(this.components);
			this.nvgGroupInSemestr = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSaveClose = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.bsSemestr = new System.Windows.Forms.BindingSource(this.components);
			this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.schoolYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.semestrColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.quantityCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.schoolYear1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.nvgGroup)).BeginInit();
			this.nvgGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ctlGroup)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ctlGroupInSemestr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSchoolYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsGroupInSemestr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nvgGroupInSemestr)).BeginInit();
			this.nvgGroupInSemestr.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsSemestr)).BeginInit();
			this.SuspendLayout();
			// 
			// nvgGroup
			// 
			this.nvgGroup.AddNewItem = this.bindingNavigatorAddNewItem;
			this.nvgGroup.BindingSource = this.bsGroup;
			this.nvgGroup.CountItem = this.bindingNavigatorCountItem;
			this.nvgGroup.DeleteItem = this.bindingNavigatorDeleteItem;
			this.nvgGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
			this.nvgGroup.Location = new System.Drawing.Point(0, 0);
			this.nvgGroup.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.nvgGroup.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.nvgGroup.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.nvgGroup.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.nvgGroup.Name = "nvgGroup";
			this.nvgGroup.PositionItem = this.bindingNavigatorPositionItem;
			this.nvgGroup.Size = new System.Drawing.Size(762, 25);
			this.nvgGroup.TabIndex = 0;
			this.nvgGroup.Text = "bindingNavigator1";
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
			// bsGroup
			// 
			this.bsGroup.DataSource = typeof(CathedraUniversity.Group);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
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
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
			// ctlGroup
			// 
			this.ctlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctlGroup.AutoGenerateColumns = false;
			this.ctlGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ctlGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.group1DataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.specialityNameDataGridViewTextBoxColumn,
            this.isOchnikiDataGridViewTextBoxColumn});
			this.ctlGroup.DataSource = this.bsGroup;
			this.ctlGroup.Location = new System.Drawing.Point(0, 28);
			this.ctlGroup.Name = "ctlGroup";
			this.ctlGroup.Size = new System.Drawing.Size(762, 168);
			this.ctlGroup.TabIndex = 1;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.Visible = false;
			// 
			// group1DataGridViewTextBoxColumn
			// 
			this.group1DataGridViewTextBoxColumn.DataPropertyName = "Group1";
			this.group1DataGridViewTextBoxColumn.HeaderText = "Группа";
			this.group1DataGridViewTextBoxColumn.Name = "group1DataGridViewTextBoxColumn";
			// 
			// specialityDataGridViewTextBoxColumn
			// 
			this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
			this.specialityDataGridViewTextBoxColumn.HeaderText = "Специальность";
			this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
			// 
			// specialityNameDataGridViewTextBoxColumn
			// 
			this.specialityNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.specialityNameDataGridViewTextBoxColumn.DataPropertyName = "SpecialityName";
			this.specialityNameDataGridViewTextBoxColumn.HeaderText = "Наименование специальности";
			this.specialityNameDataGridViewTextBoxColumn.Name = "specialityNameDataGridViewTextBoxColumn";
			// 
			// isOchnikiDataGridViewTextBoxColumn
			// 
			this.isOchnikiDataGridViewTextBoxColumn.DataPropertyName = "IsOchniki";
			this.isOchnikiDataGridViewTextBoxColumn.HeaderText = "IsOchniki";
			this.isOchnikiDataGridViewTextBoxColumn.Name = "isOchnikiDataGridViewTextBoxColumn";
			this.isOchnikiDataGridViewTextBoxColumn.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.ctlGroupInSemestr);
			this.panel1.Controls.Add(this.nvgGroupInSemestr);
			this.panel1.Location = new System.Drawing.Point(0, 200);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(762, 205);
			this.panel1.TabIndex = 2;
			// 
			// ctlGroupInSemestr
			// 
			this.ctlGroupInSemestr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctlGroupInSemestr.AutoGenerateColumns = false;
			this.ctlGroupInSemestr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ctlGroupInSemestr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.schoolYearDataGridViewTextBoxColumn,
            this.semestrColumn,
            this.quantityCommercialDataGridViewTextBoxColumn,
            this.quantityBudgetDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.schoolYear1DataGridViewTextBoxColumn});
			this.ctlGroupInSemestr.DataSource = this.bsGroupInSemestr;
			this.ctlGroupInSemestr.Location = new System.Drawing.Point(0, 28);
			this.ctlGroupInSemestr.Name = "ctlGroupInSemestr";
			this.ctlGroupInSemestr.Size = new System.Drawing.Size(762, 177);
			this.ctlGroupInSemestr.TabIndex = 1;
			this.ctlGroupInSemestr.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.ctlGroupInSemestr_CellParsing);
			// 
			// bsSchoolYear
			// 
			this.bsSchoolYear.DataSource = typeof(CathedraUniversity.SchoolYear);
			// 
			// bsGroupInSemestr
			// 
			this.bsGroupInSemestr.DataSource = typeof(CathedraUniversity.GroupInSemestr);
			// 
			// nvgGroupInSemestr
			// 
			this.nvgGroupInSemestr.AddNewItem = this.bindingNavigatorAddNewItem1;
			this.nvgGroupInSemestr.BindingSource = this.bsGroupInSemestr;
			this.nvgGroupInSemestr.CountItem = this.bindingNavigatorCountItem1;
			this.nvgGroupInSemestr.DeleteItem = this.bindingNavigatorDeleteItem1;
			this.nvgGroupInSemestr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
			this.nvgGroupInSemestr.Location = new System.Drawing.Point(0, 0);
			this.nvgGroupInSemestr.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
			this.nvgGroupInSemestr.MoveLastItem = this.bindingNavigatorMoveLastItem1;
			this.nvgGroupInSemestr.MoveNextItem = this.bindingNavigatorMoveNextItem1;
			this.nvgGroupInSemestr.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
			this.nvgGroupInSemestr.Name = "nvgGroupInSemestr";
			this.nvgGroupInSemestr.PositionItem = this.bindingNavigatorPositionItem1;
			this.nvgGroupInSemestr.Size = new System.Drawing.Size(762, 25);
			this.nvgGroupInSemestr.TabIndex = 0;
			this.nvgGroupInSemestr.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem1
			// 
			this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
			this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
			this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem1.Text = "Добавить";
			// 
			// bindingNavigatorCountItem1
			// 
			this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
			this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem1.Text = "для {0}";
			this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem1
			// 
			this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
			this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
			this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem1.Text = "Удалить";
			// 
			// bindingNavigatorMoveFirstItem1
			// 
			this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
			this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
			this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem1
			// 
			this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
			this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
			this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator3
			// 
			this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
			this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem1
			// 
			this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem1.AutoSize = false;
			this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
			this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem1.Text = "0";
			this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator4
			// 
			this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
			this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem1
			// 
			this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
			this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
			this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem1
			// 
			this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
			this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
			this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator5
			// 
			this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
			this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(466, 411);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveClose.Location = new System.Drawing.Point(547, 411);
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(122, 23);
			this.btnSaveClose.TabIndex = 7;
			this.btnSaveClose.Text = "Сохранить и выйти";
			this.btnSaveClose.UseVisualStyleBackColor = true;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(675, 411);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Отмена";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// iDDataGridViewTextBoxColumn1
			// 
			this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
			this.iDDataGridViewTextBoxColumn1.Visible = false;
			// 
			// schoolYearDataGridViewTextBoxColumn
			// 
			this.schoolYearDataGridViewTextBoxColumn.DataPropertyName = "SchoolYear1";
			this.schoolYearDataGridViewTextBoxColumn.DataSource = this.bsSchoolYear;
			this.schoolYearDataGridViewTextBoxColumn.HeaderText = "Учебный год";
			this.schoolYearDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.schoolYearDataGridViewTextBoxColumn.Name = "schoolYearDataGridViewTextBoxColumn";
			this.schoolYearDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.schoolYearDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// semestrColumn
			// 
			this.semestrColumn.DataPropertyName = "Semestr";
			this.semestrColumn.HeaderText = "Семестр";
			this.semestrColumn.MinimumWidth = 100;
			this.semestrColumn.Name = "semestrColumn";
			this.semestrColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.semestrColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// quantityCommercialDataGridViewTextBoxColumn
			// 
			this.quantityCommercialDataGridViewTextBoxColumn.DataPropertyName = "QuantityCommercial";
			this.quantityCommercialDataGridViewTextBoxColumn.HeaderText = "Коммерческих";
			this.quantityCommercialDataGridViewTextBoxColumn.Name = "quantityCommercialDataGridViewTextBoxColumn";
			// 
			// quantityBudgetDataGridViewTextBoxColumn
			// 
			this.quantityBudgetDataGridViewTextBoxColumn.DataPropertyName = "QuantityBudget";
			this.quantityBudgetDataGridViewTextBoxColumn.HeaderText = "Бюджетных";
			this.quantityBudgetDataGridViewTextBoxColumn.Name = "quantityBudgetDataGridViewTextBoxColumn";
			// 
			// groupDataGridViewTextBoxColumn
			// 
			this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
			this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
			this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
			this.groupDataGridViewTextBoxColumn.Visible = false;
			// 
			// schoolYear1DataGridViewTextBoxColumn
			// 
			this.schoolYear1DataGridViewTextBoxColumn.DataPropertyName = "SchoolYear1";
			this.schoolYear1DataGridViewTextBoxColumn.HeaderText = "SchoolYear1";
			this.schoolYear1DataGridViewTextBoxColumn.Name = "schoolYear1DataGridViewTextBoxColumn";
			this.schoolYear1DataGridViewTextBoxColumn.Visible = false;
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 446);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnSaveClose);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ctlGroup);
			this.Controls.Add(this.nvgGroup);
			this.Name = "GroupForm";
			this.Text = "GroupForm";
			this.Load += new System.EventHandler(this.GroupForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nvgGroup)).EndInit();
			this.nvgGroup.ResumeLayout(false);
			this.nvgGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ctlGroup)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ctlGroupInSemestr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSchoolYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsGroupInSemestr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nvgGroupInSemestr)).EndInit();
			this.nvgGroupInSemestr.ResumeLayout(false);
			this.nvgGroupInSemestr.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsSemestr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator nvgGroup;
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
        private System.Windows.Forms.DataGridView ctlGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ctlGroupInSemestr;
        private System.Windows.Forms.BindingNavigator nvgGroupInSemestr;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bsGroup;
        private System.Windows.Forms.BindingSource bsGroupInSemestr;
        private System.Windows.Forms.BindingSource bsSchoolYear;
        private System.Windows.Forms.BindingSource bsSemestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn group1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn isOchnikiDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn schoolYearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn semestrColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityCommercialDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityBudgetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn schoolYear1DataGridViewTextBoxColumn;
    }
}