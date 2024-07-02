using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    internal class Menu
    {
        #region Arayüz
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
            Console.WriteLine("(5) İşlem Kayıtlarını Al");
            Console.WriteLine("(6) Hesaptan Çıkış");
            Console.Write("Seçim: ");
        }
        #endregion

        #region İşlemler
        public static void SecimiUygula(string secim,AtmMakine atm,Musteri girisYapan,List<Musteri> musteriler,bool iKontrol, List<Loglar> loglar)
        {
            switch (secim)
            {
                case "1":
                    Console.Clear();
                    UstBilgi(atm, girisYapan);
                    atm.ParaCek(girisYapan);
                    atm.SiradakiIslem(atm,girisYapan, iKontrol);
                    break;
                case "2":
                    Console.Clear();
                    UstBilgi(atm, girisYapan);
                    atm.ParaYatir(girisYapan);
                    atm.SiradakiIslem(atm,girisYapan, iKontrol);
                    break;
                case "3":
                    Console.Clear();
                    UstBilgi(atm, girisYapan);
                    atm.ParaGonder(musteriler, girisYapan);
                    atm.SiradakiIslem(atm, girisYapan, iKontrol);
                    break;
                case "4":
                    Console.Clear();
                    UstBilgi(atm, girisYapan);
                    atm.OdemeYap(girisYapan);
                    atm.SiradakiIslem(atm, girisYapan, iKontrol);
                    break;
                case "5":
                    Console.Clear();
                    UstBilgi(atm, girisYapan);
                    Loglar.LogYazdir(loglar);
                    atm.SiradakiIslem(atm, girisYapan, iKontrol);
                    break;
                case "6":
                    atm.HesaptanCikis();
                    Console.Clear();
                    Giris(atm);
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş.");
                    break;
            }
        }
        #endregion
    }
}
