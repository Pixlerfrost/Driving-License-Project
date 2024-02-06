using BuisnessAppointments;
using BuisnessLocalDrivingLicenseApplication;
using BuisnessTest;
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

namespace FullWindowsFormProject.Driving_License_Tests
{
    public partial class TakeVisionTest : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private int _TestAppointmentID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        clsAppointments _Appointment;
        clsTest _Test;
        clsUsers CurrentUser;
        public TakeVisionTest(int LocalDrivingLicenseApplicationID, int AppointmentID, clsUsers User)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = AppointmentID;
            CurrentUser = User;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetLocalLicenseInfo()
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseApplicationID);
            _Appointment = clsAppointments.Find(_TestAppointmentID);
            DLApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            ClassNameLbl.Text = _LocalDrivingLicenseApplication.ClassName;
            NameLbl.Text = _LocalDrivingLicenseApplication.FullName;
            DateLbl.Text = _Appointment.AppointmentDate.ToString("dd/mm/yyyy");
            FeeesLbl.Text = _Appointment.PaidFees.ToString();
        }
        private void _Onload()
        {
            SetLocalLicenseInfo();
        }
        private void TakeVisionTest_Load(object sender, EventArgs e)
        {
            _Onload();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _Test = new clsTest();

            _Test.TestAppointmentID = _Appointment.TestAppointmentID;
            _Test.Notes = richTextBox1.Text;
            _Test.CreatedByUserID = CurrentUser.UserID;

            if (PassRadioBtn.Checked == true)
                _Test.TestResult = true;
            else if (PassRadioBtn.Checked == false)
                _Test.TestResult = false;

            if (_Test.Save())
            {
                MessageBox.Show("Test Info Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TestIDLbl.Text = _Test.TestID.ToString();
                _Appointment.IsLocked = true;
                _Appointment.Save();
                this.Close();
            }
            else
                MessageBox.Show("Test Info Not Saved Successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
