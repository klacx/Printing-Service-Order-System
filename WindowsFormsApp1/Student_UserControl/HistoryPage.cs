using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Student_UserControl
{
    public partial class HistoryPage : UserControl
    {
        public string userID;
        public HistoryPage(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void HistoryPage_Load(object sender, EventArgs e)
        {
            HistoryUserControl();
        }

        public void HistoryUserControl()
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_Order", (" WHERE user_id ='" + userID + "'"));
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                        foreach (DataRow row in dt.Rows)
                        {
                            studentHistoryLayout item = new studentHistoryLayout();

                            item.orderId = row["order_id"].ToString();
                            item.totalAmount = "RM " + row["total_amount"].ToString();
                            item.orderDate = row["order_date"].ToString();
                            item.orderStatus = row["order_status"].ToString();
                            item.urgent = bool.Parse(row["urgent"].ToString());



                            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM OrderDetails  WHERE order_id = '" + item.orderId + "'", con.connect);
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
                                    item.orderDetails = item.orderDetails + productName + " * " + detail["quantity"] + "\n";
                                    item.Height += 15;
                                }
                            }
                            panelContainer.Controls.Add(item);
                        }
                    
                }
            }
        }
    }
}
