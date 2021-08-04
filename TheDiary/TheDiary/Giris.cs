using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDiary
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            var KullaniciGiris = kullaniciTxt.Text;
            var SifreGiris = SifreTxt.Text;
            Gunluk gunluk = new Gunluk();
            this.Hide();
            gunluk.Show();
        }

        private void KaydolBtn_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();

        }
    }
}
