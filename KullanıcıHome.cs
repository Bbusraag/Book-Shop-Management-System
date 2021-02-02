using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement1;
using BookShopManagement1.modelBook;

namespace BookShopManagement1
{
    public partial class KullanıcıHome : Form
    {
        public KullanıcıHome()
        {
            InitializeComponent();
        }

        private void kullanıcılarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanıcı k = new Kullanıcı();
            datagridviewkullanıcı.DataSource =  k.GetUser();


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Kullanıcı k = new Kullanıcı();
            datagridviewkullanıcı.DataSource = k.GetUserByName(tbAra.Text.Trim());
           // datagridviewkullanıcı.DataSource = k.GetUserByEmail(tbAra.Text.Trim());
           // datagridviewkullanıcı.DataSource = k.GetUserById(tbAra.Text.Trim());


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbAra.Text.Trim());
            Kullanıcı k = new Kullanıcı();
            var result = k.Delete(id);
            if (result > 0)
            {
                MessageBox.Show("Silindi.");'Giriş dizesi doğru biçimde değild
            }
            else
            {
                MessageBox.Show("Silinmedi.");
            }
        }

        private void datagridviewkullanıcı_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Kullanıcı k = new Kullanıcı();
           //datagridviewkullanıcı.DataSource = k.Update();
        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
