using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Exe4
{
    class ProgramDay2Exe4
    {   //Excersise4  02May2017 Day 2. Multiplication Table
        static void Main(string[] args)
        {
            
            String Str_Tal="";
            for (int Int_i = 1; Int_i < 11; Int_i++)
            {
                for (int Int_MM = 1; Int_MM < 11; Int_MM++)
                {
                    if ((Int_i * Int_MM) > 49)
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        System.Console.ForegroundColor = ConsoleColor.White;
                    Str_Tal = ((Int_i * Int_MM)).ToString();
                    System.Console.Write(Str_Tal.PadLeft(4));
                }
                //System.Console.Write(Int_i);
                System.Console.WriteLine();
            }
            System.Console.WriteLine("------------------");
            System.Console.WriteLine();

            //------------------------
            //First try - N O T Multiplication Table
            int Int_X = 0;
            //int Int_Y= 0;
            //int length = 4;
            int b = 0;
            int tt = 0;
            for (int i = 0; i < 10; i++)
            {
                for (b = 1; b < 11; b++)
                //for (i=i+b; i < b+11; b++)
                {
                    System.Console.Write(b + tt);// (Int_X);
                    System.Console.Write("  ");
                }
                System.Console.WriteLine();
                tt = b + tt - 1;
            }
            //System.Console.WriteLine("jkkljklj");

            System.Console.ReadKey();
        }
    }
}
