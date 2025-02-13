using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07
{
    internal class Program
    {
        static void Konyv(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Könyv Class:");
            Console.ForegroundColor = ConsoleColor.White;
            Konyv konyv1 = new Konyv("Az ember tragédiája", "Madách Imre", 2021, 350, 5000);
            int teljesOsszeg = konyv1.Arnoveles(500);
            konyv1.Kedvezmeny(40);
            int maradekOldal = konyv1.HanyOldalMaradt(100);
            Console.WriteLine(konyv1);
            Console.WriteLine($"{konyv1.Cim} teljes összege adóval: {teljesOsszeg}, amíg a kedvezményes árral: {konyv1.Ar}. Már egy kicsit olvastam belőle, a maradék oldalszám:aradék oldalszám: {maradekOldal}");
            Console.WriteLine();

            Konyv konyv2 = new Konyv("Egri csillagok", "Gárdonyi Géza");
            Console.WriteLine(konyv2);
            Console.WriteLine();
        }

        static void Film(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Film Class:");
            Console.ForegroundColor = ConsoleColor.White;

            Film film1 = new Film("A keresztapa", "Francis Ford Coppola", 175, "dráma", true);
            film1.Jatszas();
            film1.MufajModositas("bűnügyi");
            film1.HosszNovelese(10);
            Console.WriteLine(film1);
            Console.WriteLine();

            Film film2 = new Film("Titanic", "James Cameron");
            Console.WriteLine(film2);
            Console.WriteLine();
        }

        static void Karakter(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Karakter Class:");
            Console.ForegroundColor = ConsoleColor.White;

            Karakter karakter1 = new Karakter("Gandalf", 10, 190, 20);
            karakter1.Tamadas();
            karakter1.Gyogyulas(50);
            karakter1.Szintlepes();
            Console.WriteLine(karakter1);
            Console.WriteLine();

            Karakter karakter2 = new Karakter("Frodo", 50);
            Console.WriteLine(karakter2);
            Console.WriteLine();
        }

        static void Urhajo(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Urhajo Class:");
            Console.ForegroundColor = ConsoleColor.White;

            Urhajo urhajo1 = new Urhajo("Millennium Falcon", 1000, 10, 50);
            urhajo1.Indulas();
            urhajo1.Tankolas(20);
            urhajo1.Landolas();
            Console.WriteLine(urhajo1);
            Console.WriteLine();

            Urhajo urhajo2 = new Urhajo("X-Wing", 5);
            Console.WriteLine(urhajo2);
            Console.WriteLine();
        }

        static void KemKuldetes(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KemKuldetes Class:");
            Console.ForegroundColor = ConsoleColor.White;

            KemKuldetes kuldetes1 = new KemKuldetes("Golyóállósejhaj", "Oroszország", 2, 70);
            kuldetes1.KuldetesInditasa();
            kuldetes1.VeszelySzintNovelese(5);
            kuldetes1.SikerEselyNovelese(30);
            Console.WriteLine(kuldetes1);
            Console.WriteLine();

            KemKuldetes kuldetes2 = new KemKuldetes("007", "Kína");
            Console.WriteLine(kuldetes2);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Konyv(args);
            Film(args);
            Karakter(args);
            Urhajo(args);
            KemKuldetes(args);
        }
    }
}
