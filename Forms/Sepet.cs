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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {

        }

        private void lblfiyat_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbürünid.Text.Trim());
            int fiyat = int.Parse(tbürünfiyatı.Text.Trim());
            int adet = int.Parse(tbürünadeti.Text.Trim());
            int banka = int.Parse(tbbanka.Text.Trim());
            int kredi = int.Parse(tbkartno.Text.Trim());

            if (tbürünid.Text.Trim() == "")
            {
                lblmessage.Text = "Lütfen id giriniz.";
                lblmessage.ForeColor = Color.Red;
                tbürünid.Focus();
                return;
            }
            if (tbürünfiyatı.Text.Trim() == "")
            {
                lblmessage.Text = "Lütfen ürün fiyatı giriniz.";
                lblmessage.ForeColor = Color.Red;
                tbürünfiyatı.Focus();
                return;
            }
            if (tbürünadeti.Text.Trim()=="")
            {
                lblmessage.Text = "Lütfen ürün adetini giriniz.";
                lblmessage.ForeColor = Color.Red;
                tbürünadeti.Focus();
                return;
            }
            if (tbürünadeti.Text.Trim()=="")
            {
                lblmessage.Text = "Lütfen ürün adetini giriniz.";
                lblmessage.ForeColor = Color.Red;
                tbürünadeti.Focus();
                return;
            }
            if (tbkartno.Text.Trim()=="")
            {

                lblmessage.Text = "Lütfen ürün kartını giriniz.";
                lblmessage.ForeColor = Color.Red;
                tbkartno.Focus();
                return;
            }
            //if (kredi. < 16)
            //{
            //    lblmessage.Text = "Lütfen ürün kartını giriniz.";
            //    lblmessage.ForeColor = Color.Red;
            //    tbkartno.Focus();
            //    return;
            //}
            Sepetclss s = new Sepetclss();

            
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            Sepetclss s = new Sepetclss();
            dataGridView1.DataSource = s.GetInfo();
        }
    }
}
