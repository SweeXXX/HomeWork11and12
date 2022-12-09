using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class ComplexNumber
    {
        double x;
        double y;
        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual string ToString()
        {
            return $"{x}{y}i";
        }
        static public ComplexNumber operator +(ComplexNumber z1, ComplexNumber z2)
        {
            return new ComplexNumber(z1.x + z2.x, z1.y + z2.y);
        }
        static public ComplexNumber operator -(ComplexNumber z1, ComplexNumber z2)
        {
            return new ComplexNumber(z1.x - z2.x, z1.y - z2.y);
        }
        static public ComplexNumber operator *(ComplexNumber z1, ComplexNumber z2)
        {
            return new ComplexNumber((z1.x * z2.x) - (z1.y * z2.y), z1.y * z2.x + z2.y * z1.x);
        }
        static public bool operator ==(ComplexNumber z1, ComplexNumber z2)
        {
            if (z1.x == z2.x && z1.y == z2.y)
                return true;
            return false;
        }
        static public bool operator !=(ComplexNumber z1, ComplexNumber z2)
        {
            if (z1.x != z2.x || z1.y != z2.y)
                return true;
            return false;
        }
    }
}
