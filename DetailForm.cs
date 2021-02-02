using BookShopManagement1.modelBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement1
{
    public partial class DetailForm : Form
    {
        int urunid = -1;
        
        Kırtasiye krtsy = null;

        
        public DetailForm(int id,Kırtasiye k)
        {
            InitializeComponent();
            urunid = id;
         
            krtsy = k;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Krtsye k = new Krtsye();
            //    DataTable dt = k.GetProduct();
            //    if (dt.Rows.Count > 0)
            //    {
            //        tburunid.Text = dt.Rows[0]["UrunID"].ToString();
            //        tbtur.Text = dt.Rows[0]["UrunTuru"].ToString();
            //        tbrenk.Text = dt.Rows[0]["Renk"].ToString();
            //        tbnudstok.Text = dt.Rows[0]["Stok"].ToString();
             
                   
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Krtsye k = new Krtsye();
            //    string tur = tbtur.Text.Trim();
            //    string color = tbrenk.Text.Trim();
            //    int price = int.Parse(tbfiyat.Text.Trim());
            //    int total=int.Parse(tb)
            //    int result = k.UpdateKrtsy(urunid, tbtur.Text,value,tbrenk.Text,price);
            //    if (result > 0)
            //    {
            //        MessageBox.Show ("Updated successfully.");
                    

            //        if (krtsy != null)
            //        {
            //            krtsy.LoadGridviewData();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show( ex.Message);
                
            //}
        }
    }
}
