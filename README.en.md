🇵🇱 [Polski](README.md) | 🇬🇧 **English**

# 🏋️ Gym Management App

![C#](https://img.shields.io/badge/C%23-512BD4?logo=dotnet&logoColor=white) ![.NET 8](https://img.shields.io/badge/.NET_8-512BD4?logo=dotnet&logoColor=white)

> 🎓 Project from the **C# INIT 2025** course run by the **KREDEK** student research group (Wrocław University of Science and Technology)

A console app for a gym: clients, trainers, membership passes and workouts in one place. 💪 It was a chance to properly practise object-oriented programming in C#.

## ✨ Features

- 👤 Add **clients** and **trainers** — manually or from a file (duplicates skipped by national ID)
- 🎟️ **Passes**: monthly, annual and student — each with its own price and expiry date
- 🏃 **Workouts** — date, type (strength, cardio, yoga, CrossFit, swimming and more), duration and trainer
- 🚫 You can't add a workout without a valid pass — enforced by **custom exceptions** (`BrakKarnetuException`, `KarnetWygaslException`)
- 📋 A trainer's client list and a client's workout history
- 💾 Workouts saved to a file

## 🧩 Object model

```
Osoba (Person, abstract)  ──► Klient (Client), Trener (Trainer)
Karnet (Pass, abstract)   ──► monthly, annual, student pass
```

Inheritance, abstract classes, polymorphism (`GetInfo()`), enums and custom exceptions.

## 🛠️ Tech

C# · .NET 8 · console app

## 🚀 Run it

```bash
cd gym-managment-app
dotnet run
```

The interface is in Polish.
