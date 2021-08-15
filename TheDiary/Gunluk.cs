using System;
using System.Linq;
using System.Windows.Forms;
using TheDiary.Entity;

namespace TheDiary
{
    public partial class Gunluk : Form
    {
        public int diaryID { get; set; }

        public Gunluk(int DiaryID)
        {
            diaryID = DiaryID;
            InitializeComponent();
        }

        private void Gunluk_Load(object sender, EventArgs e)
        {
            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext();
            var theDairy = theDiaryDbContext.DiaryC.FirstOrDefault(x => x.DiaryID == diaryID);
            diarytitleLabel.Text = "Günlük Başlığınız: "+theDairy.DiaryTitle;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void gunusilBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void gunukaydetBtn_Click(object sender, EventArgs e)
        {
            var date = monthCalendar1.ToString();
            var RealDate = date.Substring(date.IndexOf("Start: "));
            var RealDate2 = RealDate.Substring(RealDate.IndexOf("Start: ") + 7, 10);
            var a = Convert.ToDateTime(RealDate2);

            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext();
            var theUserDiaryPages = theDiaryDbContext.DiaryPage.Where(x => x.DiaryID == diaryID).ToList();
            var theDiary = theUserDiaryPages.Where(x => x.PageDateTime == Convert.ToDateTime(RealDate2)).ToList();

            if (theDiary.Count > 0)
            {
                MessageBox.Show("aynı güne tek kayıt girebilirsiniz");
            }
            else
            {
                DiaryPage diaryPage = new DiaryPage();
                diaryPage.PageContent = textBox1.Text;
                diaryPage.PageDateTime = Convert.ToDateTime(RealDate2);
                diaryPage.DiaryID = diaryID;
                theDiaryDbContext.DiaryPage.Add(diaryPage);
                theDiaryDbContext.SaveChanges();

                MessageBox.Show("günlüğünüze kaydedildi");
            }

        }

        private void kapatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void tarihegitBtn_Click(object sender, EventArgs e)
        {
            var date = monthCalendar1.ToString();
            var RealDate = date.Substring(date.IndexOf("Start: "));
            var RealDate2 = RealDate.Substring(RealDate.IndexOf("Start: ") + 7, 10);
            var a = Convert.ToDateTime(RealDate2);

            TheDiaryDbContext theDiaryDbContext = new TheDiaryDbContext();
            var theUserDiaryPages = theDiaryDbContext.DiaryPage.Where(x => x.DiaryID == diaryID).ToList();
            var theDiary = theUserDiaryPages.Where(x => x.PageDateTime == Convert.ToDateTime(RealDate2)).ToList();
            var DiaryContent = theDiary.FirstOrDefault(x => x.PageDateTime == Convert.ToDateTime(RealDate2));
            if (DiaryContent != null)
            {
                MessageBox.Show(DiaryContent.PageContent);
            }
            else
            {
                MessageBox.Show("bu tarihde yazınız bulamamaktadır");
                    
            }

        }
    }
}
