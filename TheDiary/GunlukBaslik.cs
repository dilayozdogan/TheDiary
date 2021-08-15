using System;
using System.Windows.Forms;
using TheDiary.Entity;

namespace TheDiary
{
    public partial class GunlukBaslik : Form
    {
        public int userID { get; set; }

        public GunlukBaslik(int UserID)
        {
            userID = UserID;
            InitializeComponent();
        }

        private void baslikkaydetBtn_Click(object sender, EventArgs e)
        {
            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext();
            var diaryTitle = diarytitleBtn.Text;
            DiaryC diaryC = new DiaryC();
            diaryC.DiaryTitle = diaryTitle;
            diaryC.DiaryID = userID;
            theDiaryDbContext.DiaryC.Add(diaryC);
            theDiaryDbContext.SaveChanges();
            MessageBox.Show("başarıyla kaydedildi");

            Gunluk gunluk = new Gunluk(userID);
            this.Hide();
            gunluk.Show();
        }

        private void baslikcikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GunlukBaslik_Load(object sender, EventArgs e)
        {

        }
    }
}
