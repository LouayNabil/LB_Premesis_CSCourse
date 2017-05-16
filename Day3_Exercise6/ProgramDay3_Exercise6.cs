using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise6
{
    class ProgramDay3_Exercise6
    {
        static void Main(string[] args)
        {
            Day3_Exercise5_Class_Vare_Egnskaber My_instance;
            My_instance = new Day3_Exercise5_Class_Vare_Egnskaber();
            My_instance.Navn = "Vare #1";
            My_instance.Pris = 100;
            Console.WriteLine(My_instance.PrisMedMoms() );
            Day3_Exercise5_Class_Vare_Egnskaber My_instance2;
            My_instance2 = new Day3_Exercise5_Class_Vare_Egnskaber("vare 2", 200);
            Console.WriteLine(My_instance2.PrisMedMoms());
            Console.ReadKey();
        }
    }
}
