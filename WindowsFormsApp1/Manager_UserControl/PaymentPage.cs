using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dynamic_Panel.Manager_Layout;
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.ServerCode;
using static WindowsFormsApp1.Student_UserControl.Profile;

namespace WindowsFormsApp1.Manager_UserControl
{
    public partial class PaymentPage : UserControl
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            PaymentUserControl();
        }

        private void PaymentUserControl()
        {
            panelContainer.Controls.Clear();
            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_Order", (" WHERE payment = 'false'"));

            if (dt.Rows.Count > 0)
            {
               paymentLayout[] itemList = new paymentLayout[dt.Rows.Count];

                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        itemList[i] = new paymentLayout();

                        itemList[i].orderId = row["order_id"].ToString();
                        itemList[i].totalAmount = "RM " + row["total_amount"].ToString();
                        itemList[i].orderDate = row["order_date"].ToString();
                        itemList[i].urgent = bool.Parse(row["urgent"].ToString());

                        Connection con = new Connection();
                        SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM OrderDetails  WHERE order_id = '" + itemList[i].orderId + "'", con.connect);
                        DataTable ODT = new DataTable();
                        SDA.Fill(ODT);
                        foreach (DataRow detail in ODT.Rows)
                        {
                            SqlDataAdapter Name = new SqlDataAdapter("SELECT product_name FROM Product  WHERE product_id = '" + detail["product_id"] + "'", con.connect);
                            DataTable NDT = new DataTable();
                            Name.Fill(NDT);
                            foreach (DataRow name in NDT.Rows)
                            {
                                string productName = name["product_name"].ToString();
                                itemList[i].orderDetails = itemList[i].orderDetails + productName + " * " + detail["quantity"] + "\n";
                                itemList[i].Height += 15;
                            }
                        }

                        panelContainer.Controls.Add(itemList[i]);

                    }
                }
            }

        }
    }
}
