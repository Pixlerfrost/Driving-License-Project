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
    public partial class EditOrAddForm : Form
    {
        public EditOrAddForm(int PersonID)
        {
            InitializeComponent();
            ctrlEditOrAdd1._PersonID = PersonID;
            
        }


        public void SubscribeToDataBackEvent(CtrlEditOrAdd.DataBackEventHandler handler)
        {
            ctrlEditOrAdd1.DataBack += handler;
        }

        private void ctrlEditOrAdd1_Load(object sender, EventArgs e)
        {

        }

        private void EditOrAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
