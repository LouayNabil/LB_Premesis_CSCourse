using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDay4_Exercise2
{//Day4_Exercise2 - Statiske metoder. Status:Done
    class ProgramDay4_Exercise2
    {
        static void Main(string[] args)
        {
            ArealBeregningerClass inst = new ArealBeregningerClass();
            Console.WriteLine("ArealBeregningerClass: " + ArealBeregningerClass.BeregnArealFirkant(10, 10));
            Console.WriteLine("ArealBeregningerClass: " + ArealBeregningerClass.BeregnArealCirkel(10));
            Console.ReadKey();
        }
    }
}
