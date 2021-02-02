namespace BookShopManagement1
{
    partial class Yardım
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardım));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb6 = new System.Windows.Forms.ComboBox();
            this.cb10 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üYEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımlarıGöserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb7 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.cb9 = new System.Windows.Forms.ComboBox();
            this.cb8 = new System.Windows.Forms.ComboBox();
            this.cb11 = new System.Windows.Forms.ComboBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Log ın kısmına girip ",
            "bilgilerinizi girdikten sonra",
            "üye olabilirsiniz"});
            this.cb1.Location = new System.Drawing.Point(0, 39);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(219, 21);
            this.cb1.TabIndex = 1;
            this.cb1.Text = "ÜYE OLMAK";
            // 
            // cb6
            // 
            this.cb6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb6.FormattingEnabled = true;
            this.cb6.Items.AddRange(new object[] {
            "Ürünlerinizi sepete ekle butonuna tıklayarak",
            "sepetinize ekleyebilirsiniz "});
            this.cb6.Location = new System.Drawing.Point(0, 370);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(223, 21);
            this.cb6.TabIndex = 2;
            this.cb6.Text = "SİPARİŞ SEPETİ OLUŞTURMAK";
            // 
            // cb10
            // 
            this.cb10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb10.FormattingEnabled = true;
            this.cb10.Items.AddRange(new object[] {
            "Listenize 1 İle 15 arasında",
            "ürün girebilirsiniz  15\'den",
            "fazla girerseniz liste kabul etmiycektir"});
            this.cb10.Location = new System.Drawing.Point(502, 146);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(286, 21);
            this.cb10.TabIndex = 3;
            this.cb10.Text = "LİSTEME KAÇ ÜRÜN EKLEYEBİLİRİM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üYEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üYEToolStripMenuItem
            // 
            this.üYEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımlarıGöserToolStripMenuItem});
            this.üYEToolStripMenuItem.Name = "üYEToolStripMenuItem";
            this.üYEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.üYEToolStripMenuItem.Text = "ÜYE";
            // 
            // yardımlarıGöserToolStripMenuItem
            // 
            this.yardımlarıGöserToolStripMenuItem.Name = "yardımlarıGöserToolStripMenuItem";
            this.yardımlarıGöserToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yardımlarıGöserToolStripMenuItem.Text = "Yardımları göster";
            this.yardımlarıGöserToolStripMenuItem.Click += new System.EventHandler(this.yardımlarıGöserToolStripMenuItem_Click);
            // 
            // cb3
            // 
            this.cb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "sitemize girip istediğiniz ",
            "ürünün adını girerek bulabilirsiniz"});
            this.cb3.Location = new System.Drawing.Point(-4, 182);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(219, 21);
            this.cb3.TabIndex = 5;
            this.cb3.Text = "İSTEDİĞİM ESERİ NASIL BULABİLİRİM";
            // 
            // cb7
            // 
            this.cb7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb7.FormattingEnabled = true;
            this.cb7.Items.AddRange(new object[] {
            "KİTAP SARAYINA ÜYE OLMADAN SİPARİŞ VEREMEZSİNİZ.",
            "ÖNCELİKLE GİRİŞ KISMINDAN ÜYE OLUP DAHA SONRA ",
            "İSTEDİĞİNİZ ÜRÜNLERİ SEPETE EKLEYEBİLİRSİNİZ"});
            this.cb7.Location = new System.Drawing.Point(502, 39);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(286, 21);
            this.cb7.TabIndex = 6;
            this.cb7.Text = "ÜYE OLMADAN SİPARİŞ VEREBİLİR MİYİM";
            // 
            // cb2
            // 
            this.cb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Kitap listemiz roman hikaye",
            "deneme makale ve bilim kurgu",
            "türlerinden oluşmaktadır. sitemize ",
            "girip detaylı bir şekilde bakabilirsiniz"});
            this.cb2.Location = new System.Drawing.Point(-4, 104);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(219, 21);
            this.cb2.TabIndex = 7;
            this.cb2.Text = "KİTAP LİSTESİ NEDİR";
            // 
            // cb5
            // 
            this.cb5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb5.FormattingEnabled = true;
            this.cb5.Items.AddRange(new object[] {
            "Kitaplarımız genel olarak 100 ile 300 ",
            "sayfa arasındadır"});
            this.cb5.Location = new System.Drawing.Point(258, 39);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(223, 21);
            this.cb5.TabIndex = 8;
            this.cb5.Text = "KİTAPLAR KAÇ SAYFA";
            // 
            // cb4
            // 
            this.cb4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "Kitaplarımızın hepsi orijinal ve yeni baskıdır"});
            this.cb4.Location = new System.Drawing.Point(-4, 245);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(223, 21);
            this.cb4.TabIndex = 9;
            this.cb4.Text = "KİTAPLAR ORİJİNAL Mİ";
            // 
            // cb9
            // 
            this.cb9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb9.FormattingEnabled = true;
            this.cb9.Items.AddRange(new object[] {
            "Üye olduğunuz  zaman indirimli ürünlerimizden ",
            "ve indirimlerden yararlanabiliyorsunuz.",
            "üye olmadığınız durumlarda sitemize giriş ",
            "yapamıyorsunuz"});
            this.cb9.Location = new System.Drawing.Point(258, 245);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(223, 21);
            this.cb9.TabIndex = 11;
            this.cb9.Text = "ÜYELİĞİN AVANTAJLARI NELERDİR";
            // 
            // cb8
            // 
            this.cb8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb8.FormattingEnabled = true;
            this.cb8.Items.AddRange(new object[] {
            "Email:",
            "Busragkts@hotmail.com",
            "ebrarteke@hotmail.com",
            "emincelik@hotmail.com",
            "Tel:",
            "(0212) 213 90 20",
            "(+90) 05452482024"});
            this.cb8.Location = new System.Drawing.Point(258, 146);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(223, 21);
            this.cb8.TabIndex = 12;
            this.cb8.Text = "İLETİŞİM BİLGİLERİ";
            // 
            // cb11
            // 
            this.cb11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cb11.FormattingEnabled = true;
            this.cb11.Items.AddRange(new object[] {
            "Kitapyurdu size ait bilgileri (e-posta, fatura adresi, teslimat adresi vs.) ",
            "hiçbir şekilde üçüncü kişiler ile paylaşmaz."});
            this.cb11.Location = new System.Drawing.Point(502, 245);
            this.cb11.Name = "cb11";
            this.cb11.Size = new System.Drawing.Size(286, 21);
            this.cb11.TabIndex = 13;
            this.cb11.Text = "KİTAP SARAYININ ALIŞVERİŞ GÜVENCESİ NASIL";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // Yardım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb11);
            this.Controls.Add(this.cb8);
            this.Controls.Add(this.cb9);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb7);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb10);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Yardım";
            this.Text = " YARDIM";
            this.Load += new System.EventHandler(this.Yardım_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb6;
        private System.Windows.Forms.ComboBox cb10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üYEToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb7;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.ComboBox cb9;
        private System.Windows.Forms.ComboBox cb8;
        private System.Windows.Forms.ComboBox cb11;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.ToolStripMenuItem yardımlarıGöserToolStripMenuItem;
    }
}