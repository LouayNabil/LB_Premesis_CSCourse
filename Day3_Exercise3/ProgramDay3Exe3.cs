using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise3
{ //Beregn array - status:?
    class ProgramDay3Exe3
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 4, 5 };
            int[] MyArray2 = { 1, 2, 3, 4, 5 };
            var res = "";
            System.Console.WriteLine("Gennemsnit som Day3Exe1, hvor det´r returneres KUN EN VÆRDI:  " + BeregnOgSorterArray(MyArray));
            System.Console.WriteLine("Gennemsnit, hv:  " + BeregnOgSorterArray2(MyArray2));
            System.Console.ReadKey();  

        }
        //static double Gennemsnit(int[] månedsløn)

        static double BeregnOgSorterArray(int[] MyArray)
        {
            double sum = 0;
            for (int i = 0; i < MyArray.Length; i++) { sum += MyArray[i]; }
            return sum;
        }
        public static ArrayResultat BeregnOgSorterArray2(int[] MyArray2)
        {
            ArrayResultat MyStruct;
            MyStruct.sum = 0;
            MyStruct.gennemsnit = 0;
            foreach (var item in MyArray2) { MyStruct.sum += item; }
            MyStruct.gennemsnit = (MyStruct.sum / MyArray2.Length);
            Array.Sort(MyArray2);
            return MyStruct;
        }
        /*    public double struct ArrayResultat;
        public double sum;
        public double Gennemsnit;
        //System.Array.
        //Array.sort
        return int f//ArrayResultat;
    */
    }

    struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;
    }

}

