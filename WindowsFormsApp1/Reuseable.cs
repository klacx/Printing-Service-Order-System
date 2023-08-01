using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Student_UserControl.Profile;
using WindowsFormsApp1.Properties;
using System.Runtime.Remoting.Contexts;
using System.Windows.Markup;

namespace WindowsFormsApp1.ServerCode
{
    internal class Connection
    {
        public SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\User\Desktop\clone\WindowsFormsApp1\demoDatabase.mdf;Integrated Security = True; Connect Timeout = 30; Max Pool Size=2000");
    }
    class classDAL
    {
        public DataTable ReadItemsTable(string tableName, string condition)
        { 
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State) 
            { 
                con.connect.Open();
            }

            try 
            { 
                using (SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM " + tableName + condition, con.connect)) 
                {
                    DataTable DT = new DataTable();
                    SDA.Fill(DT);
                    return DT;
                }
            }
            catch 
            {
                throw;            
            }
            
        }
    }
    
    class ClassBLL
    {
        public DataTable getTableItems(string tableName, string condition)
        {
            try
            {
                classDAL objDAL = new classDAL();
                return objDAL.ReadItemsTable(tableName, condition);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }

    class ClassIcon
    {
        public void LoadIcon(string userID, RoundPictureBox icon)
        {
            ClassBLL bll = new ClassBLL();
            DataTable dt = bll.getTableItems("_User", " WHERE user_id='" + userID + "'");
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(dr["user_img"] != DBNull.Value ? (byte[])dr["user_img"] : null))
                    {
                        icon.Image = new Bitmap(ms);
                    }
                }
                catch
                {
                    icon.Image = Resources.defaultAvatar;
                }
            }
        }

    }
}
