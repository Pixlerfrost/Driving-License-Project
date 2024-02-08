using BuisnessAppointments;
using BuisnessLayer;
using BuisnessLocalDrivingLicenseApplication;
using BuisnessTest;
using BuisnessUsers;
using FullWindowsFormProject.Driving_Licenses.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Driving_License_Tests
{
    public partial class DrivingLicenseTest : Form
    {
        private int _LocalDrivingLicenseID = -1;
        clsUsers _CurrentUser;
        int _TypeOfTest = -1;
        int _TestTypeID = -1;
        public enum enTestType { VisionTest, WrittenTest , StreetTest}
        public enTestType _TestMode;


        public DrivingLicenseTest(int LocalDrivingLicenseID, clsUsers User, int TypeOfTest)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _CurrentUser = User;
            _TypeOfTest = TypeOfTest;
           
        }

        private void _RefreshInfo(int LocalLicenseApplicationID)
        {
            DataView dv = clsAppointments.GetAppointmentByID(LocalLicenseApplicationID, _TestTypeID);
            AppointmentDataGrid.DataSource = dv;
            RecordsLbl.Text = dv.Count.ToString();
        }

        private void _SetTestMode()
        {
            if (_TypeOfTest == 0)
            {
                _TestMode = enTestType.VisionTest;
                _TestTypeID = 1;
            }
            else if (_TypeOfTest == 1)
            {
                _TestMode = enTestType.WrittenTest;
                _TestTypeID = 2;
            }
            else if (_TypeOfTest == 2)
            {
                _TestMode = enTestType.StreetTest;
                _TestTypeID = 3;
            }
        }

        private void _SetTestInfo()
        {
            if (_TestMode == enTestType.VisionTest)
            {
                AppointmentLbl.Text = "Vision Test Appointment";
            }
            else if (_TestMode == enTestType.WrittenTest)
            {
                AppointmentLbl.Text = "Written Test Appointment";
            }
            else if (_TestMode == enTestType.StreetTest)
            {
                AppointmentLbl.Text = "Street Test Appointment";
            }
        }

        private void _OnLoad()
        {
            AppointmentDataGrid.ContextMenuStrip = contextMenuStrip1;
            _SetTestMode();
            _SetTestInfo();
            _RefreshInfo(_LocalDrivingLicenseID);

        }

        private void Vision_Test_Load(object sender, EventArgs e)
        {
            _OnLoad();
            licenseApplicationInfo1.SetData(_LocalDrivingLicenseID, _CurrentUser);
            licenseApplicationInfo1.SetLocalLicenseInfo();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int AmountOfRecords = Convert.ToInt32(RecordsLbl.Text);
            int _AppointmentID = clsLocalDrivingLicenseApplication.FindAppointmentID(_LocalDrivingLicenseID, _TestTypeID);
            if (AmountOfRecords != 0 && clsAppointments.DidPersonPassTest(_LocalDrivingLicenseID, _TestTypeID))
            {
                MessageBox.Show("This Person Already Passed The Test!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clsAppointments.PersonAlreadyHasAppointment(_AppointmentID))
            {
                MessageBox.Show("This Person Already Has An Open Appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clsAppointments.DidPersonFail(_AppointmentID))
            {
                MakeTestAppointment frm = new MakeTestAppointment(_LocalDrivingLicenseID, _TestTypeID, 1, _CurrentUser);
                
                frm.ShowDialog();
                _RefreshInfo(_LocalDrivingLicenseID);
            }
            else
            {
                MakeTestAppointment frm = new MakeTestAppointment(_LocalDrivingLicenseID, _TestTypeID, 0, _CurrentUser);
                frm.ShowDialog();
                _RefreshInfo(_LocalDrivingLicenseID);
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeVisionTest frm = new TakeVisionTest(_LocalDrivingLicenseID, (int)AppointmentDataGrid.CurrentRow.Cells[0].Value, _CurrentUser, _TestTypeID);
            frm.ShowDialog();
            _RefreshInfo(_LocalDrivingLicenseID);
        }

        private void DisablePermissions()
        {
            if (clsAppointments.IsAppointmentLocked((int)AppointmentDataGrid.CurrentRow.Cells[0].Value))
            {
               
                takeTestToolStripMenuItem.Enabled = false;
            }
            else if(!clsAppointments.IsAppointmentLocked((int)AppointmentDataGrid.CurrentRow.Cells[0].Value))
            {
                
                takeTestToolStripMenuItem.Enabled = true;
            }
        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            DisablePermissions();
        }
    }
}
