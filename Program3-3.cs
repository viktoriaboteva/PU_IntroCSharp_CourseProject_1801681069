using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_3II
{
    class Program
    {
        static double Method(double n)
        {
            double f=0;
            for (int i = 1; i <= n; i++)
                f += Math.Pow(i, 1.0 / 4);
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("F(a+b)+F(|a-b|)="+Method(a + b)+Method(Math.Abs(a-b)));
            Console.ReadKey(true);
        }
    }
}
