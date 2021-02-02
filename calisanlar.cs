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
    public partial class calisanlar : Form
    {
        public calisanlar()
        {
            InitializeComponent();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            Calisansnf c = new Calisansnf();
            dataGridViewCalisanlar.DataSource = c.GetEmployee();
        }
    }
}
