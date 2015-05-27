namespace CathedraUniversity.Forms
{
	partial class PlaningLoadForm
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
			this.ctlPlaningLoads = new System.Windows.Forms.DataGridView();
			this.groupsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.formEmployeeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.factEmployeeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.flagColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.pochFondColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.classRoomColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.btnSplitLoadByGroups = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblSortLoad = new System.Windows.Forms.Label();
			this.lblSortLoadName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRemoveInfo = new System.Windows.Forms.Button();
			this.btnAssemblyLoad = new System.Windows.Forms.Button();
			this.btnSplitLoadInTwo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ctlPlaningLoads)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ctlPlaningLoads
			// 
			this.ctlPlaningLoads.AllowUserToAddRows = false;
			this.ctlPlaningLoads.AllowUserToDeleteRows = false;
			this.ctlPlaningLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ctlPlaningLoads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupsColumn,
            this.countHoursColumn,
            this.formEmployeeColumn,
            this.factEmployeeColumn,
            this.flagColumn,
            this.pochFondColumn,
            this.classRoomColumn});
			this.ctlPlaningLoads.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.ctlPlaningLoads.Location = new System.Drawing.Point(0, 0);
			this.ctlPlaningLoads.Name = "ctlPlaningLoads";
			this.ctlPlaningLoads.Size = new System.Drawing.Size(764, 188);
			this.ctlPlaningLoads.TabIndex = 0;
			this.ctlPlaningLoads.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlPlaningLoads_CellEndEdit);
			this.ctlPlaningLoads.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ctlPlaningLoads_CellValidating);
			this.ctlPlaningLoads.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctlPlaningLoads_CellValueChanged);
			// 
			// groupsColumn
			// 
			this.groupsColumn.HeaderText = "Группы";
			this.groupsColumn.Name = "groupsColumn";
			this.groupsColumn.ReadOnly = true;
			// 
			// countHoursColumn
			// 
			this.countHoursColumn.HeaderText = "Количество часов";
			this.countHoursColumn.Name = "countHoursColumn";
			this.countHoursColumn.ReadOnly = true;
			this.countHoursColumn.Width = 70;
			// 
			// formEmployeeColumn
			// 
			this.formEmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.formEmployeeColumn.HeaderText = "Формальный преподаватель";
			this.formEmployeeColumn.Name = "formEmployeeColumn";
			this.formEmployeeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.formEmployeeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// factEmployeeColumn
			// 
			this.factEmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.factEmployeeColumn.HeaderText = "Фактический преподаватель";
			this.factEmployeeColumn.Name = "factEmployeeColumn";
			this.factEmployeeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.factEmployeeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// flagColumn
			// 
			this.flagColumn.HeaderText = "Назначить другого фактического преподавателя";
			this.flagColumn.Name = "flagColumn";
			this.flagColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.flagColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.flagColumn.Width = 90;
			// 
			// pochFondColumn
			// 
			this.pochFondColumn.HeaderText = "Перевести в почасовой фонд";
			this.pochFondColumn.Name = "pochFondColumn";
			// 
			// classRoomColumn
			// 
			this.classRoomColumn.HeaderText = "Аудитория";
			this.classRoomColumn.Name = "classRoomColumn";
			// 
			// btnSplitLoadByGroups
			// 
			this.btnSplitLoadByGroups.Location = new System.Drawing.Point(768, 48);
			this.btnSplitLoadByGroups.Name = "btnSplitLoadByGroups";
			this.btnSplitLoadByGroups.Size = new System.Drawing.Size(108, 56);
			this.btnSplitLoadByGroups.TabIndex = 1;
			this.btnSplitLoadByGroups.Text = "Разбить нагрузку по группам";
			this.btnSplitLoadByGroups.UseVisualStyleBackColor = true;
			this.btnSplitLoadByGroups.Click += new System.EventHandler(this.btnSplitLoadByGroups_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(809, 303);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(721, 303);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "ОК";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblSortLoad
			// 
			this.lblSortLoad.AutoSize = true;
			this.lblSortLoad.Location = new System.Drawing.Point(8, 24);
			this.lblSortLoad.Name = "lblSortLoad";
			this.lblSortLoad.Size = new System.Drawing.Size(78, 13);
			this.lblSortLoad.TabIndex = 4;
			this.lblSortLoad.Text = "Вид нагрузки:";
			// 
			// lblSortLoadName
			// 
			this.lblSortLoadName.AutoSize = true;
			this.lblSortLoadName.Location = new System.Drawing.Point(92, 24);
			this.lblSortLoadName.Name = "lblSortLoadName";
			this.lblSortLoadName.Size = new System.Drawing.Size(0, 13);
			this.lblSortLoadName.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btnSplitLoadInTwo);
			this.panel1.Controls.Add(this.btnRemoveInfo);
			this.panel1.Controls.Add(this.btnAssemblyLoad);
			this.panel1.Controls.Add(this.ctlPlaningLoads);
			this.panel1.Controls.Add(this.btnSplitLoadByGroups);
			this.panel1.Location = new System.Drawing.Point(8, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(880, 192);
			this.panel1.TabIndex = 6;
			// 
			// btnRemoveInfo
			// 
			this.btnRemoveInfo.Location = new System.Drawing.Point(768, 148);
			this.btnRemoveInfo.Name = "btnRemoveInfo";
			this.btnRemoveInfo.Size = new System.Drawing.Size(108, 41);
			this.btnRemoveInfo.TabIndex = 3;
			this.btnRemoveInfo.Text = "Удалить информацию";
			this.btnRemoveInfo.UseVisualStyleBackColor = true;
			this.btnRemoveInfo.Click += new System.EventHandler(this.btnRemoveInfo_Click);
			// 
			// btnAssemblyLoad
			// 
			this.btnAssemblyLoad.Location = new System.Drawing.Point(768, 104);
			this.btnAssemblyLoad.Name = "btnAssemblyLoad";
			this.btnAssemblyLoad.Size = new System.Drawing.Size(108, 44);
			this.btnAssemblyLoad.TabIndex = 2;
			this.btnAssemblyLoad.Text = "Отменить разбиение";
			this.btnAssemblyLoad.UseVisualStyleBackColor = true;
			this.btnAssemblyLoad.Click += new System.EventHandler(this.btnAssemblyLoad_Click);
			// 
			// btnSplitLoadInTwo
			// 
			this.btnSplitLoadInTwo.Location = new System.Drawing.Point(768, 4);
			this.btnSplitLoadInTwo.Name = "btnSplitLoadInTwo";
			this.btnSplitLoadInTwo.Size = new System.Drawing.Size(108, 44);
			this.btnSplitLoadInTwo.TabIndex = 4;
			this.btnSplitLoadInTwo.Text = "Разбить пропорционально";
			this.btnSplitLoadInTwo.UseVisualStyleBackColor = true;
			this.btnSplitLoadInTwo.Click += new System.EventHandler(this.btnSplitLoadInTwo_Click);
			// 
			// PlaningLoadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 341);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblSortLoadName);
			this.Controls.Add(this.lblSortLoad);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Name = "PlaningLoadForm";
			this.Text = "Планирование учебной нагрузки";
			((System.ComponentModel.ISupportInitialize)(this.ctlPlaningLoads)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ctlPlaningLoads;
		private System.Windows.Forms.Button btnSplitLoadByGroups;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblSortLoad;
		private System.Windows.Forms.Label lblSortLoadName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAssemblyLoad;
		private System.Windows.Forms.Button btnRemoveInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupsColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countHoursColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn formEmployeeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn factEmployeeColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn flagColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn pochFondColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn classRoomColumn;
		private System.Windows.Forms.Button btnSplitLoadInTwo;


	}
}