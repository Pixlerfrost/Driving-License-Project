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

namespace FullWindowsFormProject.Users.Controls
{
    public partial class CtrlShowUserInfo : UserControl
    {
        private int _PersonID;
        clsUsers _User;
        public CtrlShowUserInfo()
        {
            InitializeComponent();
        }

        public void SetData(int Data)
        {
            _PersonID = Data;
        }

        private void _OnLoad()
        {
            ctrlShowPersonDetails1.SetData(_PersonID);
            ctrlShowPersonDetails1._SetPersonData();

            if (_PersonID > 0)
            {
                _User = clsUsers.Find(_PersonID);
                UserIDLbl.Text = _User.UserID.ToString();
                UserNameLbl.Text = _User.UserName.ToString();
                if (_User.isActive)
                    IsActiveLbl.Text = "Yes";
                else
                    IsActiveLbl.Text = "No";
            }

        }
        private void ShowUserInfo_Load(object sender, EventArgs e)
        {
            _OnLoad();

        }

        
    }
}
