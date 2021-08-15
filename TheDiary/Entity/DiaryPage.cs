using System;
using System.ComponentModel.DataAnnotations;

namespace TheDiary.Entity
{
  public  class DiaryPage
    {
        [Key]
        public int DiaryPageID { get; set; }
        [Required(ErrorMessage ="lütfen zorunlu alanı giriniz"), StringLength(500)]
        public string PageContent { get; set; }
        public DateTime PageDateTime { get; set; }
        public int DiaryID { get; set; }
        public DiaryC DiaryC { get; set; }
    } 
}
