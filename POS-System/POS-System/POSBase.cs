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
    public partial class POSBase : Form
    {
        int openNewWindow = 0;
        int OrderNo = 00;

        string UserWinName = Environment.UserName;
        string ProgramDirectory;
        string RecentDirectory;
        string LogoLocation;
        string IDInput;
        string POSFolder;

        float totalCost = 0.0f;

        public POSBase()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Reads Core.posf file in directory
            ProgramDirectory = "C:\\Users\\" + UserWinName + "\\AppData\\Roaming\\POS\\";
            RecentDirectory = File.ReadAllText(ProgramDirectory + "Core.posf");
        }

        private void POSBase_FormClosing(object sender, FormClosingEventArgs e)
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

        private void POSBase_Load(object sender, EventArgs e)
        {
            TotCost.Text = "0.00";

            //Checks for valid directory. Debugging only.
            if (Directory.Exists(RecentDirectory))
            {
                //Retrieves name of POS folder.
                FileInfo recentFolderNameInfo = new FileInfo(RecentDirectory);
                POSFolder = recentFolderNameInfo.Name;
                Console.WriteLine(POSFolder);
                BusinessNameText.Text = POSFolder;

                //Location of logo.png in folder.
                LogoLocation = ProgramDirectory + POSFolder + "\\logo.png";

                //Determines if logo file exists
                if (File.Exists(LogoLocation))
                {
                    BusinessNameText.Hide();
                    LogoBox.ImageLocation = LogoLocation;
                    Console.WriteLine("File Exists");
                }
                else
                {
                    Console.WriteLine(LogoLocation);
                    LogoBox.Hide();
                }
            }
            else
            {
                Console.WriteLine("The directory provided was invalid. The provided directory was: " + RecentDirectory);
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            //Activates HelpMenuPOS on button click.
            HelpMenuPOS HelpMenu = new HelpMenuPOS();
            HelpMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 1 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "1"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 2 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "2"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 3 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "3"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 4 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "4"; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 5 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "5"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 6 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "6"; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 7 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "7"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 8 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "8"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 9 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "9"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 0 as a string to the end.
            IDInput = ProductIDInput.Text;
            ProductIDInput.Text = IDInput + "0"; 
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and remove 1 from the end if IDInput is not empty.
            IDInput = ProductIDInput.Text;
            if(!(IDInput == "")){
                ProductIDInput.Text = ProductIDInput.Text.Remove(ProductIDInput.Text.Length - 1);
            }
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            EditProducts EditProducts = new EditProducts();
            EditProducts.Show();
        }

        private void ConfirmID_Click(object sender, EventArgs e)
        {
            string IDInput = ProductIDInput.Text;
            string IDLocation = ProgramDirectory + POSFolder + "\\products\\" + IDInput;

            Console.WriteLine(IDLocation);

            if (!(IDInput == ""))
            {
                if (Directory.Exists(IDLocation))
                {
                    POS_System.EditProduct.NumberOfProducts NumberOfProducts = new POS_System.EditProduct.NumberOfProducts();
                    NumberOfProducts.ShowDialog();
                    string NumberOfProduct = NumberOfProducts.ProductNo;

                    if (!(NumberOfProducts.ForcedClose == true))
                    {
                        //Finds file name and cost for use.
                        string InvoiceProductName = File.ReadAllText(IDLocation + "\\productname.pospf");
                        string InvoiceProductCost = File.ReadAllText(IDLocation + "\\productcost.pospf");

                        //Writes info to screen.
                        Quantity.Text = Quantity.Text + "\n" + NumberOfProduct;
                        if (!(InvoiceProductName == ""))
                        {
                            ProductName.Text = ProductName.Text + "\n" + InvoiceProductName;
                        }
                        else
                        {
                            ProductName.Text = "\n" + "*Unknown Product Name*";
                        }

                        //Converts Number of Product to int.
                        int ProductNumberInt;
                        Int32.TryParse(NumberOfProduct, out ProductNumberInt);

                        //Calculates cost of items
                        float cost = Convert.ToSingle(InvoiceProductCost) * ProductNumberInt;
                        Cost.Text = Cost.Text + "\n" + cost;

                        //Changes order number. Currently without a function.
                        OrderNo = OrderNo + 01;
                        OrderNumber.Text = OrderNumber.Text + "\n" + (OrderNo).ToString();

                        //Calculates total cost.
                        totalCost = totalCost + cost;
                        TotCost.Text = totalCost.ToString();
                        

                    }

                    ProductIDInput.Text = "";

                }
                else
                {
                    MessageBox.Show("This ID Is Invalid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This ID Is Invalid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ShowProductList_Click(object sender, EventArgs e)
        {
            ProductList ProductList = new ProductList();
            ProductList.Show();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to close this order?", "Closing order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OrderNumber.Text = "";
                Cost.Text = "";
                TotCost.Text = "";
                ProductIDInput.Text = "";
                Quantity.Text = "";
                ProductName.Text = "";

            }
        }

    }

}
