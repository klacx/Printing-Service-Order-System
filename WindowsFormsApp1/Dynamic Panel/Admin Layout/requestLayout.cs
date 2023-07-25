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
    public partial class requestLayout : UserControl
    {
        private string _productName;
        private int _requestAmount;
        public requestLayout()
        {
            InitializeComponent();
        }

        private void requestLayout_Load(object sender, EventArgs e)
        {

        }

        public string productName
        {
            get { return _productName; }
            set { _productName = value; lbl_productName.Text = value; }
        }

        public int requestAmount
        {
            get { return _requestAmount; }
            set { _requestAmount = value; lbl_requestAmount.Text = value.ToString(); }
        }
    }
}
