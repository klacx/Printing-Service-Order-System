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
using WindowsFormsApp1.Manager_UserControl;
using WindowsFormsApp1.ServerCode;
using WindowsFormsApp1.Student_UserControl;

namespace WindowsFormsApp1 
{   
    public partial class ManagerForm : KryptonForm
    {
        public string userID;
        public ManagerForm(string user_id)
        {
            InitializeComponent();
            userID = user_id;

            object sender = newRequestBtn;
            EventArgs e = EventArgs.Empty;
            newRequestBtn_Click(sender, e);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            ClassIcon classIcon = new ClassIcon();
            classIcon.LoadIcon(userID, AvatarIcon);
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            if (userPanel.Visible == false) { userPanel.Visible = true; }
            else if (userPanel.Visible == true) { userPanel.Visible = false; }
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Profile Pf = new Profile(userID);
            addUserControl(Pf);
            Pf.UpdateBtnClicked += ManagerForm_Load;
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
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls[0].ToString().Contains("PaymentPage"))
            {
                PaymentPage PP = new PaymentPage();
                addUserControl(PP);
            }
        
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls[0].ToString().Contains("ManagerHistory"))
            {
                ManagerHistory AOP = new ManagerHistory();
                addUserControl(AOP);
            }
        }

        private void newRequestBtn_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.Count >0 )
            {
                if (!panelContainer.Controls[0].ToString().Contains("newRequestPage"))
                {
                    newRequestPage NRP = new newRequestPage();
                    addUserControl(NRP);
                }
            }
            else 
            {
                newRequestPage NRP = new newRequestPage();
                addUserControl(NRP);
            }

        }
    }
}
