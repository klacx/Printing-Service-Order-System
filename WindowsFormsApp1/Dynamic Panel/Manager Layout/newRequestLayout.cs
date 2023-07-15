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

namespace WindowsFormsApp1.Dynamic_Panel.Manager_Layout
{
    public partial class newRequestLayout : UserControl
    {
        public newRequestLayout()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private string _orderId;
        private string _orderDetails;
        private string _totalAmount;
        private bool _urgent;
        private string _userID;
        private List<string> _workerID;

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
            set { _totalAmount = value; lbl_totalAmount.Text = value; }
        }

        public string userID
        {
            get { return _userID; }
            set { _userID = value; lbl_user.Text = value; }
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

        public List<string> workerID
        {
            get { return _workerID; }
            set 
            { 
                _workerID = value; 
                foreach (string worker in _workerID)
                {
                    workerComboBox.Items.Add(worker);
                }
            }
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE _Order SET assigned='true' WHERE order_id= @order_id ", con.connect)) 
            {
                cmd.Parameters.AddWithValue("@order_id", orderId);
                cmd.ExecuteNonQuery();
            }

            using (SqlCommand cmd = new SqlCommand("UPDATE WorkerAssignment SET user_id = @user_id WHERE order_id = @order_id", con.connect))
            {
                cmd.Parameters.AddWithValue("@user_id", workerComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@order_id", orderId);
                cmd.ExecuteNonQuery();
            }

            this.Parent.Controls.Remove(this);
        }
    }
}
