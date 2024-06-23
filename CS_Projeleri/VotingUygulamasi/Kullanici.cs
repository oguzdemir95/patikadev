using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingUygulamasi
{
    internal class Kullanici
    {
        private int kullaniciID;
        private string kullaniciAdi;
        private string kullaniciSifresi;

        public int KullaniciID { get => kullaniciID; set => kullaniciID = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string KullaniciSifresi { get => kullaniciSifresi; set => kullaniciSifresi = value; }

        public Kullanici()
        {
        }
    }
}
