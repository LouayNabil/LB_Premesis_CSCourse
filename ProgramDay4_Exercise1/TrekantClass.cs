using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDay4_Exercise1
{

    //SKAL RETTES til den er ikke færdig!!
    class TrekantClass
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        private int areal;

        public int Areal
        {
            get
            {
                areal = this.Grundlinje * this.Højde * 0.5;
                return areal;
            }
            //set { Areal = value; }
        }

        //Custom constructor
        public double TrekantClass(int int_Grundlinje, int int_Højde)
        {
            this.Grundlinje = int_Grundlinje;
            this.Højde = int_Højde;
        }
    }
}
