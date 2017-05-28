using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise5
{// Terning (1) - Offentlig og privat medlemmer. Status:Done
    class ProgramDay3_Exercise6
    {
        static void Main(string[] args)
        {
            Day3_Exercise6_OffentligPrivatClass1 t1;
            Day3_Exercise6_OffentligPrivatClass1 t2;

            t1 = new Day3_Exercise6_OffentligPrivatClass1();
            t2 = new Day3_Exercise6_OffentligPrivatClass1(true);
            
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            System.Console.ReadKey();
          }
    }
}
