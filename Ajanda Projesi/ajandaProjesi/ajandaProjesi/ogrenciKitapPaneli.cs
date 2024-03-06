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
    public partial class ogrenciKitapPaneli : Form
    {
        public ogrenciKitapPaneli()
        {
            InitializeComponent();
        }

        private void btnKitapAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "PDF Aç";
            pdfac.Filter = "PDF Dosyaları (*.Pdf) | *.Pdf";
            if (pdfac.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(pdfac.FileName);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            ogrenciPaneli op=new ogrenciPaneli();
            this.Hide();
            op.Show();
        }
    }
}
