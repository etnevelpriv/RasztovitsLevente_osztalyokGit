using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07
{
    internal class KemKuldetes
    {
        public string Kodnev { get; set; }
        public string Orszag { get; set; }
        public int VeszelySzint { get; set; }
        public int SikerEsely { get; set; }

        public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsely)
        {
            Kodnev = kodnev;
            Orszag = orszag;
            VeszelySzint = veszelySzint;
            SikerEsely = sikerEsely;
        }

        public KemKuldetes(string kodnev, string orszag)
        {
            Kodnev = kodnev;
            Orszag = orszag;
            VeszelySzint = 5;
            SikerEsely = 50;
        }

        public void KuldetesInditasa()
        {
            Console.WriteLine($"A {Kodnev} küldetés elkezdődött.");
        }

        public void VeszelySzintNovelese(int mennyiseg)
        {
            VeszelySzint += mennyiseg;
        }

        public void SikerEselyNovelese(int szazalek)
        {
            SikerEsely += szazalek;
            if (SikerEsely > 100)
            {
                SikerEsely = 100;
            }
        }

        public override string ToString()
        {
            return $"Kódnév: {Kodnev}, Ország: {Orszag}, Veszélyszint: {VeszelySzint}, Siker esély: {SikerEsely}%";
        }
    }
}
