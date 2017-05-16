using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise5
{
    class Day3_Exercise5_OffentligPrivatClass1
    {
        public int Int_Værdig;
        private bool Bool_snyd;
        private static Random rnd = new System.Random();

        public Day3_Exercise5_OffentligPrivatClass1()

        {

        }

        public void Skriv()
        {
            //?????
            Console.WriteLine("2");
            Console.WriteLine("4");
        }

        public Day3_Exercise5_OffentligPrivatClass1(bool snyd)
        {
            this.Int_Værdig = 1;
            this.Bool_snyd = snyd;

        }
        
        public void Ryst()//(bool snyd)
        {
            /* gør den færdig
            if (snyd)
            {
                this.Int_Værdig = 6;
            }
            else
            {
                this.Int_Værdig = rnd.Next(1,7);
            }*/
        }
    }
}
