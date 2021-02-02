namespace BookShopManagement1.Forms
{
    partial class Sepet
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
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblürünid = new System.Windows.Forms.Label();
            this.lblürüntürü = new System.Windows.Forms.Label();
            this.lblrenk = new System.Windows.Forms.Label();
            this.lblstok = new System.Windows.Forms.Label();
            this.tbürünid = new System.Windows.Forms.TextBox();
            this.tbürünfiyatı = new System.Windows.Forms.TextBox();
            this.tbürünadeti = new System.Windows.Forms.TextBox();
            this.tbbanka = new System.Windows.Forms.TextBox();
            this.tbkartno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngoster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.Location = new System.Drawing.Point(16, 216);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(143, 20);
            this.lblfiyat.TabIndex = 0;
            this.lblfiyat.Text = "KREDİ KARTI NO";
            this.lblfiyat.Click += new System.EventHandler(this.lblfiyat_Click);
            // 
            // lblürünid
            // 
            this.lblürünid.AutoSize = true;
            this.lblürünid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblürünid.Location = new System.Drawing.Point(80, 68);
            this.lblürünid.Name = "lblürünid";
            this.lblürünid.Size = new System.Drawing.Size(79, 20);
            this.lblürünid.TabIndex = 4;
            this.lblürünid.Text = "ÜRÜN ID";
            // 
            // lblürüntürü
            // 
            this.lblürüntürü.AutoSize = true;
            this.lblürüntürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblürüntürü.Location = new System.Drawing.Point(48, 105);
            this.lblürüntürü.Name = "lblürüntürü";
            this.lblürüntürü.Size = new System.Drawing.Size(111, 20);
            this.lblürüntürü.TabIndex = 5;
            this.lblürüntürü.Text = "ÜRÜN FİYATI";
            // 
            // lblrenk
            // 
            this.lblrenk.AutoSize = true;
            this.lblrenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrenk.Location = new System.Drawing.Point(93, 179);
            this.lblrenk.Name = "lblrenk";
            this.lblrenk.Size = new System.Drawing.Size(66, 20);
            this.lblrenk.TabIndex = 6;
            this.lblrenk.Text = "BANKA";
            // 
            // lblstok
            // 
            this.lblstok.AutoSize = true;
            this.lblstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstok.Location = new System.Drawing.Point(48, 142);
            this.lblstok.Name = "lblstok";
            this.lblstok.Size = new System.Drawing.Size(111, 20);
            this.lblstok.TabIndex = 7;
            this.lblstok.Text = "ÜRÜN ADETİ";
            // 
            // tbürünid
            // 
            this.tbürünid.Location = new System.Drawing.Point(167, 68);
            this.tbürünid.Name = "tbürünid";
            this.tbürünid.Size = new System.Drawing.Size(100, 20);
            this.tbürünid.TabIndex = 8;
            // 
            // tbürünfiyatı
            // 
            this.tbürünfiyatı.Location = new System.Drawing.Point(167, 105);
            this.tbürünfiyatı.Name = "tbürünfiyatı";
            this.tbürünfiyatı.Size = new System.Drawing.Size(100, 20);
            this.tbürünfiyatı.TabIndex = 9;
            // 
            // tbürünadeti
            // 
            this.tbürünadeti.Location = new System.Drawing.Point(167, 142);
            this.tbürünadeti.Name = "tbürünadeti";
            this.tbürünadeti.Size = new System.Drawing.Size(100, 20);
            this.tbürünadeti.TabIndex = 10;
            // 
            // tbbanka
            // 
            this.tbbanka.Location = new System.Drawing.Point(167, 179);
            this.tbbanka.Name = "tbbanka";
            this.tbbanka.Size = new System.Drawing.Size(100, 20);
            this.tbbanka.TabIndex = 11;
            // 
            // tbkartno
            // 
            this.tbkartno.Location = new System.Drawing.Point(167, 216);
            this.tbkartno.Name = "tbkartno";
            this.tbkartno.Size = new System.Drawing.Size(100, 20);
            this.tbkartno.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 279);
            this.dataGridView1.TabIndex = 16;
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(314, 39);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(75, 23);
            this.btngoster.TabIndex = 17;
            this.btngoster.Text = "Göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Öde";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(84, 23);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 13);
            this.lblmessage.TabIndex = 19;
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbkartno);
            this.Controls.Add(this.tbbanka);
            this.Controls.Add(this.tbürünadeti);
            this.Controls.Add(this.tbürünfiyatı);
            this.Controls.Add(this.tbürünid);
            this.Controls.Add(this.lblstok);
            this.Controls.Add(this.lblrenk);
            this.Controls.Add(this.lblürüntürü);
            this.Controls.Add(this.lblürünid);
            this.Controls.Add(this.lblfiyat);
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblürünid;
        private System.Windows.Forms.Label lblürüntürü;
        private System.Windows.Forms.Label lblrenk;
        private System.Windows.Forms.Label lblstok;
        private System.Windows.Forms.TextBox tbürünid;
        private System.Windows.Forms.TextBox tbürünfiyatı;
        private System.Windows.Forms.TextBox tbürünadeti;
        private System.Windows.Forms.TextBox tbbanka;
        private System.Windows.Forms.TextBox tbkartno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblmessage;
    }
}