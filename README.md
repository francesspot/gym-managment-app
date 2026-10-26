🇵🇱 **Polski** | 🇬🇧 [English](README.en.md)

# 🏋️ Aplikacja do zarządzania siłownią

![C#](https://img.shields.io/badge/C%23-512BD4?logo=dotnet&logoColor=white) ![.NET 8](https://img.shields.io/badge/.NET_8-512BD4?logo=dotnet&logoColor=white)

> 🎓 Projekt z kursu **C# INIT 2025** koła naukowego **KREDEK** (Politechnika Wrocławska)

Konsolowa aplikacja do zarządzania siłownią: klientami, trenerami, karnetami i treningami. Nacisk położony na programowanie obiektowe w C#.

## ✨ Funkcje

- Dodawanie **klientów** i **trenerów** — ręcznie albo z pliku (bez duplikatów po PESEL-u)
- **Karnety**: miesięczny, roczny i studencki — każdy z własną ceną i datą ważności
- **Treningi** — data, rodzaj (siłowy, cardio, joga, crossfit, pływanie i inne), czas trwania i trener
- Nie da się dodać treningu bez ważnego karnetu — pilnują tego **własne wyjątki** (`BrakKarnetuException`, `KarnetWygaslException`)
- Lista klientów trenera i historia treningów klienta
- Zapis treningów do pliku

## 🧩 Model obiektowy

```
Osoba (abstrakcyjna)  ──► Klient, Trener
Karnet (abstrakcyjny) ──► KarnetMiesieczny, KarnetRoczny, KarnetStudencki
```

Dziedziczenie, klasy abstrakcyjne, polimorfizm (`GetInfo()`), enumy i własne wyjątki.

## 🛠️ Technologie

C# ·.NET 8 · aplikacja konsolowa

## 🚀 Uruchomienie

```bash
cd gym-managment-app
dotnet run
```
