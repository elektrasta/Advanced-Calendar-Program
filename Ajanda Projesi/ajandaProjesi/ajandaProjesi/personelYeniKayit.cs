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
    public partial class personelYeniKayit : Form
    {
        public personelYeniKayit()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            personelGirisPaneli pgp = new personelGirisPaneli();
            this.Hide();
            pgp.Show();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (txtAd.Text == string.Empty)
                hata = 1;
            if (txtSoyad.Text == string.Empty)
                hata = 1;
            if (txtKullaniciAdi.Text == string.Empty)
                hata = 1;
            if (txtSifre.Text == string.Empty)
                hata = 1;
            if (mskTelefon.Text == string.Empty)
                hata = 1;
            if (txtMeslek.Text == string.Empty)
                hata = 1;

            if (hata == 0)
            {
                baglanti.Open();
                SqlCommand kayitOl = new SqlCommand();
                kayitOl.CommandText = "insert into Personel values (@ad , @soyad , @kullaniciAdi , @sifre , @telefon , @meslek)";

                kayitOl.Connection = baglanti;

                kayitOl.Parameters.AddWithValue("@ad", txtAd.Text);
                kayitOl.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                kayitOl.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);
                kayitOl.Parameters.AddWithValue("@sifre", txtSifre.Text);
                kayitOl.Parameters.AddWithValue("@telefon", Convert.ToString(mskTelefon.Text));
                kayitOl.Parameters.AddWithValue("@meslek", txtMeslek.Text);
                kayitOl.ExecuteNonQuery();
                baglanti.Close();

                personelGirisPaneli pgp = new personelGirisPaneli();
                this.Hide();
                pgp.Show();

            }
        }
    }
}
