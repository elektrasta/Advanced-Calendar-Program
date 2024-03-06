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
    public partial class personelGirisPaneli : Form
    {
        public personelGirisPaneli()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            kullaniciGirisPaneli kgp = new kullaniciGirisPaneli();
            this.Hide();
            kgp.Show();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            personelSifremiUnuttum psu = new personelSifremiUnuttum();
            this.Hide();
            psu.Show();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            personelYeniKayit pyk = new personelYeniKayit();
            this.Hide(); 
            pyk.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtkullaniciAdi.Text == string.Empty)
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

            string kullaniciAdi = txtkullaniciAdi.Text;
            string sifre = txtSifre.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Personel WHERE kullaniciAdi='" + kullaniciAdi + "'AND sifre='" + sifre + "'";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                personelPaneli pp = new personelPaneli();
                this.Hide();
                pp.Show();
            }
            baglanti.Close();
        }
    }
}
