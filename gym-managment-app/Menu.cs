using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gym_managment_app.modele;
using gym_managment_app.treningi;
using gym_managment_app.wyjatki;

namespace gym_managment_app
{
    internal class Menu
    {
        static List<Trener> trenerzy = new List<Trener>();
        static List<Klient> klienci = new List<Klient>();

        public void PokazMenu()
        {
            bool dziala = true;

            while (dziala)
            {
                Console.WriteLine("\n=== Menu Siłowni ===");
                Console.WriteLine("1. Dodaj trenera");
                Console.WriteLine("2. Dodaj klienta");
                Console.WriteLine("3. Wykup karnet dla klienta");
                Console.WriteLine("4. Dodaj trening klientowi");
                Console.WriteLine("5. Wyświetl klientów trenera");
                Console.WriteLine("6. Wyświetl treningi klienta");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybierz opcję: ");

                string? wybor = Console.ReadLine();


                switch (wybor)
                {
                    case "1":
                        DodajTrenera();
                        break;
                    case "2":
                        DodajKlienta();
                        break;
                    case "3":
                        WykupKarnet();
                        break;
                    case "4":
                        DodajTrening();
                        break;
                    case "5":
                        PokazKlientowTrenera();
                        break;
                    case "6":
                        PokazTreningiKlienta();
                        break;
                    case "0":
                        dziala = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }

        static void DodajTrenera()
        {
            Console.Write("Imię: ");
            string? imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string? nazwisko = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                Console.WriteLine("Imię i nazwisko nie moga być puste.");
                return;
            }

            Console.Write("Płeć (M/K): ");
            char plec = char.Parse(Console.ReadLine()!);
            plec = char.ToUpper(plec);

            if (plec != 'M' && plec != 'K')
            {
                Console.WriteLine("Płeć musi być M lub K.");
                return;
            }

            Console.Write("Wiek: ");
            int wiek = int.Parse(Console.ReadLine()!);

            if (wiek <= 0)
            {
                Console.WriteLine("Nieprawidłowy wiek.");
                return;
            }
            else if (wiek <= 20)
            {
                Console.WriteLine("Osoba jest za młoda na bycie trenerem na siłowni");
            }

            Console.Write("PESEL: ");
            string? pesel = Console.ReadLine();
            Console.Write("Nr telefonu: ");
            string? tel = Console.ReadLine();
            Console.Write("Specjalizacja: ");
            string? spec = Console.ReadLine();

            Trener trener = new Trener(imie!, nazwisko!, plec, wiek, pesel!, tel!, spec!);
            trenerzy.Add(trener);
            Console.WriteLine("Dodano trenera!");
        }

        static void DodajKlienta()
        {
            Console.Write("Imię: ");
            string? imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string? nazwisko = Console.ReadLine();
            Console.Write("Płeć (M/K): ");
            char plec = char.Parse(Console.ReadLine()!);
            Console.Write("Wiek: ");
            int wiek = int.Parse(Console.ReadLine()!);

            if (wiek <= 0)
            {
                Console.WriteLine("Nieprawidłowy wiek.");
                return;
            } else if (wiek <= 16)
            {
               Console.WriteLine("Jestes za młody na korzystanie z siłowni");
            }

            Console.Write("PESEL: ");
            string? pesel = Console.ReadLine();
            Console.Write("Nr telefonu: ");
            string? tel = Console.ReadLine();

            Klient klient = new Klient(imie!, nazwisko!, plec, wiek, pesel!, tel!);
            klienci.Add(klient);
            Console.WriteLine("Dodano klienta!");
        }

        static void WykupKarnet()
        {
            Klient? klient = WybierzKlienta();
            if (klient == null)
            {
                Console.WriteLine("Brak klientów.");
                return;
            }

            Console.WriteLine("Wybierz typ karnetu: 1. Miesięczny 2. Roczny 3. Studencki");
            string? typ = Console.ReadLine();

            Karnet karnet = typ switch
            {
                "1" => new KarnetMiesieczny(),
                "2" => new KarnetRoczny(),
                "3" => new KarnetStudencki(),
                _ => throw new Exception("Nieprawidłowy typ karnetu")
            };

            klient.WykupKarnet(karnet);
            Console.WriteLine("Karnet wykupiony!");
        }

        static void DodajTrening()
        {
            if (klienci.Count == 0 || trenerzy.Count == 0)
            {
                Console.WriteLine("Brak klientów lub trenerów.");
                return;
            }

            // === Wybór klienta ===
            Console.WriteLine("Wybierz klienta:");
            for (int i = 0; i < klienci.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {klienci[i].Imie} {klienci[i].Nazwisko}");
            }

            if (!int.TryParse(Console.ReadLine(), out int klientIndex) ||
                klientIndex < 1 || klientIndex > klienci.Count)
            {
                Console.WriteLine("Nieprawidłowy wybór klienta.");
                return;
            }

            Klient klient = klienci[klientIndex - 1];

            // === Wybór trenera ===
            Console.WriteLine("Wybierz trenera:");
            for (int i = 0; i < trenerzy.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {trenerzy[i].Imie} {trenerzy[i].Nazwisko} ({trenerzy[i].Specjalizacja})");
            }

            if (!int.TryParse(Console.ReadLine(), out int trenerIndex) ||
                trenerIndex < 1 || trenerIndex > trenerzy.Count)
            {
                Console.WriteLine("Nieprawidłowy wybór trenera.");
                return;
            }

            Trener trener = trenerzy[trenerIndex - 1];

            // === Wybór rodzaju treningu ===
            Console.WriteLine("Wybierz rodzaj treningu:");

            RodzajTreningu[] rodzaje = Enum.GetValues<RodzajTreningu>();
            for (int i = 0; i < rodzaje.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {rodzaje[i]}");
            }

            if (!int.TryParse(Console.ReadLine(), out int rodzajIndex) ||
                rodzajIndex < 1 || rodzajIndex > rodzaje.Length)
            {
                Console.WriteLine("Nieprawidłowy rodzaj treningu.");
                return;
            }

            RodzajTreningu typ = rodzaje[rodzajIndex - 1];

            // === Czas trwania ===
            Console.Write("Podaj czas trwania treningu (minuty): ");
            if (!int.TryParse(Console.ReadLine(), out int czas) || czas <= 0)
            {
                Console.WriteLine("Nieprawidłowy czas treningu.");
                return;
            }

            // === Tworzenie treningu ===
            Trening trening = new Trening(
                klient,
                DateTime.Now,
                typ,
                czas,
                trener
            );

            klient.DodajTrening(trening);

            Console.WriteLine("Dodano trening!");
        }


        static void PokazKlientowTrenera()
        {
            Trener? trener = WybierzTrenera();
            if (trener != null)
                trener.WyswietlKlientow();
            else
                Console.WriteLine("Brak trenerów.");
        }

        static void PokazTreningiKlienta()
        {
            Klient? klient = WybierzKlienta();
            if (klient != null)
                klient.WyswietlTreningi();
            else
                Console.WriteLine("Brak klientów.");
        }

        static Klient? WybierzKlienta()
        {
            if (klienci.Count == 0) return null;

            Console.WriteLine("Wybierz klienta:");
            for (int i = 0; i < klienci.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {klienci[i].GetInfo()}");
            }

            int id = int.Parse(Console.ReadLine()!) - 1;
            if (id >= 0 && id < klienci.Count)
                return klienci[id];
            return null;
        }

        static Trener? WybierzTrenera()
        {
            if (trenerzy.Count == 0) return null;

            Console.WriteLine("Wybierz trenera:");
            for (int i = 0; i < trenerzy.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {trenerzy[i].GetInfo()}");
            }

            int id = int.Parse(Console.ReadLine()!) - 1;
            if (id >= 0 && id < trenerzy.Count)
                return trenerzy[id];
            return null;
        }
    }
}
