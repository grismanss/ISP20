using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Math библиотека математических операций
            // Math.Sqrt(5) квадратный корень числа
            // sin cos соответственно синус и косинус
            // Math.Pow(5,4) возведение в степень в данном примере 5 в степени 4
            // Math.Abs(-10) модуль числа

            //1.14 в
            Console.WriteLine("1.14 в");
            Console.WriteLine("Введите число");
            //Считываем сисло с консоли и конвертируем к числу
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = Math.Pow(a, 2);
            Console.WriteLine("Ответ: " + a2);

            //1.14 ж Сами
            Console.WriteLine("1.14 ж");
            Console.WriteLine("Введите число");
            //Считываем сисло с консоли и конвертируем к числу
            double b = Convert.ToDouble(Console.ReadLine());
            double b2 =-7.5* Math.Pow(b, 2);
            Console.WriteLine("Ответ: " + b2);


            //далее 1.14 м
            Console.WriteLine("1.14 м");
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y");
            double y= Convert.ToDouble(Console.ReadLine());
            double xy = -5 * Math.Sqrt(x + Math.Sqrt(y));
            Console.WriteLine("Ответ: " + xy);


            //далее 1.15 е
            Console.ReadKey();
        }
    }
}
