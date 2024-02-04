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

namespace FullWindowsFormProject.Driving_Licenses
{
    public partial class ShowLicenseApplicationDetails : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        clsUsers _CurrentUser;
        public ShowLicenseApplicationDetails(int localDrivingLicenseApplicationID, clsUsers User)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _CurrentUser = User;
            
        }

        private void ShowLicenseApplicationDetails_Load(object sender, EventArgs e)
        {
            licenseApplicationInfo1.SetData(_LocalDrivingLicenseApplicationID, _CurrentUser);
            licenseApplicationInfo1.SetLocalLicenseInfo();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
