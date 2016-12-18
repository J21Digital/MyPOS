using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.EditProduct
{
    public partial class NumberOfProducts : Form
    {
        string NoOfProduct;
        bool ForceClose = false;

        public NumberOfProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoOfProduct = ProductNumber.Text;

            if (ProductNo == "")
            {
                ForceClose = true;
            }


        }

        public string ProductNo {
            get
            {
                this.Hide();
                return NoOfProduct;
            }
        }

        public bool ForcedClose
        {
            get
            {
                return ForceClose;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 1 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "1"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 2 as a string to the end.
            
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "2"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 3 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "3"; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 4 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "4"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 5 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "5"; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 6 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "6"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 7 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "7"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 8 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "8"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 9 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "9"; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and add 0 as a string to the end.
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = NoOfProduct + "0"; 
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Get ID Input Box Text, and remove 1 from the end
            NoOfProduct = ProductNumber.Text;
            ProductNumber.Text = ProductNumber.Text.Remove(ProductNumber.Text.Length - 1);
        }

        private void NumberOfProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NoOfProduct == null)
            {
                ForceClose = true;
            }
        }
    }
}
