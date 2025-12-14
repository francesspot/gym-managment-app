using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gym_managment_app.wyjatki;
using gym_managment_app.treningi;


namespace gym_managment_app.modele
{
    internal class Klient : Osoba
    {
        public Karnet? Karnet { get; private set; }
        public List<Trening> Treningi { get; private set; } = new List<Trening>();

        public Klient(string imie, string nazwisko, char plec, int wiek, string pesel, string nr_tel)
            : base(imie, nazwisko, plec, wiek, pesel, nr_tel)
        {
        }

        public void WykupKarnet(Karnet karnet)
        {
            Karnet = karnet;
            Karnet.OplacKarnet(Karnet.Cena);
        }

        public void WejdzNaSilownie()
        {
            if (Karnet == null)
                throw new BrakKarnetuException();

            if (!Karnet.CzyWazny())
                throw new KarnetWygaslException();
        }

        public override string GetInfo()
        {
            return $"Klient: {Imie} {Nazwisko}, Wiek: {Wiek}, Płeć: {Plec}, PESEL: {Pesel}, Nr Tel: {Nr_Tel} ";
        }

        public void DodajTrening(Trening trening)
        {
            Treningi.Add(trening);
        }

        public void WyswietlTreningi()
        {
            if (Treningi.Count == 0)
            {
                Console.WriteLine("Brak zapisanych treningów.");
                return;
            }


            foreach (var trening in Treningi)
            {
                Console.WriteLine(trening.GetInfo());
            }
        }
    }
}
