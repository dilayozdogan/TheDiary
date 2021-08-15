using System;
using System.Windows.Forms;
using TheDiary.Entity;

namespace TheDiary
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void KayitBtn_Click(object sender, EventArgs e)
        {
            var kullaniciAd = kayitKullaniciTxt.Text; //klavye okuma
            var kullaniciSif = kayitSifreTxt.Text;
            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext(); //db oluşturma
            User user = new User()
            {
                UserName = kullaniciAd,
                UserPassword = kullaniciSif,
                UserIsActive = true
            };
            theDiaryDbContext.User.Add(user); //kullanıcı ekleme
            theDiaryDbContext.SaveChanges();
            MessageBox.Show("kayıt başarılı");
            Giris giris = new Giris(); //ekrana geçiş
            this.Hide();
            giris.Show();
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.Show();
        }
    }
}
