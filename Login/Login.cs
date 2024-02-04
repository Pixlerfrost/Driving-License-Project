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

namespace FullWindowsFormProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        clsUsers CurrentUser;
       

      
        private void button2_Click(object sender, EventArgs e)
        {
            CurrentUser = clsUsers.Find(UserNameTxtBox.Text);
            bool LogedIn = false;
            if (CurrentUser != null && CurrentUser.Password == PasswordTxtBox.Text)
            {
                if (CurrentUser.UserName == UserNameTxtBox.Text && CurrentUser.Password == PasswordTxtBox.Text && clsUsers.IsActive(UserNameTxtBox.Text))
                {
                    LogedIn = true;
                }
            }
            else
            {
                MessageBox.Show("Username/Password are incorrect!", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (LogedIn)
            {
                
                this.Hide();
                Main frm = new Main(this, CurrentUser);
                frm.Show();
                
            }
            
        }

        private void UserNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameTxtBox.Text))
            {
                e.Cancel = true;
                UserNameTxtBox.Focus();
                errorProvider1.SetError(UserNameTxtBox, "Username should have a value!");
            }
            else if (!clsUsers.isExist(UserNameTxtBox.Text))
            {
                
                errorProvider1.SetError(UserNameTxtBox, "User Does Not Exist!");
            }
            else if (!clsUsers.IsActive(UserNameTxtBox.Text))
            {
                
                errorProvider1.SetError(UserNameTxtBox, "User Is Not Active!");
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
                errorProvider1.SetError(PasswordTxtBox, $"Password should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PasswordTxtBox, ""); ;
            }
        }

        

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

            