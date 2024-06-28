using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    internal class Menu
    {
        public static void Giris(AtmMakine atm)
        {
            Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
            Console.WriteLine("GİRİŞ");
            Console.WriteLine();
        }
        public static void UstBilgi(AtmMakine atm, Musteri girisYapan)
        {
            Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
            Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
        }
        public static void AtmMenu(Musteri girisYapan)
        {
            Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
            Console.WriteLine();
            Console.WriteLine("İşlem Listesi");
            Console.WriteLine("(1) Para Çek");
            Console.WriteLine("(2) Para Yatır");
            Console.WriteLine("(3) Para Gönder");
            Console.WriteLine("(4) Ödeme Yap");
            Console.WriteLine("(5) Hesaptan Çıkış");
            Console.Write("Seçim: ");
        }

        public static void SecimiUygula(string secim,AtmMakine atm,Musteri girisYapan,List<Musteri> musteriler,bool kontrol)
        {
            switch (secim)
            {
                case "1":
                    Console.Clear();
                    Menu.UstBilgi(atm, girisYapan);
                    atm.ParaCek(girisYapan);
                    break;
                case "2":
                    Console.Clear();
                    Menu.UstBilgi(atm, girisYapan);
                    atm.ParaYatir(girisYapan);
                    break;
                case "3":
                    Console.Clear();
                    Menu.UstBilgi(atm, girisYapan);
                    atm.ParaGonder(musteriler, girisYapan);
                    break;
                case "4":
                    Console.Clear();
                    Menu.UstBilgi(atm, girisYapan);
                    atm.OdemeYap(girisYapan);
                    break;
                case "5":
                    kontrol = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş.");
                    break;
            }
        }
    }
}
