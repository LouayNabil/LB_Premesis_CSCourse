using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{//Day 2 Excersize
    class Program
    {
        enum enum_FileTyper
        {
            csv,
            pdf,
            txt
        }

        public struct struct_Person
        {
            public int id;
            public string Navn;
            //public string author;
        }
        //Erklære
        static void Main(string[] args)
        {
            int int_Plus = 10;
            int int_Minus = 10;
            int_Plus++;
            int_Plus++;
            int_Minus--;

            Console.Write("Increment variable : " + int_Plus);
            //Console.WriteLine(int_Plus);
            Console.Write("Decrement variable : ");//, int_Minus);
            Console.WriteLine(int_Minus);

            int_Plus = +20;
            int_Minus = -20;
            Console.Write("Increment variable +20:", int_Plus);
            Console.WriteLine(int_Plus);
            Console.Write("Decrement variable -20:", int_Minus);
            Console.WriteLine(int_Minus);

            Console.ReadLine();

            //-----------------------------
            //Excercise 2_2:
            System.Double double_DPLus = 12.5;
            System.Double double_DMinus = 12.5;
            System.Double double_DMultiplication = 12.5;
            double_DPLus++;
            double_DMinus--;
            double_DMultiplication *= 2;
            System.Console.Write("Comma number Plus: ");
            System.Console.WriteLine(double_DPLus);

            System.Console.Write("Comma number Minus: " + double_DMinus);
            //System.Console.WriteLine(double_DMinus);

            System.Console.Write("Comma number Multiplication: ");
            System.Console.WriteLine(double_DMultiplication);

            //------------------------------
            //Excercise 2_3:
            enum_FileTyper myEnum = enum_FileTyper.csv;
            Console.WriteLine("enum: " + myEnum);
            //------------------------------
            //Excercise 2_4:
            struct_Person P = new struct_Person();
            P.id = 1;
            P.Navn = "Mikkel";
            Console.WriteLine("struct: " + myEnum);
            Console.ReadKey();


        }

        //System.

    }
}
