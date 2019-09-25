//Autor:        Kroll
//Datum:        25.09.2019
//Dateiname:    UserInterface.cs
//Beschreibung: Interagiert mit dem Nutzer
//Änderungen:
//25.09.2019:   Entwicklungsbeginn 

using System;
using System.Threading;

namespace OOPBruchrechner_Kroll.Views
{
    class UserInterface
    {

        #region Eigenschaften
        Bruch _Bruch;
        string _Text;



        #endregion

        #region Accessoren/Modifier
        public Bruch Bruch { get => _Bruch; set => _Bruch = value; }
        public string Text { get => _Text; set => _Text = value; }

        #endregion

        #region Konstruktoren
        public UserInterface()
        {
            this.Text = "Willkommen zum Bruchrechner";
            this.Bruch = new Bruch();
        }
        
        #endregion

        #region Worker
        public Bruch Brucheinlesen()
        {
            int Zaehler;
            int Nenner;

            Console.WriteLine("Gebe den Zähler des Bruches ein");
            Zaehler = Convert.ToInt32(Console.ReadLine()); //TODO: Fehleranfälligkeit verbessern
            Console.WriteLine("Gebe den Nenner des Bruches ein");
            Nenner = Convert.ToInt32(Console.ReadLine());

            Bruch BruchEingabe = new Bruch(Zaehler, Nenner);

            return BruchEingabe;
        }

        public void BruchAusgeben()
        {
            if (Bruch.Zaehler < 0)
            {
                Console.WriteLine("\t" + "  " + Convert.ToString(-Bruch.Zaehler)); //hier das Minus rausnehmen für richtige Anzeige
                Console.WriteLine("\t" + "- " + "──");
                Console.WriteLine("\t" + "  " + Convert.ToString(Bruch.Nenner));
            }
            //Für den Fall, dass der Bruch positiv ist
            else
            {
                Console.WriteLine("\t" + Convert.ToString(Bruch.Zaehler));
                Console.WriteLine("\t" + "──");
                Console.WriteLine("\t" + Convert.ToString(Bruch.Nenner));
            }

        }

        public void SplashAusgeben()
        {
            Console.Clear();

            Console.WriteLine(@" ___                        _      ___                  _                         
(  _`\                     ( )    |  _`\               ( )                        
| (_) ) _ __  _   _    ___ | |__  | (_) )   __     ___ | |__    ___     __   _ __ 
|  _ <'( '__)( ) ( ) /'___)|  _ `\| ,  /  /'__`\ /'___)|  _ `\/' _ `\ /'__`\( '__)
| (_) )| |   | (_) |( (___ | | | || |\ \ (  ___/( (___ | | | || ( ) |(  ___/| |   
(____/'(_)   `\___/'`\____)(_) (_)(_) (_)`\____)`\____)(_) (_)(_) (_)`\____)(_)   ");

            Console.WriteLine("\n           Programmm:    BruchrechnerV1.0");
            Console.WriteLine("           Autor:        Kroll");
            Console.WriteLine("           Beschreibung: Simples Rechnen mit Brüchen");
            Thread.Sleep(2000);
        }

        public void MenueAusgeben()
        {
            Console.Clear();
            Console.WriteLine("Bruchrechner");
            Console.WriteLine();
            Console.WriteLine("1. Zwei Brüche miteinander berechnen");
            Console.WriteLine("2. Programm verlassen");
            
        }

        public string MenueAuswahlEinlesen()
        {
            string MenuEingabe = Console.ReadLine();
            return MenuEingabe;
        }

        #endregion

        #region Schnittstellen
        #endregion
    }
}
