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
	public partial class SelectSortLoadInCourseTypeForm : Form
	{
		private CourseType courseType;
		private DatabaseDataContext database;
		private List<int> selectedSortLoads;

		#region	Свойства

		public List<int> SelectedSortLoads
		{
			get
			{
				return selectedSortLoads;
			}
		}

		#endregion

		public SelectSortLoadInCourseTypeForm(CourseType courseType, DatabaseDataContext database)
		{
			InitializeComponent();

			this.courseType = courseType;
			this.database = database;
		}

		private void SelectSortLoadInCourseTypeForm_Load(object sender, EventArgs e)
		{
			List<SortLoad> sortLoads = (from s in database.SortLoad
										select s).ToList();
			foreach (SortLoad sortLoad in sortLoads)
			{
				var cb = new CheckBox { Checked = false, Tag = sortLoad };
				var lbl = new Label { Text = sortLoad.Name, AutoSize = true };
				
				tableLayoutPanelCheckBoxes.Controls.Add(lbl);
				tableLayoutPanelCheckBoxes.Controls.Add(cb);		
			}

			List<SortLoadInCourseType> selectSortLoads = (from s in database.SortLoadInCourseType
														 where s.CourseTypeID == courseType.Id
														 select s).ToList();

			foreach (SortLoadInCourseType selectSortLoad in selectSortLoads)
			{
				foreach (Control c in this.tableLayoutPanelCheckBoxes.Controls)
				{
					var box = c as CheckBox;
					if (box != null)
					{
						var cb = (CheckBox)c;
						SortLoad sortLoad = (SortLoad)cb.Tag;
						if (selectSortLoad.SortLoadID == sortLoad.Id)
						{
							cb.Checked = true;
						}
					}
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			selectedSortLoads = new List<int>();
			foreach (Control c in this.tableLayoutPanelCheckBoxes.Controls)
			{
				var box = c as CheckBox;
				if (box != null)
				{
					var cb = (CheckBox)c;
					SortLoad sortLoad = (SortLoad)cb.Tag;
					if (cb.Checked == true)
					{
						selectedSortLoads.Add(sortLoad.Id);
					}
				}
			}
		}
	}
}
