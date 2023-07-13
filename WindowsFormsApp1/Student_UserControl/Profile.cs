using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.ServerCode;
using static WindowsFormsApp1.Student_UserControl.Profile;

namespace WindowsFormsApp1.Student_UserControl
{
    public partial class Profile : UserControl
    {
        public byte[] userImage;
        public string userID;
        public string fn;
        public Profile(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

                List<User> userList = userDataFromMDF(); 

                foreach (User user in userList)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream(userImage);
                        userIcon.Image = new Bitmap(ms);
                    }
                    catch
                    {
                        userIcon.Image = Resources.defaultAvatar;
                    }

                    firstNameTextBox.Text = user.first_name ?? string.Empty;
                    lastNameTextBox.Text = user.last_name ?? string.Empty;
                    phoneNumberTextBox.Text = user.phone_number ?? string.Empty;
                    genderTextBox.SelectedItem = user.gender?.Replace(" ", string.Empty);
                    dobTimePicker.Value = user.dob ?? DateTime.Now;
                    emailTextBox.Text = user.email ?? string.Empty;
                }
            
        }

        public class User
        {
            public string password { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string phone_number { get; set; }
            public DateTime? dob { get; set; }
            public string gender { get; set; }


        }

        public List<User> userDataFromMDF()
        {
            List<User> userListFromMDF = new List<User>();

            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_User", (" WHERE user_id ='" + userID + "'"));
            foreach (DataRow row in dt.Rows)
            {
                User user = new User
                {
                    email = row["email"] != DBNull.Value ? row["email"].ToString() : null,
                    first_name = row["first_name"] != DBNull.Value ? row["first_name"].ToString() : null,
                    last_name = row["last_name"] != DBNull.Value ? row["last_name"].ToString() : null,
                    phone_number = row["phone_number"] != DBNull.Value ? row["phone_number"].ToString() : null,
                    dob = row["dob"] != DBNull.Value ? (DateTime)row["dob"] : (DateTime?)null,
                    gender = row["gender"] != DBNull.Value ? row["gender"].ToString() : null
                };
                userListFromMDF.Add(user);
            }
            return userListFromMDF;
        }

        public List<User> userDataFromUser()
        {
            List<User> userListFromUser = new List<User>();


            User user = new User
            {
                email = emailTextBox.Text,
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                phone_number = phoneNumberTextBox.Text,
                dob = dobTimePicker.Value,
                gender = genderTextBox.Text.Replace(" ", string.Empty)
            };

            userListFromUser.Add(user);
            return userListFromUser;
        }

        public bool ValidateEmailFormat(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            List<User> userList = userDataFromMDF();

            foreach (User user in userList)
            {
                fn = user.first_name ?? string.Empty;
            }

            if (firstNameTextBox.Text != fn) { updateBtn.Enabled = true; }
        }
    }

    
}
