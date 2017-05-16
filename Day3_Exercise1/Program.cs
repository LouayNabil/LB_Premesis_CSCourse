using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_a = 10;
            int int_b = 20;
            int Int_Radius = 5;
            double double_beløb = 5000;
            double double_momsPct = 0.25;
            double månedsløn[] = { 1500, 2500, 3500, 4500 };

            Console.WriteLine("Lægsammen: " + Lægsammen(int_a, int_b));
            Console.WriteLine("Areal er:  " + BerenAreal(Int_Radius));
            Udskriv();
            Console.WriteLine("moms er : "+ BeregnMoms(double_beløb, double_momsPct));
           //Mangler denne opgave:  Console.WriteLine("Gennemsnit:  " + Gennemsnit (månedsløn));

            System.Console.ReadKey();
        }
        static int Lægsammen(int a, int b)
        {
            return (a + b);
        }
        static double BerenAreal(int Int_Radius)
        {
            //double yy=System.Math.PI
            //return (System.Math.Pow((System.Math.PI), (System.Math.PI))*Int_Radius);
            return ((System.Math.PI) * Int_Radius * Int_Radius);
        }
        static void Udskriv()
        {
            Console.WriteLine(" ");
        }
        static double BeregnMoms(double double_beløb, double double_momsPct)
        {
            double res4;
            return (double_beløb* double_momsPct);
        }
        //Mangler denne opgave:  static double Gennemsnit(int[] månedsløn)
        {



        }
    }
}
