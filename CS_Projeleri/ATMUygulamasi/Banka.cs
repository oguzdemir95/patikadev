using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public class Banka
    {
        private string _bankaAdi;

        public string BankaAdi { get => _bankaAdi; set => _bankaAdi = value; }

        public double ParaCek(double bakiye, double cekilen)
        {
            if (cekilen <= bakiye)
            {
                bakiye -= cekilen;
                return bakiye;
            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersiz.");
                return bakiye;
            }
        }

        public double ParaYatir(double bakiye,double yatirilan)
        {
            bakiye += yatirilan;
            return bakiye;

        }

        public void ParaGonder(double bakiye,double gonderilen,int hesapno)
        {

        }

        public void OdemeYap()
        {

        }

    }
}
