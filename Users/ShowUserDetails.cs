using BuisnessUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject.Users
{
    public partial class ShowUserDetails : Form
    {

        
        public ShowUserDetails(int PersonID)
        {
            InitializeComponent();
            ctrlShowUserInfo1.SetData(PersonID);
        }

        private void ShowUserDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
