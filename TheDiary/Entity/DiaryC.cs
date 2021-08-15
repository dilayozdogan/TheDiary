using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheDiary.Entity
{
   public class DiaryC
    {
        [Key, ForeignKey("User")]
        public int DiaryID { get; set; }
        public string DiaryTitle { get; set; }
        public ICollection<DiaryPage> DiaryPages { get; set; }
        public virtual User User { get; set; }

    }
}
