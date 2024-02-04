using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessTestTypes;


namespace FullWindowsFormProject.TestTypes
{
    public partial class EditTestTypes : Form
    {
        private int _ID;
        clsTestTypes _TestType;
        public EditTestTypes(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _OnLoad()
        {

            _TestType = clsTestTypes.Find(_ID);
            TitleTxtBox.Text = _TestType.TestTypeTitle;
            DescriptionTxtBox.Text = _TestType.TestTypeDescription;
            FeesTxtBox.Text = _TestType.TestTypeFees.ToString();
            IDLbl.Text = _ID.ToString();

        }

        private void EditTestTypes_Load(object sender, EventArgs e)
        {
            _OnLoad();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeTitle = TitleTxtBox.Text;
            _TestType.TestTypeDescription = DescriptionTxtBox.Text;
            _TestType.TestTypeFees = Convert.ToDecimal(FeesTxtBox.Text);

            if (_TestType.Save())
            {
                MessageBox.Show("Test Type Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MessageBox.Show("Test Type not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
