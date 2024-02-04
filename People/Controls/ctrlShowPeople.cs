using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;

namespace FullWindowsFormProject
{
    public partial class ctrlShowPeople : UserControl
    {
        
        public ctrlShowPeople()
        {
            InitializeComponent();
            
            ComboBoxFilter.SelectedIndexChanged += ComboBoxFilter_SelectedIndexChanged;
            _RefreshInfo();
        }
        private string _SelectedFilterItem;
        private string _KeyFilterItem;


        public void _RefreshInfo()
        {
           
            DataView dv = clsPeople.GetAllInfo();
            DataGridInfo.DataSource = dv;
            AmonuntOfRecords.Text = dv.Count.ToString();
        }

        private void _RefreshInfo(string FilterWord, string KeyFilterWord)
        {
            DataView dv = clsPeople.GetAllInfo(FilterWord, KeyFilterWord);
            DataGridInfo.DataSource = dv;
            AmonuntOfRecords.Text = dv.Count.ToString();
        }


        private void _OnLoad()
        {
            DataGridInfo.ContextMenuStrip = contextMenuStrip1;
        }

        private void ctrlShowPeople_Load(object sender, EventArgs e)
        {
            _OnLoad();
            _RefreshInfo();

        }
        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFilter.SelectedItem != null)
            {
                if (ComboBoxFilter.SelectedIndex == 0)
                {
                    FilterTxtBox.Text = "";
                    FilterTxtBox.Enabled = false;
                    _RefreshInfo();
                }
                else
                {
                    _SelectedFilterItem = ComboBoxFilter.SelectedItem.ToString();
                    FilterTxtBox.Enabled = true;
                }
            }
            else
            {
                FilterTxtBox.Enabled = false;
            }

            
        }

        private void FilterTxtBox_TextChanged(object sender, EventArgs e)
        {
            _KeyFilterItem = FilterTxtBox.Text;
            _RefreshInfo(_SelectedFilterItem, _KeyFilterItem);
        }

        
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowDetailsForm = new ShowPersonDetails((int)DataGridInfo.CurrentRow.Cells[0].Value);
            ShowDetailsForm.ShowDialog();
            _RefreshInfo();
        }
        private void _NotImplementedMessage()
        {
            MessageBox.Show("This Feature Is Not Implemented Yet.", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _NotImplementedMessage();
        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _NotImplementedMessage();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddOrEditfrm = new EditOrAddForm((int)DataGridInfo.CurrentRow.Cells[0].Value);
            AddOrEditfrm.ShowDialog();
            _RefreshInfo();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddOrEditfrm = new EditOrAddForm(-1);
            AddOrEditfrm.ShowDialog();
            _RefreshInfo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPeople.DeleteByID((int)DataGridInfo.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshInfo();
            }

            else
                MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new EditOrAddForm(-1);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            _RefreshInfo(_SelectedFilterItem, _KeyFilterItem);
        }
    }
}
