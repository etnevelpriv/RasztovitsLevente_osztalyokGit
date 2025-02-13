using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07
{
    internal class Urhajo
    {
        public string Nev { get; set; }
        public int Sebesseg { get; set; }
        public int Utaskapacitas { get; set; }
        public int UzemanyagSzint { get; set; }

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
        {
            Nev = nev;
            Sebesseg = sebesseg;
            Utaskapacitas = utaskapacitas;
            UzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utaskapacitas)
        {
            Nev = nev;
            Utaskapacitas = utaskapacitas;
            Sebesseg = 0;
            UzemanyagSzint = 100;
        }

        public void Indulas()
        {
             Sebesseg += 200;
             UzemanyagSzint -= 10;
            Console.WriteLine($"{Nev} elindult. Sebesség: {Sebesseg}.");
        }

        public void Tankolas(int mennyiseg)
        {
            UzemanyagSzint += mennyiseg;
            if (UzemanyagSzint > 100)
            {
                UzemanyagSzint = 100;
            }
        }

        public void Landolas()
        {
            Sebesseg = 0;
            Console.WriteLine($"{Nev} landolt. Sebesség: {Sebesseg}.");
        }

        public override string ToString()
        {
            return $"Név: {Nev}, Sebesség: {Sebesseg}, Utaskapacitás: {Utaskapacitas}, Üzemanyagszint: {UzemanyagSzint}%";
        }
    }
}
