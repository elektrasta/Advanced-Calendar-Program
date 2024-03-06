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
    public partial class arastirmaciPaneli : Form
    {
        public arastirmaciPaneli()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");

        private void arastirmaciPaneli_Load(object sender, EventArgs e)
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
            SqlCommand komut = new SqlCommand("insert into Aktiviteler (aktivitelerAdi , aktivitelerTarih) values (@aktivitelerAdi , @aktivitelerTarih)", baglanti);
            komut.Parameters.AddWithValue("@aktivitelerAdi", cmbAktivite.Text);
            komut.Parameters.AddWithValue("@aktivitelerTarih", DateTime.Now);
            komut.ExecuteNonQuery();
            baglanti.Close();

            lstwListe.Items.Add(cmbAktivite.Text);
            lstwListe.Items.Add(dtpTarih.Text);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            arastirmaciGirisPaneli agp = new arastirmaciGirisPaneli();
            this.Hide();
            agp.Show();
        }

        private void btnKitapOku_Click(object sender, EventArgs e)
        {
            arastirmaciKitapPaneli akp = new arastirmaciKitapPaneli();
            this.Hide();
            akp.Show();
        }
    }
}
