using System;
using System.IO;
using System.Collections.Generic;
using gym_managment_app.modele;
using gym_managment_app.treningi;

namespace gym_managment_app.pliki
{
    internal static class ZapisywaniePlikow
    {
        public static void ZapiszTreningidoPliku(string sciezka, List<Trening> treningi)
        {
            using (StreamWriter writer = new StreamWriter(sciezka))
            {
                foreach (var trening in treningi)
                {
                   string linia = $"{trening.Klient.Id} {trening.Klient.Imie} {trening.Klient.Nazwisko} {trening.DataTreningu:yyyy-MM-dd HH:mm} {trening.RodzajTreningu} {trening.CzasTrwaniaWMinutach} {trening.TrenerProwadzacy.Id} {trening.TrenerProwadzacy.Imie} {trening.TrenerProwadzacy.Nazwisko}";
                   writer.WriteLine(linia);
                }
            }
            Console.WriteLine("Zapisano treningi do pliku.");
        }
    }
}
