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
    public partial class GroupForm : Form
    {
        private DatabaseDataContext database = new DatabaseDataContext();

        public GroupForm()
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

        private void GroupForm_Load(object sender, EventArgs e)
        {
            bsGroup.DataSource = database.GetTable<Group>();
            bsGroupInSemestr.DataSource = bsGroup;
            bsGroupInSemestr.DataMember = "GroupInSemestr";

            bsSchoolYear.DataSource = database.GetTable<SchoolYear>();

            #region Семестр

            Dictionary<Nullable<short>, string> semestr = new Dictionary<Nullable<short>, string>();
			semestr.Add(1, "Осенний");
			semestr.Add(2, "Весенний");
			bsSemestr.DataSource = semestr;
            this.semestrColumn.DataSource = this.bsSemestr;
			this.semestrColumn.DisplayMember = "Value";
            this.semestrColumn.ValueMember = "Key";
			
            #endregion

            this.WindowState = FormWindowState.Maximized;
        }

        private void ctlGroupInSemestr_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.DesiredType.FullName.ToString() == "CathedraUniversity.SchoolYear")
            {
                string s = e.Value as string;

                //Требуется OfType, так как postBindingSource возвращает экземпляры объекта типа.
                SchoolYear sy = (from schoolYear in this.bsSchoolYear.OfType<SchoolYear>()
                                 where schoolYear.ToString() == s
                                 select schoolYear).FirstOrDefault();

                e.Value = sy;
            }
            e.ParsingApplied = true;
        }
    }
}
