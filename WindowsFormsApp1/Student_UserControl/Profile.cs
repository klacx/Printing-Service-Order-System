using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Student_UserControl
{
    public partial class Profile : UserControl
    {
        public byte[] userImage;
        public string userID;
        public bool imageUploaded = false;
        public string query;
        public List<bool> results = new List<bool>();
        public List<bool> final_result = new List<bool>();
        public bool passwordChanged;
        public event EventHandler UpdateBtnClicked;
        public string password;
        public DateTime dob;
        public string DateString;
        public Profile(string user_id)

        {
            InitializeComponent();
            userID = user_id;
            TextBoxLeaveEvent();
            TextBoxKeyDownEvent();
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

        private void compare()
        {
            List<object> MDF = userDataFromMDF();
            List<object> FUS = userDataFromUser();
            results.Clear();
            final_result.Clear();
            passwordChanged = false;

            for (int i = 0; i < 4; i++)
            {
                if (MDF[i] !=null)
                {
                    bool result = MDF[i].ToString().Replace(" ", String.Empty) == FUS[i].ToString().Replace(" ", String.Empty);
                    results.Add(result);
                }
                else 
                {
                    if (FUS[i].ToString().Length > 0)
                    {
                        results.Add(false);
                    }
                    else
                    { 
                        results.Add(true); 
                    }
                }
            }

            if (genderTextBox.SelectedIndex == -1)
            {
                results.Add(true);
            }
            else 
            {
                if (MDF[4] == null)
                {
                    results.Add(false);
                }
                else
                {
                    if (MDF[4].ToString().Replace(" ", String.Empty) == FUS[4].ToString().Replace(" ", String.Empty))
                    {
                        results.Add(true);
                    }
                    else
                    {
                        results.Add(false);
                    }
                }

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
                if (dr["dob"].ToString().Length < 1)
                {
                    DateString = "0000";
                }
                else 
                {
                    dob = DateTime.Parse(dr["dob"].ToString());
                    DateString = dob.ToString("yyyy");
                }
            }

            if (int.Parse(DateString) < 1900)
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
                        passwordChanged = true;
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

        public void updateBtn_Click(object sender, EventArgs e)
        {
            query = "UPDATE _User SET ";

            if (results[0] == false)
            {
                query += " email = @email,";
            }
            if (results[1] == false)
            {
                query += " first_name = @first_name,";
            }
            if (results[2] == false)
            {
                query += " last_name = @last_name";
            }
            if (results[3] == false)
            {
                query += " phone_number = @phone_number,";
            }
            if (results[4] == false)
            {
                query += " gender = @gender,";
            }
            if (imageUploaded)
            {
                query += " user_img = @user_img,";
            }
            if (passwordChanged)
            {
                query += " password = @password,";
            }

            query = query.Remove(query.Length - 1);

            query += " WHERE user_id= @user_id";

            Connection con = new Connection();
            con.connect.Open();
            using (SqlCommand cmd = new SqlCommand(query, con.connect))
            {
                if (results[0] == false)
                {
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                }
                if (results[1] == false)
                {
                    cmd.Parameters.AddWithValue("@first_name", firstNameTextBox.Text);
                }
                if (results[2] == false)
                {
                    cmd.Parameters.AddWithValue("@last_name", lastNameTextBox.Text);
                }
                if (results[3] == false)
                {
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumberTextBox.Text);
                }
                if (results[4] == false)
                {
                    cmd.Parameters.AddWithValue("@gender", genderTextBox.SelectedItem.ToString());
                }
                if (imageUploaded)
                {
                    cmd.Parameters.AddWithValue("@user_img", userImage);
                }
                if (passwordChanged)
                {
                    cmd.Parameters.AddWithValue("@password", NPTextBox.Text);
                }
                cmd.Parameters.AddWithValue("@user_id", userID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
            }

            imageUploaded = false;

            if(passwordChanged)
            {
                NPTextBox.Clear();
                CNPTextBox.Clear();
            }

            compare();

            UpdateBtnClicked?.Invoke(this, e);
        }
    
        private void UploadBtn_Click(object sender, EventArgs e)
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

        private void TextBoxLeaveEvent()
        {
            firstNameTextBox.Leave += TextBox_Leave;
            lastNameTextBox.Leave += TextBox_Leave;
            phoneNumberTextBox.Leave += TextBox_Leave;
            emailTextBox.Leave += TextBox_Leave;
            NPTextBox.Leave += TextBox_Leave;
            CNPTextBox.Leave += TextBox_Leave;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            compare();
        }

        private void TextBoxKeyDownEvent()
        {
            firstNameTextBox.KeyDown += TextBox_KeyDown;
            lastNameTextBox.KeyDown += TextBox_KeyDown;
            phoneNumberTextBox.KeyDown += TextBox_KeyDown;
            emailTextBox.KeyDown += TextBox_KeyDown;
            NPTextBox.KeyDown += TextBox_KeyDown;
            CNPTextBox.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                compare();
            }
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            compare();
        }

        public bool ValidateEmailFormat(string email)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
