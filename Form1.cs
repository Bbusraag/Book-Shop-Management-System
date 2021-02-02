using BookShopManagement1.Forms;
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
using System.Data.SQLite;

namespace BookShopManagement1
{
    public partial class Form1 : Form
    {
        btnregister r = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                r = new btnregister();
            }

            r.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string email = tbemail.Text.Trim();
            string password = tbpassword.Text.Trim();
            Kullanıcı k = new Kullanıcı();
           
            if (k.LogIn(email, password))
            {
                using (GöstergePaneli gp = new GöstergePaneli())
                {

                    gp.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Yanlış email veya şifre girdiniz.");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            r = null;
        }
    }
}
