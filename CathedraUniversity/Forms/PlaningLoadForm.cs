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
	public partial class PlaningLoadForm : Form
	{
		private int currentLoadPlanId;
        private int currentSortLoadId;
        private bool isComplexSortLoad;
        private CourseInWork currentCourseInWork;
		private List<LoadInCourseFact> loadInCourseFacts;

		public List<LoadInCourseFact> LoadInCourseFacts
		{
			get
			{
				return loadInCourseFacts;
			}
		}

		public PlaningLoadForm(CourseInWork courseInWork, int idSortLoad, string nameSortLoad, decimal countHours, DatabaseDataContext contextDatabase)
		{
			InitializeComponent();

            currentCourseInWork = courseInWork;
            currentSortLoadId = idSortLoad;
            SortLoad sortLoad = (from s in contextDatabase.SortLoad
                                 where s.Id == currentSortLoadId
                                 select s).SingleOrDefault();
            isComplexSortLoad = sortLoad.IsComplex;

			factEmployeeColumn.DataSource = formEmployeeColumn.DataSource = from c in contextDatabase.Employee
																			orderby c.Fio
								                                            select c;
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
                    int i = 0;
                    foreach (LoadInCourseFact loadFact in loadPlan.LoadInCourseFact)
                    {
                        ctlPlaningLoads.Rows.Add();
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
                        ctlPlaningLoads.Rows[i].Cells["classRoomColumn"].Value = loadFact.ClassRoomID;
                        i++;
                    }
                }
                else
                {
                    ctlPlaningLoads.Rows.Add();
                    ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = countHours;
                    ctlPlaningLoads.Rows[0].Cells["factEmployeeColumn"].ReadOnly = true;
                    ctlPlaningLoads.Rows[0].Cells["flagColumn"].Value = false;

                }
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
                        if (isComplexSortLoad == true)
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

		private void btnSplitLoad_Click(object sender, EventArgs e)
		{
            if (ctlPlaningLoads.Rows.Count == 1)
            {
                if (isComplexSortLoad == true)
                {
                    ctlPlaningLoads.Rows.Add();
                    ctlPlaningLoads.Rows[1].Cells["countHoursColumn"].Value = (decimal)ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value / 2;
                    ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = ctlPlaningLoads.Rows[1].Cells["countHoursColumn"].Value;
                    ctlPlaningLoads.Rows[1].Cells["factEmployeeColumn"].ReadOnly = ctlPlaningLoads.Rows[0].Cells["factEmployeeColumn"].ReadOnly;
                    ctlPlaningLoads.Rows[1].Cells["flagColumn"].Value = ctlPlaningLoads.Rows[0].Cells["flagColumn"].Value;
                }
                else
                {
                    MessageBox.Show("Текущую нагрузку нельзя разбивать!");
                }
            }
		}

		private void btnAssemblyLoad_Click(object sender, EventArgs e)
		{
			if (ctlPlaningLoads.Rows.Count == 2)
			{
				if (ctlPlaningLoads.Rows[1].Cells["formEmployeeColumn"].Value != null
					|| ctlPlaningLoads.Rows[1].Cells["classRoomColumn"].Value != null)
				{
					if (MessageBox.Show(this,
									"Вы действительно хотите отменить разбиение нагрузки?" +
									"При этом будет потеряна некоторая информация!",
									"Подтверждение!",
									MessageBoxButtons.YesNo,
									MessageBoxIcon.Question) == DialogResult.Yes)
					{
						ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = (decimal)ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value * 2;
						ctlPlaningLoads.Rows.Remove(ctlPlaningLoads.Rows[1]);
					}
				}
				else
				{
					ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value = (decimal)ctlPlaningLoads.Rows[0].Cells["countHoursColumn"].Value * 2;
					ctlPlaningLoads.Rows.Remove(ctlPlaningLoads.Rows[1]);
				}
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
            bool isIdentityEmployee = false;
            foreach (DataGridViewRow dgvr in ctlPlaningLoads.Rows)
            {
                if ((bool)dgvr.Cells["flagColumn"].Value == true
                    && (int)dgvr.Cells["formEmployeeColumn"].Value == (int)dgvr.Cells["factEmployeeColumn"].Value)
                {
                    isIdentityEmployee = true;
                    break;
                }
            }

            bool isErrorOwner = false;

            if (isComplexSortLoad == false)
            {
                if ((int)ctlPlaningLoads.Rows[0].Cells["formEmployeeColumn"].Value != currentCourseInWork.EmployeeID)
                {
                     isErrorOwner = true;
                }
            }
            

            if (isIdentityEmployee == false && isErrorOwner == false)
            {
                loadInCourseFacts = new List<LoadInCourseFact>();
                foreach (DataGridViewRow dgvr in ctlPlaningLoads.Rows)
                {
                    LoadInCourseFact loadFact = new LoadInCourseFact();
                    loadFact.CourseInWorkID = currentCourseInWork.ID;
                    loadFact.LoadInCoursePlanID = currentLoadPlanId;
                    loadFact.CountHours = (decimal)dgvr.Cells["countHoursColumn"].Value;
                    loadFact.ClassRoomID = (int)dgvr.Cells["classRoomColumn"].Value;
                    loadFact.EmployeeFormID = (int)dgvr.Cells["formEmployeeColumn"].Value;
                    if ((bool)dgvr.Cells["flagColumn"].Value == true)
                    {
                        loadFact.EmployeeFactID = (int)dgvr.Cells["factEmployeeColumn"].Value;
                    }
                    else
                    {
                        loadFact.EmployeeFactID = (int)dgvr.Cells["formEmployeeColumn"].Value;
                    }
                    loadInCourseFacts.Add(loadFact);
                }
            }
            else
            {
                if (isIdentityEmployee == true)
                {
                    MessageBox.Show("Выбран одинаковый формальный и фактический преподаватели!");
                }

                if (isErrorOwner == true)
                {
                    MessageBox.Show("Преподавателем данного вида нагрузки должен быть владелец курса!");
                }

                this.DialogResult = DialogResult.None;
            }

		}

        private void btnRemoveInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                                    "Вы действительно хотите удалить всю информацию о планировании данной нагрузки?",
                                    "Подтверждение!",
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
	}
}
