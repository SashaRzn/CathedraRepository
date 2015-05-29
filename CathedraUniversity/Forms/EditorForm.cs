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
    public partial class EditorForm : Form
    {
        public EditorForm(string text)
        {
            InitializeComponent();
            richTextBoxMain.Text = text;
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
