using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise5
{// Not done yet
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = System.IO.File.OpenText("dyrenavne.txt");
            while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }
            stream.Close();
            stream = null; //*/
            /*using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    var l = stream.ReadLine();
                    Console.WriteLine(l.ToUpper());
                }
            }*/

        }
    }
}
