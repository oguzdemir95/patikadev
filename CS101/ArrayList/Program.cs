﻿using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList  liste=new ArrayList();
        //liste.Add("Ayşe");
        //liste.Add(2);
        //liste.Add(true);
        //liste.Add('A');

        // Verilere erişim
        //Console.WriteLine(liste[1]);

        //foreach (var item in liste)
        //{
        //    Console.WriteLine(item);
        //}

        // AddRange
        Console.WriteLine("***** AddRange *****");
        //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
        List<int> sayilar=new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
        //liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach(var item in liste)
        {
            Console.WriteLine(item);
        }

        // Sort
        Console.WriteLine("***** Sort *****");
        liste.Sort();

        // Binary Search
        Console.WriteLine("***** Binary Search *****");
        Console.WriteLine(liste.BinarySearch(9));

        // Reverse
        Console.WriteLine("***** Reverse *****");
        liste.Reverse();
        foreach(var item in liste)
        {
            Console.WriteLine(item);
        }

        // Clear
        liste.Clear();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }


    }
}