using System.Reflection.Metadata.Ecma335;
using VotingUygulamasi;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Kullanici> kullanicilar = new List<Kullanici>();
        kullanicilar.Add(new Kullanici { KullaniciAdi = "kullanici1", KullaniciSifresi = "sifre1" });
        kullanicilar.Add(new Kullanici { KullaniciAdi = "kullanici2", KullaniciSifresi = "sifre2" });
        Kategori film = new Kategori { KategoriAdi = "Film Kategorileri", OySayisi = 25 };
        Kategori dizi = new Kategori { KategoriAdi = "Dizi Kategorileri", OySayisi = 20 };
        Kategori kitap = new Kategori { KategoriAdi = "Kitap Kategorileri", OySayisi = 30 };
        Kategori tech = new Kategori { KategoriAdi = "Tech Stack Kategorileri", OySayisi = 15 };
        Kategori spor = new Kategori { KategoriAdi = "Spor Kategorileri", OySayisi = 20 };
        double yuzdeToplam = film.OySayisi + dizi.OySayisi + kitap.OySayisi + tech.OySayisi + spor.OySayisi;


        while (true)
        {
            Console.WriteLine("OYLAMA");
            Console.WriteLine();
            Console.WriteLine("Oy verebilmek için kullanıcı girişi yapmalısınız.");
            Console.Write("Kullanıcı Adı: ");
            string adGiris = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifreGiris = Console.ReadLine();

            if (KullaniciVarMi(kullanicilar, adGiris, sifreGiris))
            {
                Kullanici bul = kullanicilar.FirstOrDefault(k => k.KullaniciAdi == adGiris && k.KullaniciSifresi == sifreGiris);
                Console.WriteLine("Giriş başarılı.");
                Islemler.GeriSayim();
                Console.WriteLine($"Kullanıcı Adı: {bul.KullaniciAdi}");
                if (bul.OyVerdiMi)
                {
                    Console.WriteLine($"{bul.KullaniciAdi} kullanıcısı {bul.VerdigiOy} kategorisine oy vermiştir.");
                    Islemler.OyYuzdesiYazdir(yuzdeToplam, film, dizi, kitap, tech, spor);
                }
                else
                {
                    Console.WriteLine();
                    Islemler.OylamaKategorileriYaz(film, dizi, kitap, tech, spor);
                    Islemler.SecimiUygula(yuzdeToplam, film, dizi, kitap, tech, spor, bul);
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı. Yeni kullanıcı kaydı oluşturmalısınız.");
                Console.Write("Yeni Kullanıcı Adı: ");
                string yeniAd = Console.ReadLine();
                Console.Write("Yeni Şifre: ");
                string yeniSifre = Console.ReadLine();
                Console.WriteLine($"Kullanıcı adınız '{yeniAd}' ve şifreniz '{yeniSifre}. Onaylıyor musunuz? (Y/N)");
                string onay = Console.ReadLine();
                if (onay.ToLower() == "y")
                {
                    Kullanici yeniK = new Kullanici { KullaniciAdi = yeniAd, KullaniciSifresi = yeniSifre };
                    kullanicilar.Add(yeniK);
                    Console.WriteLine("Yeni kullanıcı eklendi.");
                    Islemler.GeriSayim();
                    continue;
                }
                else if (onay.ToLower() == "n")
                {
                    continue;
                }
            }
            //foreach (var kullanici in kullanicilar)
            //{
            //    if (adGiris == kullanici.KullaniciAdi)
            //    {
            //        Console.Write("Şifre: ");
            //        string sifreGiris = Console.ReadLine();
            //        if (sifreGiris == kullanici.KullaniciSifresi)
            //        {
            //            Console.WriteLine("Giriş başarılı.");
            //            kontrol = true;
            //            Islemler.GeriSayim();
            //            Console.WriteLine($"Kullanıcı Adı: {kullanici.KullaniciAdi}");
            //            if (kullanici.OyVerdiMi)
            //            {
            //                Console.WriteLine($"{kullanici.KullaniciAdi} kullanıcısı {kullanici.VerdigiOy} kategorisine oy vermiştir.");
            //                Islemler.OyYuzdesiYazdir(yuzdeToplam, film, dizi, kitap, tech, spor);

            //            }
            //            else
            //            {
            //                Console.WriteLine();
            //                Islemler.OylamaKategorileriYaz(film, dizi, kitap, tech, spor);
            //                Islemler.SecimiUygula(yuzdeToplam, film, dizi, kitap, tech, spor, kullanici);
            //            }
            //            break;
            //        }

            //    }
            //    else
            //    {
            //        kontrol = false;
            //    }

            //}

            //if (kontrol == false)
            //{
            //    Console.WriteLine("Kullanıcı bulunamadı. Yeni kullanıcı kaydı oluşturmalısınız.");
            //    Console.Write("Yeni Kullanıcı Adı: ");
            //    string yeniAd = Console.ReadLine();
            //    Console.Write("Yeni Şifre: ");
            //    string yeniSifre = Console.ReadLine();
            //    Console.WriteLine($"Kullanıcı adınız '{yeniAd}' ve şifreniz '{yeniSifre}. Onaylıyor musunuz? (Y/N)");
            //    string onay = Console.ReadLine();
            //    if (onay.ToLower() == "y")
            //    {
            //        Kullanici yeniK=new Kullanici { KullaniciAdi = yeniAd, KullaniciSifresi = yeniSifre };
            //        kullanicilar.Add(yeniK);
            //        Console.WriteLine("Yeni kullanıcı eklendi.");
            //        Islemler.GeriSayim();
            //        continue;
            //    }
            //    else if (onay.ToLower() == "n")
            //    {
            //        continue;
            //    }
            //}

            while (true)
            {
                Console.WriteLine("Çıkış yapmak için e harfine basınız.");
                string giris = Console.ReadLine();
                if (giris.ToLower() == "e")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş.");
                }
            }
        }
    }
    public static bool KullaniciVarMi(List<Kullanici> kullanicilar,string ad,string sifre)
    {
        bool kullaniciVarMi = kullanicilar.Any(k => k.KullaniciAdi == ad && k.KullaniciSifresi == sifre);
        return kullaniciVarMi;
    }
}