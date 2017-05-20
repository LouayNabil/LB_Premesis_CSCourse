using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise2
{//Overload: status OK
    class ProgramDay3Exe2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("First Beregn: " + Beregn(3,5));
            System.Console.WriteLine("First Beregn: " + Beregn(3, 5, 7));
            System.Console.WriteLine("First Beregn: " + Beregn(3, 5, 7, 9));
            System.Console.ReadKey();
        }

        public static double Beregn(int x, int y)
        {
            return (x + y);
        }
        public static double Beregn(int x, int y, int z)
        {
            return (x + y + z);
        }
        public static double Beregn(int x, int y, int z, int m)
        {
            return (x + y + z + m);
        }
    }
}
