using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad347
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Въведете начало на интервала: x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете край на интервала: x2=");
            int x2 = int.Parse(Console.ReadLine());
            try
            { 
                double number = double.Parse(text);
                if (x1 < number && number < x2)
                    Console.WriteLine("Текстът е число в интервала[" + x1 + "," + x2 + "]");
                else Console.WriteLine("Текстът не е число в интервала[" + x1 + "," + x2 + "]");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }
    }
}
