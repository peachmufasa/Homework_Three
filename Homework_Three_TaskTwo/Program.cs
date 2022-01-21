using System;

namespace Homework_Three_TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("\n" + "Введите количество карт на руках");
                int count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\n" + $"Количество карт в руке: {count}");

                Console.WriteLine("\nВведите номинал карты");

                int sum = 0;
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"\n" + $"Введите номинал {i}-й карты");
                    string cardValue = Console.ReadLine();
                    switch (cardValue)
                    {
                        case "6":
                            sum = sum + 6;
                            break;

                        case "7":
                            sum = sum + 7;
                            break;

                        case "8":
                            sum = sum + 8;
                            break;

                        case "9":
                            sum = sum + 9;
                            break;

                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            sum = sum + 10;
                            break;

                        default:
                            Console.WriteLine("\n" + $"Карты с таким значением нет");
                            break;
                    }

                    Console.WriteLine($"\n" + $"Сумма очков: {sum}");
                }

                if (sum < 21 || sum > 21)
                {
                    Console.WriteLine("\n" + $"Вы проиграли");
                }
                else
                {
                    Console.WriteLine("\n" + $"Вы победили");
                }

                Console.WriteLine("\nХотите сыграть еще?" +
                        "\nЕсли хотите продолжить игру, введите продолжить" +
                        "\nЕсли решили остановиться, введите закончить");

                string answer = Console.ReadLine();
                if (answer == "закончить")
                {
                    break;
                }
            }

            Console.WriteLine("\n" +
                "Вы выбрали закончить игру. Нажмите любую кнопку, чтобы закрыть программу");
            Console.ReadKey();
        }
    }
}
