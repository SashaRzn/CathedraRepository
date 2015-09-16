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
    public partial class CourseInWorkLoadEditForm : Form
    {
        DatabaseDataContext _ddc;
        private readonly int _courseInWorkId;

        public CourseInWorkLoadEditForm(int courseInWorkId, DatabaseDataContext database)
        {
            InitializeComponent();
            _courseInWorkId = courseInWorkId;
            _ddc = database;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _ddc.SubmitChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CourseInWorkLoadEditForm_Load(object sender, EventArgs e)
        {
            var ciw = _ddc.CourseInWork.FirstOrDefault(p => p.ID == _courseInWorkId);
            if (ciw != null)
            {
                textBoxCourseName.Text = ciw.Course.Name;
                textBoxGroups.Text = ciw.Groups;
                textBoxSemestr.Text = ciw.SemestrString;
            }

            bindingSourceEmployeeFact.DataSource = from emp in _ddc.Employee
                where !emp.NonActive
                select emp;

            bindingSourceEmployeeForm.DataSource = from emp in _ddc.Employee
                                                   where !emp.NonActive
                                                   select emp;

            var q = from licf in _ddc.LoadInCourseFact
                where licf.CourseInWorkID == _courseInWorkId
                select licf;
            bindingSourceMain.DataSource = q;
        }

        private void dataGridViewMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMain.RowCount != 0)
            {
                bool result;
                if (dataGridViewMain.Rows[e.RowIndex].Cells["flagColumn"].Value != null
                    && Boolean.TryParse(dataGridViewMain.Rows[e.RowIndex].Cells["flagColumn"].Value.ToString(), out	result) == true)
                {
                    if (result)
                    {
                        var clicf = (LoadInCourseFact)bindingSourceMain.Current;
                        if ( clicf.LoadInCoursePlan.SortLoad.IsBisection)
                        {
                            dataGridViewMain.Rows[e.RowIndex].Cells["factEmployeeColumn"].ReadOnly = false;
                        }
                        else
                        {
                            dataGridViewMain.Rows[e.RowIndex].Cells["flagColumn"].Value = false;
                            MessageBox.Show(@"На данный вид нагрузки нельзя назначать другого фактического преподавателя!");
                        }
                    }
                    else
                    {
                        dataGridViewMain.Rows[e.RowIndex].Cells["factEmployeeColumn"].ReadOnly = true;
                        dataGridViewMain.Rows[e.RowIndex].Cells["factEmployeeColumn"].Value = null;
                    }
                }
            }
        }

        private void dataGridViewMain_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            string columnName = dataGridViewMain.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "formEmployeeColumn":
                    {
                        var s = e.Value as string;
                        Employee em = (from employee in this.bindingSourceEmployeeForm.OfType<Employee>()
                                       where employee.ToString() == s
                                       select employee).FirstOrDefault();
                        e.Value = em;
                    }
                    break;
                case "factEmployeeColumn":
                    {
                        var s = e.Value as string;
                        Employee em = (from employee in this.bindingSourceEmployeeFact.OfType<Employee>()
                                  where employee.ToString() == s
                                  select employee).FirstOrDefault();
                        e.Value = em;
                    }
                    break;
            }
            e.ParsingApplied = true;
        }
    }
}
