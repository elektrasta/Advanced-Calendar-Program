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
    public partial class ogrenciSifremiUnuttum : Form
    {
        public ogrenciSifremiUnuttum()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");
        private void btnGeri_Click(object sender, EventArgs e)
        {
            ogrenciGirisPaneli ogp =new ogrenciGirisPaneli();
            this.Hide();
            ogp.Show();
        }

        private void btnSifremiGoster_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (mskTelefon.Text == string.Empty)
            {
                hata = 1;
            }
            if (txtKullaniciAdi.Text == string.Empty)
            {
                hata = 1;
            }
            if (hata == 1)
            {
                MessageBox.Show("Alanları Doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sifre from Ogrenci where telefon='" + mskTelefon.Text + "' and kullaniciAdi='" + txtKullaniciAdi.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    string islem = dr["sifre"].ToString();
                    MessageBox.Show(islem, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    mskTelefon.Text = "";
                    txtKullaniciAdi.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı Bilgi Girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                    mskTelefon.Text = "";
                    txtKullaniciAdi.Text = "";
                }

            }
        }
    }
}
