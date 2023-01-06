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
    public partial class frm_oyunDetay : Form
    {
        public frm_oyunDetay()
        {
            InitializeComponent();
            rtb_yapimcibilgi.Enabled = true;
            rtb_yapimcibilgi.ReadOnly = true;
            dgv_yorumlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_yorumlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DbOyunMagazasi; user ID=postgres; password=halzey28");

        void YorumListele()
        {
            string sorgu = "select kullanici.kullaniciadi,icerik from yorum inner join kullanici on kullanici.kullaniciid=yorum.kullaniciid where oyunid=(select oyunid from oyun where oyunad='" + frm_home.oyun_ad + "')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv_yorumlar.DataSource = ds.Tables[0];
        }
        void KategoriListele()
        {
            string sorgu = "select kategori.kategoriad from kategorioyun inner join kategori on kategori.kategoriid=kategorioyun.kategoriid where oyunid=(select oyunid from oyun where oyunad='" + frm_home.oyun_ad + "')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<string> kategoriler = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
               kategoriler.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            var konum = lbl_kategori.Location;
            int konum_y = konum.Y;
            int konum_x = konum.X;
            for (int i = 0; i < kategoriler.Count; i++)
            {
                konum_y += 20;
                Label labelim = new Label();
                labelim.Text = kategoriler[i];
                labelim.AutoSize = true;
                labelim.Font = new Font("Arial", 9, FontStyle.Bold);
                labelim.ForeColor = Color.DarkCyan;
                labelim.Location = new Point(konum.X, konum_y);
                this.Controls.Add(labelim);                
            }
        }
        void YapimciListele()
        {
            baglanti.Open();
            string sorgu = "select * from oyunyapimcisi where yapimciid=(select yapimciid from oyun where " +
                "oyunad='"+lbl_oyunlarim_secilen.Text+"')";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lbl_yapimciadi.Text= reader["yapimciadi"].ToString();
                   lbl_piyasadegeri.Text = reader["piyasadegeri"].ToString();
                   rtb_yapimcibilgi.Text = reader["yapimcibilgi"].ToString();
                }
            baglanti.Close();
        }
        private void frm_oyunDetay_Load(object sender, EventArgs e)
        {
            rtb_yapimcibilgi.ReadOnly = true;

            lbl_oyunlarim_secilen.Text = frm_home.oyun_ad;
            YorumListele();
            KategoriListele();
            YapimciListele();
        }
    }
}
