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
            this.IO = new UserInterface();
        }
        #endregion

        #region Worker
        public void run()
        {
            Console.WriteLine("Hier geht's los");
            // TODO: 1.show splash 2. show menue 3. wait for input(menue selection) 4. show user example of a calculation and ask for input 5. read input, 6. put fractions into array, 7. calculate 8. give back result
            SplashAnzeigen();
            MenueAnzeigen();
            IO.BruchEinlesen();
            Brueche[0].Zuweisung(IO.Bruch);
            IO.BruchEinlesen
        }

        public void SplashAnzeigen()
        {
            // TODO: show Splash
        }

        public string MenueAnzeigen()
        {
            // TODO: show Menu
            return "hier sollte ein Menue sein";
        }

        public void BruechAddieren()
        {
            // TODO: add fractions
        }

        public void BruechSubtrahieren()
        {
            // TODO: subtract fractions
        }

        public void BruechMultiplizieren()
        {
            // TODO: multiply fractions
        }

        public void BruechDividieren()
        {
            // TODO: divide fractions
        }

        public void ErgebnisAnzeigen()
        {
            // TODO: show result fraction
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
