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

    public partial class ProductPage : UserControl
    {
        public string userID;
        public ProductPage(string user_id)
        {
            InitializeComponent();
            userID = user_id;
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            ProductUserControl();
        }

        public void ProductUserControl()
        {
            panelContainer.Controls.Clear();

            ClassBLL objBLL = new ClassBLL();

            DataTable dt = objBLL.getTableItems("product", "");

            if(dt != null && dt.Rows.Count > 0 ) 
            {
                    productLayout[] itemList = new productLayout[dt.Rows.Count];

                    for (int i = 0; i <1; i++)
                    {
                        foreach(DataRow row in dt.Rows) 
                        {
                            itemList[i] = new productLayout(userID);

                            try
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["product_img"]);
                                itemList[i].Icon = new Bitmap(ms);
                            }
                            catch { itemList[i].Icon = Resources.NoImage; }


                            itemList[i].Title = row["product_name"].ToString();
                            itemList[i].Price = "RM " + row["price"].ToString() + "/per unit";
                            itemList[i].SpecialPrice = "RM " + row["special_price"].ToString() + "/per 100 unit";
                            if(row["price"].ToString().Replace(" ", String.Empty) == row["special_price"].ToString().Replace(" ", String.Empty))
                            { itemList[i].lbl_specialPrice.Visible = false; }
                            itemList[i].product_id = row["product_id"].ToString();

                            panelContainer.Controls.Add(itemList[i]);


                        }
                    }
                
                
            
            }
        }

    }
}
