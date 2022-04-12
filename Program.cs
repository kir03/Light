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








string path = @"C:\Users\User\Desktop\text.txt";
Console.WriteLine("Вот как выглядит файл:");
using (StreamReader sr = new StreamReader(path))
{
    Console.WriteLine(sr.ReadToEnd());
}
Console.WriteLine("Допишите в файле, написав в последней строке слово \"stop\"");
using (StreamWriter sw = new StreamWriter(path, true))
{
    string text = string.Empty;
    while (text != "stop")
    {
        sw.WriteLine(text);
        text = Console.ReadLine();
    }

}
Console.Clear();
Console.WriteLine("Вот измененный файл:");
using (StreamReader sr = new StreamReader(path))
{
    Console.WriteLine(sr.ReadToEnd());
}
