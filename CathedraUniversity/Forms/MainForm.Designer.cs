namespace CathedraUniversity
{
	partial class MainForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectoryClassRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectoryCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectoryEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectoryPost = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectoryRate = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectoryGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDirectorySortLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlControlLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlControlLoadCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlControlLoadEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеДляРасписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlDirectory,
            this.ctlControlLoad,
            this.отчетыToolStripMenuItem,
            this.ctlSettings,
            this.ctlExit});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(873, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlDirectory
            // 
            this.ctlDirectory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlDirectoryClassRoom,
            this.ctlDirectoryCourse,
            this.ctlDirectoryEmployee,
            this.ctlDirectoryPost,
            this.ctlDirectoryRate,
            this.ctlDirectoryGroup,
            this.ctlDirectorySortLoad});
            this.ctlDirectory.Name = "ctlDirectory";
            this.ctlDirectory.Size = new System.Drawing.Size(94, 20);
            this.ctlDirectory.Text = "Справочники";
            // 
            // ctlDirectoryClassRoom
            // 
            this.ctlDirectoryClassRoom.Name = "ctlDirectoryClassRoom";
            this.ctlDirectoryClassRoom.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectoryClassRoom.Text = "Список аудиторий";
            this.ctlDirectoryClassRoom.Click += new System.EventHandler(this.ctlDirectoryAudience_Click);
            // 
            // ctlDirectoryCourse
            // 
            this.ctlDirectoryCourse.Name = "ctlDirectoryCourse";
            this.ctlDirectoryCourse.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectoryCourse.Text = "Список курсов";
            this.ctlDirectoryCourse.Click += new System.EventHandler(this.ctlDirectoryCourse_Click);
            // 
            // ctlDirectoryEmployee
            // 
            this.ctlDirectoryEmployee.Name = "ctlDirectoryEmployee";
            this.ctlDirectoryEmployee.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectoryEmployee.Text = "Список преподавателей";
            this.ctlDirectoryEmployee.Click += new System.EventHandler(this.ctlDirectoryEmployee_Click);
            // 
            // ctlDirectoryPost
            // 
            this.ctlDirectoryPost.Name = "ctlDirectoryPost";
            this.ctlDirectoryPost.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectoryPost.Text = "Список должностей";
            this.ctlDirectoryPost.Click += new System.EventHandler(this.ctlDirectoryPost_Click);
            // 
            // ctlDirectoryRate
            // 
            this.ctlDirectoryRate.Name = "ctlDirectoryRate";
            this.ctlDirectoryRate.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectoryRate.Text = "Список ставок";
            this.ctlDirectoryRate.Click += new System.EventHandler(this.ctlDirectoryRate_Click);
            // 
            // ctlDirectoryGroup
            // 
            this.ctlDirectoryGroup.Name = "ctlDirectoryGroup";
            this.ctlDirectoryGroup.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectoryGroup.Text = "Список групп";
            this.ctlDirectoryGroup.Click += new System.EventHandler(this.ctlDirectoryGroup_Click);
            // 
            // ctlDirectorySortLoad
            // 
            this.ctlDirectorySortLoad.Name = "ctlDirectorySortLoad";
            this.ctlDirectorySortLoad.Size = new System.Drawing.Size(208, 22);
            this.ctlDirectorySortLoad.Text = "Список видов нагрузкок";
            this.ctlDirectorySortLoad.Click += new System.EventHandler(this.ctlDirectorySortLoad_Click);
            // 
            // ctlControlLoad
            // 
            this.ctlControlLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlControlLoadCourse,
            this.ctlControlLoadEmployee});
            this.ctlControlLoad.Name = "ctlControlLoad";
            this.ctlControlLoad.Size = new System.Drawing.Size(144, 20);
            this.ctlControlLoad.Text = "Управление нагрузкой";
            // 
            // ctlControlLoadCourse
            // 
            this.ctlControlLoadCourse.Name = "ctlControlLoadCourse";
            this.ctlControlLoadCourse.Size = new System.Drawing.Size(182, 22);
            this.ctlControlLoadCourse.Text = "по курсам";
            this.ctlControlLoadCourse.Click += new System.EventHandler(this.ctlControlLoadCourse_Click);
            // 
            // ctlControlLoadEmployee
            // 
            this.ctlControlLoadEmployee.Name = "ctlControlLoadEmployee";
            this.ctlControlLoadEmployee.Size = new System.Drawing.Size(182, 22);
            this.ctlControlLoadEmployee.Text = "по преподавателям";
            this.ctlControlLoadEmployee.Click += new System.EventHandler(this.ctlControlLoadEmployee_Click);
            // 
            // ctlSettings
            // 
            this.ctlSettings.Name = "ctlSettings";
            this.ctlSettings.Size = new System.Drawing.Size(76, 20);
            this.ctlSettings.Text = "Установки";
            this.ctlSettings.Click += new System.EventHandler(this.ctlSettings_Click);
            // 
            // ctlExit
            // 
            this.ctlExit.Name = "ctlExit";
            this.ctlExit.Size = new System.Drawing.Size(53, 20);
            this.ctlExit.Text = "Выход";
            this.ctlExit.Click += new System.EventHandler(this.ctlExit_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеДляРасписанияToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // данныеДляРасписанияToolStripMenuItem
            // 
            this.данныеДляРасписанияToolStripMenuItem.Name = "данныеДляРасписанияToolStripMenuItem";
            this.данныеДляРасписанияToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.данныеДляРасписанияToolStripMenuItem.Text = "Данные для расписания";
            this.данныеДляРасписанияToolStripMenuItem.Click += new System.EventHandler(this.данныеДляРасписанияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 331);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Кафедра ВУЗа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlDirectory;
		private System.Windows.Forms.ToolStripMenuItem ctlDirectoryClassRoom;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
		private System.Windows.Forms.ToolStripMenuItem ctlSettings;
		private System.Windows.Forms.ToolStripMenuItem ctlDirectoryCourse;
        private System.Windows.Forms.ToolStripMenuItem ctlDirectoryEmployee;
        private System.Windows.Forms.ToolStripMenuItem ctlControlLoad;
        private System.Windows.Forms.ToolStripMenuItem ctlControlLoadCourse;
        private System.Windows.Forms.ToolStripMenuItem ctlControlLoadEmployee;
        private System.Windows.Forms.ToolStripMenuItem ctlDirectoryPost;
        private System.Windows.Forms.ToolStripMenuItem ctlDirectoryRate;
        private System.Windows.Forms.ToolStripMenuItem ctlDirectoryGroup;
		private System.Windows.Forms.ToolStripMenuItem ctlDirectorySortLoad;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеДляРасписанияToolStripMenuItem;
	}
}

