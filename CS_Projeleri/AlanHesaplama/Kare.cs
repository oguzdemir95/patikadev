using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Kare : Sekil
    {
        #region Alanlar
        private double kenar;
        #endregion

        #region Kapsülleme
        public double Kenar { get => kenar; set => kenar = value; }
        #endregion

        #region Hesaplamalar
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
        #endregion

        #region Bilgi Alma
        public void KenarBilgisi()
        {
            Console.Write("Karenin kenarını giriniz: ");
            double kenar=double.Parse(Console.ReadLine());
            Kenar = kenar;
        }
        #endregion
    }
}
