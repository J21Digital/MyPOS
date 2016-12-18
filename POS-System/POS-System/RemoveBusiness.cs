using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POS_System
{
    public partial class RemoveBusiness : Form
    {
        string UserWinName;
        string ProgramDirectory;
        int openNewWindow = 0;

        public RemoveBusiness()
        {
            InitializeComponent();

            //SetDirectories
            UserWinName = Environment.UserName;
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";

            RemoveFromInput.Enabled = false;
        }

        private void RemoveFromInput_Click(object sender, EventArgs e)
        {
            string input = RemoveByInput.Text;

            if (MessageBox.Show("Are you sure you wish to delete " + input + "?", "Wish to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Directory.Delete(ProgramDirectory + input, true);
                MessageBox.Show("Business was deleted.", "Business deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Business was not deleted.", "Business not deleted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void RemoveByInput_TextChanged(object sender, EventArgs e)
        {
            //Retrieve input from Textbox
            string input = RemoveByInput.Text;

            //Check if input is empty
            if (!(input == "" || input == "Business Name"))
            {
                //Check for directory.
                if (Directory.Exists(ProgramDirectory + input))
                {
                    RemoveFromInput.Enabled = true;
                }
                else
                {
                    RemoveFromInput.Enabled = false;
                }
            }
            else
            {
                RemoveFromInput.Enabled = false;
            }
        }

        private void RemoveBusiness_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Relaunches Setup Screen on close
            openNewWindow = openNewWindow + 1;

            if (openNewWindow == 1)
            {
                StartupMenu StartupMenu = new StartupMenu();
                StartupMenu.Show();

                this.Close();
            }
        }
    }
}
