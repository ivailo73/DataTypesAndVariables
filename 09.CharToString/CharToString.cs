using System;

namespace _09.CharToString
{
    class CharToString
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();
            string tirdChar = Console.ReadLine();

            string concatChars = firstChar + secondChar + tirdChar;
            Console.WriteLine($"{concatChars} ");
        }
    }
}
