using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class HelpMenuPOS : Form
    {
        public HelpMenuPOS()
        {
            InitializeComponent();
        }

        private void ChangeLogo_Click(object sender, EventArgs e)
        {
            //Show user help on changing logo on button click.
            MessageBox.Show("1) Locate the POS file at \"C:\\Users\\YourName\\AppData\\Roaming\\POS\\YourBusinessName\".        2) Add your logo file to folder, and rename \"logo.png\". Max image size: 200x100px "
                , "Changing Logo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
