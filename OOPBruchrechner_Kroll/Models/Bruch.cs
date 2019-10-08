//Autor:        Kroll
//Datum:        18.09.2019
//Dateiname:    Bruch.cs
//Beschreibung: "Bauplan" für ein Objekt Bruch
//Änderungen:
//18.09.2019:   Entwicklungsbeginn  
//08.10.2019:   Entwicklung abgeschlossen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBruchrechner_Kroll
{
    class Bruch
    {
        #region Eigenschaften
        private int _Zaehler;
        private int _Nenner;
        private char _Vorzeichen;

        #endregion

        #region Accessoren/Modifier
        public int Zaehler { get => _Zaehler; set => _Zaehler = value; }
        public int Nenner { get => _Nenner; set => _Nenner = value; }
        public char Vorzeichen { get => _Vorzeichen; set => _Vorzeichen = value; }
        #endregion

        #region Konstruktoren
        public Bruch()
        {
            this.Zaehler = 1;
            this.Nenner = 1;
        }
        //Spezialkonstruktor
        public Bruch(int val1, int val2)
        {
            this.Zaehler = val1;
            this.Nenner = val2;
        }
        #endregion

        #region Worker
        public Bruch Addieren(Bruch value)
        {
            int ergebnisZaehler = this.Zaehler * value.Nenner + this.Nenner * value.Zaehler;
            int ergebnisNenner = this.Nenner * value.Nenner;
            Bruch ergebnis = new Bruch(ergebnisZaehler, ergebnisNenner);
            ergebnis.Kuerzen();
            return ergebnis;
        }

        public Bruch Subtrahieren(Bruch value)
        {
            int ergebnisZaehler = this.Zaehler * value.Nenner - this.Nenner * value.Zaehler;
            int ergebnisNenner = this.Nenner * value.Nenner;
            Bruch ergebnis = new Bruch(ergebnisZaehler, ergebnisNenner);
            ergebnis.Kuerzen();
            return ergebnis;
        }

        public Bruch Multiplizieren(Bruch value)
        {
            int ergebnisZaehler = this.Zaehler * value.Zaehler;
            int ergebnisNenner = this.Nenner * value.Nenner;

            Bruch ergebnis = new Bruch(ergebnisZaehler, ergebnisNenner);
            ergebnis.Kuerzen();
            return ergebnis;
        }

        public Bruch Dividieren(Bruch value)
        {
            int ergebnisZaehler = this.Zaehler * value.Nenner;
            int ergebnisNenner = this.Nenner * value.Zaehler;

            Bruch ergebnis = new Bruch(ergebnisZaehler, ergebnisNenner);
            ergebnis.Kuerzen();
            return ergebnis;
        }

        private void Kuerzen()
        {
            //Euklidischer Alg.
            int ggTZaehler = Math.Abs(this.Zaehler);
            int ggTNenner = Math.Abs(this.Nenner);
            int ggT;

            if (ggTZaehler == 0)                    //ggT bestimmen
            {
                ggT = ggTNenner;
            }
            else
            {
                while (ggTNenner != 0)
                {
                    if (ggTZaehler > ggTNenner)
                    {
                        ggTZaehler = ggTZaehler - ggTNenner;
                    }
                    else
                    {
                        ggTNenner = ggTNenner - ggTZaehler;
                    }
                }
                ggT = ggTZaehler;
            }

            this.Zaehler = this.Zaehler / ggT;
            this.Nenner = this.Nenner / ggT;
        }

        public Bruch Zuweisung(Bruch value)
        {
            //Overloading ist für "=" nicht zulässig
            this.Zaehler = value.Zaehler;
            this.Nenner = value.Nenner;
            Bruch neuerBruch = new Bruch(value.Zaehler, value.Nenner);
            return neuerBruch;
        }
            #endregion

        #region Schnittstellen
            #endregion
        }
}
