﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public class AtmMakine:Banka
    {
        #region Alanlar
        private int _atmKodu;
        private string _atmKonumu;
        #endregion

        #region Kapsülleme
        public int AtmKodu { get => _atmKodu; set => _atmKodu = value; }
        public string AtmKonumu { get => _atmKonumu; set => _atmKonumu = value; }
        #endregion

        #region ATM İşlemleri
        public void HesaptanCikis(bool kontrol)
        {
            Console.WriteLine("Hesaptan çıkış yapılıyor.");
            Console.WriteLine("3...");
            Thread.Sleep(1000);
            Console.WriteLine("2...");
            Thread.Sleep(1000); 
            Console.WriteLine("1...");
            Thread.Sleep(1000);
        }
        #endregion
    }
}
