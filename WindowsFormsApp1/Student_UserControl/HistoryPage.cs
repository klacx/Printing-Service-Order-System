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
            ProductUserControl();
        }

        public void ProductUserControl()
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_Order", (" WHERE user_id ='" + userID + "'"));
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    studentHistoryLayout[] itemList = new studentHistoryLayout[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            itemList[i] = new studentHistoryLayout();

                            itemList[i].orderId = row["order_id"].ToString();
                            itemList[i].totalAmount = "RM " + row["total_amount"].ToString();
                            itemList[i].orderDate = row["order_date"].ToString();
                            itemList[i].orderStatus = row["order_status"].ToString();




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
                                    itemList[i].Height += 10;

                                    // need new condition > data table name
                                }

                                // need new condition > data table name
                            }

                            panelContainer.Controls.Add(itemList[i]);

                        }
                    }
                }


            }
        }
    }
}
