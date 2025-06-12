
namespace KutuphaneSistem
{
    partial class KitapIslem
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridKitap = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.btnKtpKaydet = new System.Windows.Forms.Button();
            this.btnKtpGuncelleme = new System.Windows.Forms.Button();
            this.btnKtpSilme = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnYazar = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnBilgiIslem = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnTur);
            this.panel1.Controls.Add(this.btnYazar);
            this.panel1.Controls.Add(this.btnOgrenci);
            this.panel1.Controls.Add(this.btnBilgiIslem);
            this.panel1.Controls.Add(this.btnKitap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 485);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "KÜTÜPHANE ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 100);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(245, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap İşlemleri";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(189, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 100);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridKitap
            // 
            this.dataGridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitap.Location = new System.Drawing.Point(457, 146);
            this.dataGridKitap.Name = "dataGridKitap";
            this.dataGridKitap.Size = new System.Drawing.Size(403, 280);
            this.dataGridKitap.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label6.Location = new System.Drawing.Point(28, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kitap Adı:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yazar Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 11F);
            this.label7.Location = new System.Drawing.Point(17, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKitapAd.Location = new System.Drawing.Point(131, 23);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAd.TabIndex = 7;
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtYazarSoyad.Location = new System.Drawing.Point(131, 49);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtYazarSoyad.TabIndex = 7;
            // 
            // txtTur
            // 
            this.txtTur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTur.Location = new System.Drawing.Point(131, 75);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 20);
            this.txtTur.TabIndex = 7;
            // 
            // btnKtpKaydet
            // 
            this.btnKtpKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnKtpKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKtpKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKtpKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKtpKaydet.Location = new System.Drawing.Point(21, 169);
            this.btnKtpKaydet.Name = "btnKtpKaydet";
            this.btnKtpKaydet.Size = new System.Drawing.Size(201, 33);
            this.btnKtpKaydet.TabIndex = 8;
            this.btnKtpKaydet.Text = "Kaydet";
            this.btnKtpKaydet.UseVisualStyleBackColor = false;
            // 
            // btnKtpGuncelleme
            // 
            this.btnKtpGuncelleme.BackColor = System.Drawing.Color.DarkGray;
            this.btnKtpGuncelleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKtpGuncelleme.Location = new System.Drawing.Point(21, 208);
            this.btnKtpGuncelleme.Name = "btnKtpGuncelleme";
            this.btnKtpGuncelleme.Size = new System.Drawing.Size(95, 39);
            this.btnKtpGuncelleme.TabIndex = 8;
            this.btnKtpGuncelleme.Text = "Güncelle";
            this.btnKtpGuncelleme.UseVisualStyleBackColor = false;
            // 
            // btnKtpSilme
            // 
            this.btnKtpSilme.BackColor = System.Drawing.Color.DarkGray;
            this.btnKtpSilme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKtpSilme.Location = new System.Drawing.Point(122, 208);
            this.btnKtpSilme.Name = "btnKtpSilme";
            this.btnKtpSilme.Size = new System.Drawing.Size(100, 39);
            this.btnKtpSilme.TabIndex = 8;
            this.btnKtpSilme.Text = "Sil";
            this.btnKtpSilme.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.txtSayfa);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnKtpSilme);
            this.panel4.Controls.Add(this.btnKtpGuncelleme);
            this.panel4.Controls.Add(this.btnKtpKaydet);
            this.panel4.Controls.Add(this.txtTur);
            this.panel4.Controls.Add(this.txtYazarSoyad);
            this.panel4.Controls.Add(this.txtKitapAd);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(207, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 280);
            this.panel4.TabIndex = 13;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(131, 107);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(100, 20);
            this.txtSayfa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(63, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tür:";
            // 
            // btnTur
            // 
            this.btnTur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTur.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTur.ForeColor = System.Drawing.Color.Silver;
            this.btnTur.Location = new System.Drawing.Point(0, 408);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(189, 58);
            this.btnTur.TabIndex = 6;
            this.btnTur.Text = "Tür";
            this.btnTur.UseVisualStyleBackColor = true;
            // 
            // btnYazar
            // 
            this.btnYazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazar.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazar.ForeColor = System.Drawing.Color.Silver;
            this.btnYazar.Location = new System.Drawing.Point(0, 344);
            this.btnYazar.Name = "btnYazar";
            this.btnYazar.Size = new System.Drawing.Size(189, 58);
            this.btnYazar.TabIndex = 7;
            this.btnYazar.Text = "Yazar";
            this.btnYazar.UseVisualStyleBackColor = true;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenci.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenci.ForeColor = System.Drawing.Color.Silver;
            this.btnOgrenci.Location = new System.Drawing.Point(0, 210);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(189, 61);
            this.btnOgrenci.TabIndex = 8;
            this.btnOgrenci.Text = "Öğrenci ";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            // 
            // btnBilgiIslem
            // 
            this.btnBilgiIslem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBilgiIslem.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilgiIslem.ForeColor = System.Drawing.Color.Silver;
            this.btnBilgiIslem.Location = new System.Drawing.Point(0, 146);
            this.btnBilgiIslem.Name = "btnBilgiIslem";
            this.btnBilgiIslem.Size = new System.Drawing.Size(189, 58);
            this.btnBilgiIslem.TabIndex = 9;
            this.btnBilgiIslem.Text = "Bilgi İslem";
            this.btnBilgiIslem.UseVisualStyleBackColor = true;
            // 
            // btnKitap
            // 
            this.btnKitap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitap.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitap.ForeColor = System.Drawing.Color.Silver;
            this.btnKitap.Location = new System.Drawing.Point(0, 277);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(189, 61);
            this.btnKitap.TabIndex = 10;
            this.btnKitap.Text = "Kitap";
            this.btnKitap.UseVisualStyleBackColor = false;
            // 
            // KitapIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(872, 485);
            this.Controls.Add(this.dataGridKitap);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KitapIslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridKitap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Button btnKtpKaydet;
        private System.Windows.Forms.Button btnKtpGuncelleme;
        private System.Windows.Forms.Button btnKtpSilme;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnYazar;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnBilgiIslem;
        private System.Windows.Forms.Button btnKitap;
    }
}

