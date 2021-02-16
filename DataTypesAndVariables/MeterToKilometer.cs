using System;

namespace DataTypesAndVariables
{
    class MeterToKilometer
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());
            decimal kilometer = meter / 1000.0m;
            Console.WriteLine($"{kilometer:f2}");
        }
    }
}
