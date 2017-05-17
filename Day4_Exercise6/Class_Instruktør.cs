using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise6
{
    class Class_Instruktør: Class_Person
    {
        public int Nøgleid { get; set; }

        public override void skriv()
        {
            base.skriv();
            Console.WriteLine($"()"); //$ generate template String af flere variabler.

        }
    }
}
