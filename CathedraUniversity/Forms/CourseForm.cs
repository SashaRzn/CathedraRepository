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
			bsCourseType.DataSource = database.CourseType;
			bsCourse.DataSource = bsCourseType;
			bsCourse.DataMember = "Course";

			nvgCourse.BindingSource = bsCourse;
			nvgCourseType.BindingSource = bsCourseType;

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

		private void cbCourseType_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void ctlCourseType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			CourseType courseType = (CourseType)bsCourseType.Current;
			SelectSortLoadInCourseTypeForm formSelectSortLoad = new SelectSortLoadInCourseTypeForm(courseType, database);
			if (formSelectSortLoad.ShowDialog(this) == DialogResult.OK)
			{
				List<int> selectedSortLoads = formSelectSortLoad.SelectedSortLoads;

				database.SortLoadInCourseType.DeleteAllOnSubmit(courseType.SortLoadInCourseType);
				foreach (int selectSortLoad in selectedSortLoads)
				{
					courseType.SortLoadInCourseType.Add( new SortLoadInCourseType()
					{
						SortLoadID = selectSortLoad
					});
				}
				database.SubmitChanges();
			}
		}
	}
}
