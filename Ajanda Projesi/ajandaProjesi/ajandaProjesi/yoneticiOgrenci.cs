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
    public partial class yoneticiOgrenci : Form
    {
        public yoneticiOgrenci()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");
        DataSet daset = new DataSet();
        private void yoneticiOgrenci_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }
        private void KayitGoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT ad,soyad,kullaniciAdi,telefon,meslek FROM Ogrenci", baglanti);
            adtr.Fill(daset, "Ogrenci");
            dataGridView1.DataSource = daset.Tables["Ogrenci"];
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            yoneticiPaneli yp= new yoneticiPaneli();
            this.Hide();
            yp.Show();
        }
    }
}
