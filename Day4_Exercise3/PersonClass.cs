using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercise3
{
    class PersonClass
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldNavn()
        {
            return (this.Fornavn + "  " + Efternavn);
        }
    }

}
