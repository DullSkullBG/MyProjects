using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете а:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведете знак:");
            char b = char.Parse(Console.ReadLine());
            Console.Write("Въведете б:");
            double c = double.Parse(Console.ReadLine());
            double d;
            if (b=='+')
            {
                d =a + c;
                
            }
            else if (b=='-')
            {
                d = a - c;
            }
            else if (b=='*')
            {
                d = a * c;
            }
            else if (b=='/')
            {
                d = a / c;
            }
            else if (b=='%')
            {
                d = a % c;
            }
            else
            {
                Console.WriteLine("Грешен знак");
                return;
            }
            Console.WriteLine($"{d:f2}");
        }
    }
}
