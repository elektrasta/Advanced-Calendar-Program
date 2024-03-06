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
    public partial class ajandaGirisPaneli : Form
    {
        public ajandaGirisPaneli()
        {
            InitializeComponent();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            kullaniciGirisPaneli kgp=new kullaniciGirisPaneli();
            this.Hide();
            kgp.Show();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            yoneticiGirisPaneli ygp = new yoneticiGirisPaneli();
            this.Hide();
            ygp.Show();
        }
    }
}
