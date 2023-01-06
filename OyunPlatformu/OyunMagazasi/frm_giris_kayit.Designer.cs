namespace OyunMagazasi
{
    partial class frm_giris_kayit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_giris = new System.Windows.Forms.GroupBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_giris_parola = new System.Windows.Forms.Label();
            this.tb_giris_kul_parola = new System.Windows.Forms.TextBox();
            this.lbl_giris_kul_adi = new System.Windows.Forms.Label();
            this.tb_giris_kul_adi = new System.Windows.Forms.TextBox();
            this.lbl_giris = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb_kayit = new System.Windows.Forms.GroupBox();
            this.rtb_kayit_adres = new System.Windows.Forms.RichTextBox();
            this.btn_kayit_kayit = new System.Windows.Forms.Button();
            this.lbl_kayit_adres = new System.Windows.Forms.Label();
            this.lbl_kayit_email = new System.Windows.Forms.Label();
            this.lbl_kayit_parola = new System.Windows.Forms.Label();
            this.lbl_kayit_soyad = new System.Windows.Forms.Label();
            this.tb_kayit_soyad = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_kayit_parola = new System.Windows.Forms.TextBox();
            this.tb_kayit_kul_adi = new System.Windows.Forms.TextBox();
            this.lbl_kayit_kul_adi = new System.Windows.Forms.Label();
            this.tb_kayit_ad = new System.Windows.Forms.TextBox();
            this.lbl_kayit_ad = new System.Windows.Forms.Label();
            this.lbl_kayit = new System.Windows.Forms.Label();
            this.rb_giris = new System.Windows.Forms.RadioButton();
            this.rb_kayit = new System.Windows.Forms.RadioButton();
            this.btn_admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb_giris.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gb_giris);
            this.panel1.Controls.Add(this.lbl_giris);
            this.panel1.Location = new System.Drawing.Point(10, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 352);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gb_giris
            // 
            this.gb_giris.Controls.Add(this.btn_giris);
            this.gb_giris.Controls.Add(this.lbl_giris_parola);
            this.gb_giris.Controls.Add(this.tb_giris_kul_parola);
            this.gb_giris.Controls.Add(this.lbl_giris_kul_adi);
            this.gb_giris.Controls.Add(this.tb_giris_kul_adi);
            this.gb_giris.Location = new System.Drawing.Point(18, 109);
            this.gb_giris.Name = "gb_giris";
            this.gb_giris.Size = new System.Drawing.Size(326, 228);
            this.gb_giris.TabIndex = 4;
            this.gb_giris.TabStop = false;
            this.gb_giris.Text = "Giriş";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_giris.Location = new System.Drawing.Point(52, 177);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(218, 44);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_giris_parola
            // 
            this.lbl_giris_parola.AutoSize = true;
            this.lbl_giris_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_parola.Location = new System.Drawing.Point(26, 91);
            this.lbl_giris_parola.Name = "lbl_giris_parola";
            this.lbl_giris_parola.Size = new System.Drawing.Size(54, 16);
            this.lbl_giris_parola.TabIndex = 2;
            this.lbl_giris_parola.Text = "Parola";
            // 
            // tb_giris_kul_parola
            // 
            this.tb_giris_kul_parola.Location = new System.Drawing.Point(128, 88);
            this.tb_giris_kul_parola.Name = "tb_giris_kul_parola";
            this.tb_giris_kul_parola.Size = new System.Drawing.Size(166, 20);
            this.tb_giris_kul_parola.TabIndex = 1;
            // 
            // lbl_giris_kul_adi
            // 
            this.lbl_giris_kul_adi.AutoSize = true;
            this.lbl_giris_kul_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_kul_adi.Location = new System.Drawing.Point(26, 58);
            this.lbl_giris_kul_adi.Name = "lbl_giris_kul_adi";
            this.lbl_giris_kul_adi.Size = new System.Drawing.Size(93, 16);
            this.lbl_giris_kul_adi.TabIndex = 2;
            this.lbl_giris_kul_adi.Text = "Kullanıcı Adı";
            // 
            // tb_giris_kul_adi
            // 
            this.tb_giris_kul_adi.Location = new System.Drawing.Point(128, 55);
            this.tb_giris_kul_adi.Name = "tb_giris_kul_adi";
            this.tb_giris_kul_adi.Size = new System.Drawing.Size(166, 20);
            this.tb_giris_kul_adi.TabIndex = 1;
            // 
            // lbl_giris
            // 
            this.lbl_giris.AutoSize = true;
            this.lbl_giris.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giris.Location = new System.Drawing.Point(119, 65);
            this.lbl_giris.Name = "lbl_giris";
            this.lbl_giris.Size = new System.Drawing.Size(115, 21);
            this.lbl_giris.TabIndex = 0;
            this.lbl_giris.Text = "Giriş Yap";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gb_kayit);
            this.panel2.Controls.Add(this.lbl_kayit);
            this.panel2.Location = new System.Drawing.Point(383, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 352);
            this.panel2.TabIndex = 1;
            // 
            // gb_kayit
            // 
            this.gb_kayit.Controls.Add(this.rtb_kayit_adres);
            this.gb_kayit.Controls.Add(this.btn_kayit_kayit);
            this.gb_kayit.Controls.Add(this.lbl_kayit_adres);
            this.gb_kayit.Controls.Add(this.lbl_kayit_email);
            this.gb_kayit.Controls.Add(this.lbl_kayit_parola);
            this.gb_kayit.Controls.Add(this.lbl_kayit_soyad);
            this.gb_kayit.Controls.Add(this.tb_kayit_soyad);
            this.gb_kayit.Controls.Add(this.tb_email);
            this.gb_kayit.Controls.Add(this.tb_kayit_parola);
            this.gb_kayit.Controls.Add(this.tb_kayit_kul_adi);
            this.gb_kayit.Controls.Add(this.lbl_kayit_kul_adi);
            this.gb_kayit.Controls.Add(this.tb_kayit_ad);
            this.gb_kayit.Controls.Add(this.lbl_kayit_ad);
            this.gb_kayit.Location = new System.Drawing.Point(37, 24);
            this.gb_kayit.Name = "gb_kayit";
            this.gb_kayit.Size = new System.Drawing.Size(327, 312);
            this.gb_kayit.TabIndex = 4;
            this.gb_kayit.TabStop = false;
            this.gb_kayit.Text = "Kayıt";
            // 
            // rtb_kayit_adres
            // 
            this.rtb_kayit_adres.Location = new System.Drawing.Point(118, 179);
            this.rtb_kayit_adres.Name = "rtb_kayit_adres";
            this.rtb_kayit_adres.Size = new System.Drawing.Size(169, 64);
            this.rtb_kayit_adres.TabIndex = 4;
            this.rtb_kayit_adres.Text = "";
            // 
            // btn_kayit_kayit
            // 
            this.btn_kayit_kayit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_kayit_kayit.Location = new System.Drawing.Point(52, 262);
            this.btn_kayit_kayit.Name = "btn_kayit_kayit";
            this.btn_kayit_kayit.Size = new System.Drawing.Size(218, 44);
            this.btn_kayit_kayit.TabIndex = 3;
            this.btn_kayit_kayit.Text = "Kayıt Ol";
            this.btn_kayit_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit_kayit.Click += new System.EventHandler(this.btn_kayit_kayit_Click);
            // 
            // lbl_kayit_adres
            // 
            this.lbl_kayit_adres.AutoSize = true;
            this.lbl_kayit_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_adres.Location = new System.Drawing.Point(20, 177);
            this.lbl_kayit_adres.Name = "lbl_kayit_adres";
            this.lbl_kayit_adres.Size = new System.Drawing.Size(57, 16);
            this.lbl_kayit_adres.TabIndex = 2;
            this.lbl_kayit_adres.Text = "Adres :";
            // 
            // lbl_kayit_email
            // 
            this.lbl_kayit_email.AutoSize = true;
            this.lbl_kayit_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_email.Location = new System.Drawing.Point(20, 148);
            this.lbl_kayit_email.Name = "lbl_kayit_email";
            this.lbl_kayit_email.Size = new System.Drawing.Size(60, 16);
            this.lbl_kayit_email.TabIndex = 2;
            this.lbl_kayit_email.Text = "E-Mail :";
            // 
            // lbl_kayit_parola
            // 
            this.lbl_kayit_parola.AutoSize = true;
            this.lbl_kayit_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_parola.Location = new System.Drawing.Point(20, 122);
            this.lbl_kayit_parola.Name = "lbl_kayit_parola";
            this.lbl_kayit_parola.Size = new System.Drawing.Size(54, 16);
            this.lbl_kayit_parola.TabIndex = 2;
            this.lbl_kayit_parola.Text = "Parola";
            // 
            // lbl_kayit_soyad
            // 
            this.lbl_kayit_soyad.AutoSize = true;
            this.lbl_kayit_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_soyad.Location = new System.Drawing.Point(20, 58);
            this.lbl_kayit_soyad.Name = "lbl_kayit_soyad";
            this.lbl_kayit_soyad.Size = new System.Drawing.Size(53, 16);
            this.lbl_kayit_soyad.TabIndex = 2;
            this.lbl_kayit_soyad.Text = "Soyad";
            // 
            // tb_kayit_soyad
            // 
            this.tb_kayit_soyad.Location = new System.Drawing.Point(122, 55);
            this.tb_kayit_soyad.Name = "tb_kayit_soyad";
            this.tb_kayit_soyad.Size = new System.Drawing.Size(166, 20);
            this.tb_kayit_soyad.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(122, 148);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(166, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_kayit_parola
            // 
            this.tb_kayit_parola.Location = new System.Drawing.Point(122, 122);
            this.tb_kayit_parola.Name = "tb_kayit_parola";
            this.tb_kayit_parola.Size = new System.Drawing.Size(166, 20);
            this.tb_kayit_parola.TabIndex = 1;
            // 
            // tb_kayit_kul_adi
            // 
            this.tb_kayit_kul_adi.Location = new System.Drawing.Point(122, 86);
            this.tb_kayit_kul_adi.Name = "tb_kayit_kul_adi";
            this.tb_kayit_kul_adi.Size = new System.Drawing.Size(166, 20);
            this.tb_kayit_kul_adi.TabIndex = 1;
            // 
            // lbl_kayit_kul_adi
            // 
            this.lbl_kayit_kul_adi.AutoSize = true;
            this.lbl_kayit_kul_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_kul_adi.Location = new System.Drawing.Point(20, 89);
            this.lbl_kayit_kul_adi.Name = "lbl_kayit_kul_adi";
            this.lbl_kayit_kul_adi.Size = new System.Drawing.Size(93, 16);
            this.lbl_kayit_kul_adi.TabIndex = 2;
            this.lbl_kayit_kul_adi.Text = "Kullanıcı Adı";
            // 
            // tb_kayit_ad
            // 
            this.tb_kayit_ad.Location = new System.Drawing.Point(122, 22);
            this.tb_kayit_ad.Name = "tb_kayit_ad";
            this.tb_kayit_ad.Size = new System.Drawing.Size(166, 20);
            this.tb_kayit_ad.TabIndex = 1;
            // 
            // lbl_kayit_ad
            // 
            this.lbl_kayit_ad.AutoSize = true;
            this.lbl_kayit_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit_ad.Location = new System.Drawing.Point(20, 25);
            this.lbl_kayit_ad.Name = "lbl_kayit_ad";
            this.lbl_kayit_ad.Size = new System.Drawing.Size(27, 16);
            this.lbl_kayit_ad.TabIndex = 2;
            this.lbl_kayit_ad.Text = "Ad";
            // 
            // lbl_kayit
            // 
            this.lbl_kayit.AutoSize = true;
            this.lbl_kayit.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kayit.Location = new System.Drawing.Point(155, 0);
            this.lbl_kayit.Name = "lbl_kayit";
            this.lbl_kayit.Size = new System.Drawing.Size(98, 21);
            this.lbl_kayit.TabIndex = 0;
            this.lbl_kayit.Text = "Kayıt Ol";
            // 
            // rb_giris
            // 
            this.rb_giris.AutoSize = true;
            this.rb_giris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_giris.Location = new System.Drawing.Point(186, 12);
            this.rb_giris.Name = "rb_giris";
            this.rb_giris.Size = new System.Drawing.Size(14, 13);
            this.rb_giris.TabIndex = 2;
            this.rb_giris.TabStop = true;
            this.rb_giris.UseVisualStyleBackColor = false;
            this.rb_giris.CheckedChanged += new System.EventHandler(this.rb_giris_CheckedChanged);
            // 
            // rb_kayit
            // 
            this.rb_kayit.AutoSize = true;
            this.rb_kayit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_kayit.Location = new System.Drawing.Point(596, 12);
            this.rb_kayit.Name = "rb_kayit";
            this.rb_kayit.Size = new System.Drawing.Size(14, 13);
            this.rb_kayit.TabIndex = 2;
            this.rb_kayit.TabStop = true;
            this.rb_kayit.UseVisualStyleBackColor = false;
            this.rb_kayit.CheckedChanged += new System.EventHandler(this.rb_kayit_CheckedChanged);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.SlateGray;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.Location = new System.Drawing.Point(291, 399);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(167, 45);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "AdminPaneli";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // frm_giris_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.rb_kayit);
            this.Controls.Add(this.rb_giris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_giris_kayit";
            this.Text = "frm_giris_kayit";
            this.Load += new System.EventHandler(this.frm_giris_kayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_giris.ResumeLayout(false);
            this.gb_giris.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gb_kayit.ResumeLayout(false);
            this.gb_kayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_giris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_giris_parola;
        private System.Windows.Forms.TextBox tb_giris_kul_parola;
        private System.Windows.Forms.Label lbl_giris_kul_adi;
        private System.Windows.Forms.TextBox tb_giris_kul_adi;
        private System.Windows.Forms.Button btn_kayit_kayit;
        private System.Windows.Forms.Label lbl_kayit_parola;
        private System.Windows.Forms.Label lbl_kayit_soyad;
        private System.Windows.Forms.Label lbl_kayit;
        private System.Windows.Forms.TextBox tb_kayit_soyad;
        private System.Windows.Forms.TextBox tb_kayit_kul_adi;
        private System.Windows.Forms.Label lbl_kayit_kul_adi;
        private System.Windows.Forms.TextBox tb_kayit_ad;
        private System.Windows.Forms.Label lbl_kayit_ad;
        private System.Windows.Forms.GroupBox gb_giris;
        private System.Windows.Forms.GroupBox gb_kayit;
        private System.Windows.Forms.TextBox tb_kayit_parola;
        private System.Windows.Forms.RadioButton rb_giris;
        private System.Windows.Forms.RadioButton rb_kayit;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.RichTextBox rtb_kayit_adres;
        private System.Windows.Forms.Label lbl_kayit_adres;
        private System.Windows.Forms.Label lbl_kayit_email;
        private System.Windows.Forms.TextBox tb_email;
    }
}