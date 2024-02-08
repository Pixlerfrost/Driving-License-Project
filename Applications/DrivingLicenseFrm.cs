using BuisnessLicenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Applications
{
    public partial class DrivingLicenseFrm : Form
    {
        string _NationalNo = "";
        int _LocalDrivingLicenseApplicationID = -1;
        public DrivingLicenseFrm(int LocalDrivingApplicationLicenseID, string NationalNo)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingApplicationLicenseID;
            _NationalNo = NationalNo;
        }

        private void DrivingLicenseFrm_Load(object sender, EventArgs e)
        {
            driversLicenseInfoCtrl1.SetData(_LocalDrivingLicenseApplicationID, _NationalNo);
            driversLicenseInfoCtrl1.SetDrivingLicenseInfo();
        }
    }
}
