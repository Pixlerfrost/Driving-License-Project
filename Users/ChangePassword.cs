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
    public partial class ChangePassword : Form
    {
        private int _PersonID;
        clsUsers _User;
        public ChangePassword(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            ctrlShowUserInfo1.SetData(PersonID);
        }

        private void _Onload()
        {
            _User = clsUsers.Find(_PersonID);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            _Onload();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NewPasswordTxtBox.Text == ConfirmPasswordTxtBox.Text)
                _User.Password = ConfirmPasswordTxtBox.Text;

            if (_User.Save())
            {
                MessageBox.Show("User Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User Not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CurrentPasswordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CurrentPasswordTxtBox.Text))
            {
                e.Cancel = true;
                CurrentPasswordTxtBox.Focus();
                errorProvider1.SetError(CurrentPasswordTxtBox, "Current Password must have a value!");
            }
            else if (CurrentPasswordTxtBox.Text != _User.Password)
            {
                e.Cancel = true;
                CurrentPasswordTxtBox.Focus();
                errorProvider1.SetError(CurrentPasswordTxtBox, "The password you entered is incorrect!");
            }
            else
            {
                e.Cancel = false;
                
                errorProvider1.SetError(CurrentPasswordTxtBox, "");
            }
        }

        private void NewPasswordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewPasswordTxtBox.Text))
            {
                e.Cancel = true;
                NewPasswordTxtBox.Focus();
                errorProvider1.SetError(NewPasswordTxtBox, "New Password must have a value!");
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(NewPasswordTxtBox, "");
            }
        }

        private void ConfirmPasswordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConfirmPasswordTxtBox.Text))
            {
                e.Cancel = true;
                CurrentPasswordTxtBox.Focus();
                errorProvider1.SetError(ConfirmPasswordTxtBox, "Confirm Password must have a value!");
            }
            else if (NewPasswordTxtBox.Text != ConfirmPasswordTxtBox.Text)
            {
                e.Cancel = true;
                ConfirmPasswordTxtBox.Focus();
                errorProvider1.SetError(ConfirmPasswordTxtBox, "The Confirmation Password you entered does not match the Previous Password you entered!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ConfirmPasswordTxtBox, "");
            }
        }
    }
}
