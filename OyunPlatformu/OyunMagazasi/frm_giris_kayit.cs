using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunMagazasi
{
    public partial class frm_giris_kayit : Form
    {
        public static string kul_Ad = "";
        public frm_giris_kayit()
        {
            InitializeComponent();
            gb_giris.Enabled = false;
            gb_kayit.Enabled = false;

            rb_giris.Checked = false;
            rb_kayit.Checked = false;          
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DbOyunMagazasi; user ID=postgres; password=halzey28");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_kayit_kayit_Click(object sender, EventArgs e)
        {
            string ad = tb_kayit_ad.Text.Trim();
            string soyad = tb_kayit_soyad.Text.Trim();
            string kulanici_adi = tb_kayit_kul_adi.Text.Trim();
            string parola = tb_kayit_parola.Text.Trim();
            string email = tb_email.Text.Trim();
            string adres = rtb_kayit_adres.Text.Trim();

            if (KayıtKontrol(kulanici_adi))
            {
                MessageBox.Show("Bu kullanıcı adı kullanılmış.");
                return;
            }

            // verileri ekleme işlemi
            baglanti.Open();
            string sorgu = "insert into kullanici (ad,soyad,kullaniciadi,parola) values (@p1,@p2,@p3,@p4)";
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@p1", ad); // parametreler
            cmd.Parameters.AddWithValue("@p2", soyad);
            cmd.Parameters.AddWithValue("@p3", kulanici_adi);
            cmd.Parameters.AddWithValue("@p4", parola);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            
            // kullanıcının iletişimi olmalı. İletişim verisi ekliyoruz
            baglanti.Open();
            sorgu = "insert into iletisim (email,adres,kullaniciid) values (@p1,@p2,(select kullaniciid from kullanici where kullaniciadi='" + kulanici_adi + "'))";
            cmd = new NpgsqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@p1", email);
            cmd.Parameters.AddWithValue("@p2", adres);
            cmd.ExecuteNonQuery();
            baglanti.Close();


            // kullanıcının cüzdan verisi olmalı. ekliyoruz
            baglanti.Open();
            sorgu = "insert into cuzdan (kullaniciid,bakiye) values ((select kullaniciid from kullanici where kullaniciadi='"+kulanici_adi+"'),0)";
            cmd = new NpgsqlCommand(sorgu, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt Eklendi");

            // form elemanlarını boşaltıyoruz
            tb_kayit_ad.Text = "";
            tb_kayit_soyad.Text = "";
            tb_kayit_kul_adi.Text = "";
            lbl_kayit_parola.Text = "";
        }
        bool KayıtKontrol(string kullaniciadi)// aynı kayıt varmı kontrol ediliyor
        {
            baglanti.Open();
            // bu kullanıcı adında varsa getir
            string sorgu = "select *from kullanici where kullaniciadi='" + kullaniciadi + "'";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.HasRows)// varsa gir
            {
                reader.Read();
                baglanti.Close();
                return true;
            }
                baglanti.Close();
                return false;                
        }
        private void btn_giris_Click(object sender, EventArgs e)// giriş yap
        {
            string kul_ad = tb_giris_kul_adi.Text;
            string parola = tb_giris_kul_parola.Text;

            baglanti.Open();
            // bu kullanıcı adında veri varsa getir
            string sorgu = "select *from kullanici where kullaniciadi='" + kul_ad + "'";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();
            if (reader.HasRows)// veri bulunduysa gir
            {
                reader.Read();
                string kul_parola = reader["parola"].ToString();
                if (kul_parola == parola)// parola kontrolü. doğru ise gir
                {
                    tb_giris_kul_adi.Text = "";
                    tb_giris_kul_parola.Text = "";

                    frm_home.giris_form = this; // oluşan forma bu formu gönderiyoruz
                    kul_Ad = kul_ad;
                    frm_home home = new frm_home();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Parolanız yanlış");               
            }
            // kullanıcı bulunamadı ise
            else
                MessageBox.Show(kul_ad + " : Böyle bir kullanıcı bulunamadı");
            baglanti.Close();
        }
    

        private void rb_giris_CheckedChanged(object sender, EventArgs e)// giriş radiobuttonu seçili ise
        {
            if (rb_giris.Checked == true)
                gb_giris.Enabled = true;
            else
                gb_giris.Enabled = false;
        }

        private void rb_kayit_CheckedChanged(object sender, EventArgs e)// kayıt radiobuttonu seçili ise
        {
            if (rb_kayit.Checked == true)
                gb_kayit.Enabled = true;
            else
                gb_kayit.Enabled = false;
        }

        private void frm_giris_kayit_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)// admin panel butonu
        {
            this.Hide();
            frm_admin admin_paneli = new frm_admin();
            admin_paneli.ShowDialog();
            this.Show();
        }
    }
}
