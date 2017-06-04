using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDay4_Exercise2
{
    class ArealBeregningerClass
    {//•	
        public static double BeregnArealFirkant(double højde, double brede)
        { return højde * brede; }//•	
        public static double BeregnArealCirkel(double radius)
        { return (System.Math.Pow(radius, 2 * System.Math.PI)); }
    }
}
