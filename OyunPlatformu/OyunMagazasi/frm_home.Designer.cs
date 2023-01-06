namespace OyunMagazasi
{
    partial class frm_home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_oyunlarim = new System.Windows.Forms.TabPage();
            this.btn_yorumekle = new System.Windows.Forms.Button();
            this.lbl_oyunlarim_secilen = new System.Windows.Forms.Label();
            this.lbl_oyunlarim_oyunadi = new System.Windows.Forms.Label();
            this.btn_oyunlarim_yenile = new System.Windows.Forms.Button();
            this.dgv_oyunlarim = new System.Windows.Forms.DataGridView();
            this.tab_magaza = new System.Windows.Forms.TabPage();
            this.btn_oyundetay = new System.Windows.Forms.Button();
            this.dgv_magaza = new System.Windows.Forms.DataGridView();
            this.btn_oyunal = new System.Windows.Forms.Button();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.lbl_coksatilanlar = new System.Windows.Forms.Label();
            this.tab_profil = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_iletisim_guncelle = new System.Windows.Forms.Button();
            this.rtb_iletisim_adres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_iletisim_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_profil = new System.Windows.Forms.GroupBox();
            this.btn_profil_guncelle = new System.Windows.Forms.Button();
            this.tb_profil_parola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_profil_kulAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_profil_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_profil_ad = new System.Windows.Forms.TextBox();
            this.lbl_gb_ad = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_bakiye = new System.Windows.Forms.TextBox();
            this.btn_hesapsil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_coksatilanlar = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_oyunlarim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oyunlarim)).BeginInit();
            this.tab_magaza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magaza)).BeginInit();
            this.tab_profil.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coksatilanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_oyunlarim);
            this.tabControl1.Controls.Add(this.tab_magaza);
            this.tabControl1.Controls.Add(this.tab_profil);
            this.tabControl1.Location = new System.Drawing.Point(5, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_oyunlarim
            // 
            this.tab_oyunlarim.Controls.Add(this.btn_yorumekle);
            this.tab_oyunlarim.Controls.Add(this.lbl_oyunlarim_secilen);
            this.tab_oyunlarim.Controls.Add(this.lbl_oyunlarim_oyunadi);
            this.tab_oyunlarim.Controls.Add(this.btn_oyunlarim_yenile);
            this.tab_oyunlarim.Controls.Add(this.dgv_oyunlarim);
            this.tab_oyunlarim.Location = new System.Drawing.Point(4, 22);
            this.tab_oyunlarim.Name = "tab_oyunlarim";
            this.tab_oyunlarim.Padding = new System.Windows.Forms.Padding(3);
            this.tab_oyunlarim.Size = new System.Drawing.Size(779, 291);
            this.tab_oyunlarim.TabIndex = 0;
            this.tab_oyunlarim.Text = "Oyunlarım";
            this.tab_oyunlarim.UseVisualStyleBackColor = true;
            this.tab_oyunlarim.Click += new System.EventHandler(this.tab_oyunlarim_Click);
            // 
            // btn_yorumekle
            // 
            this.btn_yorumekle.Location = new System.Drawing.Point(276, 177);
            this.btn_yorumekle.Name = "btn_yorumekle";
            this.btn_yorumekle.Size = new System.Drawing.Size(88, 36);
            this.btn_yorumekle.TabIndex = 5;
            this.btn_yorumekle.Text = "Yorum Ekle";
            this.btn_yorumekle.UseVisualStyleBackColor = true;
            this.btn_yorumekle.Click += new System.EventHandler(this.btn_yorumekle_Click);
            // 
            // lbl_oyunlarim_secilen
            // 
            this.lbl_oyunlarim_secilen.AutoSize = true;
            this.lbl_oyunlarim_secilen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oyunlarim_secilen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oyunlarim_secilen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_oyunlarim_secilen.Location = new System.Drawing.Point(125, 15);
            this.lbl_oyunlarim_secilen.Name = "lbl_oyunlarim_secilen";
            this.lbl_oyunlarim_secilen.Size = new System.Drawing.Size(0, 22);
            this.lbl_oyunlarim_secilen.TabIndex = 4;
            // 
            // lbl_oyunlarim_oyunadi
            // 
            this.lbl_oyunlarim_oyunadi.AutoSize = true;
            this.lbl_oyunlarim_oyunadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oyunlarim_oyunadi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oyunlarim_oyunadi.Location = new System.Drawing.Point(13, 15);
            this.lbl_oyunlarim_oyunadi.Name = "lbl_oyunlarim_oyunadi";
            this.lbl_oyunlarim_oyunadi.Size = new System.Drawing.Size(106, 19);
            this.lbl_oyunlarim_oyunadi.TabIndex = 3;
            this.lbl_oyunlarim_oyunadi.Text = "Seçilen Oyun : ";
            // 
            // btn_oyunlarim_yenile
            // 
            this.btn_oyunlarim_yenile.Location = new System.Drawing.Point(277, 227);
            this.btn_oyunlarim_yenile.Name = "btn_oyunlarim_yenile";
            this.btn_oyunlarim_yenile.Size = new System.Drawing.Size(88, 32);
            this.btn_oyunlarim_yenile.TabIndex = 1;
            this.btn_oyunlarim_yenile.Text = "Yenile";
            this.btn_oyunlarim_yenile.UseVisualStyleBackColor = true;
            this.btn_oyunlarim_yenile.Click += new System.EventHandler(this.btn_oyunlarim_yenile_Click);
            // 
            // dgv_oyunlarim
            // 
            this.dgv_oyunlarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_oyunlarim.Location = new System.Drawing.Point(17, 41);
            this.dgv_oyunlarim.Name = "dgv_oyunlarim";
            this.dgv_oyunlarim.Size = new System.Drawing.Size(240, 231);
            this.dgv_oyunlarim.TabIndex = 0;
            this.dgv_oyunlarim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_oyunlarim_CellClick);
            // 
            // tab_magaza
            // 
            this.tab_magaza.Controls.Add(this.dgv_coksatilanlar);
            this.tab_magaza.Controls.Add(this.btn_oyundetay);
            this.tab_magaza.Controls.Add(this.dgv_magaza);
            this.tab_magaza.Controls.Add(this.btn_oyunal);
            this.tab_magaza.Controls.Add(this.lbl_secilen);
            this.tab_magaza.Controls.Add(this.label5);
            this.tab_magaza.Controls.Add(this.lbl_coksatilanlar);
            this.tab_magaza.Location = new System.Drawing.Point(4, 22);
            this.tab_magaza.Name = "tab_magaza";
            this.tab_magaza.Padding = new System.Windows.Forms.Padding(3);
            this.tab_magaza.Size = new System.Drawing.Size(779, 291);
            this.tab_magaza.TabIndex = 1;
            this.tab_magaza.Text = "Mağaza";
            this.tab_magaza.UseVisualStyleBackColor = true;
            this.tab_magaza.Click += new System.EventHandler(this.tab_magaza_Click);
            // 
            // btn_oyundetay
            // 
            this.btn_oyundetay.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_oyundetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyundetay.ForeColor = System.Drawing.Color.Navy;
            this.btn_oyundetay.Location = new System.Drawing.Point(659, 235);
            this.btn_oyundetay.Name = "btn_oyundetay";
            this.btn_oyundetay.Size = new System.Drawing.Size(104, 42);
            this.btn_oyundetay.TabIndex = 6;
            this.btn_oyundetay.Text = "Oyun İncele";
            this.btn_oyundetay.UseVisualStyleBackColor = false;
            this.btn_oyundetay.Click += new System.EventHandler(this.btn_oyundetay_Click);
            // 
            // dgv_magaza
            // 
            this.dgv_magaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_magaza.Location = new System.Drawing.Point(15, 20);
            this.dgv_magaza.Name = "dgv_magaza";
            this.dgv_magaza.Size = new System.Drawing.Size(214, 257);
            this.dgv_magaza.TabIndex = 4;
            this.dgv_magaza.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_magaza_CellClick);
            // 
            // btn_oyunal
            // 
            this.btn_oyunal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_oyunal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunal.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_oyunal.Location = new System.Drawing.Point(550, 235);
            this.btn_oyunal.Name = "btn_oyunal";
            this.btn_oyunal.Size = new System.Drawing.Size(98, 42);
            this.btn_oyunal.TabIndex = 3;
            this.btn_oyunal.Text = "Oyunu Al";
            this.btn_oyunal.UseVisualStyleBackColor = false;
            this.btn_oyunal.Click += new System.EventHandler(this.btn_oyunal_Click);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_secilen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_secilen.Location = new System.Drawing.Point(372, 20);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(0, 22);
            this.lbl_secilen.TabIndex = 2;
            // 
            // lbl_coksatilanlar
            // 
            this.lbl_coksatilanlar.AutoSize = true;
            this.lbl_coksatilanlar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coksatilanlar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_coksatilanlar.Location = new System.Drawing.Point(248, 52);
            this.lbl_coksatilanlar.Name = "lbl_coksatilanlar";
            this.lbl_coksatilanlar.Size = new System.Drawing.Size(106, 19);
            this.lbl_coksatilanlar.TabIndex = 1;
            this.lbl_coksatilanlar.Text = "Çok Satılanlar:";
            // 
            // tab_profil
            // 
            this.tab_profil.Controls.Add(this.btn_hesapsil);
            this.tab_profil.Controls.Add(this.tb_bakiye);
            this.tab_profil.Controls.Add(this.button1);
            this.tab_profil.Controls.Add(this.lbl_bakiye);
            this.tab_profil.Controls.Add(this.label4);
            this.tab_profil.Controls.Add(this.groupBox1);
            this.tab_profil.Controls.Add(this.gb_profil);
            this.tab_profil.Location = new System.Drawing.Point(4, 22);
            this.tab_profil.Name = "tab_profil";
            this.tab_profil.Size = new System.Drawing.Size(779, 291);
            this.tab_profil.TabIndex = 3;
            this.tab_profil.Text = "Profil";
            this.tab_profil.UseVisualStyleBackColor = true;
            this.tab_profil.Click += new System.EventHandler(this.tab_profil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_iletisim_guncelle);
            this.groupBox1.Controls.Add(this.rtb_iletisim_adres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_iletisim_email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Location = new System.Drawing.Point(462, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İletişim";
            // 
            // btn_iletisim_guncelle
            // 
            this.btn_iletisim_guncelle.Location = new System.Drawing.Point(20, 161);
            this.btn_iletisim_guncelle.Name = "btn_iletisim_guncelle";
            this.btn_iletisim_guncelle.Size = new System.Drawing.Size(80, 23);
            this.btn_iletisim_guncelle.TabIndex = 4;
            this.btn_iletisim_guncelle.Text = "Güncelle";
            this.btn_iletisim_guncelle.UseVisualStyleBackColor = true;
            this.btn_iletisim_guncelle.Click += new System.EventHandler(this.btn_iletisim_guncelle_Click);
            // 
            // rtb_iletisim_adres
            // 
            this.rtb_iletisim_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_iletisim_adres.Location = new System.Drawing.Point(45, 80);
            this.rtb_iletisim_adres.Name = "rtb_iletisim_adres";
            this.rtb_iletisim_adres.Size = new System.Drawing.Size(227, 69);
            this.rtb_iletisim_adres.TabIndex = 3;
            this.rtb_iletisim_adres.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_iletisim_email
            // 
            this.tb_iletisim_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_iletisim_email.Location = new System.Drawing.Point(106, 31);
            this.tb_iletisim_email.Name = "tb_iletisim_email";
            this.tb_iletisim_email.Size = new System.Drawing.Size(166, 21);
            this.tb_iletisim_email.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Mail :";
            // 
            // gb_profil
            // 
            this.gb_profil.Controls.Add(this.btn_profil_guncelle);
            this.gb_profil.Controls.Add(this.tb_profil_parola);
            this.gb_profil.Controls.Add(this.label3);
            this.gb_profil.Controls.Add(this.tb_profil_kulAdi);
            this.gb_profil.Controls.Add(this.label2);
            this.gb_profil.Controls.Add(this.tb_profil_soyad);
            this.gb_profil.Controls.Add(this.label1);
            this.gb_profil.Controls.Add(this.tb_profil_ad);
            this.gb_profil.Controls.Add(this.lbl_gb_ad);
            this.gb_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_profil.ForeColor = System.Drawing.Color.Firebrick;
            this.gb_profil.Location = new System.Drawing.Point(3, 20);
            this.gb_profil.Name = "gb_profil";
            this.gb_profil.Size = new System.Drawing.Size(253, 227);
            this.gb_profil.TabIndex = 0;
            this.gb_profil.TabStop = false;
            this.gb_profil.Text = "Profil";
            // 
            // btn_profil_guncelle
            // 
            this.btn_profil_guncelle.Location = new System.Drawing.Point(10, 159);
            this.btn_profil_guncelle.Name = "btn_profil_guncelle";
            this.btn_profil_guncelle.Size = new System.Drawing.Size(90, 25);
            this.btn_profil_guncelle.TabIndex = 2;
            this.btn_profil_guncelle.Text = "Güncelle";
            this.btn_profil_guncelle.UseVisualStyleBackColor = true;
            this.btn_profil_guncelle.Click += new System.EventHandler(this.btn_profil_guncelle_Click);
            // 
            // tb_profil_parola
            // 
            this.tb_profil_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_profil_parola.Location = new System.Drawing.Point(106, 115);
            this.tb_profil_parola.Name = "tb_profil_parola";
            this.tb_profil_parola.Size = new System.Drawing.Size(141, 20);
            this.tb_profil_parola.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parola :";
            // 
            // tb_profil_kulAdi
            // 
            this.tb_profil_kulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_profil_kulAdi.Location = new System.Drawing.Point(106, 87);
            this.tb_profil_kulAdi.Name = "tb_profil_kulAdi";
            this.tb_profil_kulAdi.Size = new System.Drawing.Size(141, 20);
            this.tb_profil_kulAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // tb_profil_soyad
            // 
            this.tb_profil_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_profil_soyad.Location = new System.Drawing.Point(106, 59);
            this.tb_profil_soyad.Name = "tb_profil_soyad";
            this.tb_profil_soyad.Size = new System.Drawing.Size(141, 20);
            this.tb_profil_soyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soyad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_profil_ad
            // 
            this.tb_profil_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_profil_ad.Location = new System.Drawing.Point(106, 31);
            this.tb_profil_ad.Name = "tb_profil_ad";
            this.tb_profil_ad.Size = new System.Drawing.Size(141, 20);
            this.tb_profil_ad.TabIndex = 1;
            // 
            // lbl_gb_ad
            // 
            this.lbl_gb_ad.AutoSize = true;
            this.lbl_gb_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gb_ad.ForeColor = System.Drawing.Color.Black;
            this.lbl_gb_ad.Location = new System.Drawing.Point(69, 38);
            this.lbl_gb_ad.Name = "lbl_gb_ad";
            this.lbl_gb_ad.Size = new System.Drawing.Size(31, 15);
            this.lbl_gb_ad.TabIndex = 0;
            this.lbl_gb_ad.Text = "Ad :";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(698, 390);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(94, 31);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(258, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "BAKİYE($) :";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bakiye.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_bakiye.Location = new System.Drawing.Point(351, 29);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(0, 16);
            this.lbl_bakiye.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(262, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Para yükle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_bakiye
            // 
            this.tb_bakiye.Location = new System.Drawing.Point(333, 66);
            this.tb_bakiye.Name = "tb_bakiye";
            this.tb_bakiye.Size = new System.Drawing.Size(93, 20);
            this.tb_bakiye.TabIndex = 4;
            // 
            // btn_hesapsil
            // 
            this.btn_hesapsil.BackColor = System.Drawing.Color.Brown;
            this.btn_hesapsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapsil.Location = new System.Drawing.Point(279, 206);
            this.btn_hesapsil.Name = "btn_hesapsil";
            this.btn_hesapsil.Size = new System.Drawing.Size(146, 40);
            this.btn_hesapsil.TabIndex = 5;
            this.btn_hesapsil.Text = "Hesabı Sil";
            this.btn_hesapsil.UseVisualStyleBackColor = false;
            this.btn_hesapsil.Click += new System.EventHandler(this.btn_hesapsil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(248, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seçilen Oyun : ";
            // 
            // dgv_coksatilanlar
            // 
            this.dgv_coksatilanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coksatilanlar.Location = new System.Drawing.Point(254, 88);
            this.dgv_coksatilanlar.Name = "dgv_coksatilanlar";
            this.dgv_coksatilanlar.Size = new System.Drawing.Size(154, 188);
            this.dgv_coksatilanlar.TabIndex = 7;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 421);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_home";
            this.Text = "frm_home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_oyunlarim.ResumeLayout(false);
            this.tab_oyunlarim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oyunlarim)).EndInit();
            this.tab_magaza.ResumeLayout(false);
            this.tab_magaza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_magaza)).EndInit();
            this.tab_profil.ResumeLayout(false);
            this.tab_profil.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_profil.ResumeLayout(false);
            this.gb_profil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coksatilanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_oyunlarim;
        private System.Windows.Forms.TabPage tab_magaza;
        private System.Windows.Forms.DataGridView dgv_oyunlarim;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.Label lbl_coksatilanlar;
        private System.Windows.Forms.Button btn_oyunal;
        private System.Windows.Forms.Button btn_oyunlarim_yenile;
        private System.Windows.Forms.DataGridView dgv_magaza;
        private System.Windows.Forms.Label lbl_oyunlarim_secilen;
        private System.Windows.Forms.Label lbl_oyunlarim_oyunadi;
        private System.Windows.Forms.Button btn_yorumekle;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.TabPage tab_profil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_iletisim_adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_iletisim_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_profil;
        private System.Windows.Forms.Button btn_profil_guncelle;
        private System.Windows.Forms.TextBox tb_profil_parola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_profil_kulAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_profil_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_profil_ad;
        private System.Windows.Forms.Label lbl_gb_ad;
        private System.Windows.Forms.Button btn_iletisim_guncelle;
        private System.Windows.Forms.Button btn_oyundetay;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_bakiye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_hesapsil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_coksatilanlar;
    }
}