using System;

namespace HomeworkThree_TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool result = true;
            if (number <= 0)
            {
                Console.WriteLine("Простым числом может быть только целое положительное число");
            }
            else
            {
                while (i <= number - 1)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                    i++;
                }
                if (result)
                {
                    Console.WriteLine("Число является простым");
                }
                else
                {
                    Console.WriteLine("Число не является простым");
                }
            }
        }
    }
}
