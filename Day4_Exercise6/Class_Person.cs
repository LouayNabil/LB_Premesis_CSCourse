using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise6
{
    class Class_Person
    {
        public string Fornavn  { get; set; }

        public string Efternavn { get; set; }

        public virtual void skriv()
        {
            Console.WriteLine( "Fornavn Efternavn: " + Fornavn+ " " + Efternavn);
            Console.ReadKey();

        }
    }
}
