using System;

namespace _27.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int littersInTank = 0;
            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                if (littersInTank+litters>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    littersInTank += litters;

                }

            }
            Console.WriteLine($"{littersInTank}");

        }
    }
}
