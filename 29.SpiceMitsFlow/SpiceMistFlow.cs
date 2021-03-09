using System;

namespace _29.SpiceMitsFlow
{
    class SpiceMistFlow
    {
        static void Main(string[] args)
        {
            int startYieldFirstDay= int.Parse(Console.ReadLine());

            int spice = 0;
            int nextDayYeield = startYieldFirstDay;
            int days = 0;
            while (nextDayYeield>=100)
            {
                days++;
                spice = spice+nextDayYeield - 26;
                nextDayYeield -= 10;

            }
            spice -= 26;
            Console.WriteLine($"{days}");
            Console.WriteLine($"{spice}");
        }
    }
}
