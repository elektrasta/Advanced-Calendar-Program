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
    public partial class yoneticiPaneli : Form
    {
        public yoneticiPaneli()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=ajandaDB;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            yoneticiGirisPaneli ygp = new yoneticiGirisPaneli();
            this.Hide();
            ygp.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            yoneticiOgrenci yo=new yoneticiOgrenci();
            this.Hide(); 
            yo.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            yoneticiPersonel ype= new yoneticiPersonel();
            this.Hide();
            ype.Show();
        }

        private void btnArastirmaci_Click(object sender, EventArgs e)
        {
            yoneticiArastirmaci ya = new yoneticiArastirmaci();
            this.Hide();
            ya.Show();
        }
    }
}
