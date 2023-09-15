# Projekt-Dokumentation
von Denis Jashari

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    18.08.23   | 0.0.1   | Ich habe mich erneut in C# eingearbeitet und konnte eine klare Idee von meinem Projekt entwickeln. Dadurch war es mir möglich, mein Projekt sorgfältig zu planen. |
|  25.08.2023     | 0.0.2     |  Nachdem ich mich erneut mit dem Informieren und dem Planen befasst habe, begann ich mit der Programmierung.                                                         |
|   01.09.2023    | 0.0.3   |  Ich setzte meine Arbeit am Projekt fort und programmierte weiterhin daran.                                                            |
|   08.09.2023    | 1.0.0   |  Ich habe das Projekt abgeschlossen, letzte Anpassungen vorgenommen und die Projektdokumentation finalisiert.                                                            |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt wird ein lässiger Random Number Guesser C#-Spiel in objektorientierter Programmierung entwickelt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |   Muss              | Funktional     |  Als User möchte ich die Wahl erhalten, das Spiel im Menu zu starten oder beenden zu können.  |
| 2    |    Muss             | Funktional     | Als User möchte ich eine zufällig generierte Geheimzahl zwischen 1 bis 100 erraten.  |
| 3    |  Muss            |   Funktional   |  Als User möchte ich Anweisungen erhalten, ob die eingegebene Zahl zu klein oder zu gross ist.  |
| 4    |  Muss            |   Funktional   |  Als User möchte ich sicherstellen, dass das Spiel bei Fehleingaben nicht abstürzt.    |
| 5    |  Muss            |  Funktional   |  Als User möchte ich eine Siegesmitteilung erhalten, wenn ich die geheime Zahl erraten habe. |
| 6    |     Muss         | Funktional     |  Als User möchte ich die Anzahl Versuche ausgegeben haben, wenn ich die Geheimzahl errate.   |
| 7    |     Kann         | Qualität     |  Als User möchte ich, dass bestimmte ausgegebene Zeilen mit Farben dargestellt werden (Bsp. die Siegesmitteilung sollte grün sein).   |
| 8    |     Muss         | Funktional     |  Als User möchte ich, dass bei einer neuen Runde eine neue geheime Zahl generiert wird.   |
| 9    |     Muss         | Funktional     |  Als User möchte ich die Möglichkeit erhalten weitere Runden zu spielen oder ins Spielmenü zurückzukehren.  |
| 10    |     Kann         | Qualität     |  Als User möchte ich, dass das Spielmenü ansprechend und schön gestaltet ist.    |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |    Öffnung des Programms.          |  Start Button oder F5       |    Spielmenu               |
| 1.2  |   Entscheidung [1] Spielen oder [2] Beenden           |  1       |    Spiel startet.               |
| 1.3  |   Entscheidung [1] Spielen oder [2] Beenden           |  2       |    Spiel endet.               |
| 1.4  |   Entscheidung [1] Spielen oder [2] Beenden           |  Input != 1 / 2       |   Ungültige Eingabe                |
| 2.1  |  Geheime Zahl wird generiert.          |   automatisch      |     Man kann geheime die Zahl erraten.              |
| 3.1  |  Eingabe Zahl ist korrekt.           |  enter Zahl       |    Geheime Zahl wurde erraten.               |
| 3.2  |   Eingabe Zahl ist falsch.           |  enter Zahl       |   Zahl ist zu klein oder zu gross.                |
| 4.1  |  Eingabe != eine Zahl            |  Enter != Zahl       |  Ungültige Eingabe                 |
| 5.1  | Siegesmitteilung erscheint.             |  automatisch       |     Zahl wurde erraten. Hurra :)              |
| 6.1  |  Anzahl benötigter Versuche            | automatisch        |   Anzahl Versuche werden angezeigt.                |
| 7.1  | Bestimmte Zeilen sind mit Farben dargestellt (z.B. Ungültige Eingabe = Rot)            |   automatisch      |  Bestimmte Zeilen sind farblich dargestellt.             |
| 8.1  | Neue generierte Geheimzahl           |  automatisch       |   Neue Geheimzahl wird generiert.                |
| 9.1  | Erneut spielen?             |   Ja      |  Neue Runde wird gestartet                 |
| 9.2  | Erneuter Durchlauf des gleichen Schemas           |  mehrere       |   Die neue Runde funktioniert, wie die vorherige.                |
| 9.3  | Erneut spielen?             |   Nein      |  Ins Spielmenu zurückgesendet                |
| 10.1  | Spielmenu entsprechend gestalten           |  automatisch       |   Die Gestaltung sieht angehnem aus.                |



