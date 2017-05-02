using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Excersize3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Double double_DPLus = 12.5;
            System.Int32[] Int_Array = { 950000, 20000, 35000, 40000 };
            //System.Console.WriteLine("Array Values"+ Int_Array); //We can not write Array values in this way
            double Double_D = 0;
            double sum = 0;
            Double_D = Int_Array.Average();
            //System.Console.WriteLine("Array Values Average" + Int_Array);
            System.Console.WriteLine("Array Values Average Double: " + Double_D);
            System.Console.WriteLine();
            //--------------
            for (int i = 0; i < Int_Array.Length; i++)
            {
                sum += Int_Array[i];
            }
            double gns = sum / Int_Array.Length;
            for (int i = 0; i < Int_Array.Length; i++)
            {
                System.Console.WriteLine("Månedsløn: " + Int_Array[i]);
            }
            System.Console.WriteLine("Månedsløn gennemsnit: " + gns);

            //-------------------
            //Sortere of Array
            System.Array.Sort(Int_Array);
            for (int i = 0; i < Int_Array.Length; i++)
            {
                System.Console.WriteLine("Månedsløn Array Sort: " + Int_Array[i]);
            }
            //

            System.Console.ReadKey();

        }
    }
}
