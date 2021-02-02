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
    public partial class Kırtasiye : Form
    {
        private int ıd;

        public Kırtasiye()
        {
            InitializeComponent();
        }

        private void defterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KrtsyeUrunEkleme kue = new KrtsyeUrunEkleme();
            kue.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Krtsye k = new Krtsye();
            dataGridViewKirtasiye.DataSource = k.GetProduct();

        }

        private void Kırtasiye_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Krtsye k = new Krtsye();
            dataGridViewKirtasiye.DataSource = k.GetProductByType(tbarama.Text.Trim());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int urunıd = int.Parse(tbId.Text.Trim());
            string urunturu = tbtur.Text.Trim();
            string urunrenk = tbrenk.Text.Trim();
            int stok = int.Parse(nudstok.Text.Trim());

            Krtsye k = new Krtsye();
            var result = k.AddProduct(urunıd,urunturu,stok,urunrenk);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Krtsye k = new Krtsye();
            k.Delete(ıd);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Krtsye k = new Krtsye();
                var result = k.UpdateKrtsy(tbId,tbtur.Text,nudstok,tbrenk.Text);
                if (int result>0)
                {
                    lblmsgbox.Text="updated is succesfully";
                    lblmsgbox.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblmsgbox.Text = ex.Message;
                lblmsgbox.ForeColor = Color.Red;

                
            }
        }
    }
}