### 1.4 Diagramme

![image](https://github.com/denisjashari54/Ranber-Game/assets/107101355/b4d19f31-6cea-412a-b272-6a91bb5b7d88)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  18.08.2023     | Denis Jashari          |  Spielmenu erstellen            |  45min             |
| 2.A  | 18.08.2023      |  Denis Jashari          | Zufallszahl Generator erstellen             |  45min             |
| 3.A  | 25.08.2023      |  Denis Jashari          |  Mitteilungen implementieren, ob geratene Zahl zu klein oder zu gross ist            |  45min  |
| 4.A  | 25.08.2023      |  Denis Jashari          | Fehlerbehandlungen einbauen             |  45min             |
| 5.A  | 01.09.2023      |  Denis Jashari          | Siegesmitteilung implementieren              |  45min             |
| 6.A  | 25.08.2023      |  Denis Jashari          | Anzahl Versuche gegen Spielende einbauen              |  45min             |
| 7.A  | 25.08.2023      |  Denis Jashari          |  Spielmitteliungen mit Farben gestalten            |  45min             |
| 8.A  | 25.08.2023      |  Denis Jashari          | Bei Start einer neuen Runde eine neue Geheimzahl generieren          |  45min             |
| 9.A  | 25.08.2023      |  Denis Jashari          | Möglichkeit einbauen gegen Spielende eine neue Runde starten oder zurück ins Spielmenu zu kehren.           |  45min             |
| 10.A  | 01.09.2023      |  Denis Jashari          |  Spielmenu schön gestalten           |  45min             |


## 3 Entscheiden

Ich habe mich dazu entschlossen, zwei Klassen zu erstellen: Eine für das Spielmenü und eine andere, die die Spiellogik enthält. Ausserdem habe ich mir vorgenommen möglichst viel Code in verschiedene Methoden zu verschachteln, um den Programmfluss besser zu strukturieren. 

## 4 Realisieren

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 18.08.2023      | Denis Jashari          |     45min          |       40min              |
| 2.A  | 18.08.2023      | Denis Jashari           |  45min             |     30min               |
| 3.A  | 25.08.2023      |  Denis Jashari         |        45min        |        60min            |
| 4.A  |  25.08.2023     | Denis Jashari          |   45min              |     120min             |
| 5.A  |  25.08.2023     |  Denis Jashari         |   45min              |      30min             |
| 6.A  | 25.08.2023      | Denis Jashari          |   45min              |      30min             |
| 7.A  | 01.09.2023      | Denis Jashari          |  45min               |      45min             |
| 8.A  |  01.09.2023     | Denis Jashari          |  45min               |      100min            |
| 9.A  |  08.09.2023     | Denis Jashari          |  45min               |      30min             |
| 10.A  | 08.09.2023     | Denis Jashari          |  45min               |       25min            |




## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 08.09.2023      |   OK       |   Denis Jashari     |
| 1.2  | 08.09.2023      |   OK       |   Denis Jashari     |
| 1.3  | 08.09.2023      |   OK       |   Denis Jashari     |
| 1.4  | 08.09.2023      |   OK       |   Denis Jashari     |
| 2.1  | 08.09.2023      |    OK      |   Denis Jashari      |
| 3.1  | 08.09.2023      |    OK      |  Denis Jashari       |
| 3.2  | 08.09.2023      |   OK       |  Denis Jashari       |
| 4.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 5.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 6.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 7.1  | 08.09.2023      |    OK      |  Denis Jashari       |
| 8.1  | 08.09.2023      |    OK      |  Denis Jashari       |
| 9.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 9.2  | 08.09.2023      |   OK       |  Denis Jashari       |
| 9.3  | 08.09.2023      |   OK       |   Denis Jashari     |
| 10.1  | 08.09.2023      |  OK        | Denis Jashari        |

Alles verlief reibungslos. Einige Herausforderungen erforderten zusätzlichen Einsatz, jedoch konnte ich sie alle erfolgreich bewältigen.

## 6 Auswerten


Bitte werfen Sie einen Blick auf meinen Portfolioeintrag: https://portfolio.bbbaden.ch/view/view.php?t=5d1e0df3c1d6cf318813

