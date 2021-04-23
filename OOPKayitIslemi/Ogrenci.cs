using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKayitIslemi
{
    public class Ogrenci : Insan
    {
        public string No { get; set; }
        public string Sinif { get; set; }
        public double Ortalama { get; set; }
        private bool gecmeDurumu;
        public bool GecmeDurumu 
        {
            get { return gecmeDurumu; }
            private set
            {
                gecmeDurumu = Ortalama >= 60 ? true : false;
            }
        }

        public string GecmeDurumuOgren()
        {
            GecmeDurumu = !GecmeDurumu;
            return GecmeDurumu ? "Geçti" : "Kaldı";
        }
        Ogrenci[] ogrenciler = new Ogrenci[0];
        public void OgrenciBilgisiAl()
        {
            Console.WriteLine("Kaydı yapılacak öğrencinin");
            Ogrenci ogrenci = new Ogrenci();
            Console.Write("Adı Soyadı :");
            ogrenci.AdSoyad = Console.ReadLine();

            Console.Write("TC Kimlik Numarası :");
            ogrenci.TCNO = Console.ReadLine();

            Console.Write("Doğum Tarihi :");
            ogrenci.DogumTarihi = DateTime.Parse(Console.ReadLine());

            Console.Write("Cinsiyeti(E/K) :");
            string cinsiyet = Console.ReadLine();
            ogrenci.Cinsiyet = (cinsiyet == "E" || cinsiyet == "e");

            Console.Write("Sınıfı :");
            ogrenci.Sinif = Console.ReadLine();

            Console.Write("Ogrenci Numarası  :");
            ogrenci.No = Console.ReadLine();

            Console.Write("Not Ortalamsı :");
            ogrenci.Ortalama = double.Parse(Console.ReadLine());

            Array.Resize(ref ogrenciler, ogrenciler.Length + 1);
            ogrenciler[ogrenciler.Length - 1] = ogrenci;

            Console.Clear();
            Console.WriteLine("Öğrenci kaydı başarılı\n{0} adlı öğrencinin geçme durumu {1} ", ogrenci.AdSoyad, ogrenci.GecmeDurumuOgren());

        }
    }
}
