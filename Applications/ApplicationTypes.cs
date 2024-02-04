using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessApplicationTypes;

namespace FullWindowsFormProject.Applications
{
    public partial class ApplicationTypes : Form
    {
        public ApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshInfo()
        {
            DataView dv = clsApplicationTypes.GetAllApplicationTypes();
            AppTypesDG.DataSource = dv;
            RecordsLabel.Text = dv.Count.ToString();
            AppTypesDG.ContextMenuStrip = contextMenuStrip1;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshInfo();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationTypes frm = new EditApplicationTypes((int)AppTypesDG.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }
    }
}
