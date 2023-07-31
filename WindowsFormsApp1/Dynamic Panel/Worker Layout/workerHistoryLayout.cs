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
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Dynamic_Panel.Worker_Layout
{
    public partial class workerHistoryLayout : UserControl
    {
        public workerHistoryLayout()
        {
            InitializeComponent();
        }

        private void workerHistoryLayout_Load(object sender, EventArgs e)
        {

        }

        private string _orderId;
        private string _orderDetails;
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


        public string orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; lbl_orderDate.Text = value; }
        }

        public string orderStatus
        {
            get { return _orderStatus; }
            set
            { _orderStatus = value; lbl_orderStatus.Text = value; }
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
    }
}
