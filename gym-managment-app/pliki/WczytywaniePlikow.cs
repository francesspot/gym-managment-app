using System;
using System.IO;
using gym_managment_app.modele;
using System.Collections.Generic;

namespace gym_managment_app.pliki
{
    internal static class WczytywaniePlikow
    {
        public static string WczytajKlientowZPliku(string sciezka, List<Klient> klienci)
        {
            if (!File.Exists(sciezka))
            {
                throw new FileNotFoundException("Plik z klientami nie został znaleziony.", sciezka);
            }

            var wczytaniKlienci = new List<Klient>();

            foreach (var linia in File.ReadLines(sciezka))
            {
                if (string.IsNullOrWhiteSpace(linia))
                {
                    continue;
                }

                string[] dane = linia.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (dane.Length < 6)
                    continue;

                wczytaniKlienci.Add(new Klient(
                    dane[0],                  // imie
                    dane[1],                  // nazwisko
                    char.Parse(dane[2]),      // plec
                    int.Parse(dane[3]),       // wiek
                    dane[4],                  // pesel
                    dane[5]                   // nr_tel
                ));
            }

            foreach (var nowyKlient in wczytaniKlienci)
            {
                if (!klienci.Any(k => k.Pesel == nowyKlient.Pesel))
                    klienci.Add(nowyKlient);
            }

            return $"Wczytano {klienci.Count} klientów z pliku. Aktualna liczba klientów: {klienci.Count}";
        }

        public static string WczytajTrenerowZPliku(string sciezka, List<Trener> trenerzy)
        {
            if (!File.Exists(sciezka))
            {
                throw new FileNotFoundException("Plik z trenerami nie został znaleziony.", sciezka);
            }

            var wczytaniTrenerzy = new List<Trener>();

            foreach (var linia in File.ReadLines(sciezka))
            {
                if (string.IsNullOrWhiteSpace(linia))
                {
                    continue;
                }

                string[] dane = linia.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (dane.Length < 7)
                    continue;

                wczytaniTrenerzy.Add(new Trener(
                    dane[0],                  // imie
                    dane[1],                  // nazwisko
                    char.Parse(dane[2]),      // plec
                    int.Parse(dane[3]),       // wiek
                    dane[4],                  // pesel
                    dane[5],                  // nr_tel
                    dane[6]                   // specjalizacja
                ));

            }

            foreach (var nowyTrener in wczytaniTrenerzy)
            {
                if (!trenerzy.Any(t => t.Pesel == nowyTrener.Pesel))
                    trenerzy.Add(nowyTrener);
            }

            return $"Wczytano {trenerzy.Count} trenerów z pliku. Aktualna liczba trenerów: {trenerzy.Count}";
        }
    }
}
