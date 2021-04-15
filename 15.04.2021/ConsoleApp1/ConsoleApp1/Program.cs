using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1
            Console.WriteLine("ВВедите x");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                double y = Math.Pow(Math.Sin(x), 2);
                Console.WriteLine("y="+y);
            }
            else
            {
                double y = 1 - 2 * Math.Sin(x * x);
                Console.WriteLine("y="+y);
            }

            Console.ReadKey();
        }
    }
}
