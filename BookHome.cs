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
    public partial class BookHome : Form
    {
        public BookHome()
        {
            InitializeComponent();
        }
        private void kitaplarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            dataGridViewBook.DataSource = b.GetBook();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            dataGridViewBook.DataSource = b.GetBookByname(btnAra.Text.Trim());
        }

        private void btnSil_Click(object sender, EventArgs e)

        {

            tbAuthor.Text = "";
            tbBookID.Text = "";
            tbBookName.Text = "";
            tbBooktype.Text = "";
            tbNumberOfPage.Text = "";
            tbPrice.Text = "";
            tbStock.Text = "";
           

        }
 /*int ID = int.Parse(tbBookName.Text.Trim());
            Book b = new Book();
            var result = b.Delete(ID);
            if (result > 0)
            {
                MessageBox.Show("Silindi.");
            }
            else
            {
                MessageBox.Show("Silinmedi.");
            }
        }*/

            private void btnGüncelle_Click(object sender, EventArgs e)
            {

            }

            private void bookToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }

