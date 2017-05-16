using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise4
{
    class ProgramDay3Exe4
    {
        static void Main(string[] args)
        {
            ProgramDay3Exe4_TerningClass Terning1;
            ProgramDay3Exe4_TerningClass Terning2;
            Terning1 = new ProgramDay3Exe4_TerningClass();// ProgramDay3Exe4_TerningClass();
            Terning2 = new ProgramDay3Exe4_TerningClass(25);

            Console.WriteLine("Terning1 værdig: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdig: " + Terning2.værdi);

            Terning2 = Terning1;
            Console.WriteLine("Terning1 værdig: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdig: " + Terning2.værdi);

            Terning1.værdi = 256;
            Console.WriteLine("Terning1 værdig: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdig: " + Terning2.værdi);

            Terning2.værdi = 558;
            Console.WriteLine("Terning1 værdig: " + Terning1.værdi);
            Console.WriteLine("Terning2 værdig: " + Terning2.værdi);
        }
    }
}
