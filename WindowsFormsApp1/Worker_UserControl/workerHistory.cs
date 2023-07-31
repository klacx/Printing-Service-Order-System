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
using static WindowsFormsApp1.Student_UserControl.Profile;
using WindowsFormsApp1.ServerCode;
using WindowsFormsApp1.Dynamic_Panel.Worker_Layout;

namespace WindowsFormsApp1.Worker_UserControl
{
    public partial class workerHistory : UserControl
    {
        public string userID;
        public workerHistory(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void workerHistory_Load(object sender, EventArgs e)
        {
            historyUserControl();
        }

        public void historyUserControl()
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();

            ClassBLL bll1 = new ClassBLL();
            DataTable ADT = bll1.getTableItems("WorkerAssignment", (" WHERE user_id ='" + userID + "'"));


            if (ADT.Rows.Count > 0)
            {
                foreach (DataRow ADR in ADT.Rows)
                {
                    ClassBLL bll2 = new ClassBLL();
                    DataTable dt = bll2.getTableItems("_Order", (" WHERE order_id='" + ADR["order_id"].ToString() + "' and order_status ='completed'"));

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            workerHistoryLayout item = new workerHistoryLayout();

                            item.orderId = row["order_id"].ToString();
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
}
