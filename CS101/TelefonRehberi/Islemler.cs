using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    internal class Islemler
    {
        public static void KisiKaydet()
        {
            Console.WriteLine("Yeni Kişi Kaydı");
            Console.WriteLine("---------------");
            Rehber kisi = Rehber.Kisi();

            while (true)
            {
                Console.Write("Lütfen isim giriniz: ");
                kisi.Isim = Console.ReadLine();

                Console.Write("Lütfen soyisim giriniz: ");
                kisi.Soyisim = Console.ReadLine();

                Console.Write("Lütfen telefon numarası giriniz: ");
                kisi.Numara = Console.ReadLine();
                
                if(!Kontrol.YazimKontrol())
                {
                    continue;
                }

                string kayit = kisi.Isim + " " + kisi.Soyisim + " " + kisi.Numara;
                kisi.Kayitlar.Add(kayit);
                Console.WriteLine("Kişi rehbere başarıyla kaydedildi.");
                break;
            }
        }
        public static void KisiSil()
        {
            Console.WriteLine("Kişi Silme");
            Console.WriteLine("----------");
            Rehber kisi = Rehber.Kisi();

            while (true)
            {
                Console.Write("Silmek istediğiniz kişinin ismini veya soyismini giriniz: ");

                string bilgi = Console.ReadLine();
                if (!Kontrol.AramaKontrol(bilgi))
                {
                    continue;
                }

                while (true)
                {
                    string silinecekKisi = KisiAra(bilgi);
                    if (silinecekKisi == null)
                    {
                        return;
                    }
                    else if (silinecekKisi == "")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
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
                            Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
                        }
                    }

                }

            }
        }
        public static void KisiGuncelle()
        {
            Console.WriteLine("Kişi Bilgileri Güncelleme");
            Console.WriteLine("-------------------------");
            Rehber kisi = Rehber.Kisi();

            while (true)
            {
                Console.Write("Güncellemek istediğiniz kişinin ismini veya soyismini giriniz: ");

                string bilgi = Console.ReadLine();
                if (!Kontrol.AramaKontrol(bilgi))
                {
                    continue;
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

                        if (!Kontrol.YazimKontrol())
                        {
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
            Console.WriteLine("Rehberdeki Kişiler");
            Console.WriteLine("------------------");
            Rehber kisi = Rehber.Kisi();
            kisi.Kayitlar.Sort();

            foreach (var k in kisi.Kayitlar)
            {
                KisiYazdir(k);
            }
        }
        public static void KisiAra()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            
            Rehber kisi = Rehber.Kisi();
            bool kontrol = false;
            kisi.Kayitlar.Sort();
            while (true)
            {
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    while (true)
                    {
                        Console.Write("Aramak istediğiniz kişinin isim veya soyismini giriniz: ");
                        string kisiBilgi = Console.ReadLine();
                        if(!Kontrol.AramaKontrol(kisiBilgi))
                        {
                            continue;
                        }
                        else
                        {
                            foreach (var kayit in kisi.Kayitlar)
                            {
                                string kayitKucuk = kayit.ToLower();

                                if (kayitKucuk.Contains(kisiBilgi))
                                {
                                    KisiYazdir(kayit);
                                    kontrol = true;
                                }
                            }

                            if (!kontrol)
                            {
                                Console.WriteLine("Aradığınız kişi bulunamadı! Lütfen bir seçim yapınız: ");
                                if (!Kontrol.BulunamadiSecim())
                                {
                                    return;
                                }
                                else
                                {
                                    continue;
                                }

                            }
                            break;
                        }
                    }
                }
                else if (secim == "2")
                {
                    while (true)
                    {
                        Console.Write("Aramak istediğiniz kişinin numarasını giriniz: ");

                        string numara = Console.ReadLine();
                        if (!Kontrol.HepsiNumaraMi(numara))
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
                                    KisiYazdir(num);
                                    kontrol = true;
                                }
                            }
                            if (!kontrol)
                            {
                                Console.WriteLine("Aradığınız numara bulunamadı! Lütfen bir seçim yapınız: ");
                                if (!Kontrol.BulunamadiSecim())
                                {
                                    return;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
                    continue;
                }
                break;
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
                        KisiYazdir(kayit);
                        aramaSonuclari.Add(kayit);
                        kontrol = true;
                    }
                }

                if (!kontrol)
                {
                    Console.WriteLine("Aradığınız kişi bulunamadı! Lütfen bir seçim yapınız: ");
                    if (!Kontrol.BulunamadiSecim())
                    {
                        return null;
                    }
                    else
                    {
                        return "";
                    }
                }
                return aramaSonuclari[0];
            }

        }
        public static void KisiYazdir(string kayit)
        {
            string[] veri = kayit.Split(' ');
            string numara = veri[2];
            Console.WriteLine($"İsim: {veri[0],-10} Soyisim: {veri[1],-10} Numara: {TelefonFormati(numara),-15}");
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

    }
}
