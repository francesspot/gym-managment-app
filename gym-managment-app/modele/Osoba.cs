using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gym_managment_app.modele
{
    abstract class Osoba
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public char Plec { get; }
        public int Wiek { get; }
        public string Pesel { get; }

        public string Nr_Tel { get; }

        protected Osoba(string imie, string nazwisko, char plec, int wiek, string pesel, string nr_tel)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            Wiek = wiek;
            Pesel = pesel;
            Nr_Tel = nr_tel;
        }

        public abstract string GetInfo();
    }
}
