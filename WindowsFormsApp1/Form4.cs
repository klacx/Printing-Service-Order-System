using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WorkerForm : KryptonForm
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            userPanel.Visible = false;
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            if (userPanel.Visible == false) { userPanel.Visible = true; }
            else if (userPanel.Visible == true) { userPanel.Visible = false; }
        }

        private void ProfileBtn_Click_1(object sender, EventArgs e)
        {
            userPanel.Visible = false;
        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }
    }
}
