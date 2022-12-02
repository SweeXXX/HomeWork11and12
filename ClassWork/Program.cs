using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "-----\n-   -\n-   -\n-----";
            string str1 = "123\n123\n123";
            //str = str.Replace("-", "*");
            //Figure f = new Figure(str);
            //Figure f2 = new Figure(str1);
            //f2.PrintNew(false,10);
            //f.PrintStart();

            //Console.ReadKey();
            //f.PrintNew(false, 18, 10);
            //f2.PrintNew(false, 12,15);
            //Console.ReadKey();
            Point r = new Point('*');
            r.PrintNew(10,10, ConsoleColor.Magenta, ConsoleColor.Yellow, true);
            Console.ReadKey();
            r.PrintNew(10, 10, ConsoleColor.Yellow, ConsoleColor.Yellow, true);


            Console.ReadKey();
            //Console.WriteLine(Rectangle.FindS(10,10));   

        }
    }
}