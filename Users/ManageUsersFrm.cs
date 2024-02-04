using BuisnessUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Users
{
    public partial class ManageUsersFrm : Form
    {
        public ManageUsersFrm()
        {
            InitializeComponent();
        }
        private string _FilterKey;
        private string _FilterWord;

        private enum enMode { IsActiveMode = 0, NormalMode = 1}
        private enMode _Mode;

        private void _RefreshInfo()
        {
            DataView dv = clsUsers.GetUsers();
            UsersDataGrid.DataSource = dv;
            RecordAmount.Text = dv.Count.ToString();
        }
        private void _RefreshInfo(bool Active)
        {
            DataView dv = clsUsers.GetUsers(Active);
            UsersDataGrid.DataSource = dv;
            RecordAmount.Text = dv.Count.ToString();
        }

        private void _RefreshInfo(string FilterKey, string FilterWord)
        {
            DataView dv = clsUsers.GetUsers(FilterKey, FilterWord);
            UsersDataGrid.DataSource = dv;
            RecordAmount.Text = dv.Count.ToString();
        }
        private void _OnLoad()
        {
            _RefreshInfo();
            FilterTextBox.Enabled = false;
            IsActiveComboBox.Hide();
            UsersDataGrid.ContextMenuStrip = contextMenuStrip1;
        }

        private void ManageUsersFrm_Load(object sender, EventArgs e)
        {
            _OnLoad();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedItem != null)
            {
                if (FilterComboBox.SelectedIndex == 0)
                {
                    _Mode = enMode.NormalMode;
                    FilterTextBox.Text = "";
                    FilterTextBox.Enabled = false;
                    IsActiveComboBox.Hide();
                    FilterTextBox.Show();
                    _RefreshInfo();
                }
                else if (FilterComboBox.SelectedItem.ToString() == "IsActive")
                {
                    IsActiveComboBox.SelectedIndex = 0;
                    _Mode = enMode.IsActiveMode;
                    FilterTextBox.Hide();
                    IsActiveComboBox.Show();
                }
                else
                {
                    _FilterKey = FilterComboBox.SelectedItem.ToString();
                    FilterTextBox.Enabled = true;
                    _Mode = enMode.NormalMode;
                    IsActiveComboBox.Hide();
                    FilterTextBox.Show();
                }

            }
            else
                FilterTextBox.Enabled = false;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.NormalMode)
            {
                _FilterWord = FilterTextBox.Text;
                _RefreshInfo(_FilterKey, _FilterWord);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrEditUsers frm = new AddOrEditUsers(-1);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEditUsers frm = new AddOrEditUsers(-1);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEditUsers frm = new AddOrEditUsers((int)UsersDataGrid.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUsers.DeleteUser((int)UsersDataGrid.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshInfo();
            }
            else
            {
                MessageBox.Show("User cannot be deleted because it has data tied to it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IsActiveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.IsActiveMode)
            {
                if (IsActiveComboBox.SelectedIndex == 0)
                {
                    _RefreshInfo();
                }
                else if (IsActiveComboBox.SelectedIndex == 1)
                {
                    _RefreshInfo(true);
                }
                else if (IsActiveComboBox.SelectedIndex == 2)
                {
                    _RefreshInfo(false);
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword((int)UsersDataGrid.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetails frm = new ShowUserDetails((int)UsersDataGrid.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }
    }
}
