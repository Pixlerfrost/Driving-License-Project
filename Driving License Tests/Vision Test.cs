using BuisnessAppointments;
using BuisnessUsers;
using FullWindowsFormProject.Driving_Licenses.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Driving_License_Tests
{
    public partial class Vision_Test : Form
    {
        private int _LocalDrivingLicenseID = -1;
        clsUsers _CurrentUser;
        public Vision_Test(int LocalDrivingLicenseID, clsUsers User)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _CurrentUser = User;
           
        }

        private void _RefreshInfo(int LocalLicenseApplicationID)
        {
            DataView dv = clsAppointments.GetAppointmentByID(LocalLicenseApplicationID);
            AppointmentDataGrid.DataSource = dv;
            RecordsLbl.Text = dv.Count.ToString();
        }

        private void _OnLoad()
        {
            _RefreshInfo(_LocalDrivingLicenseID);
            AppointmentDataGrid.ContextMenuStrip = contextMenuStrip1;
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
            //int AmountOfRecords = Convert.ToInt32(RecordsLbl.Text);
            //if (AmountOfRecords != 0 && )
        }
    }
}
