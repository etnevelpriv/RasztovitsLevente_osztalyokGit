using System;

namespace _02._07
{
    internal class Konyv
    {
        private string cim;
        private string szerzo;
        private int kiadasEve;
        private int oldalszam;
        private int ar;

        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }

        public string Szerzo
        {
            get { return szerzo; }
            set { szerzo = value; }
        }

        public int KiadasEve
        {
            get { return kiadasEve; }
            set { kiadasEve = value; }
        }

        public int Oldalszam
        {
            get { return oldalszam; }
            set { oldalszam = value; }
        }

        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }

        public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = kiadasEve;
            this.oldalszam = oldalszam;
            this.ar = ar;
        }

        public Konyv(string cim, string szerzo)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kiadasEve = DateTime.Now.Year;
            this.oldalszam = 200;
            this.ar = 3000;
        }

        public int Arnoveles(int osszeg)
        {
            return ar += osszeg;
        }

        public int Kedvezmeny(double szazalek)
        {
            return ar -= (int)(ar * (szazalek / 100));
        }

        public int HanyOldalMaradt(int elolvasott)
        {
            return oldalszam - elolvasott;
        }

        public override string ToString()
        {
            return $"Cím: {cim}, Szerző: {szerzo}, Kiadás éve: {kiadasEve}, Oldalszám: {oldalszam}, Ár: {ar} Ft";
        }
    }
}
