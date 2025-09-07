# Skapa en Berättelse med MAUI

## Översikt
Detta projekt går ut på att ni, i par, ska skapa en interaktiv berättelse med hjälp av .NET MAUI. Berättelsen kan vara ett spel, en äventyrsberättelse eller något annat kreativt. Ni kommer att använda GitHub för att hantera er kod och projektets arbetsflöde.

Syftet är att förstå hur MAUI använder datamodeller och villkor via delegates (Func<>, Action), istället för enklare if/else. I en MVVM-liknande struktur tänker man mera "datadrivet", och i detta exemplet skapas en modell (klass eller record) för vad en scen är, där datan hanteras i en lista eller en dictionary. Text och val beskrivs i ett objekt. Dessutom kikar vi på vad Command och OnPropertyChanged innebär.

Ett annat sätt att förenklat beskriva hela proceesen är att "signalerna hoppar runt" mellan de olika metoderna och komandona. Det gäller att hålla koll, vilket är svårare än man kan tro.

## Krav
### Kodkrav
- **Användarsäker kod**: Implementera skydd mot felaktig användarinmatning genom att använda metoder som `String.IsNullOrEmpty()` och `TryParse()`.
- **Struktur**:
  - Minst tre `if-else-if-else` satser (utöver de som behövs för användarsäker kod).
  - Minst tre loopar (while eller for) (utöver de som behövs för användarsäker kod).
- **Berättelse**:
  - Det användaren skriver in ska valideras (namn, ålder, vapen, etc).
  - Berättelsen ska innehålla minst tre-fyra interaktiva moment som leder till händelser som till exempel en strid.
  - En spännande slutscen eller upplösning.

### GitHub-krav
- **Repository**: Skapa ett  repository för projektet.
- **GitHub Project**: Använd GitHub Projects för att hantera uppgifter och arbetsflöde.
- **Branches**: Arbeta i separata branches för olika uppgifter och använd pull requests för att mergea kod.
- **Collaborator**: Bjud in mig, er lärare, som collaborator till både repositoriet och GitHub Project. Viktigt!

## Instruktioner

### 1. Skapa ett Repository
1. Skapa ett nytt privat repository på GitHub och namnge det t.ex. `MauiAdventureProject`.
2. Lägg till en `.gitignore`-fil för Visual Studio-projekt och en grundläggande `README.md`.

### 2. Skapa och Hantera GitHub Project
1. Skapa ett GitHub Project kopplat till ert repository.
2. Lägg till kolumnerna **To Do**, **In Progress**, och **Done**.
3. Skapa tasks för de större delarna av projektet, tilldela dem till medlemmar och sätt deadlines.
4. lämpligt är att ni aktivt använder TODO i själva koden för att se till att inget glöms av

### 3. Arbeta med Branches och Pull Requests
1. Skapa alltid först en `develop` (ge den ett lämpligt namn, inte develop) branch från `main` för varje nytt moment. Arbeta alltid i `develop` och skapa feature branches från `develop`.
2. Skapa separata branches för varje större uppgift, t.ex. `feature/user-input`, `feature/combat-system`.
3. När en uppgift är klar, skapa en pull request för att mergea branchen till `develop`.
4. Granska och godkänn varandras pull requests innan de mergeas.

### 4. Bjuda in Lärare som Collaborator
1. Gå till ert repository på GitHub.
2. Klicka på "Settings" > "Manage access" > "Invite a collaborator".
3. Ange TeacherArea och skicka inbjudan.
4. Gör samma sak för GitHub Project: Gå till projektet, klicka på "Menu" > "Settings" > "Collaborators" och bjud in TeacherArea.

### 5. Uppdatera README.md
1. Lägg till en beskrivning av projektet och en länk till ert GitHub Project.
2. Dokumentera kort er arbetsprocess, inklusive hur ni använder branches och pull requests.

### 6. Slutlig Inlämning
1. Gör en slutlig granskning av kod och dokumentation.
2. Mergea alla färdiga branches till `main` och skapa en release på GitHub.
3. Se till att TeacherArea har fortsatt tillgång till både repository och projektet för bedömning. **OBS! Superviktigt!**

## Lycka till!
