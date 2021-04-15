using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.9
            Console.WriteLine("ВВедите s1");
            double s1 = Convert.ToDouble(Console.ReadLine());//км/ч
            Console.WriteLine("ВВедите s2");
            double s2 = Convert.ToDouble(Console.ReadLine());//м/c

            double s1_2 = s1 * 1000 / 3600;//м/с
            if (s1_2 > s2)
            {
                Console.WriteLine(s1 + "км/ч");
            }
            else
            {
                Console.WriteLine(s2 + "м/с");
            }

            Console.ReadKey();
        }
    }
}
