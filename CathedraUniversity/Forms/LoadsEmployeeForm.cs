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
	public partial class LoadsEmployeeForm : Form
	{
		private CourseInWork courseInWork;
		private DatabaseDataContext database;
		private Employee employee;
		private bool isGeneralLoad;
		private bool isFormLoad;
		private bool isFactLoad;
		private bool isPochFondLoad;
		private Employee tempEmployee;

		public Employee TempEmployee
		{
			get
			{
				return tempEmployee;
			}
		}

		public LoadsEmployeeForm(CourseInWork courseInWork, Employee employee, DatabaseDataContext database,
			bool isGeneralLoad, bool isFormLoad, bool isFactLoad, bool isPochFondLoad)
		{
			InitializeComponent();

			this.courseInWork = courseInWork;
			this.database = database;
			this.employee = employee;

			this.isGeneralLoad = isGeneralLoad;
			this.isFormLoad = isFormLoad;
			this.isFactLoad = isFactLoad;
			this.isPochFondLoad = isPochFondLoad;
		}

		private void LoadsEmployeeForm_Load(object sender, EventArgs e)
		{
			lblCourseName.Text = "Название курса: " + courseInWork.Course.Name;
			lblFormStudy.Text = "Форма обучения: " + ((courseInWork.FormStudy == true) ? "Заочная" : "Очная");
			lblSemestr.Text = "Семестр: " + courseInWork.SemestrString;

			UpdateDataGridView();
			UpdateButtons();

			ctlLoadInCourseFact.DataSource = null;
			ctlLoadInCourseFact.DataSource = bsLoadInCourseInFact;
		}

		private void UpdateDataGridView()
		{
			if (isGeneralLoad == true)
			{
				this.Text = "Общая нагрузка преподавателя";
				employeeFormColumn.Visible = false;
				employeeFactColumn.Visible = false;
				bsLoadInCourseInFact.DataSource = GeneralLoadDataSourse();
			}

			if (isFormLoad == true)
			{
				this.Text = "Формальная нагрузка преподавателя";
				employeeFormColumn.Visible = false;
				employeeFactColumn.Visible = true;
				bsLoadInCourseInFact.DataSource = FormLoadDataSourse();
			}

			if (isFactLoad == true)
			{
				this.Text = "Фактическая нагрузка преподавателя";
				employeeFormColumn.Visible = true;
				employeeFactColumn.Visible = false;
				bsLoadInCourseInFact.DataSource = FactLoadDataSourse();
			}

			if (isPochFondLoad == true)
			{
				this.Text = "Нагрузка преподавателя, оплачиваемая из почасового фонда";
				employeeFormColumn.Visible = false;
				employeeFactColumn.Visible = false;
				bsLoadInCourseInFact.DataSource = PochFondLoadDataSourse();
			}
		}

		private void UpdateButtons()
		{
			panelGeneralLoad.Visible = isGeneralLoad;
			panelFormLoad.Visible = isFormLoad;
			panelFactLoad.Visible = isFactLoad;
			panelPochFondLoad.Visible = isPochFondLoad;
		}


		private List<LoadInCourseFact> GeneralLoadDataSourse()
		{
			List<LoadInCourseFact> loadInCourseFacts = (from lf in courseInWork.LoadInCourseFact
														where lf.EmployeeFormID == employee.Id && lf.EmployeeFactID == employee.Id && lf.PochFond == false
														select lf).ToList<LoadInCourseFact>();
			return loadInCourseFacts;
		}

		private List<LoadInCourseFact> FormLoadDataSourse()
		{
			List<LoadInCourseFact> loadInCourseFacts = (from lf in courseInWork.LoadInCourseFact
														where (lf.EmployeeFormID == employee.Id && lf.EmployeeFactID != employee.Id && lf.PochFond == false)
														select lf).ToList<LoadInCourseFact>();
			return loadInCourseFacts;
		}

		private List<LoadInCourseFact> FactLoadDataSourse()
		{
			List<LoadInCourseFact> loadInCourseFacts = (from lf in courseInWork.LoadInCourseFact
														where lf.EmployeeFactID == employee.Id && lf.EmployeeFormID != employee.Id && lf.PochFond == false
														select lf).ToList<LoadInCourseFact>();
			return loadInCourseFacts;
		}

		private List<LoadInCourseFact> PochFondLoadDataSourse()
		{
			List<LoadInCourseFact> loadInCourseFacts = (from lf in courseInWork.LoadInCourseFact
														where lf.PochFond == true && lf.EmployeeFactID == employee.Id && lf.EmployeeFormID == employee.Id
														select lf).ToList<LoadInCourseFact>();
			return loadInCourseFacts;
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChangeEmployeeForOwnerLoad(LoadInCourseFact loadInCourseFact)
		{
			if (MessageBox.Show(this,
										"Выбранная нагрузка должна быть обязательно закреплена за владельцем курса! " +
						"Вы действительно хотите поменять владельца курса, а также перенести связанную с ним нагрузку?",
										"Подтверждение!",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
				formSelectEmployee.ShowDialog();
				if (formSelectEmployee.DialogResult == DialogResult.OK)
				{
					Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
					List<LoadInCourseFact> loadFacts = (List<LoadInCourseFact>)bsLoadInCourseInFact.DataSource;
					foreach (LoadInCourseFact load in loadFacts)
					{
						if (load.LoadInCoursePlan.SortLoad.IsOwner == true)
						{
							load.Employee = database.Employee.Single(c => c.Id == selectedEmployee.Id);
							load.Employee1 = database.Employee.Single(c => c.Id == selectedEmployee.Id);
						}
					}
					courseInWork.Employee = database.Employee.Single(c => c.Id == selectedEmployee.Id);
					database.SubmitChanges();
					UpdateDataGridView();
				}
			}
		}


        private void ChangeEmployeeForOwnerLoad2(LoadInCourseFact loadInCourseFact, Employee selectedEmployee)
        {
            if (courseInWork.EmployeeID == selectedEmployee.Id)
            {
                loadInCourseFact.Employee = database.Employee.Single(c => c.Id == selectedEmployee.Id);
                loadInCourseFact.Employee1 = database.Employee.Single(c => c.Id == selectedEmployee.Id);
            }
            else
            {
                MessageBox.Show("Выбранный преподаватель не является владельцем данного курса!" +
                 "Нагрузка не может быть перенесена!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

		#region Формальная и фактическая часть

        private void btnMoveFormAndFactPart_Click(object sender, EventArgs e)
        {
            if (bsLoadInCourseInFact.Current != null)
            {
                LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
                SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
                formSelectEmployee.ShowDialog();
                if (formSelectEmployee.DialogResult == DialogResult.OK)
                {
                    Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
                    bool isOwnerLoad = loadInCourseFact.LoadInCoursePlan.SortLoad.IsOwner;
                    if (isOwnerLoad == true) 
                    {
                        ChangeEmployeeForOwnerLoad2(loadInCourseFact, selectedEmployee);
                    }
                    else
                    {
                        loadInCourseFact.Employee = database.Employee.Single(c => c.Id == selectedEmployee.Id);
                        loadInCourseFact.Employee1 = database.Employee.Single(c => c.Id == selectedEmployee.Id);                        
                    }
                    database.SubmitChanges();
                    UpdateDataGridView();
                }
            }
        }

		private void btnMoveFormalPart_Click(object sender, EventArgs e)
		{

            if (bsLoadInCourseInFact.Current != null)
            {
                LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
                SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
                formSelectEmployee.ShowDialog();
                if (formSelectEmployee.DialogResult == DialogResult.OK)
                {
                    Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
                    bool isOwnerLoad = loadInCourseFact.LoadInCoursePlan.SortLoad.IsOwner;
                    if (isOwnerLoad == true)
                    {
                        ChangeEmployeeForOwnerLoad2(loadInCourseFact, selectedEmployee);
                    }
                    else
                    {
                        loadInCourseFact.Employee = database.Employee.Single(c => c.Id == selectedEmployee.Id);
                    }
                    database.SubmitChanges();
                    UpdateDataGridView();
                }
            }
		}


		private void btnMoveFactPart_Click(object sender, EventArgs e)
		{
            if (bsLoadInCourseInFact.Current != null)
            {
                LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
                SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
                formSelectEmployee.ShowDialog();
                if (formSelectEmployee.DialogResult == DialogResult.OK)
                {
                    Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
                    bool isOwnerLoad = loadInCourseFact.LoadInCoursePlan.SortLoad.IsOwner;
                    if (isOwnerLoad == true)
                    {
                        ChangeEmployeeForOwnerLoad2(loadInCourseFact, selectedEmployee);
                    }
                    else
                    {
                        loadInCourseFact.Employee1 = database.Employee.Single(c => c.Id == selectedEmployee.Id);
                    }
                    database.SubmitChanges();
                    UpdateDataGridView();
                }
            }
		}

		private void btnMoveToPochFond_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
                bool isOwnerLoad = loadInCourseFact.LoadInCoursePlan.SortLoad.IsOwner;
                if (isOwnerLoad == false)
                {
                    loadInCourseFact.PochFond = true;
                }
                else
                {
                    MessageBox.Show("Запрещено переводить нагрузку владельца курса в почасовой фонд!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
				database.SubmitChanges();
				UpdateDataGridView();
			}
		}

		#endregion

		#region Формальная часть

		/// <summary>
		/// Сделать и фактической
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFormalMakeFact_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				employee.LoadInCourseFact1.Insert(1, loadInCourseFact);
				database.SubmitChanges();
				UpdateDataGridView();
			}
		}

		/// <summary>
		/// Отдать ведущему фактически
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnMoveToFactEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				loadInCourseFact.EmployeeFormID = loadInCourseFact.EmployeeFactID;
				database.SubmitChanges();
				UpdateDataGridView();
			}
		}

		/// <summary>
		/// Перенести на другого формального преподавателя
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFormalChangeEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
				formSelectEmployee.ShowDialog();
				if (formSelectEmployee.DialogResult == DialogResult.OK)
				{
					Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
					loadInCourseFact.EmployeeFormID = selectedEmployee.Id;
					database.SubmitChanges();
					UpdateDataGridView();
				}
			}
		}

		/// <summary>
		/// Перейти к фактическому преподавателю
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGoToFactEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				tempEmployee = loadInCourseFact.Employee1;
				this.DialogResult = DialogResult.Retry;
				this.Close();
			}
		}

		#endregion

		#region Фактическая часть

		/// <summary>
		/// Сделать и формальной
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFactMakeFormal_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				loadInCourseFact.Employee = database.Employee.Single(c => c.Id == employee.Id);
				database.SubmitChanges();
				UpdateDataGridView();
			}
		}

		/// <summary>
		/// Отдать ведущему формально
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnMoveToFormalEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				loadInCourseFact.EmployeeFactID = loadInCourseFact.EmployeeFormID;
				database.SubmitChanges();
				UpdateDataGridView();
			}
		}

		/// <summary>
		/// Перенести на другого фактического преподавателя
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFactChangeEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
				formSelectEmployee.ShowDialog();
				if (formSelectEmployee.DialogResult == DialogResult.OK)
				{
					Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
					loadInCourseFact.EmployeeFactID = selectedEmployee.Id;
					database.SubmitChanges();
					UpdateDataGridView();
				}
			}
		}

		/// <summary>
		/// Перейти к фактическому преподавателю
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGoToFormalEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				tempEmployee = loadInCourseFact.Employee;
				this.DialogResult = DialogResult.Retry;
				this.Close();
			}
		}

		#endregion

		#region Почасовой фонд

		private void btnPochFondMakeFormal_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
				loadInCourseFact.PochFond = false;
				database.SubmitChanges();
				UpdateDataGridView();
			}
		}

		private void btnPochFondGoToEmployee_Click(object sender, EventArgs e)
		{
			if (bsLoadInCourseInFact.Current != null)
			{
				LoadInCourseFact loadInCourseFact = (LoadInCourseFact)bsLoadInCourseInFact.Current;
								SelectEmployeeForm formSelectEmployee = new SelectEmployeeForm(loadInCourseFact);
				formSelectEmployee.ShowDialog();
				if (formSelectEmployee.DialogResult == DialogResult.OK)
				{
					Employee selectedEmployee = formSelectEmployee.SelectedEmployee;
					loadInCourseFact.Employee = database.Employee.Single(c => c.Id == selectedEmployee.Id);
					loadInCourseFact.Employee1 = database.Employee.Single(c => c.Id == selectedEmployee.Id);
					database.SubmitChanges();
					UpdateDataGridView();
				}
			}
		}

		#endregion


	}
}
