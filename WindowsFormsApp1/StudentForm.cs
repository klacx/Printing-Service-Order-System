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
using WindowsFormsApp1.Student_UserControl;

namespace WindowsFormsApp1
{
    public partial class StudentForm : KryptonForm

    {
        public string userID;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public StudentForm(string user_id)
        {
            userID = user_id;
            InitializeComponent();

            object sender = productBtn; 
            EventArgs e = EventArgs.Empty; 
            ProductBtn_Click(sender, e);
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
            Profile Pf = new Profile(userID);
            addUserControl(Pf);
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

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            ProductPage PP = new ProductPage(userID);
            addUserControl(PP);
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            HistoryPage HP = new HistoryPage(userID);
            addUserControl(HP);
        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            ShoppingCart cart = new ShoppingCart(userID);
            addUserControl(cart);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
