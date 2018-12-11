using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad78
{
    class Program
    {
        public static void Main(string[] args)
        {
            double s = 0;
            for (int k = 1; k <= 100; k++)
                s += Math.Pow(k, 2) / (Math.Pow(k, 3) + 1);
            Console.WriteLine("S=" + s);
            Console.ReadKey(true);
        }
    }
}
