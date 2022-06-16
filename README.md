<h1 align="center">HTL-VRProject with XRInteractionToolkit</h1>
<div align="center">Documentation of my VR Game</div>
<div align="center">2021/2022</div>
<div align="center">16 - Fabio Wienerroither</div>


### Gründe das Spiel zu spielen / Story

In meinem VR-Projekt zum Thema „Ostern“ nimmt man die Identität des Osterhasen an. Im ersten Abschnitt des Spieles befindet man sich in seinem Hasenbau und bereitet alles für das Verstecken der Osternester im zweiten Abschnitt des Spiels vor. Jedoch ist an der Oberfläche Vorsicht geboten: Da der Osterhase (Du) dieses Jahr etwas spät dran ist sind die Kinder bereits am Suchen. Dein Ziel ist es dann die Osternester zu verstecken, ohne von den Kindern gesehen zu werden, um nicht die Magie der Osterfesttage zu Nichte zu machen.
Dadurch, dass man den Osterhasen spielt, wird einem gleich zu Beginn des Spieles eine besondere Rolle gegeben. Der richtige Spaß geht jedoch erst an der Oberfläche los: die Osternester nehmen, vor den Kindern verstecken, sich Laufwege einfallen lassen, um nicht von den Kindern gesehen zu werden, die durchgehende Aufmerksamkeit/Adrenalin, weil man jederzeit entdeckt werden könnte und die belohnenden Soundeffekte, wenn man eine Aufgabe erfolgreich erledigt hat. 


### Sounds

- Vogelgezwitscher
- Huhnsound
- Belohnender Sound bei korrekter Befüllung des Nests
- Guidesound bei falscher Befüllung des Nests

Für weitere Sounds ist leider, durch einige Probleme mit der Funktionaliät, keine Zeit mehr geblieben. Zudem wären die meisten Sounds im zweiten Minigame eingebaut worden.

### Minigame 1

1.	Finde im Hasenbau die „Werkstätte“ des Osterhasen (wird durch ein Eierlegendes Hund, welches Sounds von sich gibt markiert)
2.	Nimm ein Ei, tunke es in einen der Farbeimer und wirf es anschließend in das Osternest
3.	Sobald du drei Eier mit den drei verschiedenen Farben in das Nest geworfen hast, geht die „Tür“ auf und du kannst in nächste Level gehen


### Minigame 2

1.	Nimm dir ein Nest und suche den ersten Nestplatz, welcher durch einen Sound markiert ist
2.	Passe auf währenddessen nicht von Kindern entdeckt zu werden
3.	Nachdem das erste Nest erfolgreich platziert wurde, musst du zurückgehen und das zweite Nest holen
4.	Sobald du das zweite Nest im zweiten Nestplatz platziert hast, öffnet sich der Ausgang des Labyrinths 
5.	Wirst du von einem der Kinder entdeckt ist es „Game Over“ und du musst erneut beginnen


### Skizze



### Arbeitsschritte

1.	Projekt aufsetzen
2.	Erstellung erstes Minigame
3.	Testen erstes Minigame
4.	Erstellung zweites Minigame
5.	Testen zweites Minigame
6.	Movement testing (Continous Movement oder TP)
7.	Erstellung erster Build
8.	Fehlerbehebung
9.	Minigameanpassung
10.	Recherche Sound
11.	Benötigte Sound aufnehmen
12.	Sound einbauen
13.	Modellierung nicht in anderen Assets gefundener Objekte
14.	Gesamtprojekt testen
15.	Erstellung zweiter Build
16.	Fehlerbehebung
17.	Testen und Fehlerbehebung wiederholen


### Development platform

| Technology  | Name                                 |
| ----------- | ------------------------------------ |
| OS          | Windows 10                           |
| Game Engine | Unity 2020.3.18f1                    |
| IDE         | Visual Studio Code (With extensions) |

Wie Sie VS-Code mit Unity einrichten können, erfahren Sie [hier](https://code.visualstudio.com/docs/other/unity).

### Packages

| Package Name              | Package ID                           | Version |
| :------------------------ | :----------------------------------- | :------ |
| JetBrains Rider Editor    | com.unity.ide.rider                  | 2.0.7   |
| Oculus XR Plugin          | com.unity.xr.oculus                  | 1.10.0  |
| Test Framework            | com.unity.test-framework             | 1.1.29  |
| TextMeshPro               | com.unity.textmeshpro                | 3.0.6   |
| Timeline                  | com.unity.timeline                   | 1.4.8   |
| Unity UI                  | com.unity.ugui                       | 1.0.0   |
| Universal RP              | com.unity.render-pipelines.universal | 10.6.0  |
| Version Control           | com.unity.collab-proxy               | 1.9.0   |
| Visual Studio Code Editor | com.unity.ide.vscode                 | 1.2.5   |
| Visual Studio Editor      | com.unity.ide.visualstudio           | 2.0.11  |
| XR Interaction Toolkit    | com.unity.xr.interaction.toolkit     | 2.0.2   |
| XR Plugin Management      | com.unity.xr.management              | 4.0.7   |

Generiert mit meinem [Unity manifest to markdown converter](https://timtoller.github.io/unity-manifest-to-markdown/).

## Sounds und Assets

Sounds von Youtube und Mixkit

### Objects

- [Huhn]: https://www.cgtrader.com/free-3d-models/animals/bird/christmas-chicken-grey-low-polygon-art-bird
- Alle anderen Objekte wurden selbst modeliert


## Software/Hardware-Anforderungen

[Oculus Hardware-Anforderungen](https://support.oculus.com/248749509016567/)
Sie benötigen ein VR-Headset, in diesem Fall ein Oculus Rift/Quest/Quest2

[Beispiele](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples)

Beim Herunterladen treten Kompilierzeitfehler im Projekt auf. Um diese zu beheben, installieren Sie das XR Interaction Toolkit Paket über den Package Manager.


## Beschränkungen und Änderungen

Da wir nur ein relativ kleines Zeitfenster hatten das Spiel fertig zu stellen, war es nur noch notwendig ein Minigame umzusetzen, vorausgesetzt es gibt ein Intro und Outro.


### Target platform

Oculus Rift/S; Quest/2


### Third party material

Für Tests ohne Headset verwenden Sie den XR Device Simulator (im xr interaction toolkit Paket enthalten) [tutorial](https://www.youtube.com/watch?v=d4bTpkvBwrs)

> Copyright by Fabio Wienerroither
