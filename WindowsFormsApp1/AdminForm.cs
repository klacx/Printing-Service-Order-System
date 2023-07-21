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
using WindowsFormsApp1.ServerCode;
using WindowsFormsApp1.Student_UserControl;

namespace WindowsFormsApp1
{
    public partial class AdminForm : KryptonForm
    {
        public string userID;
        public AdminForm(string user_id)
        {
            InitializeComponent();

            userID = user_id;
        }

        private void AdminForm_Load(object sender, EventArgs e)
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }


        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Profile Pf = new Profile(userID);
            addUserControl(Pf);
            Pf.UpdateBtnClicked += AdminForm_Load;
            userPanel.Visible = false;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
