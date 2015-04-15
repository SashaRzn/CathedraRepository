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
	public partial class ClassRoomForm : Form
	{
		private DatabaseDataContext database = new DatabaseDataContext();

		public ClassRoomForm()
		{
			InitializeComponent();
		}

		private void ClassRoomForm_Load(object sender, EventArgs e)
		{
			Dictionary<Nullable<byte>, string> typeClassRoom = new Dictionary<Nullable<byte>, string>();
			typeClassRoom.Add(1, "Лекционная");
			typeClassRoom.Add(2, "Лаборатория");
			typeClassRoom.Add(3, "Лаборатория/Лекционная");
			ctlSourceSemestr.DataSource = typeClassRoom;

			ctlSourceClassRoom.DataSource = database.ClassRoom;

			this.typeColumn.DataSource = ctlSourceSemestr;
			this.typeColumn.DisplayMember = "Value";
			this.typeColumn.ValueMember = "Key";

			this.WindowState = FormWindowState.Maximized;		
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			database.SubmitChanges();
		}

		private void ctlClassRooms_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string headerText = ctlClassRooms.Columns[e.ColumnIndex].Name;

			if (headerText.Equals("countPlaceColumn"))
			{
				byte result;
				if (Byte.TryParse((string)e.FormattedValue, out result) == false)
				{
					ctlClassRooms.Rows[e.RowIndex].ErrorText =
						"Недопустимое значение в поле 'Количество мест'";
					e.Cancel = true;
				}
			}

			if (headerText.Equals("numberColumn"))
			{
				if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
				{
					ctlClassRooms.Rows[e.RowIndex].ErrorText =
						"Значение поля 'Номер аудитории' не может быть пустым";
					e.Cancel = true;
				}
			}
		}

		private void ctlClassRooms_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			ctlClassRooms.Rows[e.RowIndex].ErrorText = String.Empty;
		}

		private void ctlClassRooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
			{
				MessageBox.Show("Ошибка работы с базой данных");
			}
		}
	}
}
