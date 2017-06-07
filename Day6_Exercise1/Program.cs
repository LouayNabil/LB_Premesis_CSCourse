using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Exercise1
{//Collection
    class Program
    {
        static void Main(string[] args)
        {
            List<ClassPerson> lst1 = new List<ClassPerson>();
            lst1.Add(new ClassPerson() { Id = 1, Navn = "M" });
            lst1.Add(new ClassPerson() { Id = 2, Navn = "T" });
            lst1.Add(new ClassPerson() { Id = 3, Navn = "P" });
            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }


            //System.Collections.Generic.Dictionary System.Collections.IList();
            Dictionary<int, ClassPerson> lst2 = new Dictionary<int, ClassPerson>();
            lst2.Add(1, new ClassPerson() { Id = 1, Navn = "M" });
            lst2.Add(2, new ClassPerson() { Id = 2, Navn = "T" });
            lst2.Add(3, new ClassPerson() { Id = 3, Navn = "P" });

            var p = lst2[3];
            Console.WriteLine(p.Navn);
            Console.ReadKey();
        }
    }
}
