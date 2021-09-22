# Serwer Systemu Mobilnego Planowania Taktycznego

## Opis
Serwer stworzony na potrzeby aplikacji SMPT.

## O projekcie
Serwer wykonany jest w oparciu o technologie .NetCore 5.0. Dodatkowo wykorzystuje on biblioteke JINT w celu interpretowania
poleceń JavaScript. Serwer działa w stylu REST-owym stylu architektury. Przymuje on polecenia z aplikacji, a następnie
zwraca odpowiedź do aplikacji.

Serwer zabezpieczony jest protokołem _HTTPS_. Użytkownicy identyfikowani są wygenerowanym i zainstalowanym certyfikatem
bez niego dostęp i kontakt z serwerem jest nie możliwy 

Biblioteki użyte w projekcie:

1. JINT - Darmowa bilbioteka pozwalająca na interpretacja kodu JavaScript po stronie serwerowej
    *  [JINT](https://github.com/sebastienros/jint).
2. Milsymbol - Biblioteka napisana w JavaScript generująca symbole APP-6B
    *  [milsymbol](https://github.com/spatialillusions/milsymbol).

## Instalacja

Należy pobrać serwer uruchomić go w środowisku najlepiej visual studio w wierszu poleceń wpisać po uprzednim zmienieniu ścieżki do
bazy danych w klasie DataContext 

```
Add-Migration 'nazwa migracji'
updata-database
```

następnie uruchomić można poprzez visual studio, bądź plik wykonywalny.


