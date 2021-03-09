using System;

namespace _24.SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int numOfchars = int.Parse(Console.ReadLine());

            int sumOfChars = 0;

            for (int i = 0; i < numOfchars; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sumOfChars += (int)letters;

            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
