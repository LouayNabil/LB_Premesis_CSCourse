using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise4
{//ICoparable
    class Program
    {
        static void Main(string[] args)
        {
            Class_Hund[] hunde = new Class_Hund[2];
            hunde[0] = new Class_Hund() { Alder = 10, Navn ="Bulder" };
            hunde[1] = new Class_Hund() { Alder = 5, Navn = "Lady" };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
            System.Console.ReadKey();
        }
    }
}
