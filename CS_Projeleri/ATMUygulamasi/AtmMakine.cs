using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public class AtmMakine:Banka
    {
        private int _atmKodu;
        private string _atmKonumu;

        public int AtmKodu { get => _atmKodu; set => _atmKodu = value; }
        public string AtmKonumu { get => _atmKonumu; set => _atmKonumu = value; }
    }
}
