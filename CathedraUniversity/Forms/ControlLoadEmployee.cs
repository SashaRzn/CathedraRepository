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
    }
}
