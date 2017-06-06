using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise3
{//Exercixe to use Interface - A class/Interface that can be used such that other classes (for instance Hund, Ubåd) kan make instances
    //Hund&UBåd HAVE to implement all method that are defined in the Interface class Interface_IDbFunktioner !
    //Michell Cronberg Code: Module10Interface
    class Program
    {
        static void Main(string[] args)
        {
            Interface_IDbFunktioner[] MyArray = new Interface_IDbFunktioner[4];
            MyArray[0] = new Class_Hund();
            MyArray[1] = new Class_Ubåd();
            MyArray[2] = new Class_Hund();
            MyArray[3] = new Class_Ubåd();
            foreach (var item in MyArray)
            {
                item.Gem();

            }
            System.Console.ReadKey();
        }
    }
}
