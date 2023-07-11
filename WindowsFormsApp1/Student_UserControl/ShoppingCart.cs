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

namespace WindowsFormsApp1.Student_UserControl
{
    public partial class ShoppingCart : UserControl
    {
        public string userID;
        public decimal unitPrice;
        public decimal totalAmount;
        public ShoppingCart(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            ProductUserControl();
        }

        public void ProductUserControl()
        {   
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            SqlDataAdapter CIAD = new SqlDataAdapter("SELECT cart_id FROM ShoppingCart WHERE user_id='" + userID + "'", con.connect);
            DataTable CIDT = new DataTable();
            CIAD.Fill(CIDT);

            if (CIDT != null)
            {
                ClassBLL objBLL = new ClassBLL();
                DataTable dt = objBLL.getTableItems("ShoppingCartItem", " WHERE cart_id ='" + CIDT.Rows[0]["cart_id"] + "'");

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        cartItemLayout[] itemList = new cartItemLayout[dt.Rows.Count];

                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                itemList[i] = new cartItemLayout();

                                itemList[i].quantity = row["quantity"].ToString();

                                SqlDataAdapter PAD = new SqlDataAdapter("SELECT * FROM Product  WHERE product_id = '" + row["product_id"] + "'", con.connect);
                                DataTable PDT = new DataTable();
                                PAD.Fill(PDT);

                                foreach (DataRow detail in PDT.Rows)
                                {
                                    itemList[i].productName = detail["product_name"].ToString();

                                    if (itemList[i].productName == "Printing A4– Black and White")
                                    {
                                        if (int.Parse(itemList[i].quantity) <= 99)
                                        {
                                            itemList[i].unitPrice = "RM " + detail["price"];
                                            unitPrice = decimal.Parse(detail["price"].ToString());
                                        }
                                        else
                                        {
                                            itemList[i].unitPrice = "RM " + detail["special_price"];
                                            unitPrice = decimal.Parse(detail["special_price"].ToString());
                                        }
                                    }
                                    else
                                    {
                                        itemList[i].unitPrice = "RM " + detail["price"];
                                        unitPrice = decimal.Parse(detail["price"].ToString());
                                    }

                                    decimal unitTotalAmount = unitPrice * int.Parse(itemList[i].quantity);
                                    itemList[i].totalAmount = string.Format(new CultureInfo("en-MY"), "{0:C2}", unitTotalAmount);

                                    totalAmount += unitTotalAmount;
                                }

                                panelContainer.Controls.Add(itemList[i]);
                                lbl_totalAmount.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", totalAmount);
                            }
                        }
                    }


                }
            }
            
        }
    }
}
