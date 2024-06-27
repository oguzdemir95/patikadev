using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public class Musteri
    {
        private int _musteriNumarasi;
        private int _musteriSifresi;
        private string _musteriAdi;
        private string _musteriSoyadi;
        private double _bakiye;

        public int MusteriNumarasi { get => _musteriNumarasi; set => _musteriNumarasi = value; }
        public int MusteriSifresi { get => _musteriSifresi; set => _musteriSifresi = value; }
        
        public string MusteriAdi { get => _musteriAdi; set => _musteriAdi = value; }
        public string MusteriSoyadi { get => _musteriSoyadi; set => _musteriSoyadi = value; }
        public double Bakiye { get => _bakiye; set => _bakiye = value; }

        public static bool MusteriVarMi(List<Musteri> musteriler, int musterino)
        {
            bool kontrol = musteriler.Any(m => m.MusteriNumarasi == musterino);
            return kontrol;
        }
        public static bool MusteriVarMi(List<Musteri> musteriler, int musterino, int musterisifre)
        {
            bool kontrol = musteriler.Any(m => m.MusteriNumarasi == musterino && m.MusteriSifresi == musterisifre);
            return kontrol;
        }

        public static Musteri MusteriBul(List<Musteri> musteriler,int musterino)
        {
            Musteri bul = musteriler.FirstOrDefault(m => m.MusteriNumarasi == musterino);
            return bul;
        }
    }
}
