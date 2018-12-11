using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad400
{
    class Program
        {
        static void Input(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Ден-" + (i + 1) + "-");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        static double Broi(double[] a)
        {
            int br=0;
            for (int i = 0; i < a.Length; i++)
                if (a[i]>0) br++;
            return br;
        }
        static void Print(double[] a) 
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i]>0) Console.WriteLine("Ден номер-" + (i + 1));
        }
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Въведете брой дни:");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 31);
            double[] a = new double[n];
            double[] b = new double[n];
            double[] c = new double[n];
            Console.WriteLine("Станция 1:");
            Input(a);
            Console.WriteLine("Станция 2:");
            Input(b);
            Console.WriteLine("Станция 3:");
            Input(c);
            Console.WriteLine("Брой дъждовни дни за станция 1-" + Broi(a));
            Console.WriteLine("Брой дъждовни дни за станция 2-" + Broi(b));
            Console.WriteLine("Брой дъждовни дни за станция 3-" + Broi(c));
            Console.WriteLine("Станция 1:");
            Print(a);
            Console.WriteLine("Станция 2:");
            Print(b);
            Console.WriteLine("Станция 3:");
            Print(c);
            Console.ReadKey(true);
        }
     }
}
