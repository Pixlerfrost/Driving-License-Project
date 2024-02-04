using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessCountry;



namespace FullWindowsFormProject
{
    public partial class CtrlEditOrAdd : UserControl
    {
        clsPeople Person;
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;


        private enum enMode { UpdateMode, AddMode };
        private enMode _Mode;
        public int _PersonID = -1;


        public CtrlEditOrAdd()
        {
            InitializeComponent();
        }


        private void _AddNewModeOrUpdateMode()
        {
            if (_PersonID == -1)
                _Mode = enMode.AddMode;
            else if (_PersonID > 0)
                _Mode = enMode.UpdateMode;
        }

        private void _FillComboBoxWithCountries()
        {
            DataView dtCountries = clsCountry.GetAllCountries();

            foreach (DataRowView row in dtCountries)
            {
                CountryComboBox.Items.Add(row["CountryName"]);
            }

        }


        private void _OnLoad()
        {
            _AddNewModeOrUpdateMode();
            _FillComboBoxWithCountries();


            if (_Mode == enMode.AddMode)
            {
                Person = new clsPeople();
                return;
            }

            Person = clsPeople.Find(_PersonID);
          
            PersonIDLbl.Text = _PersonID.ToString();
            FirstTxtBox.Text = Person.FirstName;
            SecondTxtBox.Text = Person.SecondName;
            ThirdTxtBox.Text = Person.ThirdName;
            LastTxtBox.Text = Person.LastName;
            EmailTxtBox.Text = Person.Email;
            AddressTxtBox.Text = Person.Address;
            dateTimePicker1.Value = Person.DateOfBirth != null ? Person.DateOfBirth.Date : DateTime.MinValue;
            PhoneTxtBox.Text = Person.Phone;

           
            MaleRadioBtn.Checked = (Person.Gendor == "Male");
            FemaleRadioBtn.Checked = (Person.Gendor == "Female");
            CountryComboBox.SelectedIndex = CountryComboBox.FindString(Person.CountryName);

            NationalNoTxtBox.Text = Person.NationalNo;



        }

        private void CtrlEditOrAdd_Load(object sender, EventArgs e)
        {
            _OnLoad();

            if (_Mode == enMode.AddMode)
            {
                AddOrEditLabel.Text = "Add New Person";
            }
            else
            {
                AddOrEditLabel.Text = "Update Person";
            }
        }

        private void _CloseForm()
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Person.NationalNo = NationalNoTxtBox.Text;
            Person.FirstName = FirstTxtBox.Text;
            Person.SecondName = SecondTxtBox.Text;
            Person.ThirdName = ThirdTxtBox.Text;
            Person.LastName = LastTxtBox.Text;
            Person.Address = AddressTxtBox.Text;
            Person.Phone = PhoneTxtBox.Text;
            Person.Email = EmailTxtBox.Text;
            Person.CountryName = CountryComboBox.SelectedText;

            if (MaleRadioBtn.Checked)
                Person.Gendor = "Male";
            else if (FemaleRadioBtn.Checked)
                Person.Gendor = "Female";
            else
            {
                MessageBox.Show("Please select a gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the date string

            dateTimePicker1.MaxDate = DateTime.Now;
            Person.DateOfBirth = dateTimePicker1.Value;
            
            


            string selectedCountryName = CountryComboBox.SelectedItem.ToString();
            clsCountry SelectedCountry = clsCountry.Find(selectedCountryName);
            if (SelectedCountry != null)
            {
                Person.NationalityCountryID = SelectedCountry.NationalityCountryID;
            }
            else
            {
                MessageBox.Show("Country Object is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Person.Save())
            {
                MessageBox.Show("Done Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, Person.ID);
            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            _CloseForm();
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private void ErrorValidation(string ErrorLocation, TextBox TextBoxType, object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxType.Text))
            {
                e.Cancel = true;
                TextBoxType.Focus();
                errorProvider1.SetError(TextBoxType, $"{ErrorLocation} should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TextBoxType, "");
            }
        }

        private void FirstTxtBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidation("FirstName",FirstTxtBox, sender, e);
        }

        private void SecondTxtBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidation("SecondName", SecondTxtBox, sender, e);
        }

        private void LastTxtBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidation("LastName", LastTxtBox, sender, e);
        }

        private void NationalNoTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NationalNoTxtBox.Text))
            {
                e.Cancel = true;
                NationalNoTxtBox.Focus();
                errorProvider1.SetError(NationalNoTxtBox, $"National Number does not have a value!");
                
            }
            else if (clsPeople.IsNationalIdExist(NationalNoTxtBox.Text))
            {
                e.Cancel = true;
                NationalNoTxtBox.Focus();
                errorProvider1.SetError(NationalNoTxtBox, $"National Number already Exists!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NationalNoTxtBox, "");
            }

        }

        private void AddressTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressTxtBox.Text))
            {
                e.Cancel = true;
                AddressTxtBox.Focus();
                errorProvider1.SetError(AddressTxtBox, $"Address should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(AddressTxtBox, "");
            }
        }

        private void PhoneTxtBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorValidation("Phone Number", PhoneTxtBox, sender, e);
        }

        private void CountryComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (CountryComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(CountryComboBox.SelectedItem.ToString()))
            {
                e.Cancel = true;
                CountryComboBox.Focus();
                errorProvider1.SetError(CountryComboBox, "Please select a country!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CountryComboBox, "");
            }

        }
    }
}

