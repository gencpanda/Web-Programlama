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
    public partial class frm_yapimciEkle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DbOyunMagazasi; user ID=postgres; password=halzey28");

        public frm_yapimciEkle()
        {
            InitializeComponent();
        }
        bool YapımciKontrol(string yapimciadi)
        {
            baglanti.Open();
            string sorgu = "select *from oyunyapimcisi where yapimciadi='" + yapimciadi + "'";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (YapımciKontrol(tb_yapimciadi.Text.Trim()))
            {
                MessageBox.Show("Bu isimde yapımcı zaten mevcut");
                return;
            }
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("call yapimciekle(:p1,:p2,:p3)", baglanti);// yordam(procedure)
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("p1", DbType.String).Value = tb_yapimciadi.Text;
                komut.Parameters.AddWithValue("p2", DbType.String).Value = rtb_bilgi.Text;
                komut.Parameters.AddWithValue("p3", DbType.String).Value = Double.Parse(tb_piyasadegeri.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt eklendi");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt eklenemedi");
            }
           
        }

        private void frm_yapimciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
