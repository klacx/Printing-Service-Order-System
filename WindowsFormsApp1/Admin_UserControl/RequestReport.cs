using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Dynamic_Panel.Admin_Layout;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Admin_UserControl
{
    public partial class RequestReport : UserControl
    {
        public int month;
        public int year;
        public int totalRequest;

        public RequestReport()
        {
            InitializeComponent();
            monthComboBox.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            yearComboBox.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
        }

        private void RequestReport_Load(object sender, EventArgs e)
        {
            dateAndMonthForComboBox();
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex != -1 && yearComboBox.SelectedIndex != -1)
            {
                month = DateTime.ParseExact(monthComboBox.SelectedItem.ToString(), "MMMM", CultureInfo.InvariantCulture).Month;
                year = int.Parse(yearComboBox.SelectedItem.ToString());

                requestUserControl();
            }
        }

        private void dateAndMonthForComboBox()
        {
            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_Order", "");
            foreach (DataRow row in dt.Rows)
            {
                DateTime orderDate = (DateTime)row["order_date"];
                DateTimeFormatInfo dateFormatInfo = new DateTimeFormatInfo();
                if (!monthComboBox.Items.Contains(dateFormatInfo.GetMonthName(orderDate.Month)))
                {
                    monthComboBox.Items.Add(dateFormatInfo.GetMonthName(orderDate.Month));
                }
                if (!yearComboBox.Items.Contains(orderDate.Year))
                {
                    yearComboBox.Items.Add(orderDate.Year);
                }
            }
        }
        private void requestUserControl()
        {
            panelContainer.Controls.Clear();

            List<string> productName = new List<string>();
            List<int> requestAmount = new List<int>();
            List<int> percentage = new List<int>();

            ClassBLL bll1 = new ClassBLL();
            DataTable OPT = bll1.getTableItems("Product", " ORDER BY product_id ASC");
            foreach (DataRow product in OPT.Rows)
            {
                requestLayout item = new requestLayout();

                item.productName = product["product_name"].ToString();

                ClassBLL bll2 = new ClassBLL();
                DataTable dt = bll2.getTableItems("_Order", " WHERE MONTH(order_date) =" + month + " AND YEAR(order_date) =" + year);
                totalRequest = dt.Rows.Count;

                foreach (DataRow row in dt.Rows)
                {
                    ClassBLL bll3 = new ClassBLL();
                    DataTable ODDT = bll3.getTableItems("OrderDetails", " WHERE order_id =" + int.Parse(row["order_id"].ToString()) + "AND product_id ='" + product["product_id"].ToString() + "'"); // get order details from orderDetails table with the order_i
                    if (ODDT.Rows.Count > 0)
                    {
                        item.requestAmount += 1;
                    }
                }

                productName.Add(item.productName);
                requestAmount.Add(item.requestAmount);

                panelContainer.Controls.Add(item);
            }

            requestChart.Series.Add("Sales");
            requestChart.Series["Sales"].Points.DataBindXY(productName, requestAmount);
            requestChart.Series["Sales"].ChartType = SeriesChartType.Pie;
            requestChart.Series["Sales"]["PieLabelStyle"] = "Outside";

            lbl_totalRequest.Text = totalRequest.ToString();
        }
    }
}
