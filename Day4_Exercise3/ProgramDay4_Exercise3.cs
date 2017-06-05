using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise3
{//Arv. klassediagram så du kan se hele hierarkiet. Status:? synes at Elev & Instruktør skriver ikke Klasselokale & Nøgleid
    class ProgramDay4_Exercise3
    {
        static void Main(string[] args)
        {
            PersonClass Person1 = new PersonClass() { Fornavn= "Y" , Efternavn = "X"};
            ElevClass Elev1 = new ElevClass() { Efternavn="t", Fornavn="g", Klasselokale="A"};
            InstruktørClass Instruktør1 = new InstruktørClass() {Efternavn="2", Fornavn="s", Nøgleid=1 };
            PersonClass Person2 = new PersonClass() { Fornavn = "YY", Efternavn = "XX" }; 

            //Person1.Fornavn.se
            System.Console.WriteLine("Fuld navn: " + Person1.FuldNavn());
            System.Console.WriteLine("Fuld navn person2: " + Person2.FuldNavn());
            System.Console.WriteLine("Elev1.FuldNavn: " + Elev1.FuldNavn());
            System.Console.WriteLine("Instruktør1.FuldNavn: " +Instruktør1.FuldNavn());
            System.Console.ReadKey();
            
        }
    }
}
