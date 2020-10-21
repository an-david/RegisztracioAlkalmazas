using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Ugyfel
    {
        private string nev;
        private string szuldatum;
        private string nem;
        private string hobbi;
        private string kedvenchobbi;

        public Ugyfel(string nev, string szulDatum, string nem, string hobbi, string kedvencHobbi)
        {
            Nev = nev;
            SzulDatum = szulDatum;
            Nem = nem;
            Hobbi = hobbi;
            KedvencHobbi = kedvencHobbi;
        }

        public Ugyfel(string ugyfel)
        {
            String[] str = ugyfel.Split(';');

            nev = str[0];
            szuldatum = str[1];
            nem = str[2];
            hobbi = str[3];
            kedvenchobbi = str[4];
        }

        public string Nev { get => nev; set => nev = value; }
        public string SzulDatum { get => szuldatum; set => szuldatum = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Hobbi { get => hobbi; set => hobbi = value; }
        public string KedvencHobbi { get => kedvenchobbi; set => kedvenchobbi = value; }

        public string kiIratas()
        {
            return string.Format($"{nev};{szuldatum};{nem};{hobbi};{kedvenchobbi}");
        }

        public override string ToString()
        {
            return string.Format("Név: " + nev + "\nSzül. dátum: " + szuldatum + "\nNem: " + nem + "\nHobbik: " + hobbi + "\nKedvenc Hobbi: " + kedvenchobbi + "\n");
        }
    }
}
