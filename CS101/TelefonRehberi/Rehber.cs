using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Rehber
    {
        private string _isim;
        private string _soyisim;
        private string _numara;
        private static Rehber _kisi;
        private List<string> _kayitlar;

        public string Isim { get => _isim; set => _isim = value; }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public string Numara { get => _numara; set => _numara = value; }
        public static Rehber Kisi()
        {
            if (_kisi == null)
                _kisi = new Rehber();

            return _kisi;
        }
        public List<string> Kayitlar { get => _kayitlar; set => _kayitlar = value; }



        private Rehber()
        {
            Kayitlar = new List<string>();
        }
        public static void KisiKaydet()
        {
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Yeni Kişi Kaydı");

            Rehber kisi = Rehber.Kisi();
            while (true)
            {
                Console.Write("Lütfen isim giriniz: ");
                kisi.Isim = Console.ReadLine();

                Console.Write("Lütfen soyisim giriniz: ");
                kisi.Soyisim = Console.ReadLine();

                Console.Write("Lütfen telefon numarası giriniz: ");
                kisi.Numara = Console.ReadLine();
                if (!HepsiHarfMi(kisi.Isim))
                {
                    Console.WriteLine("İsim ve soyisim bilgileri yalnızca harflerden oluşmalıdır!");
                    continue;
                }
                else if (!HepsiHarfMi(kisi.Soyisim))
                {
                    Console.WriteLine("İsim ve soyisim bilgileri yalnızca harflerden oluşmalıdır!");
                    continue;
                }
                else if (!HepsiNumaraMi(kisi.Numara))
                {
                    Console.WriteLine("Telefon numarası yalnızca rakamlardan oluşmalıdır!");
                    continue;
                }
                else if(!NumaraHane(kisi.Numara))
                {
                    Console.WriteLine("Telefon numarası 10 haneden küçük olmamalıdır!");
                    continue;
                }
                else
                {
                    string kayit = kisi.Isim + " " + kisi.Soyisim + " " + kisi.Numara;
                    kisi.Kayitlar.Add(kayit);
                    Console.WriteLine("Kişi rehbere başarıyla kaydedildi.");
                    break;
                }

                

            }
        }
        public static void KisiSil()
        {
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Kişi Silme");
            Rehber kisi = Rehber.Kisi();

            while (true)
            {
                Console.Write("Silmek istediğiniz kişinin ismini veya soyismini giriniz: ");

                string bilgi = Console.ReadLine();
                if (!HepsiHarfMi(bilgi))
                {
                    Console.WriteLine("Kişi bilgilerinde geçersiz karakter var, lütfen tekrar deneyiniz!");
                    continue;
                }

                while(true)
                {
                    string silinecekKisi = KisiAra(bilgi);
                    if(silinecekKisi==null)
                    {
                        return;
                    }
                    else if(silinecekKisi=="")
                    {
                        break;
                    }
                    else
                    {
                        string[] adSoyad = silinecekKisi.Split(' ');
                        Console.WriteLine($"'{adSoyad[0]} {adSoyad[1]}' kişisi silinecektir, onaylıyor musunuz? (Y/N)");
                        string onay = Console.ReadLine();
                        if (onay.ToUpper() == "Y")
                        {
                            kisi.Kayitlar.Remove(silinecekKisi);
                            Console.WriteLine($"'{adSoyad[0]} {adSoyad[1]}' kişisi başarıyla silinmiştir.");
                            return;
                        }
                        else if (onay.ToUpper() == "N")
                        {
                            Console.WriteLine("Silme işlemi iptal edildi.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim. Lütfen yukarıdaki seçeneklerden birini yazınız.");
                        }
                    }
                    
                }
                
            }
        }
        public static void KisiGuncelle()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Kişi Bilgileri Güncelleme");
            Rehber kisi = Rehber.Kisi();

            while (true)
            {
                Console.Write("Güncellemek istediğiniz kişinin ismini veya soyismini giriniz: ");

                string bilgi = Console.ReadLine();
                if (!HepsiHarfMi(bilgi))
                {
                    Console.WriteLine("Kişi bilgilerinde geçersiz karakter var, lütfen tekrar deneyiniz!");
                }
                while (true)
                {
                    string guncellenecekKisi = KisiAra(bilgi);
                    if (guncellenecekKisi == null)
                    {
                        return;
                    }
                    else if (guncellenecekKisi == "")
                    {
                        break;
                    }
                    else
                    {
                        string[] adSoyad = guncellenecekKisi.Split(' ');
                        Console.WriteLine($"'{adSoyad[0]} {adSoyad[1]}' kişisi güncellenecektir.");
                        Console.Write("Lütfen yeni ismi giriniz: ");
                        kisi.Isim = Console.ReadLine();

                        Console.Write("Lütfen yeni soyismi giriniz: ");
                        kisi.Soyisim = Console.ReadLine();

                        Console.Write("Lütfen yeni telefon numarasını giriniz: ");
                        kisi.Numara = Console.ReadLine();
                        if (!HepsiHarfMi(kisi.Isim))
                        {
                            Console.WriteLine("İsim ve soyisim bilgileri yalnızca harflerden oluşmalıdır!");
                            continue;
                        }
                        if (!HepsiHarfMi(kisi.Soyisim))
                        {
                            Console.WriteLine("İsim ve soyisim bilgileri yalnızca harflerden oluşmalıdır!");
                            continue;
                        }
                        if (!HepsiNumaraMi(kisi.Numara))
                        {
                            Console.WriteLine("Telefon numarası yalnızca rakamlardan oluşmalıdır!");
                            continue;
                        }
                        if (!NumaraHane(kisi.Numara))
                        {
                            Console.WriteLine("Telefon numarası 10 haneden küçük olmamalıdır!");
                            continue;
                        }
                        string kayit = kisi.Isim + " " + kisi.Soyisim + " " + kisi.Numara;
                        kisi.Kayitlar.Remove(guncellenecekKisi);
                        kisi.Kayitlar.Add(kayit);
                        Console.WriteLine("Kişi bilgisi başarıyla güncellendi.");
                        return;
                    }
                }

            }
        }
        public static void KisiListele()
        {

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Rehberdeki Kişiler");
            Rehber kisi = Rehber.Kisi();

            foreach (var k in kisi.Kayitlar)
            {
                string[] veri = k.Split(' ');
                string numara = veri[2];
                Console.WriteLine($"İsim: {veri[0]} Soyisim: {veri[1]} Numara: {TelefonFormati(numara)}");
            }
            Console.WriteLine();
        }
        public static void KisiAra()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");
            string secim=Console.ReadLine();
            Rehber kisi = Rehber.Kisi();
            bool kontrol = false;
            kisi.Kayitlar.Sort();

            if(secim=="1")
            {
                while (true)
                {
                    Console.Write("Aramak istediğiniz kişinin isim veya soyismini giriniz: ");
                    string kisiBilgi = Console.ReadLine();
                    if (!HepsiHarfMi(kisiBilgi))
                    {
                        Console.WriteLine("İsim ve soyisim bilgileri yalnızca harflerden oluşmalıdır!");
                        continue;
                    }
                    else
                    {
                        foreach (var kayit in kisi.Kayitlar)
                        {
                            string kayitKucuk = kayit.ToLower();

                            if (kayitKucuk.Contains(kisiBilgi))
                            {
                                Console.WriteLine(kayit);
                                kontrol = true;
                            }
                        }

                        if (!kontrol)
                        {
                            Console.WriteLine("Aradığınız kişi bulunamadı! Lütfen bir seçim yapınız: ");
                            Console.WriteLine("İşlemi sonlandırmak için  : (1)");
                            Console.WriteLine("Yeniden denemek için      : (2)");
                            string s = Console.ReadLine();
                            if(s=="1")
                            {
                                return;
                            }
                            else if(s=="2")
                            {
                                continue;
                            }

                        }
                        break;
                    }
                }
            }
            if(secim=="2")
            {
                while(true)
                {
                    Console.Write("Aramak istediğiniz kişinin numarasını giriniz: ");

                    string numara = Console.ReadLine();
                    if (!HepsiNumaraMi(numara))
                    {
                        Console.WriteLine("Telefon numarası yalnızca rakamlardan oluşmalıdır!");
                        continue;
                    }
                    else
                    {
                        foreach (var num in kisi.Kayitlar)
                        {
                            if (num.Contains(numara))
                            {
                                Console.WriteLine(num);
                                kontrol = true;
                            }
                        }
                        if (!kontrol)
                        {
                            Console.WriteLine("Aradığınız numara bulunamadı! Lütfen bir seçim yapınız: ");
                            Console.WriteLine("İşlemi sonlandırmak için  : (1)");
                            Console.WriteLine("Yeniden denemek için      : (2)");
                            string s = Console.ReadLine();
                            if (s == "1")
                            {
                                return;
                            }
                            else if (s == "2")
                            {
                                continue;
                            }
                        }
                        break;
                    }
                    
                }
            }
            
        }
        public static string KisiAra(string kisiBilgi)
        {

            Rehber kisi = Rehber.Kisi();
            List<string> aramaSonuclari = new List<string>();
            bool kontrol = false;
            kisi.Kayitlar.Sort();

            while (true)
            {
                foreach (var kayit in kisi.Kayitlar)
                {
                    string kayitKucuk = kayit.ToLower();

                    if (kayitKucuk.Contains(kisiBilgi))
                    {
                        Console.WriteLine(kayit);
                        aramaSonuclari.Add(kayit);
                        kontrol = true;
                    }
                }


                if (!kontrol)
                {
                    Console.WriteLine("Aradığınız kişi bulunamadı! Lütfen bir seçim yapınız: ");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("Yeniden denemek için      : (2)");
                    string s = Console.ReadLine();
                    if (s == "1")
                    {
                        return null;
                    }
                    else if (s == "2")
                    {
                        return "";
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen yukarıdaki seçeneklerden birini yazınız.");

                    }


                }
                return aramaSonuclari[0];
            }

        }
        public static bool HepsiHarfMi(string veri)
        {
            foreach (char c in veri)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public static bool HepsiNumaraMi(string numara)
        {
            foreach (char c in numara)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static string TelefonFormati(string numara)
        {
            string duzenlenenNumara;

            if (numara.StartsWith("0"))
            {
                duzenlenenNumara = string.Format("0({0}) {1}-{2}-{3}",
                            numara.Substring(1, 3),
                            numara.Substring(4, 3),
                            numara.Substring(7, 2),
                            numara.Substring(9, 2));
            }
            else
            {
                duzenlenenNumara = string.Format("0({0}) {1}-{2}-{3}",
                            numara.Substring(0, 3),
                            numara.Substring(3, 3),
                            numara.Substring(6, 2),
                            numara.Substring(8, 2));
            }
            return duzenlenenNumara;
        }
        public static bool NumaraHane(string numara)
        {
            bool kontrol = true;
            if(numara.Length<10)
            {
                kontrol = false;
            }
            return kontrol;
        }
    }
}

