using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise5
{
    class ProgramDay3_Exercise5
    {
        static void Main(string[] args)
        {

            Day3_Exercise5_OffentligPrivatClass1 t1;
            Day3_Exercise5_OffentligPrivatClass1 t2;

            t1 = new Day3_Exercise5_OffentligPrivatClass1();
            t2 = new Day3_Exercise5_OffentligPrivatClass1(true);

            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            System.Console.ReadKey();


        }
    }
}
