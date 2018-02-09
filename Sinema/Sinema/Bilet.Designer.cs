namespace Sinema
{
    partial class Bilet
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
            this.Adsoyad = new System.Windows.Forms.Label();
            this.biletfiyat = new System.Windows.Forms.Label();
            this.tamsecim = new System.Windows.Forms.CheckBox();
            this.ogrencisecim = new System.Windows.Forms.CheckBox();
            this.ads = new System.Windows.Forms.TextBox();
            this.sayi = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.Label();
            this.fyt = new System.Windows.Forms.Label();
            this.ttr = new System.Windows.Forms.Label();
            this.Hesapla = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adsoyad
            // 
            this.Adsoyad.AutoSize = true;
            this.Adsoyad.Location = new System.Drawing.Point(9, 23);
            this.Adsoyad.Name = "Adsoyad";
            this.Adsoyad.Size = new System.Drawing.Size(63, 13);
            this.Adsoyad.TabIndex = 0;
            this.Adsoyad.Text = "Adı Soyadı :";
            // 
            // biletfiyat
            // 
            this.biletfiyat.AutoSize = true;
            this.biletfiyat.Location = new System.Drawing.Point(9, 76);
            this.biletfiyat.Name = "biletfiyat";
            this.biletfiyat.Size = new System.Drawing.Size(51, 13);
            this.biletfiyat.TabIndex = 1;
            this.biletfiyat.Text = "Bilet fiyatı";
            // 
            // tamsecim
            // 
            this.tamsecim.AutoSize = true;
            this.tamsecim.Location = new System.Drawing.Point(48, 46);
            this.tamsecim.Name = "tamsecim";
            this.tamsecim.Size = new System.Drawing.Size(47, 17);
            this.tamsecim.TabIndex = 2;
            this.tamsecim.Text = "Tam";
            this.tamsecim.UseVisualStyleBackColor = true;
            this.tamsecim.CheckedChanged += new System.EventHandler(this.tamsecim_CheckedChanged);
            // 
            // ogrencisecim
            // 
            this.ogrencisecim.AutoSize = true;
            this.ogrencisecim.Location = new System.Drawing.Point(110, 46);
            this.ogrencisecim.Name = "ogrencisecim";
            this.ogrencisecim.Size = new System.Drawing.Size(63, 17);
            this.ogrencisecim.TabIndex = 3;
            this.ogrencisecim.Text = "Öğrenci";
            this.ogrencisecim.UseVisualStyleBackColor = true;
            this.ogrencisecim.CheckedChanged += new System.EventHandler(this.ogrencisecim_CheckedChanged);
            // 
            // ads
            // 
            this.ads.Location = new System.Drawing.Point(78, 20);
            this.ads.Name = "ads";
            this.ads.Size = new System.Drawing.Size(100, 20);
            this.ads.TabIndex = 4;
            // 
            // sayi
            // 
            this.sayi.AutoSize = true;
            this.sayi.Location = new System.Drawing.Point(184, 27);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(10, 13);
            this.sayi.TabIndex = 6;
            this.sayi.Text = ".";
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Location = new System.Drawing.Point(7, 98);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(85, 13);
            this.tutar.TabIndex = 7;
            this.tutar.Text = "Ödenecek Tutar";
            // 
            // fyt
            // 
            this.fyt.AutoSize = true;
            this.fyt.Location = new System.Drawing.Point(82, 76);
            this.fyt.Name = "fyt";
            this.fyt.Size = new System.Drawing.Size(10, 13);
            this.fyt.TabIndex = 10;
            this.fyt.Text = "-";
            // 
            // ttr
            // 
            this.ttr.AutoSize = true;
            this.ttr.Location = new System.Drawing.Point(97, 98);
            this.ttr.Name = "ttr";
            this.ttr.Size = new System.Drawing.Size(10, 13);
            this.ttr.TabIndex = 11;
            this.ttr.Text = "-";
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(23, 159);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(100, 41);
            this.Hesapla.TabIndex = 12;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.kayit_Click);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(18, 248);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(89, 41);
            this.kayit.TabIndex = 14;
            this.kayit.Text = "Kaydet ve çık";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 166);
            this.dataGridView1.TabIndex = 15;
            // 
            // Bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.Hesapla);
            this.Controls.Add(this.ttr);
            this.Controls.Add(this.fyt);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.ads);
            this.Controls.Add(this.ogrencisecim);
            this.Controls.Add(this.tamsecim);
            this.Controls.Add(this.biletfiyat);
            this.Controls.Add(this.Adsoyad);
            this.Name = "Bilet";
            this.Text = "Bilet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adsoyad;
        private System.Windows.Forms.Label biletfiyat;
        private System.Windows.Forms.CheckBox tamsecim;
        private System.Windows.Forms.CheckBox ogrencisecim;
        private System.Windows.Forms.TextBox ads;
        private System.Windows.Forms.Label sayi;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Label fyt;
        private System.Windows.Forms.Label ttr;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}