using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessApplicationTypes;

namespace FullWindowsFormProject.Applications
{
    public partial class EditApplicationTypes : Form
    {
        private int _ID;
        clsApplicationTypes _ApplicationType;
        public EditApplicationTypes(int ID)
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
            _ApplicationType = clsApplicationTypes.Find(_ID);
            TitleTxtBox.Text = _ApplicationType.ApplicationTypeTitle;
            FeesTxtBox.Text = _ApplicationType.ApplicationFees.ToString();
            IDLbl.Text = _ID.ToString();
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _ApplicationType.ApplicationTypeTitle = TitleTxtBox.Text;
            _ApplicationType.ApplicationFees = Convert.ToDecimal(FeesTxtBox.Text);

            if (_ApplicationType.Save())
            {
                MessageBox.Show("Application Type Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Was not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditApplicationTypes_Load(object sender, EventArgs e)
        {
            _OnLoad();
        }
    }
}
