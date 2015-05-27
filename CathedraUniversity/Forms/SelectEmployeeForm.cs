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
	public partial class SelectEmployeeForm : Form
	{
		private Repository repository = new Repository();
		private Employee selectedEmployee;
		private LoadInCourseFact loadInCourseFact;

		public Employee SelectedEmployee
		{
			get
			{
				return selectedEmployee;
			}
		}

		public SelectEmployeeForm(LoadInCourseFact loadInCourseFact)
		{
			InitializeComponent();

			this.loadInCourseFact = loadInCourseFact;
		}

		private void SelectEmployeeForm_Load(object sender, EventArgs e)
		{
			int sortLoadid = (int)loadInCourseFact.LoadInCoursePlan.SortLoadID;
			bsEmployee.DataSource = repository.GetFilterEmployee(sortLoadid);
			cbChoiceEmployee.DataSource = bsEmployee;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (bsEmployee.Current != null)
			{
				selectedEmployee = (Employee)bsEmployee.Current;
			}
			else
			{
				MessageBox.Show("Не выбран преподаватель!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.None;
			}
		}
	}
}
