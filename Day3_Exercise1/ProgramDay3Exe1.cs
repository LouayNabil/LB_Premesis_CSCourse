using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Exercise1
{
    class ProgramDay3Exe1
    {//Små metoder - Status=OK
        static void Main(string[] args)
        {
            int int_a = 10;
            int int_b = 20;
            int Int_Radius = 5;
            double double_beløb = 5000;
            double double_momsPct = 0.25;
            int[] månedsløn = { 3, 5, 7, 9 };
            //Mangler denne opgave: double månedsløn[] = { 1500, 2500, 3500, 4500 };

            System.Console.WriteLine("Lægsammen: " + Lægsammen(10,20));// (int_a, int_b));
            System.Console.WriteLine("Areal er:  " + BerenAreal(5));// (Int_Radius));
            Udskriv();
            Udskriv("Udskrivelse af: Dette er en test");
            System.Console.WriteLine("moms er : " + BeregnMoms(double_beløb, double_momsPct));
            System.Console.WriteLine("Gennemsnit:  " + Gennemsnit(månedsløn));
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
        static void Udskriv(string str)
        {
            Console.WriteLine(str);
        }
        static double BeregnMoms(double double_beløb, double double_momsPct)
        {
            double res4;
            return (double_beløb * double_momsPct);
        }
        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            return (sum / månedsløn.Length);
        }
    }
}
