using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statickevarijable
{
    internal class Program
    {
        class PrvaKlasa
        {
            private static int counter;
            public PrvaKlasa()
            {
                counter++;
            }
            public int Counter()
            {
                return counter;
            }
        }
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();
            PrvaKlasa y = new PrvaKlasa();
            PrvaKlasa z = new PrvaKlasa();
            Console.WriteLine("X counter je " + x.Counter() + ".");
            Console.WriteLine("Y counter je " + y.Counter() + ".");
            Console.WriteLine("Z counter je " + z.Counter() + ".");
            Console.ReadLine();
        }
    }
}
