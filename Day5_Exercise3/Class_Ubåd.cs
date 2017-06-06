using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise3
{
    class Class_Ubåd : Interface_IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Gemmer Ubåd....");
        }
    }
}
