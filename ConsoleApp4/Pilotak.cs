using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Pilotak
    {
        string nev;
        string szuletesiDatum;
        string nemzetiseg;
        int rajtszám;

        public Pilotak(string nev, string szuletesDatum, string nemzetiseg, int rajtszám)
        {
            this.nev = nev;
            this.szuletesiDatum = szuletesDatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszám = rajtszám;
        }
        public string Nev { get => nev; }
        public string SzuletesiDatum { get => szuletesiDatum; }
        public string Nemetiseg { get => nemzetiseg; }
        public int Rajtszam { get => Rajtszam; }
    }
}
