using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
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
        public bool imageUploaded = false;
        public string query;
        public Profile(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            List<User> userList = SyncWithDatabase();

            foreach (User user in userList)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(user.userImage))
                    {
                        userIcon.Image = new Bitmap(ms);
                    }
                }
                catch
                {
                    userIcon.Image = Resources.defaultAvatar;
                }

                firstNameTextBox.Text = user.first_name ?? string.Empty;
                lastNameTextBox.Text = user.last_name ?? string.Empty;
                phoneNumberTextBox.Text = user.phone_number ?? string.Empty;
                genderTextBox.SelectedItem = user.gender?.Replace(" ", string.Empty);
                dobTimePicker.Value = user.dob.HasValue ? user.dob.Value : DateTime.Now;
                emailTextBox.Text = user.email ?? string.Empty;
            }

        }

        public class User
        {
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string phone_number { get; set; }
            public string gender { get; set; }
            public string password { get; set; }
            public DateTime? dob { get; set; }
            public byte[] userImage { get; set; }

        }

        public List<User> SyncWithDatabase()
        {
            List<User> data = new List<User>();

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
                    gender = row["gender"] != DBNull.Value ? row["gender"].ToString() : null,
                    dob = row["dob"] != DBNull.Value ? DateTime.Parse(row["dob"].ToString()) : DateTime.Now,
                    userImage = row["user_img"] != DBNull.Value ? (byte[])row["user_img"] : null
                };
                data.Add(user);
            }
            return data;
        }
        public List<object> userDataFromMDF()
        {
            List<object> userListFromMDF = new List<object>();
            PropertyInfo[] properties = typeof(User).GetProperties();

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
                    gender = row["gender"] != DBNull.Value ? row["gender"].ToString() : null
                };

                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(user);
                    userListFromMDF.Add(value);
                }
            }
            return userListFromMDF;
        }

        public List<object> userDataFromUser()
        {
            List<object> userListFromUser = new List<object>();
            PropertyInfo[] properties = typeof(User).GetProperties();


            User user = new User
            {
                email = emailTextBox.Text,
                first_name = firstNameTextBox.Text,
                last_name = lastNameTextBox.Text,
                phone_number = phoneNumberTextBox.Text,
                gender = genderTextBox.Text.Replace(" ", string.Empty)
            };

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(user);
                userListFromUser.Add(value);
            }
            return userListFromUser;
        }

        public bool ValidateEmailFormat(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }

        private void firstNameTextBox_LostFocus(object sender, EventArgs e)
        {
            compare();
        }

        public string password;
        public DateTime dob;
        public string DateString;
        private void compare()
        {
            List<object> MDF = userDataFromMDF();
            List<object> FUS = userDataFromUser();
            List<bool> results = new List<bool>();
            List<bool> final_result = new List<bool>();

            for (int i = 0; i < 5; i++)
            {
                bool result = MDF[i].ToString().Replace(" ", String.Empty) == FUS[i].ToString().Replace(" ", String.Empty);
                results.Add(result);
            }

            if (results.Contains(false))
            {
                final_result.Add(false);
            }
            else
            { final_result.Add(true); }

            ClassBLL bll1 = new ClassBLL();
            DataTable dt = bll1.getTableItems("_User", " WHERE user_id='" + userID + "'");


            foreach (DataRow dr in dt.Rows)
            {
                password = dr["password"].ToString();
                dob = DateTime.Parse(dr["dob"].ToString());
                DateString = dob.ToString("yyyy");
            }

            if (int.Parse(DateString) < 1500)
            {
                final_result.Add(true);
            }
            else
            {
                if (dob == dobTimePicker.Value)
                {
                    final_result.Add(true);
                }
                else { final_result.Add(false); }
            }

            if (NPTextBox.Text.Length > 0)
            {
                if (NPTextBox.Text == CNPTextBox.Text)
                {
                    if (NPTextBox.Text == password)
                    {
                        final_result.Add(true);
                    }
                    else
                    {
                        final_result.Add(false);
                    }
                }
                else
                {
                    final_result.Add(true);
                }
            }

            if (!imageUploaded)
            {
                final_result.Add(true);
            }
            else
            {
                final_result.Add(false);
            }

            if (final_result.Contains(false))
            {
                updateBtn.Enabled = true;
            }
            else
            {
                updateBtn.Enabled = false;
            }
        }

        private void phoneNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            compare();
        }

        public void updateBtn_Click(object sender, EventArgs e)
        {
            if (NPTextBox.Text.Length > 0)
            {
                if (NPTextBox.Text == CNPTextBox.Text)
                {
                    if (NPTextBox.Text == password)
                    {
                        if (imageUploaded)
                        {
                            query = query = "UPDATE _User SET email = @email, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, user_img = @userImage, dob= @dob, gender=@gender WHERE user_id = @user_id";
                        }
                        else
                        {
                            query = "UPDATE _User SET email = @email, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, dob= @dob, gender = @gender WHERE user_id = @user_id";
                        }
                    }
                    else 
                    {
                        if (imageUploaded)
                        {
                            query = "UPDATE _User SET password ='" + NPTextBox.Text + "', email = @email, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, user_img = @userImage, dob= '@dob', gender=@gender WHERE user_id = @user_id";
                        }
                        else
                        {
                            query = "UPDATE _User SET password ='" + NPTextBox.Text + "', email = @email, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, dob= @dob, gender=@gender WHERE user_id = @user_id";
                        }
                    }
                }
                else 
                { 
                    //nothing
                }
            }
            else 
            {
                if (imageUploaded)
                {
                    query = "UPDATE _User SET email = @email, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, user_img = @userImage, dob= @dob, gender=@gender WHERE user_id = @user_id";
                }
                else
                {
                    query = "UPDATE _User SET email = @email, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, dob= @dob, gender= @gender WHERE user_id = @user_id";
                }
            }


            Connection con = new Connection();
            con.connect.Open();
            using (SqlCommand cmd = new SqlCommand(query, con.connect))
            {
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@first_name", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@last_name", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone_number", phoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@dob", dobTimePicker.Value);
                cmd.Parameters.AddWithValue("@gender", genderTextBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@user_id", userID);

                if (imageUploaded)
                {
                    cmd.Parameters.AddWithValue("@userImage", userImage);
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }
        }
    
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    userImage = File.ReadAllBytes(openFileDialog.FileName);
                    imageUploaded = true;


                    using (MemoryStream ms = new MemoryStream(userImage))
                    {
                        userIcon.Image = Image.FromStream(ms);
                    }
                }
            }

            compare();
        }



    }
}
