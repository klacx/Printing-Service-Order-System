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

        }

        private void roundPictureBox1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        bool expand = false;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (expand == false)
            {
                UserDropDown.Height += 15;
                if (UserDropDown.Height >= UserDropDown.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                UserDropDown.Height -= 15;
                if (UserDropDown.Height <= UserDropDown.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
