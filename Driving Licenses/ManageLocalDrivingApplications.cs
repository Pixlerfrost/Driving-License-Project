﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;
using BuisnessLocalDrivingLicenseApplication;
using BuisnessUsers;
using FullWindowsFormProject.Driving_License_Tests;

namespace FullWindowsFormProject.Driving_Licenses
{
    public partial class ManageLocalDrivingApplications : Form
    {
        clsUsers _CurrentUser;
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

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplication.CancelLocalDrivingLicenseApplication((int)LocalDataGrid.CurrentRow.Cells[0].Value);
            _RefreshInfo();
        }

        private void scheduleVisionTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision_Test frm = new Vision_Test((int)LocalDataGrid.CurrentRow.Cells[0].Value, _CurrentUser);
            frm.ShowDialog();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseApplicationDetails frm = new ShowLicenseApplicationDetails((int)LocalDataGrid.CurrentRow.Cells[0].Value, _CurrentUser);
            frm.ShowDialog();
        }
    }
}