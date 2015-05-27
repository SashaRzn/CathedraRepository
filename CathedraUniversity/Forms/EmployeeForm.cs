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
    public partial class EmployeeForm : Form
    {
        private DatabaseDataContext database = new DatabaseDataContext();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database.SubmitChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            database.SubmitChanges();
            Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            bsEmployee.DataSource = database.GetTable<Employee>();
            bsPost.DataSource = database.GetTable<Post>();

            this.WindowState = FormWindowState.Maximized;
        }

        private void ctlEmployes_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            string s = e.Value as string;

            //Требуется OfType, так как postBindingSource возвращает экземпляры объекта типа.
            Post p = (from post in this.bsPost.OfType<Post>()
                      where post.ToString() == s
                      select post).FirstOrDefault();

            e.Value = p;
            e.ParsingApplied = true;
        }
    }
}
