//Autor:        Kroll
//Datum:        18.09.2019
//Dateiname:    main.cs
//Beschreibung: Hauptfunktion
//Änderungen:
//18.09.2019:   Entwicklungsbeginn  
using System;

namespace OOPBruchrechner_Kroll
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Bruch b1 = new Bruch(4, 5);
            Bruch b2 = new Bruch(1, 5);
            Bruch bErgebnis = new Bruch(2, 3);
            b1.Zaehler = 5;
            bErgebnis.Zuweisung(b1.Subtrahieren(b2));

            Console.WriteLine(bErgebnis.Zaehler + "/" + bErgebnis.Nenner);
        }
    }
}
