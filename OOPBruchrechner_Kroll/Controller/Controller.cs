//Autor:        Kroll
//Datum:        25.09.2019
//Dateiname:    Controller.cs
//Beschreibung: Verwaltet die Daten
//Änderungen:
//25.09.2019:   Entwicklungsbeginn 

using OOPBruchrechner_Kroll;
using System;

namespace OOPBruchrechner_Kroll
{
    class Controller
    {


        #region Eigenschaften
        Bruch[] _Brueche;
        UserInterface _IO;
        #endregion

        #region Accessoren/Modifier
        internal Bruch[] Brueche { get => _Brueche; set => _Brueche = value; }
        internal UserInterface IO { get => _IO; set => _IO = value; }
        #endregion

        #region Konstruktoren
        public Controller()
        {
            this.Brueche = new Bruch[3];
            for (int i = 0; i < Brueche.Length; i++)
            {
                Brueche[i] = new Bruch();
            }
            this.IO = new UserInterface();
        }
        #endregion

        #region Worker
        public void run()
        {
            SplashAnzeigen();

            bool running = true;

            while (running)
            {
                
                string Rechenart = MenueAnzeigen();

                if (Rechenart == "1" || Rechenart == "2" || Rechenart == "3" || Rechenart == "4")
                {
                    Console.Clear();
                    IO.BruchEinlesen();
                    Brueche[0].Zuweisung(IO.Bruch);
                    IO.BruchEinlesen();
                    Brueche[1].Zuweisung(IO.Bruch);
                }
                else
                {

                }
                
                switch (Rechenart)
                {
                    case "1":
                        BruecheAddieren();
                        ErgebnisAnzeigen();
                        break;
                    case "2":
                        BruecheSubtrahieren();
                        ErgebnisAnzeigen();
                        break;
                    case "3":
                        BruecheMultiplizieren();
                        ErgebnisAnzeigen();
                        break;
                    case "4":
                        BruecheDividieren();
                        ErgebnisAnzeigen();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("falsche Eingabe");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void SplashAnzeigen()
        {
            IO.SplashAusgeben();
        }

        public string MenueAnzeigen()
        {
            IO.MenueAusgeben();
            string Auswahl = IO.MenueAuswahlEinlesen();
            return Auswahl;
        }

        public void BruecheAddieren()
        {
            Brueche[2].Zuweisung(Brueche[0].Addieren(Brueche[1]));
        }

        public void BruecheSubtrahieren()
        {
            Brueche[2].Zuweisung(Brueche[0].Subtrahieren(Brueche[1]));
        }

        public void BruecheMultiplizieren()
        {
            Brueche[2].Zuweisung(Brueche[0].Multiplizieren(Brueche[1]));
        }

        public void BruecheDividieren()
        {
            Brueche[2].Zuweisung(Brueche[0].Dividieren(Brueche[1]));
        }

        public void ErgebnisAnzeigen()
        {
            IO.Bruch.Zuweisung(Brueche[2]);
            IO.BruchAusgeben();
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
