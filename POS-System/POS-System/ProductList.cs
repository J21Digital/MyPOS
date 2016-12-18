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
    public partial class ProductList : Form
    {
        string UserWinName = Environment.UserName;
        string ProgramDirectory;
        string RecentDirectory;
        string recentFolderName;
        string POSDirectory;

        public ProductList()
        {
            InitializeComponent();


            //Reads Core.posf file in directory
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
            RecentDirectory = File.ReadAllText(ProgramDirectory + "Core.posf");

            ProductName.Text = "";
            ProductID.Text = "";
            Cost.Text = "";
        }

        private void ProductList_Load(object sender, EventArgs e)
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

            FindInformation();
        }

        private void FindInformation()
        {
            //Retrieving and displaying product IDS

            //Gets product IDs from directory
            string[] productsByID = Directory.GetDirectories(POSDirectory);
            string[] productsByIDShort;
            Console.WriteLine(string.Join("", productsByID));

            //Joins product IDs to string
            string productsByIDString = String.Join(",", productsByID);

            //Replaces POSDirectory in string with blank
            productsByIDString = productsByIDString.Replace(POSDirectory, "");

            //Splits string back into array, and displays
            productsByIDShort = productsByIDString.Split(',').Select(str => str.Trim()).ToArray();
            ProductID.Lines = productsByIDShort;

            //Retrieving Product Name from directory
            int noOfProductID = -1;
            string currentProductSearch;

            while(!(noOfProductID == (productsByID.Length-1)))
            {
                currentProductSearch = productsByID[noOfProductID + 1];
                string currentProductName = File.ReadAllText(currentProductSearch + "\\productname.pospf");
                string currentProductCost = File.ReadAllText(currentProductSearch + "\\productcost.pospf");
                if (!(noOfProductID == -1))
                {
                    Cost.Text = Cost.Text + "\n" + currentProductCost;
                    ProductName.Text = ProductName.Text + "\n" + currentProductName;
                }
                else
                {
                    Cost.Text = Cost.Text + currentProductCost;
                    ProductName.Text = ProductName.Text + currentProductName;
                }

                noOfProductID = noOfProductID + 1;
            }
            

        }

   
    }
}
