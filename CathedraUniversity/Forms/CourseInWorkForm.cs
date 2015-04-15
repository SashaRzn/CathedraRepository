﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CathedraUniversity.Forms.Classes;

namespace CathedraUniversity.Forms
{
	public partial class CourseInWorkForm : Form
	{
		private int courseId;
		private int employeeId;
		private Nullable<short> semestr;
		private bool formStudy;
		private List<WorkLoad> workLoads = new List<WorkLoad>();
		private List<int> selectedGroups;
		private CourseInWork currentCourseInWork;

        private DatabaseDataContext contextDatabase;

		#region Properties

		public int СourseId
		{
			get
			{
				return courseId;
			}
		}

		public int EmployeeId
		{
			get
			{
				return employeeId;
			}
		}

		public Nullable<short> Semestr
		{
			get
			{
				return semestr;
			}
		}

		public bool FormStudy
		{
			get
			{
				return formStudy;
			}
		}

		public List<WorkLoad> WorkLoads
		{
			get
			{
				return workLoads;
			}
		}

		public List<int> SelectedGroups
		{
			get
			{
				return selectedGroups;
			}
		}

		#endregion

		public CourseInWorkForm(BindingSource bsSemestr, bool formStudy, DatabaseDataContext database)
		{
			InitializeComponent();

            contextDatabase = database;
			InitInterface(bsSemestr, formStudy, database);
			InitComboboxGroup(database);


			var querySortLoad = from c in database.SortLoad
								select c;
			foreach (SortLoad sortLoad in querySortLoad)
			{
				workLoads.Add(new WorkLoad()
				{
					SortLoadId = sortLoad.Id,
					SortLoadName = sortLoad.Name,
					CountHours = 0
				});
			}
			foreach (WorkLoad workLoad in workLoads)
			{
				ctlSortLoads.Rows.Add(workLoad.SortLoadId, workLoad.SortLoadName, workLoad.CountHours);
			}
			ctlSortLoads.Rows.Add("", "Часов всего", 0);
			int countRows = ctlSortLoads.Rows.Count;
			ctlSortLoads.Rows[countRows - 1].Cells[2].ReadOnly = true;
		}

