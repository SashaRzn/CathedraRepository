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
    public partial class RateForm : Form
    {
        private DatabaseDataContext database = new DatabaseDataContext();

        public RateForm()
        {
            InitializeComponent();
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

        private void RateForm_Load(object sender, EventArgs e)
        {
            foreach (SchoolYear sy in database.SchoolYear)
            {
                toolStripSchoolYear.Items.Add(sy);
            }
            toolStripSchoolYear.SelectedIndex = 0;
            updateBindingSourceRate((SchoolYear)toolStripSchoolYear.Items[0]);

            bsEmployee.DataSource = database.Employee.Where(p => !p.NonActive);
            bsPost.DataSource = database.Post;

            this.WindowState = FormWindowState.Maximized;
        }

        private void updateBindingSourceRate(SchoolYear ASchoolYear)
        {
            bsRate.DataSource = from rate in database.Rate
                                where rate.SchoolYearID == ASchoolYear.ID
                                select rate;
        }

        private void ctlRate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ctlRate.Rows[e.RowIndex].Cells["schoolYearColumn"].Value = (SchoolYear)toolStripSchoolYear.SelectedItem;
            }
        }

        private void ctlRate_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ctlRate.Refresh();
        }

        private void toolStripSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBindingSourceRate((SchoolYear)toolStripSchoolYear.SelectedItem);
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            string result = "";
            int count = 0;
            decimal totalRate = 0;
            decimal totalBaseSalary = 0;
            decimal totalPostSalary = 0;
            decimal totalGradeSurcharge = 0;
            decimal totalPostSurcharge = 0;
            int totalPochFondLimit = 0;
            foreach (Rate r in this.bsRate)
            {
                count++;
                totalRate += Utils.SafeDecimal(r.Rate1);
                totalBaseSalary += r.BaseSalary;
                totalPostSalary += r.PostSalary;
                totalGradeSurcharge += r.GradeSurcharge;
                totalPostSurcharge += r.PostSurcharge;
                totalPochFondLimit += r.PochFondLimit;
            }

            result = String.Format("Количество записей - {0},\n" +
                "ставка итого - {1},\n" +
                "базовый оклад итого - {2},\n" +
                "должностной оклад итого - {3},\n" +
                "доплата за степень итого - {4},\n" +
                "доплата за должность итого - {5},\n" +
                "оклад итого - {6},\n" +
                "лимит почасового фонда - {7}.",
                count, totalRate, totalBaseSalary, totalPostSalary, totalGradeSurcharge, totalPostSurcharge,
                totalBaseSalary + totalPostSalary + totalGradeSurcharge + totalPostSurcharge, totalPochFondLimit);

            MessageBox.Show(result);
        }

        private void ctlRate_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            switch (e.DesiredType.FullName)
            {
                case "CathedraUniversity.Employee":
                {
                    var s = e.Value as string;
                    Employee em = (from employee in this.bsEmployee.OfType<Employee>()
                        where employee.ToString() == s
                        select employee).FirstOrDefault();
                    e.Value = em;
                }
                    break;
                case "CathedraUniversity.Post":
                {
                    var s = e.Value as string;
                    Post p = (from post in this.bsPost.OfType<Post>()
                        where post.ToString() == s
                        select post).FirstOrDefault();
                    e.Value = p;
                }
                    break;
            }
            e.ParsingApplied = true;
        }
    }
}
