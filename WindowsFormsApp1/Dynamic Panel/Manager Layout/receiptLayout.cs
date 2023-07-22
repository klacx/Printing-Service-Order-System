using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    public partial class receiptLayout : UserControl
    {
        public receiptLayout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void receiptLayout_Load(object sender, EventArgs e)
        {

        }

        private string _productName;
        private string _quantity;
        private string _totalPrice;

        public string productName
        {
            get { return _productName; }
            set { _productName = value; lbl_product.Text = value; }
        }

        public string quantity
        {
            get { return _quantity; }
            set { _quantity = value; lbl_quantity.Text = value; }
        }

        public string totalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; lbl_totalPrice.Text = value; }
        }


        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
