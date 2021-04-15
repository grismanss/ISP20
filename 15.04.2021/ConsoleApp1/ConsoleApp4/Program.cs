using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит число. 
            //Программа отвечает четное оно или нет

            Console.WriteLine("ВВедите число");
            int r = Convert.ToInt32(Console.ReadLine());

            if (r % 2 == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Не четное");
            }

            Console.ReadKey();
        }
    }
}
