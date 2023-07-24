using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.ServerCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1.Student_UserControl
{
    public partial class ShoppingCart : UserControl
    {
        public string userID;
        public int cartID;
        public ShoppingCart(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        internal void ShoppingCart_Load(object sender, EventArgs e)
        {
            ProductUserControl();
        }

        public void ProductUserControl()              //show item in shopping cart
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            SqlDataAdapter CIAD = new SqlDataAdapter("SELECT cart_id FROM ShoppingCart WHERE user_id='" + userID + "'", con.connect);
            DataTable CIDT = new DataTable();
            CIDT.Clear();
            CIAD.Fill(CIDT);
            if (CIDT != null)
            {
                ClassBLL objBLL = new ClassBLL();
                DataTable dt = objBLL.getTableItems("ShoppingCartItem", " WHERE cart_id ='" + CIDT.Rows[0]["cart_id"] + "'");
                cartID = int.Parse(CIDT.Rows[0]["cart_id"].ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cartItemLayout item = new cartItemLayout();

                        item.quantity =int.Parse(row["quantity"].ToString());

                        SqlDataAdapter PAD = new SqlDataAdapter("SELECT * FROM Product  WHERE product_id = '" + row["product_id"] + "'", con.connect);
                        DataTable PDT = new DataTable();
                        PAD.Fill(PDT);

                        foreach (DataRow detail in PDT.Rows)
                        {
                            item.productName = detail["product_name"].ToString();

                            if (item.productName == "Printing A4– Black and White")
                            {
                                if (item.quantity <= 99)
                                {
                                    item.unitPrice = decimal.Parse(detail["price"].ToString());
                                }
                                else
                                {
                                    item.unitPrice = decimal.Parse(detail["special_price"].ToString());
                                }
                            }
                            else
                            {
                                item.unitPrice =  decimal.Parse(detail["price"].ToString());
                            }

                            item.totalAmount = item.unitPrice * item.quantity;

                            item.product_id = row["product_id"].ToString();

                            item.userID = userID;
                        }
                        panelContainer.Controls.Add(item);                           
                    }                   
                }
            }
            calculateTotal();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Connection con = new Connection();
            Boolean urgent = false;

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            if (urgentCheckBox.Checked)
            {
                urgent = true;
            }
            using (SqlCommand cmd = new SqlCommand("INSERT into _Order(user_id, order_date, total_amount, order_status, payment, urgent) VALUES (@user_id, @order_date, @total_amount, @order_status, @payment, @urgent)", con.connect))
            {
                cmd.Parameters.AddWithValue("@user_id", userID);
                cmd.Parameters.AddWithValue("@order_date", now);
                cmd.Parameters.AddWithValue("@total_amount", calculateTotal());
                cmd.Parameters.AddWithValue("@order_status", "pending");
                cmd.Parameters.AddWithValue("@payment", false);
                cmd.Parameters.AddWithValue("@urgent", urgent);
                cmd.ExecuteNonQuery();
            }

            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_Order", " WHERE user_id ='" + userID + "' ORDER BY order_id DESC"); 

            int order_id = int.Parse(dt.Rows[0]["order_id"].ToString());

            using (SqlCommand WAcmd = new SqlCommand("INSERT into WorkerAssignment(order_id) VALUES (@order_id)", con.connect))
            {
                WAcmd.Parameters.AddWithValue("@order_id", order_id);
                WAcmd.ExecuteNonQuery();
            }

            ClassBLL bll2 = new ClassBLL();
            DataTable cdt = bll2.getTableItems("ShoppingCartItem", " WHERE cart_id='" + cartID + "'");

            List<string> product_id = new List<string>();
            List<int> quantity = new List<int>();
            List<decimal> totalPrice = new List<decimal>();

            foreach (cartItemLayout item in panelContainer.Controls)
            {
                product_id.Add(item.product_id);
                quantity.Add(item.quantity);
                totalPrice.Add(item.totalAmount);
            }

            for (int i = 0; i< product_id.Count; i++)
            {
                using (SqlCommand ODcmd = new SqlCommand("INSERT into OrderDetails(order_id, product_id, quantity, amount) VALUES (@order_id, @product_id, @quantity, @amount)", con.connect))
                {   
                    ODcmd.Parameters.AddWithValue("@order_id", order_id);
                    ODcmd.Parameters.AddWithValue("@product_id", product_id[i]);
                    ODcmd.Parameters.AddWithValue("@quantity", quantity[i]);
                    ODcmd.Parameters.AddWithValue("@amount", totalPrice[i]);
                    ODcmd.ExecuteNonQuery();
                }
            }

            using (SqlCommand Dcmd = new SqlCommand("DELETE FROM ShoppingCartItem WHERE cart_id='" + cartID + "'", con.connect)) 
            {
                Dcmd.ExecuteNonQuery();
            }

            ProductUserControl();
        }

        public decimal calculateTotal() 
        {
            decimal totalAmount = 0;
            foreach (cartItemLayout item in panelContainer.Controls)
            {
                totalAmount += item.totalAmount;
            }
            if (urgentCheckBox.Checked)
            {
                totalAmount += (totalAmount / 100 * 30);
            }
            lbl_total.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", totalAmount);
            return totalAmount;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void urgentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
    }
}
