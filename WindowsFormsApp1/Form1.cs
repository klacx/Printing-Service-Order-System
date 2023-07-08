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
using ComponentFactory.Krypton.Toolkit;
using WindowsFormsApp1.ServerCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT roles FROM _User WHERE user_id='" + usernameTextBox.Text + "' AND password='" + passwordTextBox.Text + "'", con.connect);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Invalid username or password. Please try again");
            }
            else
            {
                string permission = DT.Rows[0][0].ToString().Replace(" ", String.Empty);
                if (permission == "admin")
                {
                    this.Hide();
                    AdminForm admin = new AdminForm();
                    admin.Closed += (s, args) => this.Close();
                    admin.Show();
                }
                else if (permission == "student")
                {
                    this.Hide();
                    StudentForm student = new StudentForm();
                    student.Closed += (s, args) => this.Close();
                    student.Show();
                }
                else if (permission == "worker")
                {
                    this.Hide();
                    WorkerForm worker = new WorkerForm();
                    worker.Closed += (s, args) => this.Close();
                    worker.Show();
                }
                else if (permission == "manager")
                {
                    this.Hide();
                    ManagerForm manager = new ManagerForm();
                    manager.Closed += (s, args) => this.Close();
                    manager.Show();
                }
            }
        }
    }
}
