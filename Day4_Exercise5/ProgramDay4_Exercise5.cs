using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise5
{
    class ProgramDay4_Exercise5
    {
        static void Main(string[] args)
        {
            Class_Dyr[] dyr = new Class_Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Class_Dyr.TilfældigDyr();

            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }
        }
    }
}
