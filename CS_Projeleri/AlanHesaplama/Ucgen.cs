using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Ucgen : Sekil
    {
        #region Alanlar
        private double birinciKenar;
        private double ikinciKenar;
        private double ucuncuKenar;
        private double taban;
        private double yukseklik;
        private double prizmaYukseklik;
        #endregion

        #region Kapsülleme
        public double BirinciKenar { get => birinciKenar; set => birinciKenar = value; }
        public double IkinciKenar { get => ikinciKenar; set => ikinciKenar = value; }
        public double UcuncuKenar { get => ucuncuKenar; set => ucuncuKenar = value; }
        public double Taban { get => taban; set => taban = value; }
        public double Yukseklik { get => yukseklik; set => yukseklik = value; }
        public double PrizmaYukseklik { get => prizmaYukseklik; set => prizmaYukseklik = value; }
        #endregion

        #region Hesaplamalar
        public override double AlanHesapla()
        {
            double alan = Taban * Yukseklik / 2;
            return alan;
        }

        public override double CevreHesapla()
        {
            double cevre = BirinciKenar + IkinciKenar + UcuncuKenar;
            return cevre;
        }

        public override double HacimHesapla()
        {
            double hacim = AlanHesapla() * PrizmaYukseklik;
            return hacim;
        }

        public override void Prizma()
        {
            Console.Write("Üçgen prizma için yükseklik giriniz: ");
            prizmaYukseklik = double.Parse(Console.ReadLine());
            PrizmaYukseklik = prizmaYukseklik;
        }
        #endregion

        #region Bilgi Alma
        public void UcKenar()
        {
            while (true)
            {
                Console.Write("Üçgenin birinci kenarını giriniz: ");
                double birinciKenar = double.Parse(Console.ReadLine());
                BirinciKenar = birinciKenar;
                Console.Write("Üçgenin ikinci kenarını giriniz: ");
                double ikinciKenar = double.Parse(Console.ReadLine());
                IkinciKenar = ikinciKenar;
                Console.Write("Üçgenin üçüncü kenarını giriniz: ");
                double ucuncuKenar = double.Parse(Console.ReadLine());
                UcuncuKenar = ucuncuKenar;

                double birIki = birinciKenar + ikinciKenar;
                double birUc = birinciKenar + ucuncuKenar;
                double ikiUc = ikinciKenar + ucuncuKenar;

                if (!(birIki >= ucuncuKenar) || !(birUc >= ikinciKenar) || !(ikiUc >= birinciKenar))
                {
                    Console.WriteLine("Kenar uzunlukları üçgen eşitsizliğine uygun olmalıdır.");
                    Console.WriteLine("a + b >= c veya a + c >= b veya b + c >= a");
                    Console.WriteLine();
                    continue;
                }
                //if(!(birinciKenar>0)||!(ikinciKenar>0)||!(ucuncuKenar>0))
                //{
                //    Console.WriteLine("Kenar uzunlukları pozitif olmalıdır.");
                //    Console.WriteLine();
                //    continue;
                //}
            }
        }
        public void TabanYukseklik()
        {
            Console.Write("Üçgenin tabanını giriniz: ");
            double taban=double.Parse(Console.ReadLine());
            Taban = taban;
            Console.Write("Üçgenin yüksekliğini giriniz: ");
            double yukseklik = double.Parse(Console.ReadLine());
            Yukseklik = yukseklik;
        }
        #endregion
    }
}
