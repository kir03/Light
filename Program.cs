using System;

namespace Light // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum status
        {
            выключен,
            включен
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            status start = (status)rnd.Next(2);
            Console.WriteLine($"Сейчас свет {start}");
            Console.WriteLine("Исправить?");
            Console.WriteLine("0 - нет");
            Console.WriteLine("1 - да");
            int.TryParse(Console.ReadLine(), out int answer);
            if (answer == 1)
            {
                if (start - 1 == 0)
                    Console.WriteLine($"Понял. Сейчас свет {start - 1}");
                else
                    Console.WriteLine($"Понял. Сейчас свет {start + 1}");
            }
            else
                Console.WriteLine("Вы решили ничего не трогать");

        }
    }
}