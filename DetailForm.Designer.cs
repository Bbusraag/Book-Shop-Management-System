namespace BookShopManagement1
{
    partial class DetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.btngncll = new System.Windows.Forms.Button();
            this.tbtur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tburunid = new System.Windows.Forms.TextBox();
            this.tbnudstok = new System.Windows.Forms.TextBox();
            this.tbfiyat = new System.Windows.Forms.TextBox();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngncll
            // 
            this.btngncll.Location = new System.Drawing.Point(182, 202);
            this.btngncll.Name = "btngncll";
            this.btngncll.Size = new System.Drawing.Size(101, 32);
            this.btngncll.TabIndex = 17;
            this.btngncll.Text = "Güncelle";
            this.btngncll.UseVisualStyleBackColor = true;
            this.btngncll.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtur
            // 
            this.tbtur.Location = new System.Drawing.Point(184, 78);
            this.tbtur.Name = "tbtur";
            this.tbtur.Size = new System.Drawing.Size(100, 20);
            this.tbtur.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(111, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Renk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // tburunid
            // 
            this.tburunid.Location = new System.Drawing.Point(183, 40);
            this.tburunid.Name = "tburunid";
            this.tburunid.Size = new System.Drawing.Size(100, 20);
            this.tburunid.TabIndex = 20;
            // 
            // tbnudstok
            // 
            this.tbnudstok.Location = new System.Drawing.Point(183, 143);
            this.tbnudstok.Name = "tbnudstok";
            this.tbnudstok.Size = new System.Drawing.Size(100, 20);
            this.tbnudstok.TabIndex = 21;
            // 
            // tbfiyat
            // 
            this.tbfiyat.Location = new System.Drawing.Point(184, 176);
            this.tbfiyat.Name = "tbfiyat";
            this.tbfiyat.Size = new System.Drawing.Size(100, 20);
            this.tbfiyat.TabIndex = 23;
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.Location = new System.Drawing.Point(108, 182);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(42, 16);
            this.lblfiyat.TabIndex = 22;
            this.lblfiyat.Text = "Fiyat";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbfiyat);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.tbnudstok);
            this.Controls.Add(this.tburunid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btngncll);
            this.Controls.Add(this.tbtur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ürünid;
        private System.Windows.Forms.Label ürüntürü;
        private System.Windows.Forms.Label ürünrenk;
        private System.Windows.Forms.Label ürünstok;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbtür;
        private System.Windows.Forms.TextBox tbrenk;
        private System.Windows.Forms.TextBox tbstok;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btngncll;
        private System.Windows.Forms.TextBox tbtur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tburunid;
        private System.Windows.Forms.TextBox tbnudstok;
        private System.Windows.Forms.TextBox tbfiyat;
        private System.Windows.Forms.Label lblfiyat;
    }
}