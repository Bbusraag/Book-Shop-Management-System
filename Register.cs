using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BookShopManagement1.modelBook;

namespace BookShopManagement1
{
    public partial class btnregister : Form
    {
        public btnregister()
        {
            InitializeComponent();
            cbcinsiyet.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kullanıcıid = int.Parse(tbkullanıcıID.Text.Trim());
            string isim = tbisim.Text.Trim();
            string soyisim = tbsoyisim.Text.Trim();
            string email = tbemail.Text.Trim();
            string şifre = tbşifre.Text.Trim();
            if (tbkullanıcıID.Text.Trim() == "")
            {
                lblmessagebox.Text = "Lütfen ID giriniz.";
                lblmessagebox.ForeColor=Color.Red;
                tbkullanıcıID.Focus();
                return;
            }
            if (isim == "")
            {
                lblmessagebox.Text = "Lütfen adını gir.";
                lblmessagebox.ForeColor = Color.Red;
                return;
            }
            if (soyisim == "")
            {
                lblmessagebox.Text = "Lütfen soyadını gir.";
                lblmessagebox.ForeColor = Color.Red;
                return;

            }
            if (email == "")
            {
                lblmessagebox.Text = "Lütfen emailini gir.";
                lblmessagebox.ForeColor = Color.Red;
                return;
            }
            //
            if (email.IndexOf("@") < 0)
            {
                lblmessagebox.Text = "please enter correct email.";
                lblmessagebox.ForeColor = Color.Red;
                return;
            }
            //
            if (!email.Contains("@")){
                lblmessagebox.Text = "please enter correct email.";
                lblmessagebox.ForeColor = Color.Red;
                return;
            }
            if (şifre =="")
            {
                lblmessagebox.Text = "Lütfen şifreni gir";
                lblmessagebox.ForeColor = Color.Red;
                return;
            }
            if (cbcinsiyet.SelectedIndex == 0)
            {
                lblmessagebox.Text = "Lütfen cinsiyet seç";
                lblmessagebox.ForeColor = Color.Red;
                return;
            }
            //string dbpath = @"C:\Users\Device X1-C1\source\repos\BookShopManagement1\BookShopManagement1\db.txt";
            Kullanıcı k = new Kullanıcı();
            var result=k.AddUser(kullanıcıid,isim,soyisim,email,şifre);
            if (result > 0)
            {
                lblmessagebox.Text = "Başarılı bir şekilde girdin.";
                lblmessagebox.ForeColor = Color.Green;
            }
            else
            {
                lblmessagebox.Text = "Başarılı bir şekilde giremedin.";
                lblmessagebox.ForeColor = Color.Red;
            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            tbisim.Text = "";
            tbsoyisim.Text = "";
            tbemail.Text = "";
            tbşifre.Text = "";
            cbcinsiyet.SelectedIndex = 0;
            lblmessagebox.Text = "";
        }
    }
}
