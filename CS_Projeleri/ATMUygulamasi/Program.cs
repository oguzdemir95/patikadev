using ATMUygulamasi;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Musteri> musteriler = new List<Musteri>();
        AtmMakine atm = new AtmMakine { BankaAdi = "Senin Finansın", AtmKodu = 1058, AtmKonumu = "Çankaya" };
        Musteri musteri1 = new Musteri { MusteriNumarasi = "10105566", MusteriSifresi = "123456", MusteriAdi = "Oğuzhan", MusteriSoyadi = "Demir", Bakiye = 20000 };
        Musteri musteri2 = new Musteri { MusteriNumarasi = "10102233", MusteriSifresi = "147852", MusteriAdi = "Baturhan", MusteriSoyadi = "Demir", Bakiye = 20000 };
        musteriler.Add(musteri1);
        musteriler.Add(musteri2);

        Loglar logGunSonu = new Loglar();

        string musterino = "";
        string musterisifre = "";
        bool kontrol = true;
        bool noKontrol = true;
        bool sKontrol = true;
        string zaman="";

        Menu.Giris(atm);
        while (noKontrol)
        {
            Console.Write("Müşteri Numarası: ");
            musterino = Console.ReadLine();
            noKontrol = Musteri.MusteriNumarasiKontrol(musterino);
        }
        while (sKontrol)
        {
            zaman = DateTime.Now.ToLongTimeString();
            Console.Write("Müşteri Şifresi: ");
            musterisifre = Console.ReadLine();
            sKontrol = Musteri.MusteriSifresiKontrol(musterisifre);
            if(sKontrol)
            {
                logGunSonu.HatalıSifreYaz(musteriler,musterino, zaman);
            }
        }

        while (kontrol)
        {
            if (Musteri.MusteriVarMi(musteriler, musterino, musterisifre))
            {
                zaman = DateTime.Now.ToLongTimeString();
                Musteri girisYapan = Musteri.MusteriBul(musteriler, musterino);
                Menu.AtmMenu(girisYapan);
                string secim = Console.ReadLine();

                Menu.SecimiUygula(secim, atm, girisYapan, musteriler, kontrol);
                atm.HesaptanCikis(kontrol);
                kontrol = false;
                logGunSonu.IslemiYaz(girisYapan, zaman,secim);

            }
            else
            {
                Console.WriteLine("Müşteri bulunamadı.");
                kontrol = false;
                logGunSonu.MusteriBulunamadiYaz(musterino, zaman);
            }

        }
    }
}