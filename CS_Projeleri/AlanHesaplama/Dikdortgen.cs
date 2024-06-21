using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Dikdortgen : Sekil
    {
        private double kisaKenar;
        private double uzunKenar;
        private double prizmaYukseklik;

        public double KisaKenar { get => kisaKenar; set => kisaKenar = value; }
        public double UzunKenar { get => uzunKenar; set => uzunKenar = value; }
        public double PrizmaYukseklik { get => prizmaYukseklik; set => prizmaYukseklik = value; }

        public override double AlanHesapla()
        {
            double alan = KisaKenar * UzunKenar;
            return alan;
        }

        public override double CevreHesapla()
        {
            double cevre = 2 * (KisaKenar + UzunKenar);
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
        public void KenarBilgisi()
        {
            Console.Write("Dikdörtgenin kısa kenarını giriniz: ");
            double kisaKenar=double.Parse(Console.ReadLine());
            KisaKenar = kisaKenar;
            Console.Write("Dikdörtgenin uzun kenarını giriniz: ");
            double uzunKenar = double.Parse(Console.ReadLine());
            UzunKenar = uzunKenar;
        }
    }
}
