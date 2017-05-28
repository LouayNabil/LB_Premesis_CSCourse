using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise5
{
    class Day3_Exercise6_OffentligPrivatClass1
    {// Terning (1) - Offentlig og privat medlemmer. Status:Done
        public int Int_Værdig;
        private bool Bool_snyd;
        private static Random rnd = new System.Random();

        public Day3_Exercise6_OffentligPrivatClass1()
        {
            this.Int_Værdig = 1;
            this.Bool_snyd = false;
        }
        public Day3_Exercise6_OffentligPrivatClass1(bool snyd)
        {
            this.Int_Værdig = 1;
            this.Bool_snyd = snyd;
        }
        public void Skriv()
        {
            System.Console.WriteLine("Udskriv fkt. def/custom constructor, værdien af terning er: "+"[" + this.Int_Værdig + "]");
        }
        public void Ryst()
        {
            if (this.Bool_snyd)
            {
                this.Int_Værdig = 6;
            }
            else
            {
                this.Int_Værdig = rnd.Next(1, 7);
            }
        }
    }
}
