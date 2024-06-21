using AlanHesaplama;

internal class Program
{
    private static void Main(string[] args)
    {
        

        while (true)
        {
            AnaMenu();
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Daire daire = new Daire();
                    switch (HesapMenu())
                    {
                        case "1":
                            daire.DaireBilgisi();
                            Console.WriteLine($"Dairenin çevresi: {daire.CevreHesapla():F3}");
                            break;
                        case "2":
                            daire.DaireBilgisi();
                            Console.WriteLine($"Dairenin alanı: {daire.AlanHesapla():F3}");
                            break;
                        case "3":
                            daire.DaireBilgisi();
                            Console.WriteLine($"Kürenin hacmi: {daire.HacimHesapla():F3}");
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyin.");
                            continue;
                    }
                    break;
                case "2":
                    Ucgen ucgen = new Ucgen();
                    double prizmaYukseklik;
                    switch (HesapMenu())
                    {
                        case "1":
                            ucgen.UcKenar();
                            Console.WriteLine($"Üçgenin çevresi: {ucgen.CevreHesapla():F3}");
                            break;
                        case "2":
                            ucgen.TabanYukseklik();
                            Console.WriteLine($"Üçgenin alanı: {ucgen.AlanHesapla():F3}");
                            break;
                        case "3":
                            ucgen.TabanYukseklik();
                            Console.Write("Üçgen prizma için yükseklik giriniz: ");
                            prizmaYukseklik = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Kürenin hacmi: {ucgen.HacimHesapla():F3}");
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyin.");
                            continue;
                    }
                    break;
                case "3":
                    Kare kare = new Kare();
                    double kenar;
                    switch (HesapMenu())
                    {
                        case "1":
                            kare.KenarBilgisi();
                            Console.WriteLine($"Dairenin çevresi: {kare.CevreHesapla():F3}");
                            break;
                        case "2":
                            kare.KenarBilgisi();
                            Console.WriteLine($"Karenin alanı: {kare.AlanHesapla():F3}");
                            break;
                        case "3":
                            kare.KenarBilgisi();
                            Console.WriteLine($"Küpün hacmi: {kare.HacimHesapla():F3}");
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyin.");
                            continue;
                    }
                    break;
                case "4":
                    Dikdortgen dikdortgen = new Dikdortgen();
                    double kisaKenar;
                    double uzunKenar;
                    switch (HesapMenu())
                    {
                        case "1":
                            dikdortgen.KenarBilgisi();
                            Console.WriteLine($"Dikdörtgenin çevresi: {dikdortgen.CevreHesapla():F3}");
                            break;
                        case "2":
                            dikdortgen.KenarBilgisi();
                            Console.WriteLine($"Digdörtgenin alanı: {dikdortgen.AlanHesapla():F3}");
                            break;
                        case "3":
                            dikdortgen.KenarBilgisi();
                            
                            Console.WriteLine($"Dikdörtgen prizmanın hacmi: {dikdortgen.HacimHesapla():F3}");
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyin.");
                            continue;
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyin.");
                    continue;
            }
            break;
        }

    }
    public static void AnaMenu()
    {
        Console.WriteLine("İşlem yapmak istediğiniz şekli seçiniz.");
        Console.WriteLine("(1) Daire");
        Console.WriteLine("(2) Üçgen");
        Console.WriteLine("(3) Kare");
        Console.WriteLine("(4) Dikdörtgen");
    }
    public static string HesapMenu()
    {
        Console.WriteLine("Hesaplama yapmak istediğiniz türü seçiniz.");
        Console.WriteLine("(1) Çevre");
        Console.WriteLine("(2) Alan");
        Console.WriteLine("(3) Hacim");
        string ikinciSecim= Console.ReadLine();
        return ikinciSecim;
    }
}