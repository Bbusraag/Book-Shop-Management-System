namespace BookShopManagement1
{
    partial class KullanıcıHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profiliGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridviewkullanıcı = new System.Windows.Forms.DataGridView();
            this.tbAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewkullanıcı)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.openToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarıGörüntüleToolStripMenuItem,
            this.profiliGörüntüleToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            this.kullanıcıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıToolStripMenuItem_Click);
            // 
            // kullanıcılarıGörüntüleToolStripMenuItem
            // 
            this.kullanıcılarıGörüntüleToolStripMenuItem.Name = "kullanıcılarıGörüntüleToolStripMenuItem";
            this.kullanıcılarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.kullanıcılarıGörüntüleToolStripMenuItem.Text = "Kullanıcıları Görüntüle";
            this.kullanıcılarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıGörüntüleToolStripMenuItem_Click);
            // 
            // profiliGörüntüleToolStripMenuItem
            // 
            this.profiliGörüntüleToolStripMenuItem.Name = "profiliGörüntüleToolStripMenuItem";
            this.profiliGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.profiliGörüntüleToolStripMenuItem.Text = "Profili Görüntüle";
            // 
            // datagridviewkullanıcı
            // 
            this.datagridviewkullanıcı.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridviewkullanıcı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewkullanıcı.GridColor = System.Drawing.SystemColors.Control;
            this.datagridviewkullanıcı.Location = new System.Drawing.Point(0, 102);
            this.datagridviewkullanıcı.Name = "datagridviewkullanıcı";
            this.datagridviewkullanıcı.Size = new System.Drawing.Size(788, 336);
            this.datagridviewkullanıcı.TabIndex = 1;
            this.datagridviewkullanıcı.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewkullanıcı_CellContentClick);
            // 
            // tbAra
            // 
            this.tbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tbAra.Location = new System.Drawing.Point(0, 64);
            this.tbAra.Name = "tbAra";
            this.tbAra.Size = new System.Drawing.Size(442, 32);
            this.tbAra.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(457, 64);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 32);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(677, 64);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 32);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(566, 64);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(93, 32);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullanıcıHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.tbAra);
            this.Controls.Add(this.datagridviewkullanıcı);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KullanıcıHome";
            this.Text = "KullanıcıHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewkullanıcı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.DataGridView datagridviewkullanıcı;
        private System.Windows.Forms.TextBox tbAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ToolStripMenuItem profiliGörüntüleToolStripMenuItem;
        private System.Windows.Forms.Button btnguncelle;
    }
}