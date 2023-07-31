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
using WindowsFormsApp1.Admin_UserControl;
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


            object sender = AddUserBtn;
            EventArgs e = EventArgs.Empty;
            AddUserBtn_Click(sender, e);
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
            Pf.UpdateBtnClicked += AdminForm_Load; //invoke by profile
            userPanel.Visible = false;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            addUser AU = new addUser();
            addUserControl(AU);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void requestRptBtn_Click(object sender, EventArgs e)
        {
            RequestReport RP = new RequestReport();
            addUserControl(RP);
        }

        private void incomeRptBtn_Click(object sender, EventArgs e)
        {
            IncomeReport IP = new IncomeReport();
            addUserControl(IP);
        }
    }
}
