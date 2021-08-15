
using System.Data.Entity;


namespace TheDiary.Entity
{
    public class TheDiaryDbContext : DbContext
    {
        public DbSet<DiaryC> DiaryC { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<DiaryPage> DiaryPage { get; set; }
    }
}
