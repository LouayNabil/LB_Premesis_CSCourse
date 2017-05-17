using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise4
{ //Exercise MANGLER at gøres færdig
    class TerningClass
    {
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Værdi er:  " + this.værdi);
                return værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    value = 1;
                }
                this.værdi = value;
                Console.WriteLine("terning tildeles: " + this.værdi);
            }
        }

        TerningClass()
        {
            Ryst();
        }
        public void Ryst()
        {
         //   this.Værdi = rnd.Next(1, 7);
        }
        /*private static rnd= System.Random()
        {

        }*/
    /*public Skriv()
    {
    }*/
    


}
}
