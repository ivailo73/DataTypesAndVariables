using System;

namespace _10.LowerToUper
{
    class LowerToUper
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int nDigit=(int)n;
            if (nDigit>=65&&nDigit<=90)
            {
                Console.WriteLine($"upper-case");
            }
            else if(nDigit >= 97 && nDigit <= 122)
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}
