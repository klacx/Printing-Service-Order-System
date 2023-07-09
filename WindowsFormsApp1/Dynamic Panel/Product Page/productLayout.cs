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
    public partial class productLayout : UserControl
    {
        public productLayout()
        {
            InitializeComponent();
        }

        private void productLayout_Load(object sender, EventArgs e)
        {

        }

        private Image _icon;
        private string _title;
        private string _price;
        private string _specialPrice;

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_icon.Image = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_title.Text = value; }
        }

        public string Price
        { 
            get { return _price.ToString(); } 
            set { _price = value; lbl_price.Text = value.ToString(); } 
        }

        public string SpecialPrice
        {
            get { return _specialPrice.ToString(); }
            set { _specialPrice = value; lbl_specialPrice.Text = value.ToString(); }
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Title);
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
