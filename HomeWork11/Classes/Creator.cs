using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal abstract class Creator
    {
        protected string name;
        protected Creator(string name)
        {
            this.name = name;
        }
        protected Creator()
        { }
        public abstract Student CreateStudent(string name, string numberOfGroup);
        
    }
}
