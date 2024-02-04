using BuisnessUsers;
using FullWindowsFormProject.Users;
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
using FullWindowsFormProject.Applications;
using FullWindowsFormProject.Driving_Licenses;

namespace FullWindowsFormProject
{
    public partial class Main : Form
    {
        Login _frmLogin;
        clsUsers _CurrentUser;
        public Main(Login frm, clsUsers CurrentUser)
        {
            InitializeComponent();
            _frmLogin = frm;
            _CurrentUser = CurrentUser;
        }

        private void ManagePeopleBtn_Click(object sender, EventArgs e)
        {
            ManagePeople ManagePeopleForm = new ManagePeople();
            ManagePeopleForm.ShowDialog();
        }


      

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsersFrm ManageUsersForm = new ManageUsersFrm();
            ManageUsersForm.ShowDialog();   
        }

       

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople ManagePeoplefrm = new ManagePeople();
            ManagePeoplefrm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowUserDetails frm = new ShowUserDetails(_CurrentUser.PersonID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(_CurrentUser.PersonID);
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTypesFrm frm = new TestTypesFrm();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationTypes frm = new ApplicationTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseFrm frm = new NewLocalDrivingLicenseFrm(_CurrentUser);
            frm.ShowDialog();
        }

        private void localLicenseDrivingApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingApplications frm = new ManageLocalDrivingApplications();
            frm.SetCurrentUser(_CurrentUser);
            frm.ShowDialog();
        }
    }
}
