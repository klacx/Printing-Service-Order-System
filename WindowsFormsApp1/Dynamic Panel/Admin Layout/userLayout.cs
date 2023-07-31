using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Dynamic_Panel.Admin_Layout
{
    public partial class userLayout : UserControl
    {
        private string _userID;
        private string _roles;
        public userLayout()
        {
            InitializeComponent();
        }

        private void userLayout_Load(object sender, EventArgs e)
        {

        }

        public string userID
        {
            get { return _userID; }
            set { _userID = value; userIDTextBox.Text = value; }
        }

        public string roles
        {
            get { return _roles; }
            set { _roles = value; rolesComboBox.SelectedItem = value; }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            deleteBtn.Visible = false;
            updateBtn.Visible = true;
            cancelBtn.Visible = true;

            updateBtn.Location = editBtn.Location;
            cancelBtn.Location = deleteBtn.Location;

            passwordTextBox.Enabled = true;
            rolesComboBox.Enabled = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = true;
            deleteBtn.Visible = true;
            updateBtn.Visible = false;
            cancelBtn.Visible = false;

            string query = "UPDATE _User SET";

            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_User", " WHERE user_id='" + userID + "'");

            if (passwordTextBox.Text.Length>3 && passwordTextBox.Text!= dt.Rows[0]["password"].ToString()) 
            {
                query += " password = @password,";
            }
            if (rolesComboBox.SelectedItem.ToString() != dt.Rows[0]["roles"].ToString())
            {
                query += " roles = @roles,";
            }
            query = query.Remove(query.Length -1);
            query += " WHERE user_id ='" + userIDTextBox.Text + "'";

            Connection con = new Connection();
            con.connect.Open();
            using(SqlCommand cmd = new SqlCommand(query,con.connect))
            {
                if (passwordTextBox.Text.Length > 3 && passwordTextBox.Text != dt.Rows[0]["password"].ToString())
                {
                    cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                }
                if (rolesComboBox.SelectedItem.ToString() != dt.Rows[0]["roles"].ToString())
                {
                    cmd.Parameters.AddWithValue("@roles", rolesComboBox.SelectedItem.ToString());
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }
            passwordTextBox.Clear();
            passwordTextBox.Enabled = false;
            rolesComboBox.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = true;
            deleteBtn.Visible = true;
            updateBtn.Visible = false;
            cancelBtn.Visible = false;

            passwordTextBox.Clear();
            rolesComboBox.SelectedItem = roles;

            passwordTextBox.Enabled = false;
            rolesComboBox.Enabled = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.connect.Open();
            DialogResult choice = MessageBox.Show("Do you want to delete this user? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM _User WHERE user_id=@user_id", con.connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", userID);
                    cmd.ExecuteNonQuery();
                }
                this.Parent.Controls.Remove(this);
            }
            
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            compare();
        }

        private void rolesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            compare();
        }

        private void compare()
        {
            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_User", " WHERE user_id='" + userID + "'");
            List<bool> bools = new List<bool>();

            if (passwordTextBox.Text.Length > 3 && passwordTextBox.Text != dt.Rows[0]["password"].ToString())
            {
                bools.Add(true);
            }
            else
            {
                bools.Add(false);
            }
            if (rolesComboBox.SelectedItem.ToString() != dt.Rows[0]["roles"].ToString())
            {
                bools.Add(true);
            }
            else
            {
                bools.Add(false);
            }

            if(bools.Contains(true))
            {
                updateBtn.Enabled = true;
            }
            else 
            { 
                updateBtn.Enabled = false; 
            }
        }
    }
}
