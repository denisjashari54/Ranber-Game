# Projekt-Dokumentation
von Denis Jashari

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    18.08.23   | 0.0.1   | Ich habe mich erneut in C# eingearbeitet und konnte eine klare Idee von meinem Projekt entwickeln. Dadurch war es mir möglich, mein Projekt sorgfältig zu planen. |
|  25.08.2023     | 0.0.2     |  Nachdem ich mich erneut mit dem Informatieren und dem Planen befasst habe, begann ich mit der Programmierung.                                                         |
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
| 2.1  |   Entscheidung [1] Spielen oder [2] Beenden           |   1      |     Spiel startet. Man kann geheime Zahl erraten              |
| 2.2  |   Entscheidung [1] Spielen oder [2] Beenden           |  2       |    Spiel beendet.               |
| 2.3  |   Entscheidung [1] Spielen oder [2] Beenden           |  Input != 1 / 2       |   Ungültige Eingabe                |
| 3.1  |  Eingabe der Zahl.           |  enter Zahl       |    Zahl ist korrekt oder falsch               |
| 4.1  |   Eingabe Zahl ist falsch.           |  enter Zahl       |   Zahl ist zu klein oder zu gross.                |
| 5.1  |  Eingabe != eine Zahl            |  Enter != Zahl       |  Ungültige Eingabe                 |
| 6.1  | Siegesmitteilung erscheint.             |  automatisch       |     Zahl wurde erraten. Hurra :)              |
| 7.1  |  Anzahl benötigter Versuche            | automatisch        |   Anzahl Versuche werden angezeigt.                |
| 8.1  | Erneut spielen?             |   Nein      |      Ins Spielmenu zurückgesesetzt              |
| 8.2  | Erneut spielen?             |   Ja      |  Neue Runde wird gestartet                 |
| 9.1  | Erneuter Durchlauf des gleichen Schemas           |  mehrere       |   Die neue Runde funktioniert, wie die vorherige.                |


### 1.4 Diagramme

![image](https://github.com/denisjashari54/Ranber-Game/assets/107101355/13573150-5e9f-4232-a4bd-3afba24cdc78)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  18.08.2023     | Denis Jashari          |  Informieren            |  90min             |
| 2.A  | 18.08.2023      |  Denis Jashari          | Planen             |  90min             |
| 3.A  | 25.08.2023      |  Denis Jashari          |  Spielmenu erstellen            |  45min  |
| 3.B  | 25.08.2023      |  Denis Jashari          | Spielmenu: [1] Spielen oder [2] Spiel beenden             |  45min             |
| 3.C  | 01.09.2023      |  Denis Jashari          | Spielmenu: [1] Spielen oder [2] Spiel beenden Fehlerbehandlung (User gibt statt 1 oder 2 andere Zeichen ein)              |  45min             |
| 4.A  | 25.08.2023      |  Denis Jashari          | Zufallsgenerator erstellen              |  45min             |
| 5.A  | 25.08.2023      |  Denis Jashari          |  Zahlen erraten einbauen            |  90min             |
| 5.B  | 25.08.2023      |  Denis Jashari          | Zahlen erraten Fehlerbehandlung (User gibt statt Zahl andere Zeichen ein)            |  45min             |
| 6.A  | 25.08.2023      |  Denis Jashari          | Geheimzahl wurde erraten + Siegesmitteilung            |  45min             |
| 7.A  | 01.09.2023      |  Denis Jashari          |  Anzahl benötigter Versuche einbauen            |  45min             |
| 8.A  | 01.09.2023     |  Denis Jashari          | Neue Runde starten             |  45min             |
| 8.B  | 01.09.2023     |  Denis Jashari          | Neue Runde starten Fehlerbehandlung (User gibt statt ja oder nein andere Zeichen ein)             |  45min             |
| 9.A  | 08.09.2023      |  Denis Jashari          | Dekoratiuon (Farbe einbauen, Titel verschöner, usw.)             |  45min             |
| 10.A  | 08.09.2023      |  Denis Jashari          | Letzte Anpassungen             |  45min             |


## 3 Entscheiden

Ich habe mich dazu entschlossen, zwei Klassen zu erstellen: Eine für das Spielmenü und eine andere, die die Spiellogik enthält. Ausserdem habe ich mir vorgenommen möglichst viel Code in verschiedene Methoden zu verschachteln, um den Programmfluss besser zu strukturieren. 

## 4 Realisieren

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 18.08.2023      | Denis Jashari          |     90min          |       90min            |
| 2.A  | 18.08.2023      | Denis Jashari           |  90min             |     120min              |
| 3.A  | 25.08.2023      |  Denis Jashari         |        45min        |        45min           |
| 3.B  | 25.08.2023      |  Denis Jashari         |   45min              |      45min             |
| 3.C  | 25.08.2023      | Denis Jashari          |   45min              |     30min              |
| 4.A  |  25.08.2023     | Denis Jashari          |   45min              |     20min              |
| 5.A  |  25.08.2023     |  Denis Jashari         |   90min              |      100min             |
| 5.B  | 25.08.2023      | Denis Jashari          |   45min              |      35min             |
| 6.A  | 25.08.2023      | Denis Jashari          |   45min              |      30min             |
| 7.A  | 01.09.2023      | Denis Jashari          |  45min               |      45min             |
| 8.A  |  01.09.2023     | Denis Jashari          |  45min               |      100min             |
| 8.B  |  01.09.2023     |  Denis Jashari         |   45min              |       25min            |
| 9.A  |  08.09.2023      | Denis Jashari          |  45min               |      15min             |
| 10.A  | 08.09.2023       | Denis Jashari          |  45min               |       20min            |




## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 08.09.2023      |   OK       |   Denis Jashari     |
| 2.1  | 08.09.2023      |    OK      |   Denis Jashari      |
| 3.1  | 08.09.2023      |    OK      |  Denis Jashari       |
| 3.2  | 08.09.2023      |   OK       |  Denis Jashari       |
| 3.3  | 08.09.2023      |   OK       |  Denis Jashari       |
| 4.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 5.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 6.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 7.1  | 08.09.2023      |    OK      |  Denis Jashari       |
| 8.1  | 08.09.2023      |    OK      |  Denis Jashari       |
| 8.2  | 08.09.2023      |   OK       |  Denis Jashari       |
| 9.1  | 08.09.2023      |   OK       |  Denis Jashari       |
| 10.1  | 08.09.2023      |  OK        | Denis Jashari        |

Alles verlief reibungslos. Einige Herausforderungen erforderten zusätzlichen Einsatz, jedoch konnte ich sie alle erfolgreich bewältigen.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.


