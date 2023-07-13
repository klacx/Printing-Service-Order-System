using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Student_UserControl.Profile;
using WindowsFormsApp1.ServerCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.SqlClient;
using WindowsFormsApp1.Student_UserControl;
using System.Windows;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Documents.DocumentStructures;
using System.Diagnostics;
using System.Xml.Linq;
using System.Globalization;

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
        private string _product_id;
        private string _user_id;

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

        public string product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        public string userID
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        private void DecreaseBtn_Click(object sender, EventArgs e)
        {
            int QuantityText = int.Parse(quantityTextBox.Text);
            QuantityText -= 1;
            quantityTextBox.Text = QuantityText.ToString();
            addCartItem(product_id, int.Parse(quantityTextBox.Text));
        }
        public void addCartItem(string product_id, int quantity)
        {
            Connection con = new Connection();

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE ShoppingCartItem SET quantity = @quantity WHERE product_id = @product_id", con.connect))
            {
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
                Refresh();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int QuantityText = int.Parse(quantityTextBox.Text);
            QuantityText += 1;
            quantityTextBox.Text = QuantityText.ToString();
            addCartItem(product_id, int.Parse(quantityTextBox.Text));
        }

        private void quantityTextBox_LossFocus(object sender, EventArgs e)
        {
            addCartItem(product_id, int.Parse(quantityTextBox.Text));
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            using (SqlCommand cmd = new SqlCommand("DELETE FROM ShoppingCartItem WHERE product_id= @product_id", con.connect))
            {
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
            }
            Refresh();
        }

        public void Refresh() 
        {
            int Quantity = 0;
            decimal Price = 0;
            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("ShoppingCartItem", (" WHERE product_id ='" + product_id + "'"));

            if (dt.Rows.Count < 1) 
            {
                this.Parent.Controls.Remove(this);
            }
            else 
            {
                foreach (DataRow row in dt.Rows)
                {
                    Quantity = int.Parse(row["quantity"].ToString());
                    quantityTextBox.Text = row["quantity"].ToString();
                }
                ClassBLL bll2 = new ClassBLL();
                DataTable PDT = bll2.getTableItems("Product", " WHERE product_id ='" + product_id + "'");
                foreach (DataRow detail in PDT.Rows)
                {
                    lbl_productName.Text = detail["product_name"].ToString();
                    if (lbl_productName.Text == "Printing A4– Black and White")
                    {
                        if (Quantity <= 99)
                        {
                            lbl_unitPrice.Text = "RM " + detail["price"];
                            Price = decimal.Parse(detail["price"].ToString());
                        }
                        else
                        {
                            lbl_unitPrice.Text = "RM " + detail["special_price"].ToString();
                            Price = decimal.Parse(detail["special_price"].ToString());
                        }
                    }
                    else
                    {
                        lbl_unitPrice.Text = "RM " + detail["price"].ToString();
                        Price = decimal.Parse(detail["price"].ToString());
                    }
                    decimal unitTotalAmount = Price * Quantity;
                    lbl_totalAmount.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", unitTotalAmount);
                    
                }
            }
        }

        private void lbl_unitPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
