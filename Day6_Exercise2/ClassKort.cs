﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Exercise2
{
    public class ClassKort
    {
        public string Kulør { get; set; }
        public int Værdi{ get; set; }
        public override string  ToString()
        {
            return this.Kulør + "  " + this.Værdi;
        }
    }
}
