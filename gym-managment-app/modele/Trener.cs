using System;
using System.Collections.Generic;

namespace gym_managment_app.modele
{
    internal class Trener : Osoba
    {
        private static int ID = 1;
        public int Id { get; }
        public string Specjalizacja { get; }

        public List<Klient> Klienci { get; private set; } = new List<Klient>();
        public Trener(string imie, string nazwisko, char plec, int wiek, string pesel, string nr_tel, string specjalizacja)
            : base(imie, nazwisko, plec, wiek, pesel, nr_tel)
        {
            Id = ID++;
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
            return $"Trener [ID={Id}]: {Imie} {Nazwisko}, Wiek: {Wiek}, Płeć: {Plec}, PESEL: {Pesel}, Nr Tel: {Nr_Tel}, Specjalizacja: {Specjalizacja}";
        }
    }
}
