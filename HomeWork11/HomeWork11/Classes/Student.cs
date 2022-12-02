using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal abstract class Student
    {
        protected string name;
        protected int lastMer;
        protected string numberOfGroup;
        protected string PorA;
        public string GetNumberOfGroup
        {
            get { return numberOfGroup; }
        }
        public string GetPorA
        {
            get { return PorA; }
        }
        public string GetTitle
        {
            get { return $"{name}, {numberOfGroup}, {PorA}"; }
        }
        protected Student(string name, int lastMer, string numberOfGroup)
        {
            this.name = name;
            this.lastMer = lastMer;
            this.numberOfGroup = numberOfGroup;
        }
        protected Student(string name, string numberOfGroup)
        {
            this.name = name;
            this.numberOfGroup = numberOfGroup;
        }
    }
}
