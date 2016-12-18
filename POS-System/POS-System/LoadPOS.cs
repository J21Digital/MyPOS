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
    public partial class LoadPOS : Form
    {
        string UserWinName;
        string ProgramDirectory;
        string RecentDirectory;
        int openNewWindow = 0;

        public LoadPOS()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Set directories
            UserWinName = Environment.UserName;
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
            RecentDirectory = File.ReadAllText(ProgramDirectory + "Core.posf");
        }

        private void LoadFromInput_Click(object sender, EventArgs e)
        {
            //Retrieve input from Textbox
            string input = LoadByNameInput.Text;

            Console.WriteLine(ProgramDirectory + input);

            //Check if input is empty
            if (!(input == "" || input == "Business Name"))
            {
                //Check for directory.
                if (Directory.Exists(ProgramDirectory + input))
                {
                    //Core.posf location
                    string CoreLocation = ProgramDirectory + "Core.posf";

                    //Write new location to Core.posf
                    File.WriteAllText(CoreLocation, ProgramDirectory + input);

                    //Open POSBase
                    POSBase POSBase = new POSBase();
                    POSBase.Show();

                    this.Hide();
                }
                else
                {
                    //Notify user of invalid POS
                    MessageBox.Show("This POS doesn't exist.", "Invalid POS Name", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                //Notify user of invalid POS
                MessageBox.Show("This POS doesn't exist.", "Invalid POS Name", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void LoadPOS_Load(object sender, EventArgs e)
        {
                //Check for directory.
                if (Directory.Exists(RecentDirectory))
                {
                    //Retrieve foldername from Core.posf
                    FileInfo recentFolderNameInfo = new FileInfo(RecentDirectory);
                    string recentFolderName = recentFolderNameInfo.Name;
                    Console.WriteLine(recentFolderName);

                    //Change button text to include folder name.
                    LoadFromRecent.Text = "Load POS: " + recentFolderName;
                }
                else
                {
                    //Response if invalid directory. Debugging only.
                    Console.WriteLine("The directory provided was invalid. The provided directory was: " + RecentDirectory);
                }
        }

        private void LoadFromRecent_Click(object sender, EventArgs e)
        {
            //When clicked, open POSBase.
            POSBase POSBase = new POSBase();
            POSBase.Show();

            this.Hide();
        }

        private void LoadPOS_FormClosing(object sender, FormClosingEventArgs e)
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
