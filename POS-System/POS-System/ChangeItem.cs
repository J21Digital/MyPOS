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
    public partial class ChangeItem : Form
    {
        string UserWinName = Environment.UserName;
        string ProgramDirectory;
        string RecentDirectory;
        string POSDirectory;
        string productID;
        string recentFolderName;

        public ChangeItem()
        {
            InitializeComponent();
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
            RecentDirectory = File.ReadAllText(ProgramDirectory + "Core.posf");
        }

        private void ConfirmChangeItem_Click(object sender, EventArgs e)
        {
            //Retrieves Product ID
            productID = ProductIDInput.Text;

            //Set POS Directory
            POSDirectory = ProgramDirectory + recentFolderName + "\\products\\" + productID;

            Console.WriteLine(POSDirectory);

            if (!(Directory.Exists(POSDirectory)))
            {
                MessageBox.Show("This product does not exist.", "Product doesn't exist", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                File.WriteAllText(POSDirectory + "\\productdesc.pospf", ProductDescription.Text);
                File.WriteAllText(POSDirectory + "\\productcost.pospf", ProductCost.Text);

                MessageBox.Show("Product has been updated.", "Product Updated.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void ChangeItem_Load(object sender, EventArgs e)
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
            else
            {
                Console.WriteLine("The directory provided was invalid. The provided directory was: " + RecentDirectory);
            }
        }
    }
}
