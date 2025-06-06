# Calorie Tracker

## Konfiguracja i uruchamianie

Należy posiadać zainstalowany dotnet w wersji 9.0 i dodatkowo w projekcie powinny być zainstalowane pakiety:

- Microsoft.EntityFrameworkCore (9.0.4)
- Microsoft.EntityFrameworkCore.Design (9.0.4)
- Microsoft.EntityFrameworkCore.SqlServer (9.0.4)
- Microsoft.EntityFrameworkCore.Tools (9.0.4)
- Microsoft.Extensions.Configuration.Json (9.0.4)
- Npgsql.EntityFrameworkCore.PostgreSQL (9.0.4)

W pliku appsettings.json powinny zostać skonfigurowane ustawienia bazy danych. Jeśli są problemy z połączeniem się z bazą, możliwe że należy edytować plik w folderze ```Calorie-Tracker\bin\Debug\net9.0-windows```, lub go tam umieścić.

Znajdując się w katalogu ```Calorie-Tracker``` należy wywołać polecenie
```bash
    dotnet ef database update
```

Migracje powinny znajdować się już w ```migrations``` jeśli ich tam nie ma należy wykonać
```bash
    dotnet ef migrations add Init
```

## Opis

Aplikacja pozwalająca śledzić swoje nawyki żywieniowe oraz liczyć spożyte kalorie każdego dnia. Umożliwia dodawanie posiłków, monitorowanie postępów oraz przeglądanie statystyk.

## Baza danych

W bazie znajdują się 3 tabele + tabela migracji: Foods, History i Notes.

#### Foods

| Klucz         | Nazwa         | Typ           |
|---------------|---------------|---------------|
| PK            | Id            | int           |
|               | Name          | text          |
|               | Calorie       | numeric(10,2) |
|               | Fats          | numeric       |
|               | Salts         | numeric       |
|               | Protein       | numeric       |
|               | Caffeine      | numeric NULL  |
|               | GramsInPortion| numeric(10,2) |

#### History

| Klucz         | Nazwa         | Typ           |
|---------------|---------------|---------------|
| PK            | Id            | int           |
|               | DateTime      | date          |
|               | Grams         | numeric(10,2) |
|               | Portions      | numeric NULL  |
| FK            | FoodID        | int           |


#### Foods

| Klucz         | Nazwa         | Typ           |
|---------------|---------------|---------------|
| PK            | Id            | int           |
|               | DateTime      | date          |
|               | Noted         | varchar(514)  |
| FK            | FoodID        | int NULL      |
