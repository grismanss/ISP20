using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//4.10
            Console.WriteLine("ВВедите r");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВедите a");
            double a = Convert.ToDouble(Console.ReadLine());
            double s1_r = 2 * Math.PI * r * r;
            double s2_a = a * a;

            if (s1_r > s2_a)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else
            {
                Console.WriteLine("Площадь квдрата больше");
            }


            Console.ReadKey();


        }
    }
}
