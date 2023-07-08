using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ServerCode
{
    internal class Connection
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\demoDatabase.mdf;Integrated Security=True;Connect Timeout=30");
    }
    class classDAL
    {
        public DataTable ReadItemsTable()
        { 
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State) 
            { 
                con.connect.Open();
            }

            try 
            { 
                using (SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Product", con.connect)) 
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
        public DataTable getProductItems()
        {
            try
            {
                classDAL objDAL = new classDAL();
                return objDAL.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
