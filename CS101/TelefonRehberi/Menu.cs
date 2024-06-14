using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Menu
    {
        public static void Menuler()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.Write("Seçim: ");
        }
        public static int SecimYap()
        {
            int secim;
            while (!int.TryParse(Console.ReadLine(), out secim))
            {
                Console.WriteLine("Geçersiz giriş.");
                Console.WriteLine();
                Menuler();
            }
            return secim;
        }
        public static void SecimiUygula(int secim)
        {
            switch (secim)
            {
                case 1:
                    Islemler.KisiKaydet();
                    break;
                case 2:
                    Islemler.KisiSil();
                    break;
                case 3:
                    Islemler.KisiGuncelle();
                    break;
                case 4:
                    Islemler.KisiListele();
                    break;
                case 5:
                    Islemler.KisiAra();
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
