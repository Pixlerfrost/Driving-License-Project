using BuisnessLayer;
using BuisnessLicenses;
using BuisnessLocalDrivingLicenseApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Driving_Licenses.Controls
{
    public partial class DriversLicenseInfoCtrl : UserControl
    {

        int LocalDrivingLicenseID = -1;
        string _NationalNo = "";
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        clsPeople _Person;
        clsLicenses _License;

        public DriversLicenseInfoCtrl()
        {
            InitializeComponent();
        }

        public void SetData(int ID, string NationalNo)
        {
            LocalDrivingLicenseID = ID;
            _NationalNo = NationalNo;
            
        }

        public void SetDrivingLicenseInfo()
        {
            int LicenseID = clsLocalDrivingLicenseApplication.FindLicenseID(LocalDrivingLicenseID);
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseID);
            _Person = clsPeople.Find(_LocalDrivingLicenseApplication.NationalNo);
            _License = clsLicenses.Find(LicenseID);

            MessageBox.Show(_LocalDrivingLicenseApplication.NationalNo);
            MessageBox.Show(_Person.Gendor);

            ClassLbl.Text = _LocalDrivingLicenseApplication.ClassName;
            NameLbl.Text = _LocalDrivingLicenseApplication.FullName;
            LicenseIDLbl.Text = _License.LicenseID.ToString();
            NationalNoLbl.Text = _LocalDrivingLicenseApplication.NationalNo;
            GenderLbl.Text = _Person.Gendor;
            IssueDateLbl.Text = _License.IssueDate.ToString();
            DateOfBirthLbl.Text = _Person.DateOfBirth.ToString();
            DriverIDLbl.Text = _License.DriverID.ToString();
            ExpirationDateLbl.Text = _License.ExpirationDate.ToString();

            if (_License.IsActive == true)
                IsActiveLbl.Text = "Yes";
            if (_License.IsActive == false)
                IsActiveLbl.Text = "No";

            


            // Set Up the IsDetained and Issue Reason Labels
            IsHeDetainedLbl.Text = "";
            IssueReasonLbl.Text = "New License";

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
