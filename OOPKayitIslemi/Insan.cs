using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKayitIslemi
{
    public enum KayitTipi { Ogrenci, Egitmen, IdariIsler };
    public abstract class Insan
    {
        public KayitTipi Tip { get; set; }
        public string AdSoyad { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TCNO { get; set; }

      
        public int YasHesapla()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
    }
}
