using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise4
{
    class ProgramDay3Exe4
    {
        //Terning. Status :OK
        static void Main(string[] args)
        {
            Day3Exe4_TerningClass Terning1;
            Day3Exe4_TerningClass Terning2;
            Terning1 = new Day3Exe4_TerningClass();
            Terning2 = new Day3Exe4_TerningClass(25);

            Console.WriteLine("Terning1 værdi: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdi: " + Terning2.værdi);

            Terning2 = Terning1;
            Console.WriteLine("Terning1 værdi-Efter vi sat t2=t1: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdi-Efter vi sat t2=t1: " + Terning2.værdi);

            Terning1.værdi = 256;
            Console.WriteLine("Terning1 værdi, efter rettelse af t1: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdi, efter rettelse af t1: " + Terning2.værdi);

            Terning2.værdi = 558;
            Console.WriteLine("Terning1 værdi, efter rettelse af t2: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdi, efter rettelse af t2: " + Terning2.værdi);
            System.Console.ReadKey();
        }
    }
}
