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
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Manager_UserControl
{
    public partial class newRequestPage : UserControl
    {
        public newRequestPage()
        {
            InitializeComponent();
        }

        private void newRequestPage_Load(object sender, EventArgs e)
        {
            AllOrderUserControl();
        }

        public void AllOrderUserControl()
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_Order", " WHERE assigned = 'false' ORDER BY urgent DESC, order_id ASC");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    newRequestLayout[] itemList = new newRequestLayout[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            itemList[i] = new newRequestLayout();

                            itemList[i].orderId = row["order_id"].ToString();
                            itemList[i].totalAmount = "RM" + row["total_amount"].ToString();
                            itemList[i].urgent = bool.Parse(row["urgent"].ToString());
                            itemList[i].userID = row["user_id"].ToString();

                            ClassBLL bll2 = new ClassBLL();
                            DataTable ODT = bll2.getTableItems("OrderDetails", " WHERE order_id='" + itemList[i].orderId + "'");
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

                            ClassBLL bll3 = new ClassBLL();
                            DataTable worker_id = bll3.getTableItems("_User", " WHERE roles = 'worker'");
                            foreach (DataRow worker in worker_id.Rows)
                            {
                                itemList[i].workerComboBox.Items.Add(worker["user_id"].ToString());
                            }

                            panelContainer.Controls.Add(itemList[i]);

                        }
                    }
                }


            }
        }
    }
}
