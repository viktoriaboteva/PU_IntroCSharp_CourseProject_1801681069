using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi mesec:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: case 12: Console.Write("3.8"); break;
                case 2: case 3: case 4: Console.Write("3.5"); break;
                case 5: case 6: case 7: case 8: Console.Write("4.1"); break;
                case 9: case 10: case 11: Console.Write("4.9"); break;
                default: Console.WriteLine("Nqma takav mesec"); break;
            }
            Console.ReadKey(true);
        }
    }
}
