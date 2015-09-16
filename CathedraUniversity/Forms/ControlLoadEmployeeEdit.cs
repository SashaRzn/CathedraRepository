using System.Globalization;
using CathedraUniversity.Forms.Classes;
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
    public partial class ControlLoadEmployeeEdit : Form
    {
        private Employee employee;
        private DatabaseDataContext database;


        public ControlLoadEmployeeEdit(Employee employee, DatabaseDataContext database)
        {
            InitializeComponent();
            this.employee = employee;
            this.database = database;
        }

        private void ControlLoadEmployeeEdit_Load(object sender, EventArgs e)
        {
            textBoxInfo.Text = employee.Fio + ", " + employee.Post.Name.ToLower();
            if (!String.IsNullOrEmpty(employee.Phone))
                textBoxInfo.Text += ", " + employee.Phone;
            if (!String.IsNullOrEmpty(employee.E_mail))
                textBoxInfo.Text += ", e-mail: " + employee.E_mail;
            textBoxComment.Text = employee.Comment;
            updateParameters();
            updateDataGridViews();
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            employee.Comment = textBoxComment.Text;
            database.SubmitChanges();
            Close();
        }

        private void updateParameters()
        {
            //labelTotalFormalWorkloadValue.Text = (eisy.Post.RateInHoursInSchoolYear(eisy.SchoolYear)*
            //    eisy.RateForm).ToString();
            labelTotalFormalWorkloadValue.Text = employee.RateInHours.ToString();

            labelFactPochFondText.Text = " - в т.ч. почасовой фонд (лимит " + employee.PochFondLimit.ToString() + "):";

            Employee pf = database.Employee.FirstOrDefault(p => p.Id == Settings.PochFondKod);
            int currentSchoolYearId = Settings.SchoolYearId;
            labelPochNagruzValue.Text = String.Format("{0}/{1}/{2}",
                pf.Post.RateInHoursInSchoolYear(currentSchoolYearId),
                pf.WorkloadForm,
                pf.Post.RateInHoursInSchoolYear(currentSchoolYearId) - pf.WorkloadForm);

            decimal a = employee.Post.RateInHoursInSchoolYear(currentSchoolYearId);
            decimal b = employee.WorkloadForm;
            decimal c = employee.Post.RateInHoursInSchoolYear(currentSchoolYearId) - employee.WorkloadForm;

            labelFormalWorkloadValue.Text = employee.WorkloadForm.ToString();
            if (employee.IsOverload || employee.IsUnderload)
                labelFormalWorkloadValue.BackColor = Color.LightCoral;
            else
                labelFormalWorkloadValue.BackColor = Color.LightGreen;

            labelUnderloadValue.Text = employee.Underload.ToString();
            if (employee.IsUnderload)
                labelUnderloadValue.BackColor = Color.LightCoral;
            else if (employee.Underload == 0)
                labelUnderloadValue.BackColor = this.BackColor;
            else
                labelUnderloadValue.BackColor = Color.LightGreen;

            labelOverloadValue.Text = employee.Overload.ToString();
            if (employee.IsOverload)
                labelOverloadValue.BackColor = Color.LightCoral;
            else if (employee.Overload == 0)
                labelOverloadValue.BackColor = this.BackColor;
            else
                labelOverloadValue.BackColor = Color.LightGreen;

            labelFactValue.Text = employee.WorkloadFact.ToString();

            labelFactOtherTutorValue.Text = employee.WorkloadFactTutor.ToString();

            labelFactPochFondValue.Text = employee.WorkloadFactPochFond.ToString();
            if (employee.IsPochFondOverload)
                labelFactPochFondValue.BackColor = Color.LightCoral;

        }


        private void updateDataGridViews()
        {
            ctlCourseInWork.Rows.Clear();

            int currentSchoolYearId = Settings.SchoolYearId;

            var queryCourseInWorkList = (from lf in database.LoadInCourseFact
                where lf.CourseInWork.SchoolYearID == currentSchoolYearId &&
                      (lf.EmployeeFormID == employee.Id || lf.EmployeeFactID == employee.Id)
                group lf by new {lf.CourseInWorkID, lf.CourseInWork}
                into grouping
                orderby grouping.Key.CourseInWork.Course.Name
                select grouping);

            foreach (var grp in queryCourseInWorkList)
            {
                CourseInWork courseInWork = (from c in database.CourseInWork
                    where c.ID == grp.Key.CourseInWorkID
                    select c).SingleOrDefault();

                List<LoadInCourseFact> loadGeneral = (from lf in database.LoadInCourseFact
                    where lf.CourseInWorkID == courseInWork.ID &&
                          (lf.EmployeeFormID == employee.Id && lf.EmployeeFactID == employee.Id
                           && lf.PochFond == false)
                    select lf).ToList();
                string textToolTipGeneral = GetTextHint(loadGeneral);
                decimal totalGeneralHours = TotalHoursInList(loadGeneral);

                List<LoadInCourseFact> loadForm = (from lf in database.LoadInCourseFact
                    where lf.CourseInWorkID == courseInWork.ID
                          &&
                          (lf.EmployeeFormID == employee.Id && lf.EmployeeFactID != employee.Id && lf.PochFond == false)
                    select lf).ToList();
                string textToolTipForm = GetTextHint(loadForm);
                decimal totalFormHours = TotalHoursInList(loadForm);
                string formColleagues = "";
                var loadInCourseForm = loadForm.FirstOrDefault();
                if (loadInCourseForm != null)
                    formColleagues = loadInCourseForm.EmployeeFactFio;

                List<LoadInCourseFact> loadFact = (from lf in database.LoadInCourseFact
                    where lf.CourseInWorkID == courseInWork.ID
                          &&
                          (lf.EmployeeFactID == employee.Id && lf.EmployeeFormID != employee.Id && lf.PochFond == false)
                    select lf).ToList();
                string textToolTipFact = GetTextHint(loadFact);
                decimal totalFactHours = TotalHoursInList(loadFact);
                string factColleagues = "";
                var loadInCourseFact = loadFact.FirstOrDefault();
                if (loadInCourseFact != null)
                    factColleagues = loadInCourseFact.EmployeeFormFio;

                List<LoadInCourseFact> loadPochFond = (from lf in database.LoadInCourseFact
                    where lf.CourseInWorkID == courseInWork.ID
                          &&
                          (lf.PochFond == true && lf.EmployeeFactID == employee.Id && lf.EmployeeFormID == employee.Id)
                    select lf).ToList();
                string textToolTipPochFond = GetTextHint(loadPochFond);
                decimal totalPochFondHours = TotalHoursInList(loadPochFond);

                ctlCourseInWork.Rows.Add(
                    courseInWork.ID,
                    courseInWork.Course.Name,
                    courseInWork.Groups,
                    (courseInWork.Semestr == 1) ? "Осенний" : "Весенний",
                    (courseInWork.FormStudy == true) ? "Очная" : "Заочная",
                    totalGeneralHours,
                    totalFormHours,
                    formColleagues,
                    totalFactHours,
                    factColleagues,
                    totalPochFondHours);

                int index = ctlCourseInWork.Rows.Count - 1;
                ctlCourseInWork.Rows[index].Cells["generalLoadColumn"].ToolTipText = textToolTipGeneral;
                ctlCourseInWork.Rows[index].Cells["formLoadColumn"].ToolTipText = textToolTipForm;
                ctlCourseInWork.Rows[index].Cells["factLoadColumn"].ToolTipText = textToolTipFact;
                ctlCourseInWork.Rows[index].Cells["pochFondLoadColumn"].ToolTipText = textToolTipPochFond;
            }
            ctlCourseInWork.Refresh();
        }

        private string GetTextHint(List<LoadInCourseFact> loadFactList)
        {
            StringBuilder textHint = new StringBuilder(100);
            foreach (LoadInCourseFact loadFact in loadFactList)
            {
                textHint.Insert(textHint.Length,
                    String.Format(" {0}: {1}", loadFact.LoadInCoursePlan.SortLoad.Name, loadFact.CountHours));
            }
            return textHint.ToString();
        }

        private decimal TotalHoursInList(List<LoadInCourseFact> loadFacts)
        {
            decimal totalHours = 0;
            if (loadFacts.Count > 0)
            {
                totalHours = (from c in loadFacts
                    select c.CountHours).Sum();
            }
            return totalHours;
        }

        private void btnFormMove_Click(object sender, EventArgs e)
        {
            if (ctlCourseInWork.SelectedRows.Count > 0)
            {
                decimal totalHours = (decimal) ctlCourseInWork.SelectedRows[0].Cells["formLoadColumn"].Value;
                ProcessingButton(totalHours, false, true, false, false);
            }
        }

        private void btnGeneralMove_Click(object sender, EventArgs e)
        {
            if (ctlCourseInWork.SelectedRows.Count > 0)
            {
                decimal totalHours = (decimal) ctlCourseInWork.SelectedRows[0].Cells["generalLoadColumn"].Value;
                ProcessingButton(totalHours, true, false, false, false);
            }
        }

        private void btnFactMove_Click(object sender, EventArgs e)
        {
            if (ctlCourseInWork.SelectedRows.Count > 0)
            {
                decimal totalHours = (decimal) ctlCourseInWork.SelectedRows[0].Cells["factLoadColumn"].Value;
                ProcessingButton(totalHours, false, false, true, false);
            }

        }

        private void btnPochFondMove_Click(object sender, EventArgs e)
        {
            if (ctlCourseInWork.SelectedRows.Count > 0)
            {
                decimal totalHours = (decimal) ctlCourseInWork.SelectedRows[0].Cells["pochFondLoadColumn"].Value;
                ProcessingButton(totalHours, false, false, false, true);
            }
        }

        private void ProcessingButton(decimal totalHours, bool isGeneralLoad, bool isFormLoad, bool isFactLoad,
            bool isPochFondLoad)
        {
            if (totalHours > 0)
            {
                var courseInWorkId = (int) ctlCourseInWork.SelectedRows[0].Cells["idColumn"].Value;

                var courseInWork = (from c in database.CourseInWork
                    where c.ID == courseInWorkId
                    select c).SingleOrDefault();

                var formLoadsEmployee = new LoadsEmployeeForm(courseInWork, employee, database,
                    isGeneralLoad, isFormLoad, isFactLoad, isPochFondLoad);
                if (formLoadsEmployee.ShowDialog(this) == DialogResult.Cancel)
                {
                    updateDataGridViews();
                }
                else
                {
                    var tempEmployee = formLoadsEmployee.TempEmployee;
                    var formControlLoadEmployeeEdit = new ControlLoadEmployeeEdit(tempEmployee, database);
                    formControlLoadEmployeeEdit.ShowDialog();

                    updateDataGridViews();
                }
            }
            else
            {
                MessageBox.Show(@"На выбранном курсе нет запрашиваемой нагрузки!");
            }
        }

        private void buttonCrossLoadStat_Click(object sender, EventArgs e)
        {
            int currentSchoolYearId = Settings.SchoolYearId;

            var queryCourseInWorkList1 = from lf in database.LoadInCourseFact
                where lf.CourseInWork.SchoolYearID == currentSchoolYearId &&
                      (lf.EmployeeFormID == employee.Id && lf.EmployeeFactID != employee.Id)
                group lf by new { EmployeeForm = lf.Employee1 }
                into grouping
                select new { GroupFields = grouping, Hours = grouping.Sum(p => p.CountHours )};
            string result = "Формальной нагрузки:\r\n";
            foreach (var groupRow in queryCourseInWorkList1)
            {
                result += "   " + groupRow.GroupFields.Key.EmployeeForm.ShortName + " - " + groupRow.Hours + "\r\n";
            }

            var queryCourseInWorkList2 = from lf in database.LoadInCourseFact
                                        where lf.CourseInWork.SchoolYearID == currentSchoolYearId &&
                                              (lf.EmployeeFormID != employee.Id && lf.EmployeeFactID == employee.Id)
                                        group lf by new { EmployeeFact = lf.Employee }
                                            into grouping
                                            select new { GroupFields = grouping, Hours = grouping.Sum(p => p.CountHours) };
            result += "Фактической нагрузки:\r\n";
            foreach (var groupRow in queryCourseInWorkList2)
            {
                result += "   " + groupRow.GroupFields.Key.EmployeeFact.ShortName + " - " + groupRow.Hours + "\r\n";
            }
            MessageBox.Show(result);
        }

        private void ctlCourseInWork_DoubleClick(object sender, EventArgs e)
        {
            var courseInWorkId = (int)ctlCourseInWork.SelectedRows[0].Cells["idColumn"].Value;
            var ciwlef = new CourseInWorkLoadEditForm(courseInWorkId, database);
            if (ciwlef.ShowDialog() == DialogResult.OK)
            {
                updateDataGridViews();
            }
        }
    }
}
