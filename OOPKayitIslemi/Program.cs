using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKayitIslemi
{
    class Program
    {

        Ogrenci[] ogrenciler = new Ogrenci[0];
        Egitmen[] egitmenler = new Egitmen[0];
        IdariIsler[] personeller = new IdariIsler[0];
        string[] Girdigisınıflar = new string[0];

        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Egitmen egitmen = new Egitmen();
            IdariIsler idari = new IdariIsler();
            int Ogrencitoplam=0;
            int Egitmentoplam=0;
            int Idaritoplam=0;
            string cevap;
            do
            {
                Console.WriteLine("Kaydını gerçekleştirmek istediğiniz birimi seçiniz: \n1- Öğrenci \n2- Eğitmen\n3- İdari İşler");
                cevap = Console.ReadLine();

                
                switch (cevap)
                {
                    case "1":
                        ogrenci.OgrenciBilgisiAl();
                        Ogrencitoplam++;
                        break;
                    case "2":
                        egitmen.EgitmenBilgisiAl();
                        Egitmentoplam++;
                        break;

                    case "3":
                        idari.IdariIslerBilgisiAl();
                        Idaritoplam++;
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız...");
                        break;
                }

                Console.WriteLine("Başka bir kayıt yapmak ister misiniz? (e-h)");
                cevap = Console.ReadLine();
                Console.Clear();
            } while (cevap == "e" || cevap == "E");

            Console.Clear();
            Console.WriteLine("İsteğiniz üzerine kayıt ekranı kapanacaktır.");

            Console.WriteLine("Kayıt Listesi Güncel Durumu");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Kayıtlı Öğrenci Sayısı :" + Ogrencitoplam.ToString());
            Console.WriteLine("Kayıtlı Egitmen Sayısı :" + Egitmentoplam.ToString());
            Console.WriteLine("Kayıtlı Personel Sayısı :" + Idaritoplam.ToString());

            Console.WriteLine("\nUygulamayı kapatmak için entera basınız.");
            Console.ReadLine();
        }
    }
}