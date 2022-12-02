using HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class ActiveStudent:Student
    {
        public ActiveStudent(string name, string numberOfGroup) : base(name, numberOfGroup) { PorA = "A"; }
        public ActiveStudent(string name, int lastMer, string numberOfGroup) : base(name, lastMer, numberOfGroup) { }
    }
}
