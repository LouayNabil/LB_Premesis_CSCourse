using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Exercise2
{//Collection2
    class Program
    {
        static void Main(string[] args)
        {
            ClassBunke b = new ClassBunke();
            b.TilføjKort(new ClassKort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new ClassKort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new ClassKort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k=b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
