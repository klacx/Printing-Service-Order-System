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
using WindowsFormsApp1.Worker_UserControl;

namespace WindowsFormsApp1
{
    public partial class WorkerForm : KryptonForm
    {
        public string userID;
        public WorkerForm(string user_id)
        {
            InitializeComponent();
            userID = user_id;

            object sender = newRequestBtn;
            EventArgs e = EventArgs.Empty;
            requestBtn_Click(sender, e);
        }

        private void WorkerForm_Load(object sender, EventArgs e)
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

        private void ProfileBtn_Click_1(object sender, EventArgs e)
        {
            Profile Pf = new Profile(userID);
            addUserControl(Pf);
            Pf.UpdateBtnClicked += WorkerForm_Load;
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
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void requestBtn_Click(object sender, EventArgs e)
        {
            newRequest workerRequest = new newRequest(userID);
            addUserControl(workerRequest);
        }

        private void progressingBtn_Click(object sender, EventArgs e)
        {
            progressingRequest progressingRequest = new progressingRequest(userID);
            addUserControl(progressingRequest);
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            workerHistory workerHistory = new workerHistory(userID);
            addUserControl(workerHistory);
        }
    }
}
