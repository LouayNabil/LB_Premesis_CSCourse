using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Exercise2
{
    class ClassBunke
    {
        private Stack<ClassKort> bunke = new Stack<ClassKort>();
        public void TilføjKort(ClassKort k)
        {
            bunke.Push(k);
        }
        public ClassKort FjernKort()
        {
            if (bunke.Count > 0)
            {
                return bunke.Pop();
            }
            else
                return null;
        }


        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }
        }
    }
}
