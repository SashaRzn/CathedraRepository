using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraUniversity.Forms
{
	public partial class CourseForm : Form
	{
		private DatabaseDataContext database = new DatabaseDataContext();

		public CourseForm()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
			database.Dispose();
		}

		private void CourseForm_Load(object sender, EventArgs e)
		{
			bsCourse.DataSource = database.Course;

			ctlCourses.DataSource = bsCourse;
			nvgCourse.BindingSource = bsCourse;

			if (this.Parent != null)
			{
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			database.SubmitChanges();
		}

		private void btnSaveAndBack_Click(object sender, EventArgs e)
		{
			database.SubmitChanges();
			database.Dispose();
			Close();
		}
	}
}
