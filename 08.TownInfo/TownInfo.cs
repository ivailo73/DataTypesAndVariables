using System;

namespace _08.TownInfo
{
    class TownInfo
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {area} square km.");
        }
    }
}
