using ATMUygulamasi;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Musteri> musteriler = new List<Musteri>();
        AtmMakine atm = new AtmMakine { BankaAdi = "Senin Finansın", AtmKodu = 1058, AtmKonumu = "Çankaya" };
        Musteri musteri1 = new Musteri { MusteriNumarasi = 10105566, MusteriSifresi = 123456, MusteriAdi = "Oğuzhan", MusteriSoyadi = "Demir", Bakiye = 20000 };
        Musteri musteri2 = new Musteri { MusteriNumarasi = 10102233, MusteriSifresi = 147852, MusteriAdi = "Baturhan", MusteriSoyadi = "Demir", Bakiye = 20000 };
        musteriler.Add(musteri1);
        musteriler.Add(musteri2);

        bool kontrol = true;
        Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
        Console.WriteLine("GİRİŞ");
        Console.WriteLine();
        Console.Write("Müşteri Numarası: ");
        int musterino = int.Parse(Console.ReadLine());
        Console.Write("Müşteri Şifresi: ");
        int musterisifre = int.Parse(Console.ReadLine());

        while (kontrol)
        {
            if (Musteri.MusteriVarMi(musteriler, musterino, musterisifre))
            {
                Musteri girisYapan = Musteri.MusteriBul(musteriler, musterino);
                Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
                AtmMenu();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
                        Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
                        atm.ParaCek(girisYapan);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
                        Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
                        atm.ParaYatir(girisYapan);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
                        Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
                        atm.ParaGonder(musteriler, girisYapan);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
                        Console.WriteLine($"Müşteri Numarası: {girisYapan.MusteriNumarasi} {girisYapan.MusteriAdi} {girisYapan.MusteriSoyadi}");
                        atm.OdemeYap(girisYapan);
                        break;
                    case "5":
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz giriş.");
                        break;
                }
            }
            else
                Console.WriteLine("Müşteri bulunamadı.");
        }
    }
    public static void AtmMenu()
    {
        Console.WriteLine();
        Console.WriteLine("İşlem Listesi");
        Console.WriteLine("(1) Para Çek");
        Console.WriteLine("(2) Para Yatır");
        Console.WriteLine("(3) Para Gönder");
        Console.WriteLine("(4) Ödeme Yap");
        Console.WriteLine("(5) Hesaptan Çıkış");
        Console.Write("Seçim: ");
    }

}