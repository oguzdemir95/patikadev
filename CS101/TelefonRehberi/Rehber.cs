using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Rehber
    {
        private string _isim;
        private string _soyisim;
        private string _numara;
        private static Rehber _kisi;
        private List<string> _kayitlar;

        public string Isim { get => _isim; set => _isim = value; }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public string Numara { get => _numara; set => _numara = value; }
        public static Rehber Kisi()
        {
            if (_kisi == null)
                _kisi = new Rehber();

            return _kisi;
        }
        public List<string> Kayitlar { get => _kayitlar; set => _kayitlar = value; }
        private Rehber()
        {
            Kayitlar = new List<string>();
            Kayitlar.Add("Burak Yılmaz 05111234567");
            Kayitlar.Add("Serkan Güven 05119876543");
            Kayitlar.Add("Aylin Güney 05112345678");
            Kayitlar.Add("Pelin Aydın 05118765432");
            Kayitlar.Add("Mehmet Yıldız 05110123456");
        }
    }
}

