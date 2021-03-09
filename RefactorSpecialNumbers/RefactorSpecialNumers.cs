using System;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                bool izSpecial = false;

                int sum = 0;
                int number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                izSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, izSpecial);
                sum = 0;
                i = number;
            }
        }
    }
}
