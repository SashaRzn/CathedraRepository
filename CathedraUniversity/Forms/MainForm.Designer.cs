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
			this.ctlControlLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ctlDirectoryCourse = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlDirectory,
            this.ctlControlLoad,
            this.ctlSettings,
            this.ctlExit});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(594, 24);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			// 
			// ctlDirectory
			// 
			this.ctlDirectory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlDirectoryClassRoom,
            this.ctlDirectoryCourse});
			this.ctlDirectory.Name = "ctlDirectory";
			this.ctlDirectory.Size = new System.Drawing.Size(94, 20);
			this.ctlDirectory.Text = "Справочники";
			// 
			// ctlDirectoryClassRoom
			// 
			this.ctlDirectoryClassRoom.Name = "ctlDirectoryClassRoom";
			this.ctlDirectoryClassRoom.Size = new System.Drawing.Size(176, 22);
			this.ctlDirectoryClassRoom.Text = "Список аудиторий";
			this.ctlDirectoryClassRoom.Click += new System.EventHandler(this.ctlDirectoryAudience_Click);
			// 
			// ctlControlLoad
			// 
			this.ctlControlLoad.Name = "ctlControlLoad";
			this.ctlControlLoad.Size = new System.Drawing.Size(144, 20);
			this.ctlControlLoad.Text = "Управление нагрузкой";
			this.ctlControlLoad.Click += new System.EventHandler(this.ctlControlLoad_Click);
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
			// ctlDirectoryCourse
			// 
			this.ctlDirectoryCourse.Name = "ctlDirectoryCourse";
			this.ctlDirectoryCourse.Size = new System.Drawing.Size(176, 22);
			this.ctlDirectoryCourse.Text = "Список курсов";
			this.ctlDirectoryCourse.Click += new System.EventHandler(this.ctlDirectoryCourse_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 300);
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
		private System.Windows.Forms.ToolStripMenuItem ctlControlLoad;
		private System.Windows.Forms.ToolStripMenuItem ctlSettings;
		private System.Windows.Forms.ToolStripMenuItem ctlDirectoryCourse;
	}
}

