using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dynamic_Panel.Product_Page
{
    public partial class cartItemLayout : UserControl
    {
        public cartItemLayout()
        {
            InitializeComponent();
        }

        private void cartItemLayout_Load(object sender, EventArgs e)
        {

        }

        private string _productName;
        private string _unitPrice;
        private string _quantity;
        private string _totalAmount;

        public string productName
        {
            get { return _productName; }
            set { _productName = value; lbl_productName.Text = value; }
        }

        public string unitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; lbl_unitPrice.Text = value; }
        }

        public string quantity
        {
            get { return _quantity; }
            set { _quantity = value; quantityTextBox.Text = value; }
        }

        public string totalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; lbl_totalAmount.Text = value; }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void reduceBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
