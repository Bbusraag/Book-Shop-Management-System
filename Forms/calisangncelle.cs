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

namespace BookShopManagement1.Forms
{
    public partial class calisangncelle : Form
    {
        int CalisanID = -1;
        calisanlar home = null;
        public calisangncelle(int id,calisanlar c)
        {
            
            InitializeComponent();
            CalisanID = id;
            home = c;
        }

        private void calisangncelle_Load(object sender, EventArgs e)
        {
            try
            {
               Calisansnf c = new Calisansnf();
                DataTable dt = c.GetEmployee();
                if (dt.Rows.Count > 0)
                {
                    tbcalisanid.Text = dt.Rows[0]["CalisanlarID"].ToString();
                    tbisim.Text = dt.Rows[0]["Isim"].ToString();
                    tbsoyisim.Text = dt.Rows[0]["Soyisim"].ToString();
                    tbemail.Text = dt.Rows[0]["Email"].ToString();
                    tbpassword.Text = dt.Rows[0]["Password"].ToString();
                  tbgorev.Text= dt.Rows[0]["Gorev"].ToString();
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btngncll_Click(object sender, EventArgs e)
        {
            try
            {
                Calisansnf s = new Calisansnf();
                int result = s.Update(CalisanID, tbisim.Text, tbsoyisim.Text, tbemail.Text, tbgorev.Text, tbpassword.Text);
                
                if (result > 0)
                {
                    MessageBox.Show( "Updated successfully.");
                    //lblMessage.ForeColor = Color.Green;

                    if (home != null)
                    {
                        home.LoadGridviewData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            int id = int.Parse(tbcalisanid.Text.Trim());
            Calisansnf c = new Calisansnf();
            var r = c.Update(id, tbisim.Text, tbsoyisim.Text, tbemail.Text, tbgorev.Text, tbpassword.Text);
            //Krtsye k = new Krtsye();
            //var result = k.AddProduct(urunıd, urunturu, adet, urunrenk, price, total, indirim, ödeme);
        }
    }
}
