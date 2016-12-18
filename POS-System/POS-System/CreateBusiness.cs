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
    public partial class CreateBusiness : Form
    {
        //Finds Windows Username
        string UserWinName = Environment.UserName;

        string BusinessName;
        string NewDirectory;
        public static string POSCoreDirectory;
        string saveLocation;
        int openNewWindow = 0;

        public CreateBusiness()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Location to write files.
            saveLocation = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
        }

        private void companyTitleBox_textChanged(object sender, EventArgs e)
        {
            //Set BusinessName to input text.
            BusinessName = companyTitleBox.Text;

            //Set NewDirectory to new POS save location
            NewDirectory = saveLocation + BusinessName;

        }

        private void createPOS_Click(object sender, EventArgs e)
        {
            //Check if BusinessName is valid.
            if (BusinessName == "" || BusinessName == "Business Name")
            {
                //Returns message to user if invalid business name
                MessageBox.Show("This name is invalid.", "Invalid Business Name", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            else
            {
                //Check for invalid POS name. Debugging only.
                try
                {
                    //Checks for existing directory.
                    if (!Directory.Exists(NewDirectory))
                    {
                        //Writes new directory and notifies user.
                        Directory.CreateDirectory(NewDirectory);
                        Console.WriteLine("The directory " + NewDirectory + " has been created.");
                        string MessageBoxMessage = "The POS at directory " + NewDirectory + " has been created.";
                        MessageBox.Show(MessageBoxMessage, "POS Created", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        //Location of Core.posf file in directory.
                        POSCoreDirectory = NewDirectory.Replace(BusinessName, "") + "Core.posf";

                        //If file exists, delete it.
                        if (File.Exists(POSCoreDirectory))
                        {
                            File.Delete(POSCoreDirectory);
                        }

                        //Write to file location of new directory, for use by other scripts.
                        File.WriteAllText(POSCoreDirectory, NewDirectory, Encoding.UTF8);

                        Console.WriteLine(POSCoreDirectory);
                        Console.WriteLine("The File " + POSCoreDirectory + " has been created.");

                        POSBase POSBase = new POSBase();
                        POSBase.Show();
                        this.Hide();

                    }

                    else
                    {
                        //Tell user if directory exists.
                        MessageBox.Show("This POS Already Exists.", "POS Exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                }
                catch
                {
                    MessageBox.Show("This POS name is invalid. Please try again.", "Invalid POS name", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void CreateBusiness_FormClosing(object sender, FormClosingEventArgs e)
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
