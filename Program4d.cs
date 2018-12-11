using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4d
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("x=");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y=");
                double y = double.Parse(Console.ReadLine());
                Console.Write("z=");
                double z = double.Parse(Console.ReadLine());
                double result = (x + y) / (z + (z / (x + (z / (y - x)))));
                Console.WriteLine("Резултат=" + result);
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
        }
    }
}
