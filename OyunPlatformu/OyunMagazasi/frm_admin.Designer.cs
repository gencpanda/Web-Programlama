namespace OyunMagazasi
{
    partial class frm_admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_magaza = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.tb_ekle = new System.Windows.Forms.TextBox();
            this.tb_guncelle = new System.Windows.Forms.TextBox();
            this.lbl_oyunadi = new System.Windows.Forms.Label();
            this.lbl_guncelle_uyari = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_fantastik = new System.Windows.Forms.CheckBox();
            this.cb_fps = new System.Windows.Forms.CheckBox();
            this.cb_yaris = new System.Windows.Forms.CheckBox();
            this.cb_korku = new System.Windows.Forms.CheckBox();
            this.cb_macera = new System.Windows.Forms.CheckBox();
            this.cb_acikdunya = new System.Windows.Forms.CheckBox();
            this.cb_strateji = new System.Windows.Forms.CheckBox();
            this.cb_aksiyon = new System.Windows.Forms.CheckBox();
            this.combo_yapimci = new System.Windows.Forms.ComboBox();
            this.btn_yapimciEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_toplamoyun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magaza)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMİN PANELİ";
            // 
            // dgv_magaza
            // 
            this.dgv_magaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_magaza.Location = new System.Drawing.Point(11, 112);
            this.dgv_magaza.Name = "dgv_magaza";
            this.dgv_magaza.Size = new System.Drawing.Size(251, 305);
            this.dgv_magaza.TabIndex = 1;
            this.dgv_magaza.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_magaza_CellClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.Location = new System.Drawing.Point(6, 39);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(175, 47);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Crimson;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Location = new System.Drawing.Point(277, 391);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(175, 47);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.DimGray;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Location = new System.Drawing.Point(277, 331);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(175, 47);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secilen.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_secilen.Location = new System.Drawing.Point(173, 59);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(0, 21);
            this.lbl_secilen.TabIndex = 4;
            // 
            // tb_ekle
            // 
            this.tb_ekle.Location = new System.Drawing.Point(187, 39);
            this.tb_ekle.Name = "tb_ekle";
            this.tb_ekle.Size = new System.Drawing.Size(212, 21);
            this.tb_ekle.TabIndex = 5;
            // 
            // tb_guncelle
            // 
            this.tb_guncelle.Location = new System.Drawing.Point(458, 346);
            this.tb_guncelle.Name = "tb_guncelle";
            this.tb_guncelle.Size = new System.Drawing.Size(212, 20);
            this.tb_guncelle.TabIndex = 5;
            // 
            // lbl_oyunadi
            // 
            this.lbl_oyunadi.AutoSize = true;
            this.lbl_oyunadi.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oyunadi.Location = new System.Drawing.Point(12, 59);
            this.lbl_oyunadi.Name = "lbl_oyunadi";
            this.lbl_oyunadi.Size = new System.Drawing.Size(144, 19);
            this.lbl_oyunadi.TabIndex = 6;
            this.lbl_oyunadi.Text = "Seçilen Oyun Adı :";
            // 
            // lbl_guncelle_uyari
            // 
            this.lbl_guncelle_uyari.AutoSize = true;
            this.lbl_guncelle_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_guncelle_uyari.ForeColor = System.Drawing.Color.Red;
            this.lbl_guncelle_uyari.Location = new System.Drawing.Point(689, 353);
            this.lbl_guncelle_uyari.Name = "lbl_guncelle_uyari";
            this.lbl_guncelle_uyari.Size = new System.Drawing.Size(0, 13);
            this.lbl_guncelle_uyari.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cb_fantastik);
            this.groupBox1.Controls.Add(this.cb_fps);
            this.groupBox1.Controls.Add(this.cb_yaris);
            this.groupBox1.Controls.Add(this.cb_korku);
            this.groupBox1.Controls.Add(this.cb_macera);
            this.groupBox1.Controls.Add(this.cb_acikdunya);
            this.groupBox1.Controls.Add(this.cb_strateji);
            this.groupBox1.Controls.Add(this.cb_aksiyon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(187, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori";
            // 
            // cb_fantastik
            // 
            this.cb_fantastik.AutoSize = true;
            this.cb_fantastik.Location = new System.Drawing.Point(10, 68);
            this.cb_fantastik.Name = "cb_fantastik";
            this.cb_fantastik.Size = new System.Drawing.Size(84, 19);
            this.cb_fantastik.TabIndex = 0;
            this.cb_fantastik.Text = "Fantastik";
            this.cb_fantastik.UseVisualStyleBackColor = true;
            // 
            // cb_fps
            // 
            this.cb_fps.AutoSize = true;
            this.cb_fps.Location = new System.Drawing.Point(10, 92);
            this.cb_fps.Name = "cb_fps";
            this.cb_fps.Size = new System.Drawing.Size(52, 19);
            this.cb_fps.TabIndex = 0;
            this.cb_fps.Text = "FPS";
            this.cb_fps.UseVisualStyleBackColor = true;
            // 
            // cb_yaris
            // 
            this.cb_yaris.AutoSize = true;
            this.cb_yaris.Location = new System.Drawing.Point(10, 43);
            this.cb_yaris.Name = "cb_yaris";
            this.cb_yaris.Size = new System.Drawing.Size(58, 19);
            this.cb_yaris.TabIndex = 0;
            this.cb_yaris.Text = "Yarış";
            this.cb_yaris.UseVisualStyleBackColor = true;
            // 
            // cb_korku
            // 
            this.cb_korku.AutoSize = true;
            this.cb_korku.Location = new System.Drawing.Point(100, 92);
            this.cb_korku.Name = "cb_korku";
            this.cb_korku.Size = new System.Drawing.Size(63, 19);
            this.cb_korku.TabIndex = 0;
            this.cb_korku.Text = "Korku";
            this.cb_korku.UseVisualStyleBackColor = true;
            // 
            // cb_macera
            // 
            this.cb_macera.AutoSize = true;
            this.cb_macera.Location = new System.Drawing.Point(100, 68);
            this.cb_macera.Name = "cb_macera";
            this.cb_macera.Size = new System.Drawing.Size(74, 19);
            this.cb_macera.TabIndex = 0;
            this.cb_macera.Text = "Macera";
            this.cb_macera.UseVisualStyleBackColor = true;
            // 
            // cb_acikdunya
            // 
            this.cb_acikdunya.AutoSize = true;
            this.cb_acikdunya.Location = new System.Drawing.Point(100, 43);
            this.cb_acikdunya.Name = "cb_acikdunya";
            this.cb_acikdunya.Size = new System.Drawing.Size(96, 19);
            this.cb_acikdunya.TabIndex = 0;
            this.cb_acikdunya.Text = "Açık Dünya";
            this.cb_acikdunya.UseVisualStyleBackColor = true;
            // 
            // cb_strateji
            // 
            this.cb_strateji.AutoSize = true;
            this.cb_strateji.Location = new System.Drawing.Point(100, 15);
            this.cb_strateji.Name = "cb_strateji";
            this.cb_strateji.Size = new System.Drawing.Size(72, 19);
            this.cb_strateji.TabIndex = 0;
            this.cb_strateji.Text = "Strateji";
            this.cb_strateji.UseVisualStyleBackColor = true;
            // 
            // cb_aksiyon
            // 
            this.cb_aksiyon.AutoSize = true;
            this.cb_aksiyon.Location = new System.Drawing.Point(10, 18);
            this.cb_aksiyon.Name = "cb_aksiyon";
            this.cb_aksiyon.Size = new System.Drawing.Size(74, 19);
            this.cb_aksiyon.TabIndex = 0;
            this.cb_aksiyon.Text = "Aksiyon";
            this.cb_aksiyon.UseVisualStyleBackColor = true;
            // 
            // combo_yapimci
            // 
            this.combo_yapimci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_yapimci.FormattingEnabled = true;
            this.combo_yapimci.Location = new System.Drawing.Point(415, 38);
            this.combo_yapimci.Name = "combo_yapimci";
            this.combo_yapimci.Size = new System.Drawing.Size(169, 23);
            this.combo_yapimci.TabIndex = 9;
            // 
            // btn_yapimciEkle
            // 
            this.btn_yapimciEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btn_yapimciEkle.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yapimciEkle.Location = new System.Drawing.Point(8, 95);
            this.btn_yapimciEkle.Name = "btn_yapimciEkle";
            this.btn_yapimciEkle.Size = new System.Drawing.Size(172, 38);
            this.btn_yapimciEkle.TabIndex = 10;
            this.btn_yapimciEkle.Text = "Yapımcı Ekle";
            this.btn_yapimciEkle.UseVisualStyleBackColor = false;
            this.btn_yapimciEkle.Click += new System.EventHandler(this.btn_yapimciEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oyun Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(412, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yapımcı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_fiyat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_yapimciEkle);
            this.groupBox2.Controls.Add(this.combo_yapimci);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tb_ekle);
            this.groupBox2.Controls.Add(this.btn_ekle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(277, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 193);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyun Ekle,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(458, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Oyun Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toplam Oyun Sayısı :";
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(455, 106);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(71, 21);
            this.tb_fiyat.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(412, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiyat";
            // 
            // lbl_toplamoyun
            // 
            this.lbl_toplamoyun.AutoSize = true;
            this.lbl_toplamoyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamoyun.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_toplamoyun.Location = new System.Drawing.Point(169, 91);
            this.lbl_toplamoyun.Name = "lbl_toplamoyun";
            this.lbl_toplamoyun.Size = new System.Drawing.Size(0, 15);
            this.lbl_toplamoyun.TabIndex = 13;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 443);
            this.Controls.Add(this.lbl_toplamoyun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_guncelle_uyari);
            this.Controls.Add(this.lbl_oyunadi);
            this.Controls.Add(this.tb_guncelle);
            this.Controls.Add(this.lbl_secilen);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.dgv_magaza);
            this.Controls.Add(this.label1);
            this.Name = "frm_admin";
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magaza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_magaza;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.TextBox tb_ekle;
        private System.Windows.Forms.TextBox tb_guncelle;
        private System.Windows.Forms.Label lbl_oyunadi;
        private System.Windows.Forms.Label lbl_guncelle_uyari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_fps;
        private System.Windows.Forms.CheckBox cb_yaris;
        private System.Windows.Forms.CheckBox cb_strateji;
        private System.Windows.Forms.CheckBox cb_aksiyon;
        private System.Windows.Forms.CheckBox cb_fantastik;
        private System.Windows.Forms.CheckBox cb_korku;
        private System.Windows.Forms.CheckBox cb_macera;
        private System.Windows.Forms.CheckBox cb_acikdunya;
        private System.Windows.Forms.ComboBox combo_yapimci;
        private System.Windows.Forms.Button btn_yapimciEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_toplamoyun;
    }
}