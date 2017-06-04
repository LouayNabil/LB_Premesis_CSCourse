using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise1
{
    class Trekant_Class
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }
        public double Areal {
            get {
                return this.Grundlinje * this.Højde * 0.5;
            }
            set { }
        }
        public Trekant_Class(int Grundlinje, int Højde)
        {
            this.Grundlinje = Grundlinje;
            this.Højde = Højde;
            //Grundlinje*Højde*0.5
        }

    }
}
