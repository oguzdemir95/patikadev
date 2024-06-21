﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Daire : Sekil
    {
        private double yaricap;

        public double Yaricap { get => yaricap; set => yaricap = value; }

        public override double AlanHesapla()
        {
            double alan = Math.PI * Yaricap * Yaricap;
            return alan;
        }

        public override double CevreHesapla()
        {
            double cevre = 2 * Math.PI * Yaricap;
            return cevre;
        }

        public override double HacimHesapla()
        {
            double hacim = (4 / 3) * Math.PI * Yaricap * Yaricap*Yaricap;
            return hacim;
        }

        public override void Prizma()
        {
            throw new NotImplementedException();
        }
        public void DaireBilgisi()
        {
            Console.Write("Dairenin yarıçapını giriniz: ");
            double yaricap=double.Parse(Console.ReadLine());
            Yaricap = yaricap;
        }
    }
}
