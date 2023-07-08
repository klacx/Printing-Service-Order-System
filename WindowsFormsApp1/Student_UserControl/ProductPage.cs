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
using WindowsFormsApp1.ServerCode;

namespace WindowsFormsApp1.Student_UserControl
{

    public partial class ProductPage : UserControl
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            ProductUserControl();
        }

        public void ProductUserControl()
        {
            panelContainer.Controls.Clear();

            ClassBLL objBLL = new ClassBLL();

            DataTable dt = objBLL.getProductItems();

            if(dt != null ) 
            {
                if (dt.Rows.Count > 0)
                {
                    productLayout[] itemList = new productLayout[dt.Rows.Count];

                    for (int i = 0; i <1; i++)
                    {
                        foreach(DataRow row in dt.Rows) 
                        {
                            itemList[i] = new productLayout();

                            try
                            {
                                MemoryStream ms = new MemoryStream((byte[])row["product_img"]);
                                itemList[i].Icon = new Bitmap(ms);
                            }
                            catch {  }


                            itemList[i].Title = row["product_name"].ToString();
                            itemList[i].Price = row["price"].ToString() + "/per unit";
                            itemList[i].SpecialPrice = row["special_price"].ToString() + "/per 100 unit";
                            if(row["price"].ToString().Replace(" ", String.Empty) == row["special_price"].ToString().Replace(" ", String.Empty))
                            { itemList[i].lbl_specialPrice.Visible = false; }

                            panelContainer.Controls.Add(itemList[i]);

                            //itemList[i].Click += new System.EventHandler(this.addToCartBtn_Click);
                        }
                    }
                }
                
            
            }
        }

        //public void addToCartBtn_Click(object sender, EventArgs e) {MessageBox.Show("Clicked");}
    }
}
