[Polski](README.md) | **English**

# Gym Management App

A C# (.NET 8) console application for managing a gym: clients, trainers, membership passes and training sessions. The project focuses on object-oriented programming — inheritance, abstract classes, polymorphism and custom exceptions. The interface is in Polish.

## Features

- Add clients and trainers (manually or from a text file).
- Buy a membership pass for a client — **monthly** (120 zł, valid 1 month), **annual** (1000 zł, valid 1 year) or **student** (80 zł, valid 1 month).
- Add a training session for a client: date, type, duration and trainer. Before adding it, the program checks that the client has a pass and that it hasn't expired.
- Show a trainer's clients and a client's training history.
- Save all training sessions to `treningi.txt`.

Available training types: strength, cardio, functional, yoga, Pilates, HIIT, dance, stretching, CrossFit, swimming.

## Object model

```
Osoba (abstract)            Karnet (abstract)
├── Klient                  ├── KarnetMiesieczny
└── Trener                  ├── KarnetRoczny
                            └── KarnetStudencki
Trening        – client, trainer, date, type (RodzajTreningu), duration
Exceptions     – BrakKarnetuException (no pass), KarnetWygaslException (pass expired)
```

## Input file format

Values separated by spaces, one person per line.

Clients:
```
first_name surname sex age PESEL phone
Jan Kowalski M 25 01234567890 500600700
```

Trainers (with specialisation as the last field):
```
first_name surname sex age PESEL phone specialisation
Anna Nowak K 30 93010112345 600700800 Joga
```

Duplicates (same PESEL) are skipped when loading.

## Build and run

Requires the [.NET 8 SDK](https://dotnet.microsoft.com/download).

```bash
cd gym-managment-app
dotnet run
```

Or open `gym-managment-app.sln` in Visual Studio.
