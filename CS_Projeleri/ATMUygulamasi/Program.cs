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

        string musterino = "";
        string musterisifre = "";
        bool kontrol = true;
        bool noKontrol = true;
        bool sKontrol = true;

        Menu.Giris(atm);
        while (noKontrol)
        {
            Console.Write("Müşteri Numarası: ");
            musterino = Console.ReadLine();
            noKontrol = Musteri.MusteriNumarasiKontrol(musterino);
        }
        while (sKontrol)
        {
            Console.Write("Müşteri Şifresi: ");
            musterisifre = Console.ReadLine();
            sKontrol = Musteri.MusteriSifresiKontrol(musterisifre);
        }

        while (kontrol)
        {
            if (Musteri.MusteriVarMi(musteriler, musterino, musterisifre))
            {
                Musteri girisYapan = Musteri.MusteriBul(musteriler, musterino);
                Menu.AtmMenu(girisYapan);
                string secim = Console.ReadLine();

                Menu.SecimiUygula(secim, atm, girisYapan, musteriler, kontrol);
                atm.HesaptanCikis(kontrol);
                kontrol = false;
            }
            else
                Console.WriteLine("Müşteri bulunamadı.");
        }
    }
}