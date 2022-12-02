using HomeWork11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class CreatePassive:Creator
    {
        public CreatePassive() : base() { }
        public CreatePassive(string name) : base(name) { }  
        public override PassiveStudent CreateStudent(string name, string numberOfGroup)
        {
            return new PassiveStudent(name, numberOfGroup);
        }
    }
    internal class CreateActive : Creator
    {
        public CreateActive() : base() { }
        public CreateActive(string name) : base(name) { }
        public override ActiveStudent CreateStudent(string name, string numberOfGroup)
        {
            return new ActiveStudent(name, numberOfGroup);
        }
    }
}
