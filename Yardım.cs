using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement1.modelBook;

namespace BookShopManagement1
{
    public partial class Yardım : Form
    {
        public Yardım()
        {
            InitializeComponent();
        }

        private void yardımlarıGöserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassYardım y = new ClassYardım();
            //datagridview.DataSource = y.GetYardım();
        }

        

        private void btnara_Click(object sender, EventArgs e)
        {
            Yardım y = new Yardım();
           // datagridview.DataSource = y.GetÜYEByOLMAK(tbarama.Text.Trim());
         
            
        }

        

        private void Yardım_Load(object sender, EventArgs e)
        {

        }
    }
}
