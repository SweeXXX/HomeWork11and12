using HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11.Classes
{
    internal class PassiveStudent:Student
    {
        public PassiveStudent(string name, string numberOfGroup) : base(name, numberOfGroup) { PorA = "P"; }
        protected PassiveStudent(string name, int lastMer, string numberOfGroup) : base(name, lastMer, numberOfGroup) { }


    }
}
