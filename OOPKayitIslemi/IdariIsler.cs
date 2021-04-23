using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKayitIslemi
{
    public class IdariIsler : Insan
    {
        public string Unvan { get; set; }
        public decimal Maas { get; set; }

        IdariIsler[] idariIsler = new IdariIsler[0];
        public void IdariIslerBilgisiAl()
        {
            Console.WriteLine("Kaydı yapılacak personelin: ");
            IdariIsler personel = new IdariIsler();
            Console.WriteLine("Adı Soyadı: ");
            personel.AdSoyad = Console.ReadLine();

            Console.WriteLine("TC Kimlik Numarası: ");
            personel.TCNO = Console.ReadLine();

            Console.WriteLine("Doğum Tarihi: ");
            personel.DogumTarihi = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyeti (E / K): ");
            string cinsiyetPersonel = Console.ReadLine();
            personel.Cinsiyet = (cinsiyetPersonel == "e" || cinsiyetPersonel == "E") ? true : false;

            Console.WriteLine("Unvan: ");
            personel.Unvan = Console.ReadLine();

            Console.WriteLine("Maaş: ");
            personel.Maas = decimal.Parse(Console.ReadLine());

            Array.Resize(ref idariIsler, idariIsler.Length + 1);
            idariIsler[idariIsler.Length - 1] = personel;

            Console.Clear();
            Console.WriteLine("Personel kaydı başarılı...\n{0} adlı personel maaşı: {1}, unvanı: {2}", personel.AdSoyad, personel.Maas, personel.Unvan);
        }
    }
}
