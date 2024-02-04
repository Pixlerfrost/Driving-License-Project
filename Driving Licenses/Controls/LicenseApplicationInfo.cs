using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLocalDrivingLicenseApplication;
using BuisnessApplications;
using BuisnessUsers;

namespace FullWindowsFormProject.Driving_Licenses.Controls
{
    public partial class LicenseApplicationInfo : UserControl
    {
        private int _LocalDrivingLicenseID = -1;

        clsLocalDrivingLicenseApplication _DrivingApplication;
        clsApplications _Application;
        clsUsers _CreatedByUser;
        public LicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void SetData(int LocalDrivingLicenseID, clsUsers CurrentUser)
        {
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _CreatedByUser = CurrentUser;
        }

        public void SetLocalLicenseInfo()
        {
            int ApplicationID = clsLocalDrivingLicenseApplication.FindAppID(_LocalDrivingLicenseID).ApplicationID;
            
            _DrivingApplication = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseID);
            _Application = clsApplications.Find(ApplicationID);
            

            DrivingLocalLbl.Text = _DrivingApplication.LocalDrivingLicenseApplicationID.ToString();
            PassedTestsLbl.Text = _DrivingApplication.PassedTestCount.ToString() + "/3";
            AppliedForLicenseLbl.Text = _DrivingApplication.ClassName;
            IDLbl.Text = _Application.ApplicationID.ToString();
            StatusLbl.Text = _DrivingApplication.Status;
            FeesLbl.Text = 15.ToString();
            TypeLbl.Text = "New Local Driving License Service";
            ApplicantLbl.Text = _DrivingApplication.FullName;
            DateLbl.Text = _Application.ApplicationDate.ToString("dd/mm/yyyy");
            StatusDateLbl.Text = _Application.LastStatusDate.ToString("dd/mm/yyyy");
            CreatedByLbl.Text = _CreatedByUser.UserName;
            
        }
        private void _OnLoad()
        {
            

        }

        private void LicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            _OnLoad();
        }

      
    }
}
