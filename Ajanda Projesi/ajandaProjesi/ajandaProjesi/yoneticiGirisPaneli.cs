using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajandaProjesi
{
    public partial class yoneticiGirisPaneli : Form
    {
        public yoneticiGirisPaneli()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            ajandaGirisPaneli agp = new ajandaGirisPaneli();
            this.Hide();
            agp.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtKullaniciAdi.Text == string.Empty)
            {
                hata = 1;
            }
            if (txtSifre.Text == string.Empty)
            {
                hata = 1;
            }
            if (hata == 1)
            {
                MessageBox.Show("Kullanıcı Adı ve şifre boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Yonetici WHERE kullaniciAdi='" + kullaniciAdi + "'AND sifre='" + sifre + "'";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                yoneticiPaneli yp = new yoneticiPaneli();
                this.Hide();
                yp.Show();
            }
            baglanti.Close();
        }
    }
}
