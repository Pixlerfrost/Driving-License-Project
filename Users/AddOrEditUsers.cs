using BuisnessLayer;
using BuisnessUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Users
{
    public partial class AddOrEditUsers : Form
    {
        private int _PersonID;
        private string FilterKey;
        private string FilterWord;
        clsPeople _Person;
        clsUsers _User;

        private enum enMode { AddMode = 0, UpdateMode = 1 };
        private enMode _Mode;
        public AddOrEditUsers(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            
        }

        private void _SetMode()
        {
            if (_PersonID == -1)
            {   
                _Mode = enMode.AddMode;
            }
            else
            {
                _Mode = enMode.UpdateMode;
            }
        }

        private void _OnLoad()
        {
            _SetMode();
            if (_Mode == enMode.AddMode)
            {
                label1.Text = "Add Users";
                FilterGroupBox.Enabled = true;
            }
            else if (_Mode == enMode.UpdateMode)
            {
                label1.Text = "Update Users";
                FilterGroupBox.Enabled = false;
                ctrlShowPersonDetails1.SetData(_PersonID);
                ctrlShowPersonDetails1._SetPersonData();

            }
            FilterTextBox.Enabled = false;

        }

        private void AddOrEditUsers_Load(object sender, EventArgs e)
        {
            _OnLoad();
            if (_Mode == enMode.AddMode)
            {
                _User = new clsUsers();
                return;
            }
            
            _User = clsUsers.Find(_PersonID);
            UserIDLbl.Text = _User.UserID.ToString();
            UserNameTxtBox.Text = _User.UserName;
            PasswordTxtBox.Text = _User.Password;
            ConfirmPasswordTxtBox.Text = _User.Password;
            if (_User.isActive)
                IsActiveCheckBox.Checked = true;
            else
                IsActiveCheckBox.Checked = false;

        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedItem != null)
            {
                if (FilterComboBox.SelectedIndex == 0)
                {
                    FilterTextBox.Text = "";
                    FilterTextBox.Enabled = false;
                    ctrlShowPersonDetails1._ClearData();
                }
                else
                {
                    FilterTextBox.Enabled = true;
                    FilterKey = FilterComboBox.SelectedItem.ToString();
                   
                }
            }
            else
            {
                FilterTextBox.Text = "";
                FilterTextBox.Enabled = false;
                ctrlShowPersonDetails1._ClearData();
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterWord = FilterTextBox.Text;
            if (!string.IsNullOrWhiteSpace(FilterWord))
            {
                if (FilterKey == "PersonID")
                {
                    int PersonID = Convert.ToInt32(FilterWord);
                    _Person = clsPeople.Find(PersonID);
                }
                else if (FilterKey == "NationalNo")
                {
                    _Person = clsPeople.Find(FilterWord);
                }
            }
            
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            if (_Person != null)
            {
                ctrlShowPersonDetails1.SetData(_Person.ID);
                ctrlShowPersonDetails1._SetPersonData();
            }
            else
                MessageBox.Show("This Person does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void SendID(object sender, int PersonID)
        {
            _Person = clsPeople.Find(PersonID);
            ctrlShowPersonDetails1.SetData(_Person.ID);
            ctrlShowPersonDetails1._SetPersonData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EditOrAddForm frm = new EditOrAddForm(-1);
            frm.SubscribeToDataBackEvent(SendID);
            frm.ShowDialog();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddMode)
            {
                if (_Person == null)
                {
                    MessageBox.Show("Please Select a Person!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (clsUsers.IsPersonUser(_Person.ID))
                {
                    MessageBox.Show("This Person is already a User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages["LoginInfoPage"];
                }
            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages["LoginInfoPage"];
                
            }

        }


        private void UserNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameTxtBox.Text))
            {
                e.Cancel = true;
                UserNameTxtBox.Focus();
                errorProvider1.SetError(UserNameTxtBox, "UserName must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UserNameTxtBox, "");
            }
        }

        private void PasswordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTxtBox.Text))
            {
                e.Cancel = true;
                PasswordTxtBox.Focus();
                errorProvider1.SetError(PasswordTxtBox, "Password must have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PasswordTxtBox, "");
            }
        }

        private void ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConfirmPasswordTxtBox.Text))
            {
                e.Cancel = true;
                ConfirmPasswordTxtBox.Focus();
                errorProvider1.SetError(ConfirmPasswordTxtBox, "You must confirm the Password!");
            }
            else if (ConfirmPasswordTxtBox.Text != PasswordTxtBox.Text)
            {
                e.Cancel = true;
                ConfirmPasswordTxtBox.Focus();
                errorProvider1.SetError(ConfirmPasswordTxtBox, "Password Confirmation does not match the Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ConfirmPasswordTxtBox, "");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUserInfo()
        {
            if (_Mode == enMode.AddMode)
            {
                _User.PersonID = _Person.ID;
                _User.UserName = UserNameTxtBox.Text;
                _User.Password = PasswordTxtBox.Text;
                if (IsActiveCheckBox.Checked == true)
                    _User.isActive = true;
                else
                    _User.isActive = false;
            }
            else if (_Mode == enMode.UpdateMode)
            {
                //_User.PersonID = _Person.ID;
                _User.UserName = UserNameTxtBox.Text;
                _User.Password = PasswordTxtBox.Text;
                if (IsActiveCheckBox.Checked == true)
                    _User.isActive = true;
                else
                    _User.isActive = false;
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SetUserInfo();


            if (_User.Save())
            {
                MessageBox.Show("User Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserIDLbl.Text = _User.UserID.ToString();

            }
            else
            {
                MessageBox.Show("User Not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void PersonInfoPage_Click(object sender, EventArgs e)
        {

        }
    }
}
