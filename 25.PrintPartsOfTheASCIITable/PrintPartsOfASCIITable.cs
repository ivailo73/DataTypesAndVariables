using System;

namespace _25.PrintPartsOfTheASCIITable
{
    class PrintPartsOfASCIITable
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int finalChar = int.Parse(Console.ReadLine());
            for (int i = startChar; i <= finalChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
