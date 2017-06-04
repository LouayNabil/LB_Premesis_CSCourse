using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise1
{//Egenskaber - Trekant class. Status: Done
    class ProgramDay4_Exercise1
    {
        static void Main(string[] args)
        {
            Trekant_Class inst = new Trekant_Class(4,5);
            Console.WriteLine("Trekan areal er: " + inst.Areal);
            System.Console.ReadKey();
        }

    }
}
