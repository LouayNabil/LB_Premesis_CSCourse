using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise6
{
    class Day3_Exercise5_Class_Vare_Egnskaber
    {

        //private string Navn;
        //using "propfull" + Tab

        //Constructor
        public Day3_Exercise5_Class_Vare_Egnskaber()
        { }
        //Custom Constructor
        public Day3_Exercise5_Class_Vare_Egnskaber(string navn, double pris)
        {
            this.pris = pris;
            this.Navn = navn;
        }

        private string  navn;

        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses navn");
                return navn; }
            set {
                Console.WriteLine("Nu tildeles navn");
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses navn");
                return pris; }
            set { Console.WriteLine("Nu tildeles navn");
                pris = value; }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

    }
}
