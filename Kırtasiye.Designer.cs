namespace BookShopManagement1
{
    partial class Kırtasiye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kırtasiye));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewKirtasiye = new System.Windows.Forms.DataGridView();
            this.tbarama = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbtur = new System.Windows.Forms.TextBox();
            this.tbrenk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nudstok = new System.Windows.Forms.NumericUpDown();
            this.lblmsgbox = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirtasiye)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(668, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ürün Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewKirtasiye
            // 
            this.dataGridViewKirtasiye.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewKirtasiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKirtasiye.Location = new System.Drawing.Point(41, 103);
            this.dataGridViewKirtasiye.Name = "dataGridViewKirtasiye";
            this.dataGridViewKirtasiye.Size = new System.Drawing.Size(735, 341);
            this.dataGridViewKirtasiye.TabIndex = 11;
            // 
            // tbarama
            // 
            this.tbarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbarama.Location = new System.Drawing.Point(41, 49);
            this.tbarama.Name = "tbarama";
            this.tbarama.Size = new System.Drawing.Size(519, 38);
            this.tbarama.TabIndex = 12;
            this.tbarama.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(566, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 49);
            this.button4.TabIndex = 13;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblmsgbox);
            this.groupBox1.Controls.Add(this.nudstok);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbrenk);
            this.groupBox1.Controls.Add(this.tbtur);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(772, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 341);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(87, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 23);
            this.tbId.TabIndex = 4;
            this.tbId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbtur
            // 
            this.tbtur.Location = new System.Drawing.Point(87, 75);
            this.tbtur.Name = "tbtur";
            this.tbtur.Size = new System.Drawing.Size(100, 23);
            this.tbtur.TabIndex = 5;
            // 
            // tbrenk
            // 
            this.tbrenk.Location = new System.Drawing.Point(87, 143);
            this.tbrenk.Name = "tbrenk";
            this.tbrenk.Size = new System.Drawing.Size(100, 23);
            this.tbrenk.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nudstok
            // 
            this.nudstok.Location = new System.Drawing.Point(87, 110);
            this.nudstok.Name = "nudstok";
            this.nudstok.Size = new System.Drawing.Size(100, 23);
            this.nudstok.TabIndex = 11;
            this.nudstok.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblmsgbox
            // 
            this.lblmsgbox.AutoSize = true;
            this.lblmsgbox.Location = new System.Drawing.Point(230, 40);
            this.lblmsgbox.Name = "lblmsgbox";
            this.lblmsgbox.Size = new System.Drawing.Size(0, 17);
            this.lblmsgbox.TabIndex = 12;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // Kırtasiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbarama);
            this.Controls.Add(this.dataGridViewKirtasiye);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kırtasiye";
            this.Text = "Kırtasiye";
            this.Load += new System.EventHandler(this.Kırtasiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirtasiye)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewKirtasiye;
        private System.Windows.Forms.TextBox tbarama;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbrenk;
        private System.Windows.Forms.TextBox tbtur;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudstok;
        private System.Windows.Forms.Label lblmsgbox;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}