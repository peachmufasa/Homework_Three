using System;

namespace Homework_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число");
            int inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            Console.ReadKey();
        }
    }
}
