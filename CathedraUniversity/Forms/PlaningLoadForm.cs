using System;
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
	public partial class PlaningLoadForm : Form
	{
        private Repository repository = new Repository();

		private int currentLoadPlanId;
        private string sortLoadName;
        private int currentSortLoadId;

		/// <summary>
		/// Флаг, показывающий была ли разбита нагрузка для каждой группы 
		/// </summary>
		private bool byGroups;
        
		private bool isBisectionLoad;
		private bool isOwnerLoad;
		private bool isClassLoad;
		private bool isDivideGroupsLoad;

		private CourseInWork currentCourseInWork;
		private List<LoadInCourseFact> loadInCourseFacts;

		public List<LoadInCourseFact> LoadInCourseFacts
		{
			get
			{
				return loadInCourseFacts;
			}
		}

        public bool ByGroups
        {
            get
            {
                return byGroups;
            }
        }

		public PlaningLoadForm(CourseInWork courseInWork, int idSortLoad, string nameSortLoad, decimal countHours, DatabaseDataContext contextDatabase)
		{
			InitializeComponent();

            currentCourseInWork = courseInWork;
            currentSortLoadId = idSortLoad;
            sortLoadName = nameSortLoad;

            SortLoad sortLoad = (from s in contextDatabase.SortLoad
                                 where s.Id == currentSortLoadId
                                 select s).SingleOrDefault();
            
			isBisectionLoad = sortLoad.IsBisection;
			isClassLoad = sortLoad.IsClass;
			isDivideGroupsLoad = sortLoad.IsDivideGroups;
			isOwnerLoad = sortLoad.IsOwner;			

            //factEmployeeColumn.DataSource = formEmployeeColumn.DataSource = from c in contextDatabase.Employee
            //                                                                //where c.NonActive == false
            //                                                                orderby c.Fio
            //                                                                select c;

            factEmployeeColumn.DataSource = formEmployeeColumn.DataSource = repository.GetFilterEmployee(idSortLoad);
			factEmployeeColumn.DisplayMember = formEmployeeColumn.DisplayMember = "ShortName";
			factEmployeeColumn.ValueMember = formEmployeeColumn.ValueMember = "Id";
			
			classRoomColumn.DataSource = from cr in contextDatabase.ClassRoom
										 orderby cr.Number
										 select cr;
			classRoomColumn.DisplayMember = "Number";
			classRoomColumn.ValueMember = "Id";
			lblSortLoadName.Text = nameSortLoad;


            using (DatabaseDataContext context = new DatabaseDataContext())
            {

                LoadInCoursePlan loadPlan = (from lf in context.LoadInCoursePlan
                                             where lf.CourseInWorkID == courseInWork.ID && lf.SortLoadID == idSortLoad
                                             select lf).SingleOrDefault();
                currentLoadPlanId = loadPlan.Id;

                if (loadPlan.LoadInCourseFact.Count != 0)
                {
                    if (loadPlan.ByGroups == true)
                    {
                        byGroups = true;
                        int countGroups = currentCourseInWork.GroupInCourse.Count;
                        for (int j = 0; j < countGroups; j++)
                        {
                            ctlPlaningLoads.Rows.Add();
                            ctlPlaningLoads.Rows[j].Cells["groupsColumn"].Value = currentCourseInWork.GroupInCourse[j].GroupInSemestr.GroupName;
                            ctlPlaningLoads.Rows[j].Cells["countHoursColumn"].Value = countHours;
                            ctlPlaningLoads.Rows[j].Cells["factEmployeeColumn"].ReadOnly = true;
                            ctlPlaningLoads.Rows[j].Cells["flagColumn"].Value = false;
                            ctlPlaningLoads.Rows[j].Cells["pochFondColumn"].Value = false;
                        }

                        foreach (DataGridViewRow row in ctlPlaningLoads.Rows)
                        {
                            foreach (LoadInCourseFact loadFact in loadPlan.LoadInCourseFact)
                            {
                                if (String.Compare(row.Cells["groupsColumn"].Value.ToString(), loadFact.GroupInCourse.GroupInSemestr.GroupName) == 0)
                                {
                                    row.Cells["formEmployeeColumn"].Value = loadFact.EmployeeFormID;
                                    if (loadFact.EmployeeFormID == loadFact.EmployeeFactID)
                                    {
                                        row.Cells["flagColumn"].Value = false;
                                        row.Cells["factEmployeeColumn"].ReadOnly = true;
                                    }
                                    else
                                    {
                                        row.Cells["factEmployeeColumn"].Value = loadFact.EmployeeFactID;
                                        row.Cells["factEmployeeColumn"].ReadOnly = false;
                                        row.Cells["flagColumn"].Value = true;
                                    }

                                    if (loadFact.PochFond == true)
                                    {
                                        row.Cells["pochFondColumn"].Value = true;
                                    }
                                    else
                                    {
                                        row.Cells["pochFondColumn"].Value = false;
                                    }
                                    if (loadFact.ClassRoomID != null)
                                    {
                                        row.Cells["classRoomColumn"].Value = loadFact.ClassRoomID;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        int i = 0;
                        decimal factCountHours = 0;
                        foreach (LoadInCourseFact loadFact in loadPlan.LoadInCourseFact)
                        {
                            factCountHours += loadFact.CountHours;
                            ctlPlaningLoads.Rows.Add();

                            ctlPlaningLoads.Rows[i].Cells["groupsColumn"].Value = currentCourseInWork.Groups;                       
                            ctlPlaningLoads.Rows[i].Cells["countHoursColumn"].Value = loadFact.CountHours;
                            ctlPlaningLoads.Rows[i].Cells["formEmployeeColumn"].Value = loadFact.EmployeeFormID;
                            if (loadFact.EmployeeFactID != null)
                            {
                                if (loadFact.EmployeeFactID == loadFact.EmployeeFormID)
                                {
                                    ctlPlaningLoads.Rows[i].Cells["flagColumn"].Value = false;
                                    ctlPlaningLoads.Rows[i].Cells["factEmployeeColumn"].ReadOnly = true;
                                }
                                else
                                {
                                    ctlPlaningLoads.Rows[i].Cells["factEmployeeColumn"].Value = loadFact.EmployeeFactID;
                                    ctlPlaningLoads.Rows[i].Cells["factEmployeeColumn"].ReadOnly = false;
                                    ctlPlaningLoads.Rows[i].Cells["flagColumn"].Value = true;
                                }
                            }
                            ctlPlaningLoads.Rows[i].Cells["pochFondColumn"].Value = loadFact.PochFond;
                            ctlPlaningLoads.Rows[i].Cells["classRoomColumn"].Value = loadFact.ClassRoomID;
                            i++;
                        }

                        if (loadPlan.CountHours > factCountHours)
                        {
                            ctlPlaningLoads.Rows.Add();
                            ctlPlaningLoads.Rows[1].Cells["groupsColumn"].Value = currentCourseInWork.Groups;
                            ctlPlaningLoads.Rows[1].Cells["countHoursColumn"].Value = (decimal)countHours / 2;
                            ctlPlaningLoads.Rows[1].Cells["factEmployeeColumn"].ReadOnly = true;
                            ctlPlaningLoads.Rows[1].Cells["flagColumn"].Value = false;
                            ctlPlaningLoads.Rows[1].Cells["pochFondColumn"].Value = false;
                        }
                    }    
                }
                else
                {
                    //if (isBisectionLoad == true && currentCourseInWork.IsDivisionLab == true)
					if (String.Compare(sortLoadName, "Лабораторная работа") == 0 && currentCourseInWork.IsDivisionLab == true)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            ctlPlaningLoads.Rows.Add();
                            ctlPlaningLoads.Rows[i].Cells["groupsColumn"].Value = currentCourseInWork.Groups;
                            ctlPlaningLoads.Rows[i].Cells["countHoursColumn"].Value = (decimal)countHours / 2;
                            ctlPlaningLoads.Rows[i].Cells["factEmployeeColumn"].ReadOnly = true;
                            ctlPlaningLoads.Rows[i].Cells["flagColumn"].Value = false;
                            ctlPlaningLoads.Rows[i].Cells["pochFondColumn"].Value = false;
                        }
                    }
                    else
                    {
                        ctlPlaningLoads.Rows.Add();
                        ctlPlaningLoads.Rows[0].Cells["groupsColumn"].Value = currentCourseInWork.Groups;
                        ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = countHours;
                        ctlPlaningLoads.Rows[0].Cells["factEmployeeColumn"].ReadOnly = true;
                        ctlPlaningLoads.Rows[0].Cells["flagColumn"].Value = false;
                        ctlPlaningLoads.Rows[0].Cells["pochFondColumn"].Value = false;

                        if (isOwnerLoad == true)
                        {
                            ctlPlaningLoads.Rows[0].Cells["formEmployeeColumn"].Value = currentCourseInWork.EmployeeID;

                        }
                    }

                }
            }

            if (isClassLoad == false)
            {
                ctlPlaningLoads.Columns["classRoomColumn"].Visible = false;
            }
            else
            {
                ctlPlaningLoads.Columns["classRoomColumn"].Visible = true;
            }

            if (isDivideGroupsLoad == false)
            {
                btnSplitLoadByGroups.Enabled = false;
            }

            if (isBisectionLoad == false)
            {
				btnSplitLoadInTwo.Enabled = false;
            }
		}


		private void ctlPlaningLoads_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
            if (ctlPlaningLoads.RowCount != 0)
            {
                bool result;
                if (ctlPlaningLoads.Rows[e.RowIndex].Cells["flagColumn"].Value != null
                    && Boolean.TryParse(ctlPlaningLoads.Rows[e.RowIndex].Cells["flagColumn"].Value.ToString(), out	result) == true)
                {
                    if (result == true)
                    {
                        if (isBisectionLoad == true)
                        {
                            ctlPlaningLoads.Rows[e.RowIndex].Cells["factEmployeeColumn"].ReadOnly = false;
                        }
                        else
                        {
                            ctlPlaningLoads.Rows[e.RowIndex].Cells["flagColumn"].Value = false;
                            MessageBox.Show("На данный вид нагрузки нельзя назначать другого фактического преподавателя!");
                        }
                    }
                    else
                    {
                        ctlPlaningLoads.Rows[e.RowIndex].Cells["factEmployeeColumn"].ReadOnly = true;
                        ctlPlaningLoads.Rows[e.RowIndex].Cells["factEmployeeColumn"].Value = null;
                    }
                }
            }			
		}


		private void btnSplitLoadByGroups_Click(object sender, EventArgs e)
		{
            int countGroups = currentCourseInWork.GroupInCourse.Count;
			if (countGroups > 1)
			{
				if (ctlPlaningLoads.Rows.Count == 1)
				{
					ctlPlaningLoads.Rows[0].Cells["groupsColumn"].Value = currentCourseInWork.GroupInCourse[0].GroupInSemestr.GroupName;
					for (int i = 1; i < countGroups; i++)
					{
						ctlPlaningLoads.Rows.Add();
						ctlPlaningLoads.Rows[i].Cells["groupsColumn"].Value = currentCourseInWork.GroupInCourse[i].GroupInSemestr.GroupName;
						ctlPlaningLoads.Rows[i].Cells["countHoursColumn"].Value = (decimal)ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value;
						ctlPlaningLoads.Rows[i].Cells["factEmployeeColumn"].ReadOnly = ctlPlaningLoads.Rows[0].Cells["factEmployeeColumn"].ReadOnly;
						ctlPlaningLoads.Rows[i].Cells["flagColumn"].Value = ctlPlaningLoads.Rows[0].Cells["flagColumn"].Value;
						ctlPlaningLoads.Rows[i].Cells["pochFondColumn"].Value = false;
					}
				}
				byGroups = true;
			}
			else
			{
				MessageBox.Show("Действие не выполнено!  На курс назначна только ОДНА группа!");
			}
		}

		private void btnSplitLoadInTwo_Click(object sender, EventArgs e)
		{
			if (ctlPlaningLoads.Rows.Count == 1)
			{
				ctlPlaningLoads.Rows.Add();
				ctlPlaningLoads.Rows[1].Cells["groupsColumn"].Value = ctlPlaningLoads.Rows[0].Cells["groupsColumn"].Value;
				ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = (decimal)ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value / 2;
				ctlPlaningLoads.Rows[1].Cells["countHoursColumn"].Value = ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value;
				ctlPlaningLoads.Rows[1].Cells["factEmployeeColumn"].ReadOnly = ctlPlaningLoads.Rows[0].Cells["factEmployeeColumn"].ReadOnly;
				ctlPlaningLoads.Rows[1].Cells["flagColumn"].Value = ctlPlaningLoads.Rows[0].Cells["flagColumn"].Value;
				ctlPlaningLoads.Rows[1].Cells["pochFondColumn"].Value = false;
			}
		}


        
		private void btnAssemblyLoad_Click(object sender, EventArgs e)
		{
            if (String.Compare(sortLoadName, "Лабораторная работа") == 0 && currentCourseInWork.IsDivisionLab == true)
            {
                MessageBox.Show("Действие не рекомендуется!");
            }
            else
            {
                if (ctlPlaningLoads.Rows.Count > 1)
                {
                    bool isInfo = false;
                    foreach (DataGridViewRow row in ctlPlaningLoads.Rows)
                    {
                        if (row.Index == 0) continue;
                        if (row.Cells["formEmployeeColumn"].Value != null
                            || row.Cells["classRoomColumn"].Value != null)
                        {
                            isInfo = true;
                        }
                    }


                    if (isInfo == true)
                    {
                        if (MessageBox.Show(this,
                                        "Вы действительно хотите отменить разбиение нагрузки?" +
                                        "При этом будет потеряна некоторая информация!",
                                        "Подтверждение!",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                        {
							AssemblyRows();
                        }
                    }
                    else
                    {
						AssemblyRows();
                    }
                }
            }
		}

		
		private void AssemblyRows()
		{
			if (byGroups == true)
			{
				int countRows = ctlPlaningLoads.Rows.Count;
				for (int i = countRows; i > 1; i--)
				{
					ctlPlaningLoads.Rows.Remove(ctlPlaningLoads.Rows[i - 1]);
				}
				ctlPlaningLoads.Rows[0].Cells["groupsColumn"].Value = currentCourseInWork.Groups;
				byGroups = false;
			}
			else
			{
				if (ctlPlaningLoads.Rows.Count == 2)
				{
					ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = (decimal)ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value * 2;
					ctlPlaningLoads.Rows.Remove(ctlPlaningLoads.Rows[1]);
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
            StringBuilder sb = new StringBuilder(200);
			foreach (DataGridViewRow row in ctlPlaningLoads.Rows)
			{
                if (row.Cells["formEmployeeColumn"].Value != null)
                {
                    if (isOwnerLoad == true)
                    {
                        if ((int)row.Cells["formEmployeeColumn"].Value != currentCourseInWork.EmployeeID)
                        {
                            string textMessage = String.Format("Нагрузка должна быть закреплена за владельцем курса! (строка №{0})", row.Index + 1);
                            sb.Insert(sb.Length, textMessage + "\r\n");
                            row.Cells["formEmployeeColumn"].Value = currentCourseInWork.EmployeeID;
                        }
                    }

                    if ((bool)row.Cells["flagColumn"].Value == true && row.Cells["factEmployeeColumn"].Value == null)
                    {
                        string textMessage = String.Format("Не указан фактический преподаватель! (строка №{0})", row.Index + 1);
                        sb.Insert(sb.Length, textMessage + "\r\n");
                    }

                    if (isClassLoad == true && row.Cells["classRoomColumn"].Value == null)
                    {
                        string textMessage = String.Format("Не выбрана рекомендуемая аудитория! (строка №{0})", row.Index + 1);
                        sb.Insert(sb.Length, textMessage + "\r\n");
                    }

                    if ((bool)row.Cells["pochFondColumn"].Value == true && row.Cells["factEmployeeColumn"].Value != null)
                    {
                        string textMessage = String.Format("Перевод в почасовой фонд невозможен для двух преподавателей! (строка №{0})", row.Index + 1);
                        sb.Insert(sb.Length, textMessage + "\r\n");
                    }
                }
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                this.DialogResult = DialogResult.None;
            }
            else
            {
                loadInCourseFacts = new List<LoadInCourseFact>();
                foreach (DataGridViewRow row in ctlPlaningLoads.Rows)
                {

                    if ((bool)row.Cells["pochFondColumn"].Value == true && row.Cells["formEmployeeColumn"].Value != null)
                    {
                        // тогда проверить лимит почасового фонда у форм сотрудника, если он будет превышать с учетом
                        // этих часов, то вывести сообщение с подробной информацией
                        using (DatabaseDataContext context = new DatabaseDataContext())
                        {
                            Employee employee = (from emp in context.Employee
                                                 where emp.Id == (int)row.Cells["formEmployeeColumn"].Value
                                                 select emp).SingleOrDefault();
                            int pochFondLimit = employee.pochFondLimit;
                            decimal currentCountHoursPochFond = (decimal)row.Cells["countHoursColumn"].Value + employee.countHoursInPochFond;
                            if (currentCountHoursPochFond > pochFondLimit)
                            {
                                string textMessage = String.Format("Вы действительно хотите перевести нагрузку в почасовой фонд у {0} (лимит: {1})?"
                                    + "\r\n" +  "В связи с этим у данного сотрудника будет превышен лимит на {2} часов.",
                                    employee.ShortName, employee.PochFondLimit, currentCountHoursPochFond - pochFondLimit);
                                if (MessageBox.Show(this, textMessage, "Подтверждение!",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.No)
                                {
									this.DialogResult = DialogResult.None;
                                    return; 
                                }
                            }
                        }
                    }

                    if (row.Cells["formEmployeeColumn"].Value != null)
                    {
                        // запись
                        LoadInCourseFact loadFact = new LoadInCourseFact();
                        loadFact.CourseInWorkID = currentCourseInWork.ID;
                        loadFact.LoadInCoursePlanID = currentLoadPlanId;
                        loadFact.CountHours = (decimal)row.Cells["countHoursColumn"].Value;

                        loadFact.EmployeeFormID = (int)row.Cells["formEmployeeColumn"].Value;
                        if (row.Cells["classRoomColumn"].Value != null)
                        {
                            loadFact.ClassRoomID = (int)row.Cells["classRoomColumn"].Value;
                        }

                        if ((bool)row.Cells["flagColumn"].Value == true)
                        {
                            loadFact.EmployeeFactID = (int)row.Cells["factEmployeeColumn"].Value;
                        }
                        else
                        {
                            loadFact.EmployeeFactID = (int)row.Cells["formEmployeeColumn"].Value;
                        }

                        if ((bool)row.Cells["pochFondColumn"].Value == true)
                        {
                            loadFact.PochFond = true;
                        }
                        else
                        {
                            loadFact.PochFond = false;
                        }


                        if (byGroups == true)
                        {
                            int groupInCourseId = (from g in currentCourseInWork.GroupInCourse
                                                   where g.GroupInSemestr.GroupName == row.Cells["groupsColumn"].Value.ToString()
                                                   select g.Id).SingleOrDefault();
                            loadFact.GroupInCourseID = groupInCourseId;
                        }

                        loadInCourseFacts.Add(loadFact);
                    }
                    else
                    {
                        continue;
                    }

                }
                
                if (loadInCourseFacts.Count < ctlPlaningLoads.Rows.Count && loadInCourseFacts.Count > 0)
                {
                    string textMessage = String.Format("Будет сохранено только {0} из {1} строк", loadInCourseFacts.Count, ctlPlaningLoads.Rows.Count);
                    if (MessageBox.Show(this, textMessage, @"Подтверждение!",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                    }
                }
            }

		}

        private void btnRemoveInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                                    @"Вы действительно хотите удалить всю информацию о планировании данной нагрузки?",
                                    @"Подтверждение!",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DatabaseDataContext context = new DatabaseDataContext())
                {
                    LoadInCoursePlan loadPlan = (from d in context.LoadInCoursePlan
                                                 where d.Id == currentLoadPlanId
                                                 select d).SingleOrDefault();
                    context.LoadInCourseFact.DeleteAllOnSubmit(loadPlan.LoadInCourseFact);
                    context.SubmitChanges();
                }
                
                this.Close();
            }
            
        }

		private void ctlPlaningLoads_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string headerText = ctlPlaningLoads.Columns[e.ColumnIndex].Name;

			if (headerText.Equals("formEmployeeColumn"))
			{
				string value = String.Empty;
				using (DatabaseDataContext context = new DatabaseDataContext())
				{
					if (ctlPlaningLoads.Rows[e.RowIndex].Cells["factEmployeeColumn"].Value != null)
					{
						Employee employee = (from emp in context.Employee
											 where emp.Id == (int)ctlPlaningLoads.Rows[e.RowIndex].Cells["factEmployeeColumn"].Value
											 select emp).SingleOrDefault();
						value = employee.ShortName;
					}
				}

				if (String.Compare((string)e.FormattedValue, value) == 0)
				{
					ctlPlaningLoads.Rows[e.RowIndex].ErrorText =
					   "Выбран одинаковый формальный и фактический преподаватели!";
					e.Cancel = true;
				}
			}

			if (headerText.Equals("factEmployeeColumn"))
			{
				string value = String.Empty;
				using (DatabaseDataContext context = new DatabaseDataContext())
				{
					if (ctlPlaningLoads.Rows[e.RowIndex].Cells["formEmployeeColumn"].Value != null)
					{
						Employee employee = (from emp in context.Employee
											 where emp.Id == (int)ctlPlaningLoads.Rows[e.RowIndex].Cells["formEmployeeColumn"].Value
											 select emp).SingleOrDefault();
						value = employee.ShortName;
					}
				}

				if (String.Compare((string)e.FormattedValue, value) == 0)
				{
					ctlPlaningLoads.Rows[e.RowIndex].ErrorText =
					   "Выбран одинаковый формальный и фактический преподаватели!";
					e.Cancel = true;
				}
			}
		}

		private void ctlPlaningLoads_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			ctlPlaningLoads.Rows[e.RowIndex].ErrorText = String.Empty;
		}

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
	}
}
