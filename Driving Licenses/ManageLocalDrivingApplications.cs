﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessApplications;
using BuisnessAppointments;
using BuisnessLayer;
using BuisnessLocalDrivingLicenseApplication;
using BuisnessUsers;
using FullWindowsFormProject.Driving_License_Tests;
using BuisnessDrivers;
using BuisnessLicenses;
using BuisnessLicenseClasses;
using FullWindowsFormProject.Applications;

namespace FullWindowsFormProject.Driving_Licenses
{
    public partial class ManageLocalDrivingApplications : Form
    {
        clsUsers _CurrentUser;
        clsDrivers _Drivers;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        clsLicenses _Licenses;
        clsLicenseClasses _LicenseClass;
        clsApplications _Applications;
        string CurrentFilter = "";
        string CurrentKey = "";
     

        
        public ManageLocalDrivingApplications()
        {
            InitializeComponent();
        }
        public void SetCurrentUser(clsUsers User)
        {
            _CurrentUser = User;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseFrm frm = new NewLocalDrivingLicenseFrm(_CurrentUser);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void _RefreshInfo()
        {
            DataView dv = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            LocalDataGrid.DataSource = dv;
            RecordsLbl.Text = dv.Count.ToString();
        }

        private void _RefreshInfo(string Filter, string Key)
        {
            DataView dv = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications(Filter, Key);
            LocalDataGrid.DataSource = dv;
            RecordsLbl.Text = dv.Count.ToString();
        }
        private void _OnLoad()
        {
            _RefreshInfo();
            TextBoxFilter.Enabled = false;
            LocalDataGrid.ContextMenuStrip = contextMenuStrip1;
            
            
        }

        private void ManageLocalDrivingApplications_Load(object sender, EventArgs e)
        {
            _OnLoad();
        }

        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshInfo();
            TextBoxFilter.Clear();
            if (ComboBoxFilter.SelectedItem.ToString() == "None")
            {
                _RefreshInfo();
                TextBoxFilter.Enabled = false;
            }
            else
            {
                CurrentFilter = ComboBoxFilter.SelectedItem.ToString();
                TextBoxFilter.Enabled = true;
            }
        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            CurrentKey = TextBoxFilter.Text;
            _RefreshInfo(CurrentFilter, CurrentKey);
        }

        private void issueDrivingLicensesFirstTImeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int ApplicationID = clsLocalDrivingLicenseApplication.FindAppID((int)LocalDataGrid.CurrentRow.Cells[0].Value).ApplicationID;
            _LicenseClass = clsLicenseClasses.Find((string)LocalDataGrid.CurrentRow.Cells[1].Value);
            _Applications = clsApplications.Find(ApplicationID);
            MessageBox.Show(_LicenseClass.LicenseClassID.ToString());

            _Drivers = new clsDrivers();
            _Drivers.CreatedByUserID = _CurrentUser.UserID;
            _Drivers.CreatedDate = DateTime.Now;
            _Drivers.PersonID = _Applications.ApplicantPersonID;
            if (_Drivers.Save())
            {
                _Licenses = new clsLicenses();
                _Licenses.ApplicationID = ApplicationID;
                _Licenses.DriverID = _Drivers.DriverID;
                _Licenses.LicenseClass = _LicenseClass.LicenseClassID;
                _Licenses.IssueDate = DateTime.Now;
                _Licenses.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);

                _Licenses.PaidFees = _LicenseClass.ClassFees;
                _Licenses.IsActive = true;
                _Licenses.IssueReason = 1;
                _Licenses.CreatedByUserID = _CurrentUser.UserID;
                if (_Licenses.Save())
                {
                    clsApplications.SetApplicationToComplete((int)LocalDataGrid.CurrentRow.Cells[0].Value);
                    _RefreshInfo();
                    MessageBox.Show($"License with ID = {_Licenses.LicenseID} Has Been Successfully Issued!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("License Was Not Issued!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Driver ID Was Not Saved Successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplication.CancelLocalDrivingLicenseApplication((int)LocalDataGrid.CurrentRow.Cells[0].Value);
            _RefreshInfo();
        }

        private void scheduleVisionTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrivingLicenseTest frm = new DrivingLicenseTest((int)LocalDataGrid.CurrentRow.Cells[0].Value, _CurrentUser, (int)LocalDataGrid.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseApplicationDetails frm = new ShowLicenseApplicationDetails((int)LocalDataGrid.CurrentRow.Cells[0].Value, _CurrentUser);
            frm.ShowDialog();
        }

       

        
        
        private void scheduleTestsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            int PassedTestCount = (int)LocalDataGrid.CurrentRow.Cells[5].Value;
            if (PassedTestCount == 0)
            {
                scheduleVisionTestsToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
            else if (PassedTestCount == 1)
            {
                scheduleVisionTestsToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
            else if (PassedTestCount == 2)
            {
                scheduleVisionTestsToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
            }
            else if (PassedTestCount == 3)
            {
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleVisionTestsToolStripMenuItem.Enabled = false;
            }


        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrivingLicenseTest frm = new DrivingLicenseTest((int)LocalDataGrid.CurrentRow.Cells[0].Value, _CurrentUser, (int)LocalDataGrid.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrivingLicenseTest frm = new DrivingLicenseTest((int)LocalDataGrid.CurrentRow.Cells[0].Value, _CurrentUser, (int)LocalDataGrid.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if ((int)LocalDataGrid.CurrentRow.Cells[5].Value == 3)
            {
                issueDrivingLicensesFirstTImeToolStripMenuItem.Enabled = true;
                if ((string)LocalDataGrid.CurrentRow.Cells[6].Value == "Completed")
                {
                    editApplicationToolStripMenuItem.Enabled = false;
                    deleteApplicationToolStripMenuItem.Enabled = false;
                    scheduleTestsToolStripMenuItem.Enabled = false;
                    cancelApplicationToolStripMenuItem.Enabled = false;
                    issueDrivingLicensesFirstTImeToolStripMenuItem.Enabled = false;
                    showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                }
                else if ((string)LocalDataGrid.CurrentRow.Cells[6].Value != "Completed")
                {
                    editApplicationToolStripMenuItem.Enabled = true;
                    deleteApplicationToolStripMenuItem.Enabled = true;
                    scheduleTestsToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;
                    issueDrivingLicensesFirstTImeToolStripMenuItem.Enabled = true;
                    showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                scheduleTestsToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;
                issueDrivingLicensesFirstTImeToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            }
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication((int)LocalDataGrid.CurrentRow.Cells[0].Value);
            MessageBox.Show("Application Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _RefreshInfo();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrivingLicenseFrm frm = new DrivingLicenseFrm((int)LocalDataGrid.CurrentRow.Cells[0].Value, (string)LocalDataGrid.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
        }
    }
}