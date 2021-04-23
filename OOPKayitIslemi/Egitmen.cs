using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKayitIslemi
{
    public class Egitmen : Insan
    {
        public string UzmanlikAlani { get; set; }
        public decimal Maas { get; set; }
        public string[] GirdigiSiniflar { get;  set; }

        Egitmen[] egitmenler = new Egitmen[0];
        public void EgitmenBilgisiAl()
        {

            string[] GirdigiSiniflar = new string[0];
            Console.WriteLine("Kaydı yapılacak eğitmenin: ");
            Egitmen egitmen = new Egitmen();
            Console.WriteLine("Adı Soyadı: ");
            egitmen.AdSoyad = Console.ReadLine();

            Console.WriteLine("TC Kimlik Numarası: ");
            egitmen.TCNO = Console.ReadLine();

            Console.WriteLine("Doğum Tarihi: ");
            egitmen.DogumTarihi = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyeti (E / K): ");
            string cinsiyetEgitmen = Console.ReadLine();
            egitmen.Cinsiyet = (cinsiyetEgitmen == "e" || cinsiyetEgitmen == "E") ? true : false;

            Console.WriteLine("Uzmanlık Alanı: ");
            egitmen.UzmanlikAlani = Console.ReadLine();

            Console.WriteLine("Maaş: ");
            egitmen.Maas = decimal.Parse(Console.ReadLine());
            string cevap=" ";
            do
            {

                Console.WriteLine("Girdiği Sınıflar: ");
                Array.Resize(ref GirdigiSiniflar, GirdigiSiniflar.Length + 1);
                GirdigiSiniflar[GirdigiSiniflar.Length - 1] = Console.ReadLine();

                Array.Resize(ref egitmenler, egitmenler.Length + 1);
                egitmenler[egitmenler.Length - 1] = egitmen;
                Console.WriteLine("Başka bir sınıf kaydı yapmak ister misiniz? (e-h)");
                cevap = Console.ReadLine();

            } while (cevap == "e" || cevap == "E");
            Console.Clear();
            foreach (string sinif in GirdigiSiniflar)
            {
                Console.WriteLine("Girdiği Sınıflar: "+ sinif);
            }
            Array.Resize(ref egitmenler, egitmenler.Length + 1);
            egitmenler[egitmenler.Length - 1] = egitmen;
            
            Console.WriteLine("Eğitmen kaydı başarılı...\n{0} adlı eğitmenin maaşı: {1}", egitmen.AdSoyad, egitmen.Maas);
        }
    }
}
