using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    public partial class orderLayout : UserControl
    {
        public orderLayout()
        {
            InitializeComponent();
        }

        private void orderLayout_Load(object sender, EventArgs e)
        {

        }

        private string _orderId;
        private string _orderDetails;
        private string _status;
        private string _orderDate;
        private bool _urgent;
        private string _userID;
        private bool _payment;
        private string _workerID;

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

        public string userID
        {
            get { return _userID; ; }
            set { _userID = value; lbl_user.Text = value; }
        }

        public string workerID
        {
            get { return _workerID; }
            set { _workerID = value; lbl_worker.Text = value; }
        }

        public string orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; lbl_orderDate.Text = value; }
        }
        public string orderStatus
        {
            get { return _status; }
            set
            {
                _status = value;
                lbl_orderStatus.Text = value;
                if (_status == "progressing")
                { lbl_orderStatus.ForeColor = Color.Blue; }
                else if (_status == "completed")
                { lbl_orderStatus.ForeColor = Color.Green; }

            }
        }

        public bool payment
        {
            get { return _payment; }
            set
            {
                _payment = value;
                if (value == true)
                {
                    lbl_payment.Text = "Completed";
                    lbl_payment.ForeColor = Color.Green;
                }
                else
                {
                    lbl_payment.Text = "Incompleted";
                    lbl_payment.ForeColor = Color.Red;
                    print.Visible = false;
                }
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


    }


    
}
