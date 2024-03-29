﻿//Autor:        Kroll
//Datum:        25.09.2019
//Dateiname:    UserInterface.cs
//Beschreibung: Interagiert mit dem Nutzer
//Änderungen:
//25.09.2019:   Entwicklungsbeginn 
//27.09.2019:   Funktionen mit TODOS hinzugefuegt
//28.09.2019:   Methoden ausgefuellt
//08.10.2019:   Entwicklung abgeschlossen

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace OOPBruchrechner_Kroll
{
    class UserInterface
    {

        #region Eigenschaften
        private Bruch _Bruch;
        private string _Text;
        #endregion

        #region Accessoren/Modifier
        public Bruch Bruch { get => _Bruch; set => _Bruch = value; }
        public string Text { get => _Text; set => _Text = value; }

        #endregion

        #region Konstruktoren
        public UserInterface()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            this.Text = "\n           Programmm:    Bruchrechner Version 1.0" +
                "\n           Autor:        Kroll" +
                "\n           Beschreibung: Simples Rechnen mit Brüchen";
            this.Bruch = new Bruch();
        }
        //Spezialkonstruktor
        public UserInterface(string versionsKennung)
        {
            this.Text = this.Text = "\n           Programmm:    Bruchrechner Version " + versionsKennung +
                "\n           Autor:        Kroll" +
                "\n           Beschreibung: Simples Rechnen mit Brüchen";
            
            this.Bruch = new Bruch();
        }

        #endregion

        #region Worker
        public Bruch BruchEinlesen()
        {
            int Zaehler;
            int Nenner;

            Console.WriteLine("Schreibe deinen Bruch (z.B.: -5/4):");

            Regex regEx = new Regex(@"^(-?\d+)(?# 1.Gruppe)(?:/)(-?[1-9]\d*)");
            string input = Console.ReadLine();
            Match match = regEx.Match(input);
            GroupCollection data = match.Groups;
            List<string> matches = new List<string>();

            if (match.Success)
            {
                foreach (string groupName in regEx.GetGroupNames())
                {
                    matches.Add(match.Groups[groupName].Value);
                }
                Bruch = new Bruch(Convert.ToInt32(matches[1]), Convert.ToInt32(matches[2]));
            }
            else // Bei falscher Eingabe noch einmal eine Eingabe erfragen
            {
                Console.WriteLine("Falsche Eingabe! Beachte das Beispiel und teile nicht durch 0!");
                Console.WriteLine("Weiter mit beliebiger Taste");
                Console.ReadKey();
                BruchEinlesen();
            }
            
            return Bruch;
        }

        public void BruchAusgeben()
        {
            Console.Clear();
            Console.WriteLine("Das Ergebnis lautet: ");
            
            //TODO: evtl. eine eigene Methode zum Prüfen der "Edge-Cases"
            if (Bruch.Zaehler == 0)
            {
                Console.WriteLine(0);
            }
            else if (Bruch.Zaehler == 1 && Bruch.Nenner == 1)
            {
                Console.WriteLine(1);
            }
            else if (Bruch.Zaehler < 0 && Bruch.Nenner < 0)
            {
                Console.WriteLine("\t" + Convert.ToString(-Bruch.Zaehler)); //hier das Minus rausnehmen für richtige Anzeige
                Console.WriteLine("\t" + "──");
                Console.WriteLine("\t" + Convert.ToString(-Bruch.Nenner)); //hier das Minus rausnehmen für richtige Anzeige
            }
            else if (Bruch.Zaehler < 0)
            {
                Console.WriteLine("\t" + "  " + Convert.ToString(-Bruch.Zaehler)); //hier das Minus rausnehmen für richtige Anzeige
                Console.WriteLine("\t" + "- " + "──");
                Console.WriteLine("\t" + "  " + Convert.ToString(Bruch.Nenner));
            }
            else if (Bruch.Nenner < 0)
            {
                Console.WriteLine("\t" + "  " + Convert.ToString(Bruch.Zaehler)); 
                Console.WriteLine("\t" + "- " + "──");
                Console.WriteLine("\t" + "  " + Convert.ToString(-Bruch.Nenner)); //hier das Minus rausnehmen für richtige Anzeige
            }
            else if (Bruch.Nenner == 1)
            {
                Console.WriteLine(Bruch.Zaehler);
            }
            //Für den Fall, dass der Bruch positiv ist
            else
            {
                Console.WriteLine("\t" + Convert.ToString(Bruch.Zaehler));
                Console.WriteLine("\t" + "──");
                Console.WriteLine("\t" + Convert.ToString(Bruch.Nenner));
            }

            Console.ReadKey();
        }

        public void SplashAusgeben()
        {
            Console.Clear();
            Console.WriteLine(Text);
            Thread.Sleep(2000);
        }

        public void MenueAusgeben()
        {
            Console.Clear();
            Console.WriteLine("Bruchrechner: ");
            Console.WriteLine();
            Console.WriteLine("1. Zwei Brüche miteinander addieren");
            Console.WriteLine("2. Zwei Brüche miteinander subtrahieren");
            Console.WriteLine("3. Zwei Brüche miteinander multiplizieren");
            Console.WriteLine("4. Zwei Brüche miteinander dividieren");
            Console.WriteLine("5. Programm verlassen");
        }

        public string MenueAuswahlEinlesen()
        {
            string MenuEingabe = Console.ReadLine(); //TODO: Fehleingaben abweisen
            return MenuEingabe;
        }

        #endregion

        #region Schnittstellen
        #endregion
    }
}
