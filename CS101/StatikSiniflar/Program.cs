﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

        Calisan calisan1 = new Calisan("Ayşe","Yılmaz","İnsan Kaynakları");
        Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");
        Calisan calisan2 = new Calisan("Deniz", "Arda", "İnsan Kaynakları");
        Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

        Console.WriteLine($"Toplama işlemi sonucu: {Islemler.Topla(100, 200)}");

    }
}
class Calisan
{
    private string isim;
    private string soyisim;
    private string departman;
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.departman = departman;
        calisanSayisi++;
    }

    static Calisan()
    {
        calisanSayisi = 0;
    }
}

static class Islemler
{
    public static long Topla(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}