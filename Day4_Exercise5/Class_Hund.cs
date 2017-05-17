using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise5
{
    class Class_Hund : Class_Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("jeg er en hund og hedder..." + this.Navn);
            System.Console.ReadKey();
        }


    }
}
