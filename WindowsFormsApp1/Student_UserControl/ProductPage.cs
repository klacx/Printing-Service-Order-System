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

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    productLayout item = new productLayout(userID);

                    try
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["product_img"]);
                        item.Icon = new Bitmap(ms);
                    }
                    catch { item.Icon = Resources.NoImage; }


                    item.Title = row["product_name"].ToString();
                    item.Price = "RM " + row["price"].ToString() + "/per unit";
                    item.SpecialPrice = "RM " + row["special_price"].ToString() + "/per 100 unit";
                    if (row["price"].ToString().Replace(" ", String.Empty) == row["special_price"].ToString().Replace(" ", String.Empty))
                    { item.lbl_specialPrice.Visible = false; }
                    item.product_id = row["product_id"].ToString();

                    panelContainer.Controls.Add(item);


                }
            }
        }

    }
}
