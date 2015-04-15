using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CathedraUniversity.Forms;

namespace CathedraUniversity
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void ctlDirectoryAudience_Click(object sender, EventArgs e)
		{
			ClassRoomForm formClassRoom = new ClassRoomForm();
			formClassRoom.MdiParent = this;
			formClassRoom.Show();

		}

		private void ctlExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctlControlLoad_Click(object sender, EventArgs e)
		{
			ControlLoad formClassRoom = new ControlLoad();
			formClassRoom.MdiParent = this;
			formClassRoom.Show();
		}

		private void ctlSettings_Click(object sender, EventArgs e)
		{
			PreferencesForm fp = new PreferencesForm();
			fp.ShowDialog();
		}

		private void ctlDirectoryCourse_Click(object sender, EventArgs e)
		{
			CourseForm formCourse = new CourseForm();
			formCourse.MdiParent = this;
			formCourse.Show();
		}
	}
}
