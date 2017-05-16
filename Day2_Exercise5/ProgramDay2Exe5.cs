using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Exercise5
{
    class ProgramDay2Exe5
    {// Arbejde med strenge

        static void Main(string[] args)
        {
            string  Str_x = "Mikkel";
            string  Str_y = "Cronberg";
            string  String_SamletNavn = Str_x + " "+ Str_y;
            string  String_SamletNavn2 = $"{Str_x} {Str_y}";
            string  Str_navnStort = String_SamletNavn.ToUpper();
            string  Str_navnLille = String_SamletNavn.ToLower();
            string  Str_Del = String_SamletNavn.Substring(7, 4);

            System.Console.WriteLine(String_SamletNavn);
            System.Console.WriteLine(String_SamletNavn2);
            System.Console.WriteLine(Str_navnStort);
            System.Console.WriteLine(Str_navnLille);
            System.Console.WriteLine(Str_Del);
            System.Console.ReadKey();

            //System.Int32[] Int_Array = { 950000, 20000, 35000, 40000 };
            System.String[] Str_ArayName= String_SamletNavn.Split(' ');//.Split(5,2) }
            foreach (var item in Str_ArayName)
                System.Console.WriteLine(item);
            System.Console.ReadKey();
        }
    }
}
