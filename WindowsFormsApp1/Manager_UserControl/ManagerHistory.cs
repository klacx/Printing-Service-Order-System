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
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.ServerCode;
using WindowsFormsApp1.Dynamic_Panel.Manager_Layout;

namespace WindowsFormsApp1.Manager_UserControl
{
    public partial class ManagerHistory : UserControl
    {
        public ManagerHistory()
        {
            InitializeComponent();
        }

        private void AllOrderPage_Load(object sender, EventArgs e)
        {
            AllOrderUserControl();
        }

        public void AllOrderUserControl()
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_Order", " ORDER BY CASE order_status WHEN 'pending' THEN 1 WHEN 'progressing' THEN 2 WHEN 'completed' THEN 3 END ASC, order_id ASC");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    orderLayout[] itemList = new orderLayout[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            itemList[i] = new orderLayout();

                            itemList[i].orderId = row["order_id"].ToString();
                            itemList[i].orderDate = row["order_date"].ToString();
                            itemList[i].orderStatus = row["order_status"].ToString();
                            itemList[i].urgent = bool.Parse(row["urgent"].ToString());
                            itemList[i].userID = row["user_id"].ToString();
                            itemList[i].payment = bool.Parse(row["payment"].ToString());

                            ClassBLL bll2 = new ClassBLL();
                            DataTable worker = bll2.getTableItems("WorkerAssignment", " WHERE order_id='" + itemList[i].orderId + "'");
                            if (worker.Rows[0]["user_id"].ToString().Replace(" ", String.Empty).Length != 0) 
                            { itemList[i].workerID = worker.Rows[0]["user_id"].ToString(); }
                            else
                            { itemList[i].workerID = "-"; }

                            ClassBLL bll3 = new ClassBLL();
                            DataTable ODT = bll3.getTableItems("OrderDetails", " WHERE order_id='" + itemList[i].orderId + "'");
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
}
