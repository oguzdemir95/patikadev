using VotingUygulamasi;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Kullanici> kullanicilar= new List<Kullanici>();
        kullanicilar.Add(new Kullanici { KullaniciAdi = "kullanici1", KullaniciSifresi = "sifre1" });
        kullanicilar.Add(new Kullanici { KullaniciAdi = "kullanici2", KullaniciSifresi = "sifre2" });
        Console.WriteLine("Oylama Kategorileri");
        Console.WriteLine("*******************");
        Console.WriteLine("(1) Film Kategorileri");
        Console.WriteLine("(2) Tech Stack Kategorileri");
        Console.WriteLine("(3) Spor Kategorileri");

        Console.WriteLine("Oy verebilmek için kullanıcı girişi yapmalısınız.");
        bool kontrol = true;
        while (true)
        {
            Console.Write("Kullanıcı Adı: ");
            string adGiris= Console.ReadLine();
            foreach (var kullanici in kullanicilar)
            {
                if(adGiris==kullanici.KullaniciAdi)
                {
                    Console.Write("Şifre: ");
                    string sifreGiris = Console.ReadLine();
                    if (sifreGiris == kullanici.KullaniciSifresi)
                    {
                        Console.WriteLine("Giriş başarılı.");
                        kontrol = true;
                        break;
                    }
                    
                }
                else
                {
                    kontrol = false;
                }

            }
            if (kontrol == false)
            {
                Console.WriteLine("Kullanıcı bulunamadı. Yeni kullanıcı kaydı oluşturmalısınız.");
                Console.Write("Yeni Kullanıcı Adı: ");
                string yeniAd = Console.ReadLine();
                Console.Write("Yeni Şifre: ");
                string yeniSifre= Console.ReadLine();
                Console.WriteLine($"Kullanıcı adınız '{yeniAd}' ve şifreniz '{yeniSifre}. Onaylıyor musunuz? (Y/N)");
                string onay = Console.ReadLine();
                if(onay.ToLower()=="y")
                {
                    kullanicilar.Add(new Kullanici { KullaniciAdi = yeniAd, KullaniciSifresi = yeniSifre });
                    Console.WriteLine("Yeni kullanıcı eklendi.");
                }
                else if(onay.ToLower()=="n")
                {
                    break;
                }
                break;
            }
            break;
        }
        

    }
}