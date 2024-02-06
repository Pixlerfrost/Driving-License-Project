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
using BuisnessAppointments;
using BuisnessUsers;

namespace FullWindowsFormProject.Driving_License_Tests
{
    public partial class MakeTestAppointment : Form
    {
        int _LocalLicenseApplicationID = -1;
        int _TestType = -1;
        int _AppointmentType = -1;
        public enum enTestType { Vision = 1, Written = 2, Street = 3 }
        public enum enAppointmentType { NormalTest = 0, RetakeTest = 1 }
        public enTestType _TestMode;
        public enAppointmentType _AppointmentMode;

       


        clsLocalDrivingLicenseApplication _DrivingApplication;
        clsAppointments _TestAppointment;
        clsUsers _CurrentUser;
        public MakeTestAppointment(int LocalLicenseApplicationID, int TestType, int AppointmentType, clsUsers User)
        {
            InitializeComponent();
            _LocalLicenseApplicationID = LocalLicenseApplicationID;
            _TestType = TestType;
            _AppointmentType = AppointmentType;
            _CurrentUser = User;
        }

        public void _SetTestData()
        {
            _DrivingApplication = clsLocalDrivingLicenseApplication.Find(_LocalLicenseApplicationID);
            ApplicationIDLbl.Text = _DrivingApplication.LocalDrivingLicenseApplicationID.ToString();
            ClassNameLbl.Text = _DrivingApplication.ClassName;
            FullNameLbl.Text = _DrivingApplication.FullName;
            if (_TestMode == enTestType.Vision)
                FeesLbl.Text = 10.ToString();
            else if (_TestMode == enTestType.Written)
                FeesLbl.Text = 20.ToString();
            else if (_TestMode == enTestType.Street)
                FeesLbl.Text = 30.ToString();

            if (_AppointmentMode == enAppointmentType.NormalTest)
            {
                RetakeFees.Text = 0.ToString();
                TestLbl.Text = "Schedule Test";
                RetakeTestGroupBox.Enabled = false;
            }
            else if (_AppointmentMode == enAppointmentType.RetakeTest)
            {
                RetakeFees.Text = 5.ToString();
                TestLbl.Text = "Schedule Retake Test";
                RetakeTestGroupBox.Enabled = true;
            }


            int Totalfees = Convert.ToInt32(RetakeFees.Text) + Convert.ToInt32(FeesLbl.Text);

            TotalFees.Text = Totalfees.ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetTestType()
        {
            if (_TestType == 1)
                _TestMode = enTestType.Vision;
            else if (_TestType == 2)
                _TestMode = enTestType.Written;
            else if (_TestType == 3)
                _TestMode = enTestType.Street;
        }
        private void _SetAppointmentType()
        {
            if (_AppointmentType == 0)
                _AppointmentMode = enAppointmentType.NormalTest;
            else if (_AppointmentType == 1)
                _AppointmentMode = enAppointmentType.RetakeTest;
        }
        private void _OnLoad()
        {
            _SetTestType();
            _SetAppointmentType();
            _SetTestData();

            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void TakeVisionTest_Load(object sender, EventArgs e)
        {
            _OnLoad();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _TestAppointment = new clsAppointments();

            _TestAppointment.TestTypeID = _TestType;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalLicenseApplicationID;
            _TestAppointment.AppointmentDate = dateTimePicker1.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(TotalFees.Text);
            _TestAppointment.CreatedByUserID = _CurrentUser.UserID;
            _TestAppointment.IsLocked = false;

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
            else
                MessageBox.Show("Appointment not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
