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
    public partial class PostForm : Form
    {
        private DatabaseDataContext database = new DatabaseDataContext();

        public PostForm()
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

        private void PostForm_Load(object sender, EventArgs e)
        {
            bsPost.DataSource = database.Post;
            bsPostSalary.DataSource = bsPost;
            bsPostSalary.DataMember = "PostSalary";

            bsSchoolYear.DataSource = database.SchoolYear;

            this.WindowState = FormWindowState.Maximized;
        }

        private void ctlPostSalary_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.DesiredType.FullName.ToString() == "CathedraUniversity.SchoolYear")
            {
                string s = e.Value as string;

                //Требуется OfType, так как postBindingSource возвращает экземпляры объекта типа.
                SchoolYear sy = (from schoolYear in this.bsSchoolYear.OfType<SchoolYear>()
                                 where schoolYear.ToString() == s
                                 select schoolYear).FirstOrDefault();

                e.Value = sy;
                e.ParsingApplied = true;
            }
        }
    }
}
