using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessTestTypes;
using FullWindowsFormProject.TestTypes;

namespace FullWindowsFormProject.Applications
{
    public partial class TestTypesFrm : Form
    {
        public TestTypesFrm()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            DataView dv = clsTestTypes.GetAllTestTypes();
            TestTypesDG.DataSource = dv;
            RecordsLabel.Text = dv.Count.ToString();
            TestTypesDG.ContextMenuStrip = contextMenuStrip1;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Applications_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

      
        private void editTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypes frm = new EditTestTypes((int)TestTypesDG.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();
        }
    }
}
