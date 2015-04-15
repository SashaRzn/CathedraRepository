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
using System.Globalization;

namespace CathedraUniversity.Forms
{
	public partial class PreferencesForm : Form
	{
		private DatabaseDataContext database = new DatabaseDataContext();

		public PreferencesForm()
		{
			InitializeComponent();
		}

		private void PreferencesForm_Load(object sender, EventArgs e)
		{
			bsSchoolYear.DataSource = database.SchoolYear;
			int i = 0;
			foreach (SchoolYear sy in bsSchoolYear)
			{
				if (sy.ID == Settings.SchoolYearId)
				{
					bsSchoolYear.Position = i;
					break;
				}
				i++;
			}
			txtLoadPercent.Text = Settings.LoadPercent.ToString(CultureInfo.InvariantCulture);
			txtPochFondKodValue.Text = Settings.PochFondKod.ToString(CultureInfo.InvariantCulture);
			txtFreeHoursEmployeeId.Text =
				Settings.FreeHoursEmployeeId.ToString(CultureInfo.InvariantCulture);

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			//Settings.SchoolYearId = (int)cbSchoolYear.SelectedValue;

			if (bsSchoolYear.Current != null)
			{
				SchoolYear sy = (SchoolYear)bsSchoolYear.Current;
				Settings.SchoolYearId = sy.ID;

			}
			else
			{
				MessageBox.Show(@"Не задан элемент в выпадающем списке!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbSchoolYear.Focus();
				return;
			}
			decimal percent;
			if (!Decimal.TryParse(txtLoadPercent.Text, out percent))
			{
				MessageBox.Show(@"Ошибочное значение процента!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtLoadPercent.Focus();
				return;
			}
			if (percent < 0 || percent > 100)
			{
				MessageBox.Show(@"Значение процента может находиться только в диапазоне от 0 до 100!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtLoadPercent.Focus();
				return;
			}
			Settings.LoadPercent = percent;
			int pochFondKod;
			if (!Int32.TryParse(txtPochFondKodValue.Text, out pochFondKod))
			{
				MessageBox.Show(@"Ошибочное значение кода сотрудника!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPochFondKodValue.Focus();
				return;
			}
			Settings.PochFondKod = pochFondKod;

			int freeHoursEmployeeId;
			if (!Int32.TryParse(txtFreeHoursEmployeeId.Text, out freeHoursEmployeeId))
			{
				MessageBox.Show(@"Ошибочное значение кода сотрудника!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFreeHoursEmployeeId.Focus();
				return;
			}
			Settings.FreeHoursEmployeeId = freeHoursEmployeeId;
			Close();	
		}

	}
}
