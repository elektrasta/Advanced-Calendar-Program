using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajandaProjesi
{
    public partial class kullaniciGirisPaneli : Form
    {
        public kullaniciGirisPaneli()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ogrenciGirisPaneli ogp=new ogrenciGirisPaneli();
            this.Hide();
            ogp.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            personelGirisPaneli pgp=new personelGirisPaneli();
            this.Hide();
            pgp.Show();
        }

        private void btnArastirmaci_Click(object sender, EventArgs e)
        {
            arastirmaciGirisPaneli agp = new arastirmaciGirisPaneli();
            this.Hide();
            agp.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            ajandaGirisPaneli ajgp =new ajandaGirisPaneli();
            this.Hide();
            ajgp.Show();
        }
    }
}
