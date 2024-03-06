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
using System.IO;

namespace ajandaProjesi
{
    public partial class ogrenciPaneli : Form
    {
        public ogrenciPaneli()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");

        private void ogrenciPaneli_Load(object sender, EventArgs e)
        {
            AktiviteGetir();
        }

        private void AktiviteGetir()
        {
            baglanti.Open();
            SqlCommand marka = new SqlCommand("SELECT * FROM Aktivite", baglanti);
            SqlDataReader read = marka.ExecuteReader();
            while (read.Read())
            {
                cmbAktivite.Items.Add(read["aktiviteAdi"].ToString());
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Aktiviteler (aktivitelerAdi , aktivitelerTarih) values (@aktivitelerAdi , @aktivitelerTarih)",baglanti);
            komut.Parameters.AddWithValue("@aktivitelerAdi",cmbAktivite.Text);
            komut.Parameters.AddWithValue("@aktivitelerTarih", DateTime.Now);
            komut.ExecuteNonQuery();
            baglanti.Close();

            lstwListe.Items.Add(cmbAktivite.Text);
            lstwListe.Items.Add(dtpTarih.Text);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            ogrenciGirisPaneli ogp =new ogrenciGirisPaneli();
            this.Hide();
            ogp.Show();
        }

        private void btnKitapOku_Click(object sender, EventArgs e)
        {
            ogrenciKitapPaneli okp =new ogrenciKitapPaneli();
            this.Hide();
            okp.Show();
        }
    }
}
