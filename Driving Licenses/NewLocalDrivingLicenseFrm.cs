using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLicenseClasses;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq.Expressions;
using BuisnessUsers;
using BuisnessApplications;
using BuisnessLocalDrivingLicenseApplication;
using BuisnessLayer;


namespace FullWindowsFormProject.Driving_Licenses
{
    public partial class NewLocalDrivingLicenseFrm : Form
    {
        clsUsers _User;
        clsApplications _Application;
        clsLocalDrivingLicenseApplication _NewLocalDriversLicenseApplication;
        clsLicenseClasses _LicenseClasses;
        decimal fees = 0;


        public NewLocalDrivingLicenseFrm(clsUsers CurrentUser)
        {
            InitializeComponent();
            _User = CurrentUser;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (searchPerson1.IsPersonDataFull())
                tabControl1.SelectedTab = tabControl1.TabPages["ApplicationInfoPg"];
            else
                MessageBox.Show("Person Does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int SaveApplication()
        {
            
            _Application = new clsApplications();
            _Application.ApplicantPersonID = searchPerson1._Person.ID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = 1;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID = _User.UserID;
            _Application.PaidFees = fees + 15;

            if (_Application.Save())
                return _Application.ApplicationID;
            else
                return -1;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(searchPerson1._Person.ID);
           
            int LicenseClassID = _LicenseClasses.LicenseClassID;
            int ApplicationID = SaveApplication();

            if (!clsLocalDrivingLicenseApplication.DoesPersonHaveDuplicateLicense(Person.NationalNo, LicenseClassComboBox.SelectedItem.ToString()))
            {
                if (ApplicationID != -1)
                {
                    _NewLocalDriversLicenseApplication = new clsLocalDrivingLicenseApplication();
                    _NewLocalDriversLicenseApplication.ApplicationID = ApplicationID;
                    _NewLocalDriversLicenseApplication.LicenseClassID = LicenseClassID;
                    if (_NewLocalDriversLicenseApplication.Save())
                    {
                        DrivingApplicationID.Text = _NewLocalDriversLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                        MessageBox.Show("Drivers License Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("ApplicationID Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("This Person Has Already Applied for this Driving License!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadClassesIntoComboBox()
        {
            DataView dv = clsLicenseClasses.GetAllLicenseClasses();

            foreach (DataRowView row in dv)
            {
                LicenseClassComboBox.Items.Add(row["ClassName"]);
            }
        }

        private void _Onload()
        {

            _LoadClassesIntoComboBox();
            
            ApplicationDate.Text = DateTime.Now.ToString("dd/mm/yyyy");
            UserThatCreated.Text = _User.UserName;
        }

        private void NewLocalDrivingLicenseFrm_Load(object sender, EventArgs e)
        {
            _Onload();
        }

        private void SetApplicationFee(decimal Fee)
        {
            fees = Fee;
        }

        private void LicenseClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LicenseClasses = clsLicenseClasses.Find(LicenseClassComboBox.SelectedItem.ToString());
            switch (LicenseClassComboBox.SelectedIndex)
            {
                case 0:
                    SetApplicationFee(15);
                    break;
                case 1:
                    SetApplicationFee(30);
                    break;
                case 2:
                    SetApplicationFee(20);
                    break;
                case 3:
                    SetApplicationFee(200);
                    break;
                case 4:
                    SetApplicationFee(50);
                    break;
                case 5:
                    SetApplicationFee(250);
                    break;
                case 6:
                    SetApplicationFee(300);
                    break;
                default:
                    SetApplicationFee(0);
                    break;

            }
        }

        private void searchPerson1_Load(object sender, EventArgs e)
        {

        }

        private void searchPerson1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
