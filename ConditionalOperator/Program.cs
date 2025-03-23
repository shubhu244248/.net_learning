using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string randNum = random.Next(0, 2) == 0 ? "Heads" : "Tails";
            Console.WriteLine($"The coin flip result is: {randNum}");
        }
    }
}