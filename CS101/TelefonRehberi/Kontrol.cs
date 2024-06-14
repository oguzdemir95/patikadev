using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Kontrol
    {
        public static bool HepsiHarfMi(string veri)
        {
            foreach (char c in veri)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public static bool HepsiNumaraMi(string numara)
        {
            foreach (char c in numara)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static string TelefonFormati(string numara)
        {
            string duzenlenenNumara;

            if (numara.StartsWith("0"))
            {
                duzenlenenNumara = string.Format("0({0}) {1}-{2}-{3}",
                            numara.Substring(1, 3),
                            numara.Substring(4, 3),
                            numara.Substring(7, 2),
                            numara.Substring(9, 2));
            }
            else
            {
                duzenlenenNumara = string.Format("0({0}) {1}-{2}-{3}",
                            numara.Substring(0, 3),
                            numara.Substring(3, 3),
                            numara.Substring(6, 2),
                            numara.Substring(8, 2));
            }
            return duzenlenenNumara;
        }
        public static bool NumaraHane(string numara)
        {
            bool kontrol = true;
            if (numara.Length < 10||numara.Length>11)
            {
                kontrol = false;
            }
            return kontrol;
        }
        public static bool BulunamadiSecim()
        {
            bool kontrol = true;
            Console.WriteLine("İşlemi sonlandırmak için  : (1)");
            Console.WriteLine("Yeniden denemek için      : (2)");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    return false;
                case "2":
                    return true;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    return BulunamadiSecim();
            }
            return kontrol;
        }
    }
}
