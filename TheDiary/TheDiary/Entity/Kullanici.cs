using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiary.Entity
{
    class Kullanici
    {
        public int KullaniciID { get; set; }
        public string KullaniciName { get; set; }
        public string KullaniciPassword { get; set; }
        public bool UserIsActive { get; set; }
    }
}
