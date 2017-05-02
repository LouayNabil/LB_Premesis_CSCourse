using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first method..");
            Read();

        }
        static void Read()
        {
            string temp, TEMP;
            Console.WriteLine("Please write something :)");
            temp = Console.ReadLine();
            TEMP = temp.ToUpper();// ("kljkjklkj");//            ToUpper(temp);
            Console.WriteLine(TEMP);
            Console.ReadLine();
            //            
        }
    }
}
