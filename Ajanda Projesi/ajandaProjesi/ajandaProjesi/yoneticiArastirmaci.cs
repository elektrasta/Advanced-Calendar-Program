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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ajandaProjesi
{
    public partial class yoneticiArastirmaci : Form
    {
        public yoneticiArastirmaci()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");
        DataSet daset = new DataSet();
        private void yoneticiArastirmaci_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }
        private void KayitGoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT ad,soyad,kullaniciAdi,telefon,meslek FROM Arastirmaci", baglanti);
            adtr.Fill(daset, "Arastirmaci");
            dataGridView1.DataSource = daset.Tables["Arastirmaci"];
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            yoneticiPaneli yp=new yoneticiPaneli();
            this.Hide();
            yp.Show();
        }
    }
}
