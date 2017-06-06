using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise2
{
    class Program
    {//generate Log file in "C:\TempLOUAY\Day5_Exercise2\bin\Debug\logs"
     //Michell Cronberg Code: Module09Exceptions
        private static Logger Logger = LogManager.GetCurrentClassLogger(); //private static
        static void Main(string[] args)

        {
            //NLog logger = new(NLog);
            // mangler log
            Logger.Trace("Enter");
            Logger.Debug("Nu kaldes test1");
            test1(5, 5);
            Logger.Debug("Retur fra test1");
            Logger.Debug("Nu kaldes test2");
            test2();
            Logger.Debug("Retur fra test2");
            Logger.Trace("Exit");
        }

        static void test1(int i, int x)
        {
            // mangler log

            Logger.Trace("Enter i, x{0}, {1}", i, x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            Logger.Trace("Exit");
        }

        static void test2()
        {
            // mangler log
            Logger.Trace("Enter");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
                Logger.Error(ex);
            }
            Logger.Trace("Exit");
        }
    }

}
