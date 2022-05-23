using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon.Entities.Concrete
{
    public class OtobusCadir
    {
      
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string VarisNoktasi { get; set; }
        public string KalkisNoktasi { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public int BiletSayisi { get; set; }
        public int Fiyat { get; set; }
    }
}
