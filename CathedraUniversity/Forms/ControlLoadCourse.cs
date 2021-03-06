﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CathedraUniversity.Forms.Classes;
using Microsoft.SqlServer.Server;

namespace CathedraUniversity.Forms
{
	public partial class ControlLoadCourse : Form
	{
		private DatabaseDataContext database = new DatabaseDataContext();
		private Nullable<short> semestrValue = 1;
		private bool formStudyValue = true;
		private int courseTypeValue = 1;
		private bool isFormClose = false;

		public ControlLoadCourse()
		{
			InitializeComponent();
		}

		private void ControlLoad_Load(object sender, EventArgs e)
		{
			Dictionary<Nullable<short>, string> semestr = new Dictionary<Nullable<short>, string>();
			semestr.Add(1, "Осенний");
			semestr.Add(2, "Весенний");
			bsSemestr.DataSource = semestr;
			cbSemestr.DisplayMember = "Value";
			cbSemestr.ValueMember = "Key";
			cbSemestr.DataSource = bsSemestr;

			List<FormStudy> formStudy = new List<FormStudy>()
			{
				new FormStudy() { Flag = true, Description = "Очная" }, 
				new FormStudy() { Flag = false, Description = "Заочная" },
                new FormStudy() { Flag = null, Description = "Все" }
			};
			bsFormStudy.DataSource = formStudy;
			cbFormStudy.DisplayMember = "Description";
			cbFormStudy.ValueMember = "Flag";
			cbFormStudy.DataSource = bsFormStudy;

			bsCourseType.DataSource = from ct in database.CourseType
									  select ct;
			cbCourseType.DisplayMember = "Name";
			cbCourseType.ValueMember = "Id";
			cbCourseType.DataSource = bsCourseType;
					   
			InitDataGrid();
			this.WindowState = FormWindowState.Maximized;
		}
     

		private void CourseDelete()
		{
			if (ctlCourseInWork.SelectedRows.Count > 0)
			{
				if (ctlCourseInWork.SelectedRows[0].Cells["idColumn"].Value != null)
				{
					int idCoourseInWork = (int)ctlCourseInWork.SelectedRows[0].Cells["idColumn"].Value;
					if (MessageBox.Show(this,
											"Вы действительно хотите удалить информацию о курсе?",
											"Подтверждение!",
											MessageBoxButtons.YesNo,
											MessageBoxIcon.Question) == DialogResult.Yes)
					{
						CourseInWork courseInWork = (from ciw in database.CourseInWork
													 where ciw.ID == idCoourseInWork
													 select ciw).SingleOrDefault();

						database.LoadInCourseFact.DeleteAllOnSubmit(courseInWork.LoadInCourseFact);
						database.LoadInCoursePlan.DeleteAllOnSubmit(courseInWork.LoadInCoursePlan);
						database.GroupInCourse.DeleteAllOnSubmit(courseInWork.GroupInCourse);
						database.CourseInWork.DeleteOnSubmit(courseInWork);
						database.SubmitChanges();
						InitDataGrid();
					}
				}
			}
		}

