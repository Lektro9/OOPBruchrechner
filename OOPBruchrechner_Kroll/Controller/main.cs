//Autor:        Kroll
//Datum:        18.09.2019
//Dateiname:    main.cs
//Beschreibung: Hauptfunktion
//Änderungen:
//18.09.2019:   Entwicklungsbeginn 
//08.10.2019:   Entwicklung abgeschlossen
using System;

namespace OOPBruchrechner_Kroll
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Controller Verwalter = new Controller("1.2");

            Verwalter.run();

        }
    }
}
