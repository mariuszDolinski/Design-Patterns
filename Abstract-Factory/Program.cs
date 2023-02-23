// Abstract factory (Fabryka abstrakcyjna) - fabryka do tworzenia abstrakcyjnych klas (lub interfejsów)
//     przykładowo jesli musimy zaimplementować tą samą aplikację na różnych systemach, np. Windows i MacOS
//     gdzie układ kontrole jest taki sam tu i tu ,to możemy uzyć fabryki abstrakcyjnej do tworzenia interfejsów
//     poszczególnych komponentów i z nich potem tworzyć konkretne kontrolki dla konkretnego systemu operacyjnego.
//     Dzięki takiemu rozwiązaniu mozna stworzyć jeden kod, który będzie mógł po uruchomieniu
//     wygenerować komponenty dla konkretnego podanego po uruchomieniu systemu

using Abstract_Factory;
using Abstract_Factory.WindowsComponents;
using Abstract_Factory.MacComponents;

Application macApplication = new Application(new MacFactory());
Application windowsApplication = new Application(new WindowsFactory());

macApplication.RenderUI();
Console.WriteLine();
windowsApplication.HandleInputUI();