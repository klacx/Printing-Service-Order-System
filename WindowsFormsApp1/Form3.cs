using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp1
{
    public partial class StudentForm : KryptonForm

    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            userPanel.Visible = false;
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            if (userPanel.Visible == false) { userPanel.Visible = true; }
            else if (userPanel.Visible == true) { userPanel.Visible = false; }
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }
    }
}
