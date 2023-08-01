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
        private string _productName;
        private decimal _unitPrice;
        private int _quantity;
        private decimal _totalAmount;
        private string _product_id;
        private string _user_id;
        public event EventHandler controlRefreshed;

        public cartItemLayout()
        {
            InitializeComponent();
        }

        private void cartItemLayout_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        public string productName
        {
            get { return _productName; }
            set { _productName = value; lbl_productName.Text = value; }
        }

        public decimal unitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; lbl_unitPrice.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", value); }

        }

        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; quantityTextBox.Text = value.ToString(); }
        }

        public decimal totalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; lbl_totalAmount.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", value); }
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
            quantity -= 1;
            addCartItem(product_id, int.Parse(quantityTextBox.Text));
            RefreshControl();
            controlRefreshed?.Invoke(this, EventArgs.Empty);                 //<<< we invoke the parent's event here
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
                RefreshControl();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            quantity += 1;
            addCartItem(product_id, quantity);
            RefreshControl();
            controlRefreshed?.Invoke(this, EventArgs.Empty);                //<<< we invoke the parent's event here
        }

        private void quantityTextBox_LossFocus(object sender, EventArgs e)
        {
            checkQuantityTextBox();
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
            RefreshControl();

            this.Parent.Controls.Remove(this);
            controlRefreshed?.Invoke(this, EventArgs.Empty);                 //<<< we invoke the parent's event here

        }

        public void RefreshControl() 
        {
            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("ShoppingCartItem", (" WHERE product_id ='" + product_id + "'"));

            if (dt.Rows.Count < 1) 
            {
                lbl_totalAmount.Text = "RM0.00";
            }
            else 
            {
                foreach (DataRow row in dt.Rows)
                {
                    quantity = int.Parse(row["quantity"].ToString());
                }
                ClassBLL bll2 = new ClassBLL();
                DataTable PDT = bll2.getTableItems("Product", " WHERE product_id ='" + product_id + "'");
                foreach (DataRow detail in PDT.Rows)
                {
                    productName = detail["product_name"].ToString();
                    if (productName == "Printing A4- Black and White")
                    {
                        if (quantity <= 99)
                        {
                            unitPrice =  decimal.Parse(detail["price"].ToString());
                        }
                        else
                        {
                            unitPrice = decimal.Parse(detail["special_price"].ToString());
                        }
                    }
                    else
                    {
                        unitPrice = decimal.Parse(detail["price"].ToString());
                    }
                    totalAmount = unitPrice * quantity;     
                }
            }

            if (int.Parse(quantityTextBox.Text) < 1)
            { DecreaseBtn.Enabled = false; }
            else
            { DecreaseBtn.Enabled = true; }
            if (int.Parse(quantityTextBox.Text) < 2000)
            { addBtn.Enabled = true; }
            else
            { addBtn.Enabled = false; }
        }

        private void cartItemLayout_Click(object sender, EventArgs e)
        {
            checkQuantityTextBox();
        }

        public void checkQuantityTextBox()
        {
            bool check = quantityTextBox.Text.Any(c => !char.IsDigit(c));
            if (quantityTextBox.Text.Length > 0 && !check && int.Parse(quantityTextBox.Text)<2001)
            {
                quantity = int.Parse(quantityTextBox.Text);
                addCartItem(product_id, quantity);
            }
            else
            {   
                if(check)
                {
                    quantityTextBox.Text = "0";
                }
                else
                {
                    if (int.Parse(quantityTextBox.Text) > 2000)
                    {
                        quantityTextBox.Text = "2000";
                        System.Windows.MessageBox.Show("Maximun quantity of an item for an order is 2000\nPlease contact staff for more information ");
                    }
                    else
                    {
                        quantityTextBox.Text = "0";
                    }
                }
              
            }

            RefreshControl();
            controlRefreshed?.Invoke(this, EventArgs.Empty);
        }

        private void quantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            checkQuantityTextBox();
        }
    }
}
