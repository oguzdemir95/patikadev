using TelefonRehberi;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Menu.Menuler();
            int secim = Menu.SecimYap();
            Menu.SecimiUygula(secim);
        }
    }
}
