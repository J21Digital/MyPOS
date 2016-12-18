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
    public partial class AddItem : Form
    {
        string UserWinName = Environment.UserName;
        string ProgramDirectory;
        string RecentDirectory;
        string POSDirectory;
        string productID;
        string recentFolderName;

        public AddItem()
        {
            InitializeComponent();
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
            RecentDirectory = File.ReadAllText(ProgramDirectory + "Core.posf");
        }

        private void ConfirmAddItem_Click(object sender, EventArgs e)
        {
            //Retrieves Product ID
            productID = ProductIDInput.Text;
            string productCost = ProductCost.Text;
            float productCostFloat;

            //Set POS Directory
            POSDirectory = ProgramDirectory + recentFolderName + "\\products\\" + productID;

            if (float.TryParse(productCost, out productCostFloat))
            {
                if (!(Directory.Exists(POSDirectory)))
                {
                    Directory.CreateDirectory(POSDirectory);
                    File.WriteAllText(POSDirectory + "\\productname.pospf", ProductName.Text);
                    File.WriteAllText(POSDirectory + "\\productdesc.pospf", ProductDescription.Text);
                    File.WriteAllText(POSDirectory + "\\productcost.pospf", ProductCost.Text);

                    MessageBox.Show("Product Added.", "Product Added", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This product already exists. Please remove product to override.", "Product exists.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The product cost is invalid. Please enter another.", "Product cost invalid.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
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

        private void ProductCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
