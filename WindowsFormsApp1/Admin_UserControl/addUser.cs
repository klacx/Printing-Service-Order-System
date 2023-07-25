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
using WindowsFormsApp1.Dynamic_Panel.Admin_Layout;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Admin_UserControl
{
    public partial class addUser : UserControl
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            usersUserControl();
        }

        private void usersUserControl()
        {
            panelContainer.Controls.Clear();

            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_User", "");

            foreach (DataRow dr in dt.Rows) 
            {
                userLayout user = new userLayout();
                user.userID = dr["user_id"].ToString();
                user.roles = dr["roles"].ToString();
                panelContainer.Controls.Add(user);
            }
            
        }

        private void checkForAdd()
        {
            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_User", "");

            bool checkID = dt.AsEnumerable().Any(row => row.Field<string>("user_id") == userIDTextBox.Text);

            if ( userIDTextBox.Text.Length > 3 && !checkID && passwordTextBox.Text.Length > 3 && rolesComboBox.SelectedIndex != -1)
            {
                addBtn.Enabled = true;
            }
            else 
            { 
                addBtn.Enabled = false;
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            checkForAdd();
        }

        private void rolesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            checkForAdd();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.connect.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT into _User (user_id, password, roles) VALUES(@user_id, @password, @roles)", con.connect)) 
            {
                cmd.Parameters.AddWithValue("@user_id", userIDTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@roles", rolesComboBox.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
            }
            usersUserControl();
            userIDTextBox.Clear();
            passwordTextBox.Clear();
            rolesComboBox.SelectedIndex = -1;
            addBtn.Enabled = false;
        }

        private void userIDTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            checkForAdd();
        }
    }
}
