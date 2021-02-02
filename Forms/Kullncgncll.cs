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
    public partial class Kullncgncll : Form
    {
        int Userid = -1;
        KullanıcıHome home = null;
        public Kullncgncll(int id, KullanıcıHome k)
        {
            InitializeComponent();
            Userid = id;
            home = k;
        }

        private void Kullncgncll_Load(object sender, EventArgs e)
        {
            try
            {
                Kullanıcı k = new Kullanıcı();
                DataTable dt = k.GetUser();
                if (dt.Rows.Count > 0)
                {
                   tbkullanıcıID.Text = dt.Rows[0]["KullaniciID"].ToString();
                    tbisim.Text = dt.Rows[0]["İsim"].ToString();
                    tbsoyisim.Text = dt.Rows[0]["Soyisim"].ToString();
                   tbemail.Text = dt.Rows[0]["Email"].ToString();
                    tbşifre.Text = dt.Rows[0]["Password"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbgncll_Click(object sender, EventArgs e)
        {

            try
            {
                Kullanıcı k = new Kullanıcı();
                
                int result = k.Update(tbisim.Text,tbsoyisim.Text,tbemail.Text,tbşifre.Text,Userid);
                if (result > 0)
                {
                    MessageBox.Show("Updated successfully.");


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
        }
    }
}
