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
        }
        static void Main(string[] args)
        {
            Konyv(args);
            Film(args);
        }
    }
}
