using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise1
{
    class Program
    {//Simpel Fejlhåndtering
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            try
            {
                Console.WriteLine("Indtast 1.tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2.tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int res = tal1 + tal2;
                Console.WriteLine("Resultatet er: " + res);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("det er sket en fejl " + ex.Message);
                //throw;
            }
        }
    }
}
