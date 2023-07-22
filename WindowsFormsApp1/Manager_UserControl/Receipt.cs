using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Student_UserControl.Profile;
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.ServerCode;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    public partial class Receipt : UserControl
    {
        public int orderID;
        public Receipt(int order_id)
        {
            InitializeComponent();
            orderID = order_id;
            ReceipttUserControl();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public void ReceipttUserControl()
        {
            panelContainer.Controls.Clear();

            ClassBLL bll1 = new ClassBLL();
            DataTable ODT = bll1.getTableItems("_Order", " WHERE order_id ='" + orderID + "'");

            lbl_orderID.Text = orderID.ToString();
            lbl_orderDate.Text = ODT.Rows[0]["order_date"].ToString();
            lbl_totalAmount.Text = "RM " + ODT.Rows[0]["total_amount"].ToString();
            if (bool.Parse(ODT.Rows[0]["urgent"].ToString()))
            {
                lbl_urgent.Visible = true;
                lbl_charge.Visible = true;
                lbl_charge.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", "RM " + decimal.Parse(ODT.Rows[0]["total_amount"].ToString()) / 130 * 30);
            }

            ClassBLL bll2 = new ClassBLL();
            DataTable PDT = bll2.getTableItems("OrderDetails", " WHERE order_id ='" + orderID + "'");

            foreach (DataRow dr in PDT.Rows)
            {
                ClassBLL bll3 = new ClassBLL();
                DataTable PNDT = bll3.getTableItems("Product", " WHERE product_id ='" + dr["product_id"].ToString() + "'");
                receiptLayout item = new receiptLayout();

                item.productName = PNDT.Rows[0]["product_name"].ToString();
                item.quantity = dr["quantity"].ToString();

                if (item.productName == "Printing A4- Black and White")
                {
                    if (int.Parse(item.quantity) <= 99)
                    {
                        item.totalPrice = string.Format(new CultureInfo("en-MY"), "{0:C2}", "RM " + (decimal.Parse(PNDT.Rows[0]["price"].ToString()) * int.Parse(item.quantity)));

                    }
                    else
                    {
                        item.totalPrice = string.Format(new CultureInfo("en-MY"), "{0:C2}", "RM " + (decimal.Parse(PNDT.Rows[0]["special_price"].ToString()) * int.Parse(item.quantity)));
                    }
                }
                else 
                {
                    item.totalPrice = string.Format(new CultureInfo("en-MY"), "{0:C2}", "RM " + (decimal.Parse(PNDT.Rows[0]["price"].ToString()) * int.Parse(item.quantity)));
                }

                panelContainer.Controls.Add(item);
            }
        }
    }
}
