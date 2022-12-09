using System;
using System.Text;

namespace Work
{
    public delegate void DelegatSorted(int kret);

    class Program
    {
        static void Main(string[] args)
        {
            //RationalNumber num = new RationalNumber(5, 2);
            //RationalNumber n2 = new RationalNumber(5, 3);
            //Console.WriteLine((num-n2).ToString());

            //ComplexNumber z1 = new ComplexNumber(2, -2);
            //ComplexNumber z2 = new ComplexNumber(3, 2);
            //Console.WriteLine((z1 * z2).ToString());
            //Console.WriteLine((z1 == z2));

            //Library library = new Library();
            //library.SortingLibrary(new DelegatSorted(library.Sort), 1);
            //library.SortingLibrary(new DelegatSorted(library.Sort), 2);
            //library.SortingLibrary(new DelegatSorted(library.Sort), 3);

            Bank b1 = new Bank(228558, 584, AccountType.Savings);
            Bank b2 = new Bank(228559, 584, AccountType.Savings);
            Console.WriteLine(b1.Equals(b2));

        }
    }
    public class RationalNumber
    {
        static public implicit operator RationalNumber(int c)
        {
            var f = new RationalNumber();
            f.chisl = 1;
            f.znam = c;
            return f;//////////////////////////////////////////////Вопросик появился: пАчему не рОбатает? Вопросик закрыт
            //оказывается, переопределять приведение к классу можно только с одним параметром((
        }


        int chisl;
        int znam;
        public int GetChisl
        {
            get { return chisl; }
        }
        public int GetZnam { get { return znam; } }
        private RationalNumber() { }
        private bool Equals(object a)
        {
            return true;
        }
        public RationalNumber(int chis, int zna)
        {
            if (zna != 0)
            {
                chisl = chis;
                znam = zna;
            }
        }
        public virtual string ToString()
        {
            return $"{chisl}/{znam}";
        }
        static public explicit operator double(RationalNumber n)
        {
            return (double)(n.chisl/n.znam );
        }
        static public RationalNumber operator +(RationalNumber n1, RationalNumber n2)
        {
            RationalNumber result = new RationalNumber(n1.chisl * n2.znam + n2.chisl * n1.znam, n1.znam * n2.znam);
            return result;
        }
        static public RationalNumber operator -(RationalNumber n1, RationalNumber n2)
        {
            RationalNumber result = new RationalNumber(n1.chisl * n2.znam - n2.chisl * n1.znam, n1.znam * n2.znam);
            return result;
        }
        static public bool operator ==(RationalNumber r, RationalNumber p)
        {
            if(r.znam!=0 && p.znam!=0)
            {
                if (((double)r.GetChisl / (double)(r.GetZnam)) == ((double)p.GetChisl / ((double)p.GetZnam)))
                    return true;
                return false;
            }
            else
            {

                return false;
            }
        }
        static public bool operator !=(RationalNumber r, RationalNumber p)
        {
            if (r.znam != 0 && p.znam != 0)
            {
                if ((double)r.GetChisl / (r.GetZnam) != (double)p.GetChisl / (p.GetZnam))
                    return true;
                return false;
            }
            else return false;
            
        }
        static public bool operator >(RationalNumber r, RationalNumber p)
        {
            if ((double)r.GetChisl / (r.GetZnam) > (double)p.GetChisl / (p.GetZnam))
                return true;
            return false;
        }
        static public bool operator <(RationalNumber r, RationalNumber p)
        {
            if ((double)r.GetChisl / (r.GetZnam) < (double)p.GetChisl / (p.GetZnam))
                return true;
            return false;
        }
        static public RationalNumber operator ++(RationalNumber r)
        {
            r.chisl++;
            return r;
        }
        static public RationalNumber operator --(RationalNumber r)
        {
            r.chisl--;
            return r;
        }
        static public double operator +(RationalNumber r, double num)
        {

            return (double)(r.GetChisl/r.GetZnam) + num;
        }
        static public double operator -(RationalNumber r, double num)
        {

            return (double)(r.GetChisl / r.GetZnam) - num;
        }
        static public bool operator >=(RationalNumber r, RationalNumber m)
        {
            if ((double)r.chisl / r.znam >= (double)m.chisl / m.znam)
                return true;
            return false;
        }
        static public bool operator <=(RationalNumber r, RationalNumber m)
        {
            if ((double)r.chisl / r.znam <= (double)m.chisl / m.znam)
                return true;
            return false;
        }
    }

    

}