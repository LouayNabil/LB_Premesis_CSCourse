using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Exercise4
{
    class Program
    {//Når der sker hændelser så får vi at vide det.
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher W = new System.IO.FileSystemWatcher(@"C:\Temp", "*.txt");
            W.EnableRaisingEvents = true;
            W.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            //W.NotifyFilter = System.IO.WatcherChangeTypes.All;
            W.Changed += W_Changed;
            W.Created += W_Created;
            do
            {

            } while (true);
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine(e.Name);
        }
        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine(e.Name);
        }
    }
}
