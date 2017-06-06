using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise3
{
    class Class_Hund : Interface_IDbFunktioner
    {
        public int Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund....");
            //throw new NotImplementedException();
        }


        //def constructor
        //public Class_Hund()
    }
}
