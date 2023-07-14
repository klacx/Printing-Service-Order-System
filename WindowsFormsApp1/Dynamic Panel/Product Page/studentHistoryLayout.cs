using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dynamic_Panel.Product_Page
{
    public partial class studentHistoryLayout : UserControl
    {
        public studentHistoryLayout()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void studentHistoryLayout_Load(object sender, EventArgs e)
        {

        }

        private string _orderId;
        private string _orderDetails;
        private string _totalAmount;
        private string _orderDate;
        private string _orderStatus;
        private bool _urgent;

        public string orderId
        {
            get { return _orderId; }
            set { _orderId = value; lbl_id.Text = value; }
        }

        public string orderDetails
        {
            get { return _orderDetails; }
            set { _orderDetails = value; lbl_orderDetails.Text = value; }
        }

        public string totalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; lbl_amount.Text = value; }
        }

        public string orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; lbl_orderDate.Text = value; }
        }

        public string orderStatus
        {
            get { return _orderStatus; }
            set 
            { _orderStatus = value; 
              lbl_orderStatus.Text = value;
              if (_orderStatus == "pending")
              { lbl_orderStatus.ForeColor = Color.Red; }
              else if (_orderStatus == "progressing")
              { lbl_orderStatus.ForeColor = Color.Blue; }
              else if (_orderStatus == "completed")
              { lbl_orderStatus.ForeColor = Color.Green; }
            }
        }

        public bool urgent
        {
            get { return _urgent; }
            set 
            { 
                _urgent = value; 
                if (value == true)
                {
                    this.BackColor = Color.Gainsboro;
                }
            }
        }

        private void lbl_orderDetails_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void lbl_orderDate_Click(object sender, EventArgs e)
        {

        }
    }
}
