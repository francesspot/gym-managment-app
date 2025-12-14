using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_managment_app.modele
{
    internal class Trener : Osoba
    {
        public string Specjalizacja { get; }

        public List<Klient> Klienci { get; private set; } = new List<Klient>();
        public Trener(string imie, string nazwisko, char plec, int wiek, string pesel, string nr_tel, string specjalizacja)
            : base(imie, nazwisko, plec, wiek, pesel, nr_tel)
        {
            Specjalizacja = specjalizacja;
        }

        public void DodajKlienta(Klient klient)
        {
            Klienci.Add(klient);
        }

        public void WyswietlKlientow()
        {
            if (Klienci.Count == 0)
            {
                Console.WriteLine("Brak przypisanych klientów.");
                return;
            }
            foreach (var klient in Klienci)
            {
                Console.WriteLine(klient.GetInfo());
            }
        }

        public override string GetInfo()
        {
            return $"Trener: {Imie} {Nazwisko} Specjalizacja: {Specjalizacja}";
        }
    }
}
