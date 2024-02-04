using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;


namespace FullWindowsFormProject.Users.Controls
{
    public partial class SearchPerson : UserControl
    {
        public SearchPerson()
        {
            InitializeComponent();
        }

        public clsPeople _Person { get; set; }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedItem.ToString() == "PersonID")
                _Person = clsPeople.Find(Convert.ToInt32(FilterTextBox.Text));
            else if (FilterComboBox.SelectedItem.ToString() == "NationalNo")
                _Person = clsPeople.Find(FilterTextBox.Text);

            if (_Person != null)
            {
                ctrlShowPersonDetails1.SetData(_Person.ID);
                ctrlShowPersonDetails1._SetPersonData();
            }
            else
                MessageBox.Show("Person Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SendId(object sender, int PersonID)
        {
            _Person = clsPeople.Find(PersonID);
            ctrlShowPersonDetails1.SetData(_Person.ID);
            ctrlShowPersonDetails1._SetPersonData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditOrAddForm frm = new EditOrAddForm(-1);
            frm.SubscribeToDataBackEvent(SendId);
            frm.ShowDialog();
        }

        public bool IsPersonDataFull()
        {
            if (ctrlShowPersonDetails1.IsPersonExist())
                return true;
            else
                return false;
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedItem.ToString() == "None")
            {
                FilterTextBox.Enabled = false;
                FilterTextBox.Clear();
                ctrlShowPersonDetails1._ClearData();
            }
            else
                FilterTextBox.Enabled = true;
        }

        private void SearchPerson_Load(object sender, EventArgs e)
        {
            FilterTextBox.Enabled = false;
        }
    }
}
