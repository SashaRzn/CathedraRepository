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

        private void ctlDirectoryEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm formEmployee = new EmployeeForm();
            formEmployee.MdiParent = this;
            formEmployee.Show();
        }

        private void ctlControlLoadCourse_Click(object sender, EventArgs e)
        {
            ControlLoadCourse formClassRoom = new ControlLoadCourse();
            formClassRoom.MdiParent = this;
            formClassRoom.Show();
        }

        private void ctlDirectoryPost_Click(object sender, EventArgs e)
        {
            PostForm formPost = new PostForm();
            formPost.MdiParent = this;
            formPost.Show();
        }

        private void ctlDirectoryRate_Click(object sender, EventArgs e)
        {
            RateForm formRate = new RateForm();
            formRate.MdiParent = this;
            formRate.Show();
        }

        private void ctlDirectoryGroup_Click(object sender, EventArgs e)
        {
            GroupForm formGroup = new GroupForm();
            formGroup.MdiParent = this;
            formGroup.Show();
        }

        private void ctlControlLoadEmployee_Click(object sender, EventArgs e)
        {
            ControlLoadEmployee formLoadEmployee = new ControlLoadEmployee();
            formLoadEmployee.MdiParent = this;
            formLoadEmployee.Show();
        }

		private void ctlDirectorySortLoad_Click(object sender, EventArgs e)
		{
			SortLoadForm formSortLoad = new SortLoadForm();
			formSortLoad.MdiParent = this;
			formSortLoad.Show();
		}
	}
}
