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

namespace POS_System.EditProduct
{
    public partial class RemoveItem : Form
    {
        string UserWinName = Environment.UserName;
        string ProgramDirectory;
        string RecentDirectory;
        string POSDirectory;
        string recentFolderName;

        public RemoveItem()
        {
            InitializeComponent();
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
            RecentDirectory = File.ReadAllText(ProgramDirectory + "Core.posf");
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            //Checks for valid directory. Debugging only.
            if (Directory.Exists(RecentDirectory))
            {
                //Retrieves name of POS folder.
                FileInfo recentFolderNameInfo = new FileInfo(RecentDirectory);
                recentFolderName = recentFolderNameInfo.Name;
                Console.WriteLine(recentFolderName);

                //Locates POS Folder.

                POSDirectory = ProgramDirectory + recentFolderName + "\\products\\";

            }
        }

        private void ConfirmRemoveItem_Click(object sender, EventArgs e)
        {
            POSDirectory = ProgramDirectory + recentFolderName + "\\products\\" + ProductIDInput.Text;

            if (Directory.Exists(POSDirectory))
            {
                if (MessageBox.Show("Do you really want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Directory.Delete(POSDirectory, true);
                }
                else
                {
                    MessageBox.Show("The product was not removed.", "Product Removal Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Product ID Was Invalid.", "Product Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
