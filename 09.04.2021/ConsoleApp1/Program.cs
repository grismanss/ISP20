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

            //тут будем писать весь наш код!!!!

            Console.WriteLine("ПРивет мир! Это моя первая программа на C#");
            
            Console.WriteLine("Как тебя зовут???");
            string myName = Console.ReadLine();//Считывание с консоли данных в переменную

            int age, weight, height;

            Console.WriteLine("Сколько тебе лет???");
            age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваш вес кг???");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваш рост см???");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя:" + myName);
            Console.WriteLine("Ваш возраст:" + age+" лет");
            Console.WriteLine("Ваш рост:" + height/100.0+" метров");
            Console.WriteLine("Ваш вес:" + weight*1000+" грамм");
            Console.ReadKey();//чтоюы консоль не закрывалась


            //Однострочный комментарий


            /*
             Многострочный комментарий
             Написать программу, которая спрашивает ваше имя, возраст, рост  в см
             и вес в кг и выводит сообщение:

               Ваше имя: ...
               Ваш возраст: ... лет
               Ваш рост: ... метров
               Ваш вес: ... в граммах


             
             */
        }
    }
}
