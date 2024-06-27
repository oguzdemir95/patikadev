using ATMUygulamasi;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Musteri> musteriler=new List<Musteri>();
        AtmMakine atm=new AtmMakine { BankaAdi="Senin Finansın", AtmKodu = 1058, AtmKonumu = "Çankaya" };
        Musteri musteri1 = new Musteri { MusteriNumarasi = 10105566, MusteriSifresi = 123456, MusteriAdi = "Oğuzhan", MusteriSoyadi="Demir",Bakiye = 20000 };
        musteriler.Add(musteri1);

        Console.WriteLine($"{atm.BankaAdi} {atm.AtmKodu} numaralı ATM {atm.AtmKonumu}");
        Console.WriteLine("GİRİŞ");
        Console.WriteLine();
        Console.Write("Müşteri Numarası: ");
        int musterino = int.Parse(Console.ReadLine());
        Console.Write("Müşteri Şifresi: ");
        int musterisifre=int.Parse(Console.ReadLine());
        bool musteriVarMi=musteriler.Any(m=>m.MusteriNumarasi==musterino&&m.MusteriSifresi==musterisifre);
        if (musteriVarMi)
        {
            Console.WriteLine($"Müşteri Numarası: {musteri1.MusteriNumarasi} {musteri1.MusteriAdi} {musteri1.MusteriSoyadi}");
            Console.WriteLine();
            Console.WriteLine("İşlem Listesi");
            Console.WriteLine("(1) Para Çek");
            Console.WriteLine("(2) Para Yatır");
            Console.WriteLine("(3) Para Gönder");
            Console.WriteLine("(4) Ödeme Yap");
            Console.WriteLine("(5) Hesaptan Çıkış");
            Console.Write("Seçim: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Write($"Mevcut bakiyeniz: {musteri1.Bakiye}");
                    Console.WriteLine();
                    Console.Write("Çekmek istediğiniz miktar: ");
                    double cekilen = double.Parse(Console.ReadLine());
                    musteri1.Bakiye = atm.ParaCek(musteri1.Bakiye, cekilen);
                    Console.WriteLine($"Çekilen miktar: {cekilen}");
                    Console.WriteLine($"Bakiyeniz: {musteri1.Bakiye}");
                    break;
                case "2":
                    Console.Write($"Mevcut bakiyeniz: {musteri1.Bakiye}");
                    Console.WriteLine();
                    Console.Write("Yatırmak istediğiniz miktar: ");
                    double yatirilan = double.Parse(Console.ReadLine());
                    musteri1.Bakiye = atm.ParaYatir(musteri1.Bakiye, yatirilan);
                    Console.WriteLine($"Yatırılan miktar: {yatirilan}");
                    Console.WriteLine($"Bakiyeniz: {musteri1.Bakiye}");
                    break;
                default:
                    break;
            }
        }
        else
            Console.WriteLine("Müşteri bulunamadı.");
        

        
    }
}