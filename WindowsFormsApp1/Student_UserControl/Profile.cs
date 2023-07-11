using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dynamic_Panel.Product_Page;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Student_UserControl
{
    public partial class Profile : UserControl
    {
        public string userID;
        public Profile(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            ClassBLL objBLL = new ClassBLL();
            DataTable dt = objBLL.getTableItems("_User", (" WHERE user_id ='" + userID + "'"));
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        try
                        {
                            MemoryStream ms = new MemoryStream((byte[])row["product_img"]);
                            userIcon.Image = new Bitmap(ms);
                        }
                        catch { userIcon.Image = Resources.defaultAvatar; }

                        try { firstNameTextBox.Text = row["first_name"].ToString(); }
                        catch { }

                        try{ lastNameTextBox.Text = row["last_name"].ToString(); }
                        catch {}

                        try { phoneNumberTextBox.Text = row["phone_number"].ToString(); }
                        catch { }

                        try { genderTextBox.SelectedItem = row["gender"].ToString().Replace(" ", String.Empty); }
                        catch { }

                        try { dobTimePicker.Value = Convert.ToDateTime(row["dob"]); }
                        catch { }

                        try { emailTextBox.Text = row["email"].ToString(); }
                        catch { }
                    }
                }
            }
        }
    }

    
}
