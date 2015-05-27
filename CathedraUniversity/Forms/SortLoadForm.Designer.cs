namespace CathedraUniversity.Forms
{
	partial class SortLoadForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortLoadForm));
			this.nvgSortLoad = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.ctlSortLoad = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSaveClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.bsSortLoad = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isClassDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isBisectionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isOwnerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isDivideGroupsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.indexRecalcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.nvgSortLoad)).BeginInit();
			this.nvgSortLoad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ctlSortLoad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSortLoad)).BeginInit();
			this.SuspendLayout();
			// 
			// nvgSortLoad
			// 
			this.nvgSortLoad.AddNewItem = this.bindingNavigatorAddNewItem;
			this.nvgSortLoad.BindingSource = this.bsSortLoad;
			this.nvgSortLoad.CountItem = this.bindingNavigatorCountItem;
			this.nvgSortLoad.DeleteItem = this.bindingNavigatorDeleteItem;
			this.nvgSortLoad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.nvgSortLoad.Location = new System.Drawing.Point(0, 0);
			this.nvgSortLoad.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.nvgSortLoad.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.nvgSortLoad.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.nvgSortLoad.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.nvgSortLoad.Name = "nvgSortLoad";
			this.nvgSortLoad.PositionItem = this.bindingNavigatorPositionItem;
			this.nvgSortLoad.Size = new System.Drawing.Size(605, 25);
			this.nvgSortLoad.TabIndex = 0;
			this.nvgSortLoad.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// ctlSortLoad
			// 
			this.ctlSortLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctlSortLoad.AutoGenerateColumns = false;
			this.ctlSortLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ctlSortLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameColumn,
            this.isClassDataGridViewCheckBoxColumn,
            this.isBisectionDataGridViewCheckBoxColumn,
            this.isOwnerDataGridViewCheckBoxColumn,
            this.isDivideGroupsDataGridViewCheckBoxColumn,
            this.indexRecalcDataGridViewTextBoxColumn});
			this.ctlSortLoad.DataSource = this.bsSortLoad;
			this.ctlSortLoad.Location = new System.Drawing.Point(0, 28);
			this.ctlSortLoad.Name = "ctlSortLoad";
			this.ctlSortLoad.Size = new System.Drawing.Size(604, 296);
			this.ctlSortLoad.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(521, 336);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Выйти";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveClose.Location = new System.Drawing.Point(384, 336);
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(131, 23);
			this.btnSaveClose.TabIndex = 6;
			this.btnSaveClose.Text = "Сохранить и выйти";
			this.btnSaveClose.UseVisualStyleBackColor = true;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(303, 336);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// bsSortLoad
			// 
			this.bsSortLoad.DataSource = typeof(CathedraUniversity.SortLoad);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameColumn
			// 
			this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameColumn.DataPropertyName = "Name";
			this.nameColumn.HeaderText = "Вид нагрузки";
			this.nameColumn.Name = "nameColumn";
			// 
			// isClassDataGridViewCheckBoxColumn
			// 
			this.isClassDataGridViewCheckBoxColumn.DataPropertyName = "IsClass";
			this.isClassDataGridViewCheckBoxColumn.HeaderText = "Аудиторная";
			this.isClassDataGridViewCheckBoxColumn.Name = "isClassDataGridViewCheckBoxColumn";
			// 
			// isBisectionDataGridViewCheckBoxColumn
			// 
			this.isBisectionDataGridViewCheckBoxColumn.DataPropertyName = "IsBisection";
			this.isBisectionDataGridViewCheckBoxColumn.HeaderText = "Разбивается пропорционально";
			this.isBisectionDataGridViewCheckBoxColumn.Name = "isBisectionDataGridViewCheckBoxColumn";
			// 
			// isOwnerDataGridViewCheckBoxColumn
			// 
			this.isOwnerDataGridViewCheckBoxColumn.DataPropertyName = "IsOwner";
			this.isOwnerDataGridViewCheckBoxColumn.HeaderText = "Закреплена за владельцем курса";
			this.isOwnerDataGridViewCheckBoxColumn.Name = "isOwnerDataGridViewCheckBoxColumn";
			// 
			// isDivideGroupsDataGridViewCheckBoxColumn
			// 
			this.isDivideGroupsDataGridViewCheckBoxColumn.DataPropertyName = "IsDivideGroups";
			this.isDivideGroupsDataGridViewCheckBoxColumn.HeaderText = "Разбивается по группам";
			this.isDivideGroupsDataGridViewCheckBoxColumn.Name = "isDivideGroupsDataGridViewCheckBoxColumn";
			// 
			// indexRecalcDataGridViewTextBoxColumn
			// 
			this.indexRecalcDataGridViewTextBoxColumn.DataPropertyName = "IndexRecalc";
			this.indexRecalcDataGridViewTextBoxColumn.HeaderText = "Индекс пересчета";
			this.indexRecalcDataGridViewTextBoxColumn.Name = "indexRecalcDataGridViewTextBoxColumn";
			// 
			// SortLoadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 369);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSaveClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.ctlSortLoad);
			this.Controls.Add(this.nvgSortLoad);
			this.Name = "SortLoadForm";
			this.Text = "Справочник видов нагрузок";
			this.Load += new System.EventHandler(this.SortLoadForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nvgSortLoad)).EndInit();
			this.nvgSortLoad.ResumeLayout(false);
			this.nvgSortLoad.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ctlSortLoad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsSortLoad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingNavigator nvgSortLoad;
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
		private System.Windows.Forms.DataGridView ctlSortLoad;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSaveClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.BindingSource bsSortLoad;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isClassDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isBisectionDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isOwnerDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isDivideGroupsDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn indexRecalcDataGridViewTextBoxColumn;
	}
}