		private void CourseEdit()
		{
			if (ctlCourseInWork.SelectedRows.Count > 0)
			{
				if (ctlCourseInWork.SelectedRows[0].Cells["idColumn"].Value != null)
				{

					int idCoourseInWork = (int)ctlCourseInWork.SelectedRows[0].Cells["idColumn"].Value;
					CourseInWork courseInWork = (from ciw in database.CourseInWork
												 where ciw.ID == idCoourseInWork
												 select ciw).SingleOrDefault();
					CourseInWorkForm formCourseInWork = new CourseInWorkForm(courseInWork, bsSemestr, formStudyValue, courseTypeValue, database);
					if (formCourseInWork.ShowDialog(this) == DialogResult.OK)
					{
						int courseId = formCourseInWork.СourseId;
						int employeeId = formCourseInWork.EmployeeId;
						Nullable<short> semestr = formCourseInWork.Semestr;
						bool formStudy = formCourseInWork.FormStudy;
						List<WorkLoad> workLoads = formCourseInWork.WorkLoads;
						List<int> groups = formCourseInWork.SelectedGroups;


                        courseInWork.Course = database.Course.Single(c => c.ID == courseId);
                        courseInWork.Employee = database.Employee.Single(c => c.Id == employeeId);

                        //courseInWork.CourseID = courseId;
                        //courseInWork.EmployeeID = employeeId;
                        courseInWork.Semestr = semestr;
                        courseInWork.FormStudy = formStudy;

						bool changed;
						foreach (WorkLoad workLoad in workLoads)
						{
							changed = false;
							foreach (LoadInCoursePlan loadPlan in courseInWork.LoadInCoursePlan)
							{
								if (loadPlan.SortLoadID == workLoad.SortLoadId)
								{
									loadPlan.CountHours = workLoad.CountHours;
									changed = true;
								}
							}
							if (changed == false && workLoad.CountHours > 0)
							{
								courseInWork.LoadInCoursePlan.Add(new LoadInCoursePlan()
								{
									SortLoadID = workLoad.SortLoadId,
									CountHours = workLoad.CountHours
								});
							}
						}

						bool isAdd;
						foreach (int groupId in groups)
						{
							isAdd = true;
							foreach (GroupInCourse groupInCourse in courseInWork.GroupInCourse)
							{
								if (groupInCourse.GroupInSemestrID == groupId)
								{
									isAdd = false;
								}
							}
							if (isAdd == true)
							{
								courseInWork.GroupInCourse.Add(new GroupInCourse()
								{
									GroupInSemestrID = groupId
								});
							}
						}

						// формируем список для удаления групп из таблицы
						List<int> deleteGroups = new List<int>();
						bool isDelete;
						foreach (GroupInCourse groupInCourse in courseInWork.GroupInCourse)
						{
							isDelete = true;
							foreach (int groupId in groups)
							{
								if (groupInCourse.GroupInSemestrID == groupId)
								{
									isDelete = false;
								}
							}
							if (isDelete == true)
							{
								deleteGroups.Add((int)groupInCourse.GroupInSemestrID);
							}
						}

						//удаляем не выбранные группы
						foreach (int groupInSemestrId in deleteGroups)
						{
							GroupInCourse groupInCourse = (from g in database.GroupInCourse
														   where g.GroupInSemestrID == groupInSemestrId
														   && g.CourseInWorkID == courseInWork.ID
														   select g).SingleOrDefault();
							database.GroupInCourse.DeleteOnSubmit(groupInCourse);
						}
						database.SubmitChanges();
					    var index = 0;
					    if (ctlCourseInWork.SelectedRows[0] != null)
					        index = ctlCourseInWork.SelectedRows[0].Index;
						InitDataGrid();
                        if (index != 0 )
                            ctlCourseInWork.Rows[index].Selected = true;
					}
					else
					{
						// InitDataGrid();
					}
				}
			}
		}

		private void CourseAdd()
		{
			CourseInWorkForm formCourseInWork = new CourseInWorkForm(bsSemestr, formStudyValue, courseTypeValue, database);
			if (formCourseInWork.ShowDialog(this) == DialogResult.OK)
			{
				int courseId = formCourseInWork.СourseId;
				int employeeId = formCourseInWork.EmployeeId;
				Nullable<short> semestr = formCourseInWork.Semestr;
				bool formStudy = formCourseInWork.FormStudy;
				List<WorkLoad> workLoads = formCourseInWork.WorkLoads;
				List<int> groups = formCourseInWork.SelectedGroups;

				CourseInWork courseInWork = new CourseInWork()
				{
					CourseID = courseId,
					//CourseTypeID = courseTypeValue,
					EmployeeID = employeeId,
					FormStudy = formStudy,
					Semestr = semestr,
					SchoolYearID = Settings.SchoolYearId
				};

				foreach (WorkLoad workLoad in workLoads)
				{
					if (workLoad.CountHours > 0)
					{
						courseInWork.LoadInCoursePlan.Add(new LoadInCoursePlan()
						{
							SortLoadID = workLoad.SortLoadId,
							CountHours = workLoad.CountHours
						});
					}
				}

				foreach (int groupId in groups)
				{
					courseInWork.GroupInCourse.Add(new GroupInCourse()
					{
						GroupInSemestrID = groupId
					});
				}
				database.CourseInWork.InsertOnSubmit(courseInWork);
				database.SubmitChanges();
				InitDataGrid();
			}
		}


