using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Ucgen : Sekil
    {
        private double birinciKenar;
        private double ikinciKenar;
        private double ucuncuKenar;
        private double taban;
        private double yukseklik;
        private double prizmaYukseklik;

        public double BirinciKenar { get => birinciKenar; set => birinciKenar = value; }
        public double IkinciKenar { get => ikinciKenar; set => ikinciKenar = value; }
        public double UcuncuKenar { get => ucuncuKenar; set => ucuncuKenar = value; }
        public double Taban { get => taban; set => taban = value; }
        public double Yukseklik { get => yukseklik; set => yukseklik = value; }
        public double PrizmaYukseklik { get => prizmaYukseklik; set => prizmaYukseklik = value; }

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
            throw new NotImplementedException();
        }
        public void UcKenar()
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
    }
}
