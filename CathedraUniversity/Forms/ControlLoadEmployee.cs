using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraUniversity.Forms
{
    public partial class ControlLoadEmployee : Form
    {
        private DatabaseDataContext database = new DatabaseDataContext();
		EntitySet<Employee> entitySetEmployeeInSchoolYear = new EntitySet<Employee>();


        public ControlLoadEmployee()
        {
            InitializeComponent();
        }

        private void ControlLoadEmployee_Load(object sender, EventArgs e)
        {
            //bsEmployee.DataSource = database.Employee;

			#region Заполняем список dataGridViewEmployeeInSchoolYear
			foreach (Employee em in database.Employee)
			{
				if (!em.NonActive)
				{
					entitySetEmployeeInSchoolYear.Add(em);
				}
			}
			bsEmployee.DataSource = entitySetEmployeeInSchoolYear;
			#endregion

			updatedataGridViewEmployeeLoad();

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.SubmitChanges();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            database.SubmitChanges();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void updatedataGridViewEmployeeLoad()
		{
			foreach (DataGridViewRow r in ctlEmployeeLoad.Rows) paintRow(r);
			ctlEmployeeLoad.Refresh();
		}

		private void paintRow(DataGridViewRow ADataGridViewRow)
		{
			if (ADataGridViewRow != null)
			{
				// Получаем строку в первом наборе данных
				Employee employee = (Employee)ADataGridViewRow.DataBoundItem;
				if (employee != null)
				{
					DataGridViewCellStyle newStyle = ctlEmployeeLoad.DefaultCellStyle.Clone();
					if (employee.IsOverload)
						newStyle.BackColor = Color.LightCoral;
					else if (employee.IsUnderload)
						newStyle.BackColor = Color.LightGray;
					else if (employee.IsPochFondOverload)
						newStyle.BackColor = Color.Red;
					else
						newStyle.BackColor = Color.White;
					ADataGridViewRow.DefaultCellStyle = newStyle;
				}
			}
		}

		private void ctlEmployeeLoad_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (e.ListChangedType != ListChangedType.ItemDeleted)
			{
				updatedataGridViewEmployeeLoad();
			}
		}

		private void ctlEmployeeLoad_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// убрать
		}

		private void ctlEmployeeLoad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Employee employee = (Employee)bsEmployee.Current;
			ControlLoadEmployeeEdit formControlLoadEmployeeEdit = new ControlLoadEmployeeEdit(employee, database);
			formControlLoadEmployeeEdit.ShowDialog();
			updatedataGridViewEmployeeLoad();
		}

        private void toolStripGeneralTable_Click(object sender, EventArgs e)
        {
            string returnString = "Фамилия".PadRight(30) + "|" +
                "Должность".PadRight(20) + "|" +
                "Форм. нагрузка".PadRight(15) + "|" +
                "Перегрузка".PadRight(10) + "|" +
                "Недогрузка".PadRight(10) + "|" +
                "Форм. нагр. по часам".PadRight(20) + "|" +
                "Форм. ставка".PadRight(12) + "|" +
                "Факт. нагрузка".PadRight(14) + "|" +
                "Факт. ставка".PadRight(12) + "|" + "\n";

            decimal workloadForm = 0;
            decimal overload = 0;
            decimal underload = 0;
            decimal rateFormByHours = 0;
            decimal rateForm = 0;
            decimal workloadFact = 0;
            decimal rateFact = 0;

            //var q = from eisy in this.bindingSourceEmployeeInSchoolYear.OfType<EmployeeInSchoolYear>()
            //        orderby eisy.Post.Id descending
            //        select eisy;

            List<Employee> employeeList = (from emp in database.Employee
                                           where emp.NonActive == false
                                           select emp).ToList();

            foreach (Employee eisy in employeeList)
            {
                if (eisy.WorkloadForm != 0 ||
                    eisy.Overload != 0 ||
                    eisy.Underload != 0 ||
                    (decimal)eisy.RateFormByHours != 0 ||
                    eisy.RateForm != 0 ||
                    eisy.WorkloadFact != 0 ||
                    (decimal)eisy.RateFact != 0)
                {
                    returnString += eisy.Fio.PadRight(30) + "|" +
                        eisy.Post.ToString().PadRight(20) + "|" +
                        eisy.WorkloadForm.ToString().PadLeft(15) + "|" +
                        eisy.Overload.ToString().PadLeft(10) + "|" +
                        eisy.Underload.ToString().PadLeft(10) + "|" +
                        eisy.RateFormByHours.ToString().PadLeft(20) + "|" +
                        eisy.RateForm.ToString().PadLeft(12) + "|" +
                        eisy.WorkloadFact.ToString().PadLeft(14) + "|" +
                        eisy.RateFact.ToString().PadLeft(12) + "|" + "\n";

                    workloadForm += eisy.WorkloadForm;
                    overload += eisy.Overload;
                    underload += eisy.Underload;
                    rateFormByHours += (decimal)eisy.RateFormByHours;
                    rateForm += eisy.RateForm;
                    workloadFact += eisy.WorkloadFact;
                    rateFact += (decimal)eisy.RateFact;
                }
            }
            returnString += "\n";
            returnString += "ИТОГО: ".PadRight(30) + "|" +
                    "".PadRight(20) + "|" +
                    workloadForm.ToString().PadLeft(15) + "|" +
                    overload.ToString().PadLeft(10) + "|" +
                    underload.ToString().PadLeft(10) + "|" +
                    rateFormByHours.ToString().PadLeft(20) + "|" +
                    rateForm.ToString().PadLeft(12) + "|" +
                    workloadFact.ToString().PadLeft(14) + "|" +
                    rateFact.ToString().PadLeft(12) + "|" + "\n";

            EditorForm foemEditor = new EditorForm(returnString);
            foemEditor.ShowDialog();
        }
    }
}
