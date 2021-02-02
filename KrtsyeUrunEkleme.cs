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
    public partial class KrtsyeUrunEkleme : Form
    {
        int urunıd;
        string urunturu;
        string renk;
        int stok;

        public int Urunıd { get => urunıd; set => urunıd = value; }
        public string Urunturu { get => urunturu; set => urunturu = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Stok { get => stok; set => stok = value; }

        public KrtsyeUrunEkleme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int urunıd = int.Parse(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string urunturu = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string renk = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int stok = int.Parse(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urunıd<=30)
            {
                Console.WriteLine("Bu ID zaten kullanılmış! Lütfen farklı bir ID giriniz.");
            }

            //if (urunturu!="Defter" || "Kalem" || "Silgi" || "Uç" || "Kalem Kutusu" || "Çanta")
            //{
            //    Console.WriteLine("Girdiğiniz ürün türü eklenememektedir! Lütfen farklı bir ürün türü giriniz.");
            //}
        
        
        
        }
    }
}
