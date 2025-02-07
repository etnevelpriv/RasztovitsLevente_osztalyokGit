using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new Konyv("Az ember tragédiája", "Madách Imre", 2021, 350, 5000);
            int teljesOsszeg = konyv1.Arnoveles(500);
            konyv1.Kedvezmeny(40);
            int maradekOldal = konyv1.HanyOldalMaradt(100);
            Console.WriteLine(konyv1);
            Console.WriteLine($"{konyv1.Cim} teljes összege adóval: {teljesOsszeg}, amíg a kedvezményes árral: {konyv1.Ar}. Már egy kicsit olvastam belőle, a maradék oldalszám:aradék oldalszám: {maradekOldal}");
            Console.WriteLine();


            Konyv konyv2 = new Konyv("Egri csillagok", "Gárdonyi Géza");
            Console.WriteLine(konyv2);
        }
    }
}
