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
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            EditProduct.AddItem AddItem = new EditProduct.AddItem();
            AddItem.Show();
            this.Hide();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            EditProduct.RemoveItem RemoveItem = new EditProduct.RemoveItem();
            RemoveItem.Show();
            this.Hide();
        }

        private void ChangeProduct_Click(object sender, EventArgs e)
        {
            ChangeItem ChangeItem = new ChangeItem();
            ChangeItem.Show();
            this.Hide();
        }
    }
}
