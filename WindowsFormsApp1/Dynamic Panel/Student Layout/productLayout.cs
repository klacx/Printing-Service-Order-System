using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Dynamic_Panel.Product_Page
{
    public partial class productLayout : UserControl
    {
        public string userID;
        public int cartID;
        public productLayout(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void productLayout_Load(object sender, EventArgs e)
        {

        }

        private Image _icon;
        private string _title;
        private string _price;
        private string _specialPrice;
        private string _product_id;

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

        public string product_id
        {
            get { return _product_id.ToString(); }
            set { _product_id = value;  }
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            addItemToCart();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        public void addItemToCart()
        {
            ClassBLL objBLL = new ClassBLL();

            DataTable dt = objBLL.getTableItems("ShoppingCart", " WHERE user_id='" + userID + "'");

            Connection con = new Connection();

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                SqlCommand SCcmd = new SqlCommand("INSERT into ShoppingCart(user_id) VALUES ('" + userID + "')", con.connect);
                SCcmd.ExecuteNonQuery();
            }

            DataTable iddt = objBLL.getTableItems("ShoppingCart", " WHERE user_id='" + userID + "'");
            cartID = int.Parse(iddt.Rows[0]["cart_id"].ToString());

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ShoppingCartItem WHERE cart_id='" + cartID +"' and product_id='" + product_id +"'", con.connect);
            DataTable cart = new DataTable();
            adapter.Fill(cart);

            if (cart.Rows.Count > 0)
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE ShoppingCartItem SET quantity = @quantity WHERE product_id = @product_id", con.connect))
                {
                    int quantity = int.Parse(cart.Rows[0]["quantity"].ToString());
                    quantity += 1;
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            { 
               using (SqlCommand cmd = new SqlCommand("INSERT into ShoppingCartItem(cart_id, product_id, quantity) VALUES (@cart_id,@product_id,1)", con.connect))
               {
                    cmd.Parameters.AddWithValue("@cart_id", cartID);
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
