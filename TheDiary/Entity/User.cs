using System.ComponentModel.DataAnnotations;

namespace TheDiary.Entity
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsActive { get; set; }
        public DiaryC DiaryC { get; set; }
    }
}
