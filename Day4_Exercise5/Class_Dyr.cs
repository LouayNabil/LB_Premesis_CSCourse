using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise5
{
    class Class_Dyr //Runs OK :) as written as teacher solution
    {
        static System.Random rnd = new Random();

        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("jeg er dyr der hedde: " + this.Navn);
        }

        public static Class_Dyr TilfældigDyr() //Notice Type = Class_Dyr
        {
            string sti = @"X:\Michell\Filer\dyrenavne.txt";
            string[] navn = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navn.Length); //length of the Name array
            if (index % 2 == 0)
                return new Class_Hund() { Navn = navn[index] }; //make instance of HUNS 
            else
                return new Class_Kat() { Navn = navn[index] };
        }


    }
}
