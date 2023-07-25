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
             newRequestPageUserControl();
        }

        public void newRequestPageUserControl()
        {
            panelContainer.Controls.Clear();

            Connection con = new Connection();
            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_Order", " WHERE assigned = 'false' ORDER BY urgent DESC, order_id ASC");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        newRequestLayout item = new newRequestLayout();

                        item.orderId = row["order_id"].ToString();
                        item.totalAmount = "RM" + row["total_amount"].ToString();
                        item.urgent = bool.Parse(row["urgent"].ToString());
                        item.userID = row["user_id"].ToString();

                        ClassBLL bll2 = new ClassBLL();
                        DataTable ODT = bll2.getTableItems("OrderDetails", " WHERE order_id='" + item.orderId + "'");
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

                        ClassBLL bll3 = new ClassBLL();
                        DataTable worker_id = bll3.getTableItems("_User", " WHERE roles = 'worker'");
                        foreach (DataRow worker in worker_id.Rows)
                        {
                            item.workerComboBox.Items.Add(worker["user_id"].ToString());
                        }

                        panelContainer.Controls.Add(item);

                    }
                }
            }
        }
    }
}
