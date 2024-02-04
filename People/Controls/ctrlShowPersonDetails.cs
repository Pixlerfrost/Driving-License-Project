using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;

namespace FullWindowsFormProject
{
    public partial class ctrlShowPersonDetails : UserControl
    {
        public int _PersonID = -1;
        public clsPeople _Person;
        public ctrlShowPersonDetails()
        {
            InitializeComponent();
            
        }

        public void SetData(int Data)
        {
            _PersonID = Data;
        }

        public void _SetPersonData()
        {
            _Person = clsPeople.Find(_PersonID);
            if (_Person != null)
            {
                PersonID_Lbl.Text = _PersonID.ToString();
                Name_Lbl.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
                NationalNo_Lbl.Text = _Person.NationalNo;
                Gender_Lbl.Text = _Person.Gendor;
                Email_Lbl.Text = _Person.Email;
                Address_Lbl.Text = _Person.Address;
                DateOfBirth_Lbl.Text = _Person.DateOfBirth != null ? _Person.DateOfBirth.Date.ToString("yyyy-MM-dd") : "N/A";
                Phone_Lbl.Text = _Person.Phone;
                Country_Lbl.Text = _Person.CountryName;
            }
        }
        public bool IsPersonExist()
        {
            if (PersonID_Lbl.Text == "???")
                return false;
            else 
                return true;
        }

        public void _ClearData()
        {
            PersonID_Lbl.Text = "???";
            Name_Lbl.Text = "???";
            NationalNo_Lbl.Text = "???";
            Gender_Lbl.Text = "???";
            Email_Lbl.Text = "???";
            Address_Lbl.Text = "???";
            DateOfBirth_Lbl.Text = "???";
            Phone_Lbl.Text = "???";
            Country_Lbl.Text = "???";
        }

        private void ctrlShowPersonDetails_Load(object sender, EventArgs e)
        {
            _SetPersonData();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditOrAddForm AddOrEditFrm = new EditOrAddForm(_PersonID);
            
            AddOrEditFrm.ShowDialog();

            _SetPersonData();
        }

       
    }
}
