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
    public partial class GöstergePaneli : Form
    {
        int panelgenisligi;
        bool iscollapsed;
        public GöstergePaneli()
        {
            InitializeComponent();

            timerzaman.Start();
            panelgenisligi = pnlsol.Width;
            iscollapsed = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnhediyekart);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                pnlsol.Width = pnlsol.Width + 10;
                if (pnlsol.Width >= panelgenisligi)
                {
                    timer1.Stop();
                    iscollapsed = false;
                    this.Refresh();

                }
            }
            else
            {
                pnlsol.Width = pnlsol.Width - 10;
                if (pnlsol.Width <= 49)
                {
                    timer1.Stop();
                    iscollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            pnlside.Top = btn.Top;
            pnlside.Height = btn.Height;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnkitaplar);
            BookHome b = new BookHome();
            b.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnanasayfa);
        }

        private void btnindirim_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnindirim);
        }

        private void btnkırtasiye_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnkırtasiye);
            Kırtasiye kirtasiye = new Kırtasiye();
            kirtasiye.ShowDialog();
        }

        private void btnyardım_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnyardım);
        }

        private void btnanket_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnanket);
            anket a = new anket();
            a.ShowDialog();
        }

        private void timerzaman_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblsaat.Text = dt.ToString("HH:MM:ss");

        }

        private void lblsaat_Click(object sender, EventArgs e)
        {

        }

        private void btnkullanıcı_Click(object sender, EventArgs e)
        {
            KullanıcıHome kh = new KullanıcıHome();
            ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calisanlar c = new calisanlar();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }
    }
}
