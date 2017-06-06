using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise4
{
    class Class_Hund : IComparable
    {
        public int Alder { get; set; }
        public string Navn { get; set; }

        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();
            Class_Hund h = obj as Class_Hund;
            if (h.Alder>this.Alder)
            {
                return -1;
            }
            if (h.Alder>this.Alder)
            {
                return 1;
            }
            return 0;
        }
    }
}
