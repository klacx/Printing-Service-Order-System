using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dynamic_Panel;
using WindowsFormsApp1.Dynamic_Panel.Admin_Layout;
using WindowsFormsApp1.ServerCode;
using WindowsFormsApp1.Student_UserControl;

namespace WindowsFormsApp1.Admin_UserControl
{
    public partial class IncomeReport : UserControl
    {
        public int month;
        public int year;
        public decimal totalAmount;
        public decimal totalIncome=0;

        public IncomeReport()
        {
            InitializeComponent();
            monthComboBox.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            yearComboBox.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
            dateAndMonthForComboBox();
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex != -1 && yearComboBox.SelectedIndex != -1)
            {
                month = DateTime.ParseExact(monthComboBox.SelectedItem.ToString(), "MMMM", CultureInfo.InvariantCulture).Month;
                year = int.Parse(yearComboBox.SelectedItem.ToString());

                incomeUserControl();
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
        private void incomeUserControl() 
        {
            panelContainer.Controls.Clear();
            incomeChart.Series.Clear();

            ClassBLL bll1 = new ClassBLL();
            DataTable OPT = bll1.getTableItems("Product", " ORDER BY product_id ASC");
            foreach (DataRow product in OPT.Rows)
            {
                incomeLayout item = new incomeLayout();

                item.productName = product["product_name"].ToString();

                ClassBLL bll2 = new ClassBLL();
                DataTable dt = bll2.getTableItems("_Order", " WHERE MONTH(order_date) =" + month + " AND YEAR(order_date) =" + year);

                foreach (DataRow row in dt.Rows)
                {


                    ClassBLL bll3 = new ClassBLL();
                    DataTable ODDT = bll3.getTableItems("OrderDetails", " WHERE order_id =" + int.Parse(row["order_id"].ToString()) + "AND product_id ='" + product["product_id"].ToString() + "'"); // get order details from orderDetails table with the order_i
                    if (ODDT.Rows.Count > 0) 
                    {
                        item.totalAmount += decimal.Parse(ODDT.Rows[0]["amount"].ToString());
                        
                    }
                }
                incomeChart.Series.Add(item.productName);
                incomeChart.Series[item.productName].Points.AddXY("Amount(RM)", item.totalAmount);
                totalAmount += item.totalAmount;
                panelContainer.Controls.Add(item);
            }

            ClassBLL bll4 = new ClassBLL();
            DataTable IDT = bll4.getTableItems("_Order", " WHERE MONTH(order_date) =" + month + " AND YEAR(order_date) =" + year);

            foreach (DataRow row in IDT.Rows)
            {
                totalIncome += decimal.Parse(row["total_amount"].ToString());
            }
            lbl_totalIncome.Text = string.Format(new CultureInfo("en-MY"), "{0:C2}", totalIncome);

            incomeLayout urgentCharge = new incomeLayout();
            urgentCharge.productName = "Urgent Charge's Profit";
            urgentCharge.totalAmount = totalIncome - totalAmount;
            panelContainer.Controls.Add(urgentCharge);
        }
    }
}