		private void InitDataGrid()
		{
			int schoolYear = Settings.SchoolYearId;

            using (DatabaseDataContext context = new DatabaseDataContext())
            {
                if (cbFormStudy.SelectedValue != null)
                {
                    var query = from s in context.CourseInWork
                                where s.SchoolYearID == schoolYear && s.Semestr == semestrValue
                                && s.FormStudy == formStudyValue && s.Course.CourseTypeId == courseTypeValue
                                orderby s.Course.Name
                                select s;
                    ctlCourseInWork.Rows.Clear();
                    foreach (CourseInWork courseInWork in query)
                    {
                        ctlCourseInWork.Rows.Add(
                            courseInWork.ID,
                            courseInWork.Course.Name,
                            (courseInWork.Semestr == 1) ? "Осенний" : "Весенний",
                            (courseInWork.FormStudy == true) ? "Очная" : "Заочная",
                            (courseInWork.Employee != null) ? courseInWork.Employee.ShortName : "",
                            courseInWork.Groups,
                            courseInWork.TotalPlanHours,
                            courseInWork.TotalDistributeHours);
                    }

                    List<LoadInCoursePlan> loadPlanList = (from p in context.LoadInCoursePlan
                                                           where p.CourseInWork.SchoolYearID == schoolYear && p.CourseInWork.Course.CourseTypeId == courseTypeValue
                                                           && p.CourseInWork.FormStudy == formStudyValue && p.CourseInWork.Semestr == semestrValue
                                                           select p).ToList();
                    if (loadPlanList.Count > 0)
                    {
                        decimal totalHours = (from l in loadPlanList
                                              select l.CountHours).Sum();
                        lblStat.Text = totalHours.ToString() + " часов";
                    }
                    else
                    {
                        lblStat.Text = "0 часов";
                    }
                    
                }
                else
                {
                    var query = from s in context.CourseInWork
                                where s.SchoolYearID == schoolYear && s.Semestr == semestrValue && s.Course.CourseTypeId == courseTypeValue
                                orderby s.Course.Name
                                select s;
                    ctlCourseInWork.Rows.Clear();
                    foreach (CourseInWork courseInWork in query)
                    {
                        ctlCourseInWork.Rows.Add(
                            courseInWork.ID,
                            courseInWork.Course.Name,
                            (courseInWork.Semestr == 1) ? "Осенний" : "Весенний",
                            (courseInWork.FormStudy == true) ? "Очная" : "Заочная",
                            (courseInWork.Employee != null) ? courseInWork.Employee.ShortName : "",
                            courseInWork.Groups,
                            courseInWork.TotalPlanHours,
                            courseInWork.TotalDistributeHours);
                    }
                }
            }
		}

		private void cbSemestr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbSemestr.SelectedValue != null)
			{
				int result;
				if (Int32.TryParse(cbSemestr.SelectedValue.ToString(), out result) == true)
				{
					if (semestrValue != ((Nullable<short>)result))
					{
						semestrValue = (Nullable<short>)result;
						InitDataGrid();
					}
				}
			}
		}

		private void cbCourseType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCourseType.SelectedValue != null)
			{
				int result;
				if (Int32.TryParse(cbCourseType.SelectedValue.ToString(), out result) == true)
				{
					if (courseTypeValue != result)
					{
						courseTypeValue = result;
						InitDataGrid();
					}
				}
			}

		}

		private void cbFormStudy_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (cbFormStudy.SelectedValue != null)
            {
                bool result;
                if (bool.TryParse(cbFormStudy.SelectedValue.ToString(), out result) == true)
                {
                    if (formStudyValue != result)
                    {
                        formStudyValue = result;
                        InitDataGrid();
                    }
                }
            }
            else
            {
				if (isFormClose == false)
				{
					InitDataGrid();
				}
            }
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CourseAdd();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			CourseEdit();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			CourseDelete();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			isFormClose = true;
			Close();
		}

		private void contextDeleteCourse_Click(object sender, EventArgs e)
		{
			CourseDelete();	
		}

        private void contextEditCourse_Click(object sender, EventArgs e)
        {
            CourseEdit();
        }

        private void contextAddCourse_Click(object sender, EventArgs e)
        {
            CourseAdd();
        }

        private void ctlCourseInWork_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CourseEdit();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
			int schoolYear = Settings.SchoolYearId;
            using (var context = new DatabaseDataContext())
            {
                var query = from courseInWork in context.CourseInWork
                    where courseInWork.SchoolYearID == schoolYear
                    group courseInWork
                        by new {courseInWork.Course.CourseType, courseInWork.FormStudy, courseInWork.Semestr}
                    into ciw
                    select new {GroupFields = ciw.Key, 
                        SumTotalPlanHours = ciw.Sum(p1 => p1.LoadInCoursePlan.Sum(p2 => p2.CountHours)),
                        SumTotalFactHours = (decimal?)ciw.Sum(p1 => p1.LoadInCourseFact.Sum(p2 => p2.CountHours))
                    };
                decimal sumplan = 0;
                decimal sumfact = 0;
                string ls = "";
                foreach (var groupRow in query)
                {
                    ls += String.Format("{0}, {1}, {2}: план - {3}, факт - {4}", 
                        groupRow.GroupFields.CourseType.Name, 
                        (bool) groupRow.GroupFields.FormStudy ? "Очная" : "Заочная",
                        groupRow.GroupFields.Semestr == 1 ? "Осенний" : "Весенний",
                        groupRow.SumTotalPlanHours,
                        groupRow.SumTotalFactHours) + "\r\n";
                    sumplan += groupRow.SumTotalPlanHours;
                    sumfact += groupRow.SumTotalFactHours.HasValue ? (decimal)groupRow.SumTotalFactHours : 0;
                }
                ls += "ИТОГО:  план - " + sumplan + ", факт - " + sumfact;
                var ef = new EditorForm(ls);
                ef.ShowDialog();
            }
        }
	}
}