		private void InitComboboxGroup(DatabaseDataContext database)
		{
			int schoolYearId = Settings.SchoolYearId;

			cbGroup1.DataSource = from g in database.GroupInSemestr
								  where g.SchoolYear == schoolYearId && g.Semestr == (short)cbSemestr.SelectedValue
								  select g;

			cbGroup1.DisplayMember = "GroupName";
			cbGroup1.ValueMember = "ID";
			cbGroup1.SelectedValue = -1;
			cbGroup1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbGroup1.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		public CourseInWorkForm(CourseInWork courseInWork, BindingSource bsSemestr, bool formStudy, DatabaseDataContext database)
		{
			InitializeComponent();

            contextDatabase = database;
            currentCourseInWork = courseInWork;

			InitInterface(bsSemestr, formStudy, database);
			cbCourseName.SelectedValue = courseInWork.CourseID;
			cbEmployee.SelectedValue = (courseInWork.Employee != null) ? courseInWork.EmployeeID : -1;
			cbSemestr.SelectedValue = courseInWork.Semestr;
			cbFormStudy.SelectedValue = courseInWork.FormStudy;

			// инициализация списка workLoads
			var querySortLoad = from c in database.SortLoad
						select c;
			foreach (SortLoad sortLoad in querySortLoad)
			{
				workLoads.Add(new WorkLoad()
				{
					SortLoadId = sortLoad.Id,
					SortLoadName = sortLoad.Name,
					CountHours = 0
				});
			}

			foreach (WorkLoad workLoad in workLoads)
			{
				foreach (LoadInCoursePlan loadPlan in courseInWork.LoadInCoursePlan)
				{
					if (workLoad.SortLoadId == loadPlan.SortLoadID)
					{
						workLoad.CountHours = loadPlan.CountHours;
					}
				}
			}

			foreach (WorkLoad workLoad in workLoads)
			{
				ctlSortLoads.Rows.Add(workLoad.SortLoadId, workLoad.SortLoadName, workLoad.CountHours);
			}
			ctlSortLoads.Rows.Add("", "Часов всего", courseInWork.TotalPlanHours);
			int countRows = ctlSortLoads.Rows.Count;
			ctlSortLoads.Rows[countRows - 1].Cells[2].ReadOnly = true;

			
			// инициализация групп
			InitComboboxGroup(database);
			int countGroups = courseInWork.GroupInCourse.Count;
			for (int i = 1; i < countGroups; i++)
			{
				AddComboBoxGroup();			
			}
			for (int i = 0; i < countGroups; i++)
			{
				ComboBox comboBox = (ComboBox)panelGroups.Controls[i];
				comboBox.SelectedValue = courseInWork.GroupInCourse[i].GroupInSemestrID;
			}
		}

		private void AddComboBoxGroup()
		{
			ComboBox comboBox;
			comboBox = new System.Windows.Forms.ComboBox();
			panelGroups.Controls.Add(comboBox);
			int x = 0;
			int y = 24;
			comboBox.FormattingEnabled = true;
			comboBox.Location = new System.Drawing.Point(x, y * (panelGroups.Controls.Count - 1));   //	 panelGroups.Controls.Count
			comboBox.Name = "cbGroup" + panelGroups.Controls.Count.ToString();
			comboBox.Size = new System.Drawing.Size(121, 21);
			comboBox.TabIndex = 0;
			comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

			this.btnGroupAdd.Location = new System.Drawing.Point(btnGroupAdd.Location.X, btnGroupAdd.Location.Y + y);
			this.btnGroupDelete.Location = new System.Drawing.Point(btnGroupDelete.Location.X, btnGroupDelete.Location.Y + y);

			int schoolYearId = Settings.SchoolYearId;
			comboBox.DataSource = from g in contextDatabase.GroupInSemestr
								  where g.SchoolYear == schoolYearId && g.Semestr == (short)cbSemestr.SelectedValue
								  select g;
			comboBox.DisplayMember = "GroupName";
			comboBox.ValueMember = "ID";
			comboBox.SelectedValue = -1;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			courseId = (int)cbCourseName.SelectedValue;
			employeeId = (cbEmployee.SelectedValue != null) ? (int)cbEmployee.SelectedValue : 0;
			semestr = (Nullable<short>)cbSemestr.SelectedValue;
			formStudy = (bool)cbFormStudy.SelectedValue;

			decimal countHours;
			for (int i = 0; i < ctlSortLoads.RowCount-1; i++)
			{
				if (Decimal.TryParse(ctlSortLoads.Rows[i].Cells[2].Value.ToString(), out countHours) == true)
				{
					workLoads[i].CountHours = countHours;
				}
			}

			selectedGroups = new List<int>();
			for (int i = 0; i < panelGroups.Controls.Count; i++)
			{
				ComboBox comboBox = (ComboBox)panelGroups.Controls[i];
				selectedGroups.Add((int)comboBox.SelectedValue);
			}
		}

		private void InitInterface(BindingSource bsSemestr, bool formStudy, DatabaseDataContext database)
		{
			cbSemestr.DisplayMember = "Value";
			cbSemestr.ValueMember = "Key";
			cbSemestr.DataSource = bsSemestr;

            List<FormStudy> formStudyList = new List<FormStudy>()
			{
				new FormStudy() { Flag = false, Description = "Очная" }, 
				new FormStudy() { Flag = true, Description = "Заочная" }
			};
            bsFormStudyNew.DataSource = formStudyList;
            cbFormStudy.DisplayMember = "Description";
            cbFormStudy.ValueMember = "Flag";
            cbFormStudy.DataSource = bsFormStudyNew;
            cbFormStudy.SelectedValue = formStudy;

			bsCourse.DataSource = from c in database.Course
								  orderby c.Name
								  select c;
			cbCourseName.DisplayMember = "Name";
			cbCourseName.ValueMember = "ID";
			cbCourseName.DataSource = bsCourse;		
			cbCourseName.SelectedIndex = -1;
			cbCourseName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbCourseName.AutoCompleteSource = AutoCompleteSource.ListItems;

			bsEmployee.DataSource = from emp in database.Employee
									orderby emp.Fio
									select emp;
			cbEmployee.DisplayMember = "Fio";
			cbEmployee.ValueMember = "ID";
			cbEmployee.DataSource = bsEmployee;
			cbEmployee.SelectedIndex = -1;
			cbEmployee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbEmployee.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void ctlSortLoads_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			decimal countHours;
			decimal totalHours = 0;
			for (int i = 0; i < ctlSortLoads.RowCount - 1; i++)
			{
				if (Decimal.TryParse(ctlSortLoads.Rows[i].Cells[2].Value.ToString(), out countHours) == true)
				{
					totalHours += countHours;
				}
			}
			int countRows = ctlSortLoads.Rows.Count;
			ctlSortLoads.Rows[countRows - 1].Cells[2].Value = totalHours;
		}


		private void btnGroupAdd_Click(object sender, EventArgs e)
		{
			if (panelGroups.Controls.Count < 5)
			{
				AddComboBoxGroup();
			}
		}

		private void btnGroupDelete_Click(object sender, EventArgs e)
		{
			if (panelGroups.Controls.Count == 1)
			{
				cbGroup1.SelectedValue = -1;
			}
			if (panelGroups.Controls.Count > 1)
			{
				ComboBox comboBox = (ComboBox)panelGroups.Controls[panelGroups.Controls.Count - 1];
				comboBox.Dispose();

				int y = 24;
				Button button = (Button)sender;
				button.Location = new System.Drawing.Point(button.Location.X, button.Location.Y - y);
				this.btnGroupAdd.Location = new System.Drawing.Point(this.btnGroupAdd.Location.X, this.btnGroupAdd.Location.Y - y);
			}
		}

		private void btnCourseAdd_Click(object sender, EventArgs e)
		{
			CourseForm formCourse = new CourseForm();
			if (formCourse.ShowDialog(this) == DialogResult.OK)
			{
				bsCourse.DataSource = from c in contextDatabase.Course
									  orderby c.Name
									  select c;	
			}
		}

		private void ctlSortLoads_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int idSortLoad;
			int selRowNum = ctlSortLoads.SelectedCells[0].RowIndex;
			string stringSortLoad = ctlSortLoads.Rows[selRowNum].Cells["idColumn"].Value.ToString();
			if (Int32.TryParse(stringSortLoad, out idSortLoad) == true)
			{
				string nameSortLoad = (string)ctlSortLoads.Rows[selRowNum].Cells["sortLoadColumn"].Value;
				decimal countHours = (decimal)ctlSortLoads.Rows[selRowNum].Cells["countHoursColumn"].Value;
				if (countHours > 0)
				{
					PlaningLoadForm formPlaningLoad = new PlaningLoadForm(currentCourseInWork, idSortLoad, nameSortLoad, countHours, contextDatabase);
					if (formPlaningLoad.ShowDialog(this) == DialogResult.OK)
					{
						List<LoadInCourseFact> listLoadFact = formPlaningLoad.LoadInCourseFacts;
                        LoadInCoursePlan loadPlan = (from d in contextDatabase.LoadInCoursePlan
                                           where d.CourseInWorkID == currentCourseInWork.ID && d.SortLoadID == idSortLoad
                                           select d).SingleOrDefault();
                        contextDatabase.LoadInCourseFact.DeleteAllOnSubmit(loadPlan.LoadInCourseFact);
                        loadPlan.LoadInCourseFact.AddRange(listLoadFact);
                        contextDatabase.SubmitChanges();
					}
				}
			}
		}
	}
}