using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07
{
    internal class Film
    {
        public string Cim { get; set; }
        public string Rendezo { get; set; }
        public int HosszPercekben { get; set; }
        public string Mufaj { get; set; }
        public bool Megjelent { get; set; }

        public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
        {
            Cim = cim;
            Rendezo = rendezo;
            HosszPercekben = hosszPercekben;
            Mufaj = mufaj;
            Megjelent = megjelent;
        }

        public Film(string cim, string rendezo)
        {
            Cim = cim;
            Rendezo = rendezo;
            HosszPercekben = 120;
            Mufaj = "Ismeretlen";
            Megjelent = false;
        }

        public void Jatszas()
        {
            Console.WriteLine("A film elkezdődött.");
        }

        public void MufajModositas(string ujMufaj)
        {
            Mufaj = ujMufaj;
        }

        public void HosszNovelese(int percek)
        {
            HosszPercekben += percek;
        }

        public override string ToString()
        {
            return $"Cím: {Cim}, Rendező: {Rendezo}, Hossz: {HosszPercekben} perc, Műfaj: {Mufaj}, Megjelent: {Megjelent}";
        }
    }
}
