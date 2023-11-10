# MyBlazorBroker

Die bisher in nativem JavaScript geschriebene Progressive Web App **MyBroker** soll zu einer Blazor WebAssembly-Anwendung umgebaut werden.

## Die MyBroker PWA
Probier es mit Google Chrome aus:  
https://gregorbiswanger.github.io/MyBroker/

## Vorbereitungen für den Start
Folgendes benötigst du für das Projekt:    
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0 "dotnet.microsoft.com/download/dotnet/6.0") (läuft auf Windows, Mac und Linux)  
- [Visual Studio](https://visualstudio.microsoft.com "visualstudio.microsoft.com") oder [Visual Studio Code](https://code.visualstudio.com "code.visualstudio.com") mit der Blazor-Erweiterung (läuft auf Windows, Mac und Linux)  
  
Ein komplettes Übungsprojekt habe ich schon für dich auf GitHub vorbereitet:    
  
`git clone https://github.com/GregorBiswanger/MyBlazorBroker.git`  

Danach öffnest du das Projekt in Visual Studio oder Visual Studio Code.

## To-dos
Du brauchst dieselben Grundfunktionen der MyBroker-Web-App:
- Zwei Seiten mit Routing
- Logik zum Hinzufügen einer neuen Aktie
- Laden von Aktiendaten aus dem Web-Service (siehe unten)
- Anzeigen von Aktiendaten im Dashboard (Startseite)
- Aktualisieren von Aktiendaten per Klick auf einen Reload-Button
- Ein rotes oder grünes Label für den Änderungswert verwenden
  
## Bonus-To-dos
Für diejenigen unter euch mit mehr Erfahrung, könnt ihr die nächsten Features umsetzen:
- Speichern der Aktiendaten mit der HTML5-Standarddatenbank **LocalStorage**
- Implementieren einer Funktion zum Entfernen von Aktien im Dashboard
- Einen Materialize **Toast** anzeigen für aktualisierte Aktien mit positivem Änderungswert (siehe Dokumentation http://materializecss.com/)

## Extrem-Bonus-To-do
Für die absoluten Jedi-Ritter unter euch:
- Verwandle dieses Projekt in ein **Simulationsspiel** ;)

## Dummy-Web-Service
Dieser auf Node.js basierende REST-Web-Service liefert Dummy-Aktiendaten:  
https://stockplaceholder.herokuapp.com/api/stocks
  
### Dokumentation des Web-Services
https://stockplaceholder.herokuapp.com/api-docs/

**Viel Erfolg!**
