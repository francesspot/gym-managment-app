**Polski** | [English](README.en.md)

# Aplikacja do zarządzania siłownią

Konsolowa aplikacja w C# (.NET 8) do zarządzania siłownią: klientami, trenerami, karnetami i treningami. Projekt skupia się na programowaniu obiektowym — dziedziczeniu, klasach abstrakcyjnych, polimorfizmie i własnych wyjątkach.

## Funkcje

- Dodawanie klientów i trenerów (ręcznie lub z pliku tekstowego).
- Wykupienie karnetu dla klienta — **miesięczny** (120 zł, ważny miesiąc), **roczny** (1000 zł, ważny rok) lub **studencki** (80 zł, ważny miesiąc).
- Dodanie treningu klientowi: data, rodzaj, czas trwania i trener. Przed dodaniem program sprawdza, czy klient ma karnet i czy nie wygasł.
- Wyświetlanie klientów trenera i historii treningów klienta.
- Zapis wszystkich treningów do `treningi.txt`.

Dostępne rodzaje treningu: siłowy, cardio, funkcjonalny, joga, pilates, HIIT, taniec, stretching, crossfit, pływanie.

## Model obiektowy

```
Osoba (abstrakcyjna)        Karnet (abstrakcyjny)
├── Klient                  ├── KarnetMiesieczny
└── Trener                  ├── KarnetRoczny
                            └── KarnetStudencki
Trening        – klient, trener, data, rodzaj (RodzajTreningu), czas trwania
Wyjątki        – BrakKarnetuException, KarnetWygaslException
```

## Format plików wejściowych

Wartości oddzielone spacjami, jedna osoba w wierszu.

Klienci:
```
imie nazwisko plec wiek PESEL telefon
Jan Kowalski M 25 01234567890 500600700
```

Trenerzy (ostatnie pole to specjalizacja):
```
imie nazwisko plec wiek PESEL telefon specjalizacja
Anna Nowak K 30 93010112345 600700800 Joga
```

Duplikaty (ten sam PESEL) są pomijane przy wczytywaniu.

## Kompilacja i uruchomienie

Wymagany [.NET 8 SDK](https://dotnet.microsoft.com/download).

```bash
cd gym-managment-app
dotnet run
```

Można też otworzyć `gym-managment-app.sln` w Visual Studio.
