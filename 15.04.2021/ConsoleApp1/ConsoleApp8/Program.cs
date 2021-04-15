using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит четырехзначное число
            //Выяснить является ли оно полиндромом
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 1000;
            int c = k / 10 % 10;
            int d = k / 100 % 10;
            if ((a == b) & (c == d))
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("net");
            }
            Console.ReadKey();
        }
    }
}
