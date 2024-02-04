using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullWindowsFormProject
{
    public partial class ShowPersonDetails : Form
    {
        public int _PersonID = -1;
        
        public ShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            
            ctrlShowPersonDetails1.SetData(_PersonID);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
