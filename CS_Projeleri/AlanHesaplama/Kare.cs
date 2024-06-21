using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Kare : Sekil
    {
        private double kenar;

        public double Kenar { get => kenar; set => kenar = value; }

        public override double AlanHesapla()
        {
            double alan = Kenar * Kenar;
            return alan;
        }

        public override double CevreHesapla()
        {
            double cevre = 4 * Kenar;
            return cevre;
        }

        public override double HacimHesapla()
        {
            double hacim=Kenar* Kenar* Kenar;
            return hacim;
        }

        public override void Prizma()
        {
            throw new NotImplementedException();
        }
        public void KenarBilgisi()
        {
            Console.Write("Karenin kenarını giriniz: ");
            double kenar=double.Parse(Console.ReadLine());
            Kenar = kenar;
        }
    }
}
