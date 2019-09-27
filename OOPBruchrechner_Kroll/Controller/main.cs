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
            Controller Verwalter = new Controller();

            Verwalter.run();

        }
    }
}
