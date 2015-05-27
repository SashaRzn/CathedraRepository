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
	public partial class SortLoadForm : Form
	{
		private DatabaseDataContext database = new DatabaseDataContext();

		public SortLoadForm()
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

		private void SortLoadForm_Load(object sender, EventArgs e)
		{
			bsSortLoad.DataSource = database.SortLoad;

			this.WindowState = FormWindowState.Maximized;
		}
	}
}
