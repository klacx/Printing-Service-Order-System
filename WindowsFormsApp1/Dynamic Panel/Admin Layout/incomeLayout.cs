using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dynamic_Panel.Admin_Layout
{
    public partial class incomeLayout : UserControl
    {
        private string _productName;
        private decimal _totalAmount;
        public incomeLayout()
        {
            InitializeComponent();
        }

        private void incomeLayout_Load(object sender, EventArgs e)
        {

        }

        public string productName
        {
            get { return _productName; }
            set { _productName = value; lbl_productName.Text = value; }
        }

        public decimal totalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; lbl_totalAmount.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", value); }
        }
    }
}
