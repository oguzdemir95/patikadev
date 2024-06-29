using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    internal class Loglar
    {
        private string _aktarim;

        public string Aktarim { get => _aktarim; set => _aktarim = value; }
        public void IslemiYaz(Musteri mst,string zaman,string secim)
        {
            string tarih = DateTime.Now.Date.ToString("d");
            string yol = @$"C:\Users\oğuzhan\source\repos\oguzdemir95\patikadev\CS_Projeleri\ATMUygulamasi\GunSonu_{tarih}.txt";
            StreamWriter yaz = new StreamWriter(yol,true);
            yaz.WriteLine("------------");
            yaz.WriteLine("HESAP GİRİŞİ");
            yaz.WriteLine($"Saat: {zaman}");
            yaz.WriteLine($"Müşteri Numarası: {mst.MusteriNumarasi}");
            yaz.WriteLine($"Müşteri: {mst.MusteriAdi} {mst.MusteriSoyadi}");
            yaz.Write("İŞLEM: ");
            switch (secim)
            {
                case "1":
                    yaz.WriteLine("Para Çekme");
                    break;
                case "2":
                    yaz.WriteLine("Para Yatırma");
                    break;
                    case "3":
                    yaz.WriteLine("Para Gönderme");
                    break;
                case "4":
                    yaz.WriteLine("Borç Ödeme");
                    break;
                default:
                    break;
            }
            yaz.WriteLine();
            yaz.Close();
        }
        public void HatalıSifreYaz(List<Musteri> musteriler,string musterino, string zaman)
        {
            string tarih = DateTime.Now.Date.ToString("d");
            string yol = @$"C:\Users\oğuzhan\source\repos\oguzdemir95\patikadev\CS_Projeleri\ATMUygulamasi\GunSonu_{tarih}.txt";
            StreamWriter yaz = new StreamWriter(yol, true);
            yaz.WriteLine("------------");
            yaz.WriteLine("HATALI GİRİŞ");
            yaz.WriteLine($"Saat: {zaman}");
            yaz.WriteLine($"Müşteri Numarası: {Musteri.MusteriBul(musteriler,musterino).MusteriNumarasi}");
            yaz.WriteLine($"Müşteri: {Musteri.MusteriBul(musteriler, musterino).MusteriAdi} " +
                $"{Musteri.MusteriBul(musteriler, musterino).MusteriSoyadi}");
            yaz.WriteLine("Hatalı Şifre");
            yaz.WriteLine();
            yaz.Close();
        }
        public void MusteriBulunamadiYaz(string musterino,string zaman)
        {
            string tarih = DateTime.Now.Date.ToString("d");
            string yol = @$"C:\Users\oğuzhan\source\repos\oguzdemir95\patikadev\CS_Projeleri\ATMUygulamasi\GunSonu_{tarih}.txt";
            StreamWriter yaz = new StreamWriter(yol, true);
            yaz.WriteLine("-------------------");
            yaz.WriteLine("BULUNAMAYAN MÜŞTERİ");
            yaz.WriteLine($"Saat: {zaman}");
            yaz.WriteLine($"Girilen Müşteri Numarası: {musterino}");
            yaz.WriteLine();
            yaz.Close();
        }
    }
}
