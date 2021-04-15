using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит двузначное число
            //Найти сумму его цифр и выяснить четная она или нет

            Console.WriteLine("ВВедите число");
            int r = Convert.ToInt32(Console.ReadLine());
            int a = r / 10;
            int b = r % 10;

            Console.WriteLine(a+b);

            if ((a + b) % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не Четное");
            }

            Console.ReadKey();
        }
    }
}
