using System;
using System.Linq;
using System.Windows.Forms;
using TheDiary.Entity;

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
            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext();
            if (!theDiaryDbContext.Database.Exists())
            {
                theDiaryDbContext.Database.Create();

            }
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            var KullaniciGiris = kullaniciTxt.Text; //klavye okuma
            var SifreGiris = SifreTxt.Text;

            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext();
            var user1 = theDiaryDbContext.User.Include("DiaryC").Where(x => x.UserName == KullaniciGiris).ToList();
            var theRealUser = user1.FirstOrDefault(x => x.UserPassword == SifreGiris);
            if (theRealUser != null)
            {
                if (theRealUser.UserName == KullaniciGiris && theRealUser.UserPassword == SifreGiris)
                {
                    if (theRealUser.DiaryC != null)
                    {
                        Gunluk gunluk = new Gunluk(theRealUser.UserID);
                        this.Hide();
                        gunluk.Show();

                    }
                    else
                    {
                        GunlukBaslik gunlukbaslik = new GunlukBaslik(theRealUser.UserID);
                        this.Hide();
                        gunlukbaslik.Show();
                    }
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre hatalı");

                }
            }
            else
            {
                MessageBox.Show("böyle bir kullanıcı bulunamadı");
            }
        }

        private void KaydolBtn_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit(); //ekrana geçiş
            this.Hide();
            kayit.Show();

        }
    }
}
