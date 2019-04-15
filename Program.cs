using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(400,100);
            Fraction f1 = new Fraction(160,40);

            Console.WriteLine(f.GetString());
            Console.WriteLine(f1.GetString());
            Console.WriteLine();

            Console.WriteLine(f.EgalA(f1));
            f.Reduire();
            f1.Reduire();
            Console.WriteLine(f.GetString());
            Console.WriteLine(f1.GetString());

            Console.WriteLine();

            Fraction f2 =f * f1;

            Console.WriteLine(f2.GetString());

            Console.ReadKey();

        }
         
    }
}
