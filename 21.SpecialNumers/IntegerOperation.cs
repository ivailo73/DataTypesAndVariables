using System;

namespace _21.SpecialNumers
{
    class IntegerOperation
    {
        static void Main(string[] args)
        {

            int firstNimber = int.Parse(Console.ReadLine());
            int secondNimber = int.Parse(Console.ReadLine());
            int thirdNimber = int.Parse(Console.ReadLine());
            int fourthNimber = int.Parse(Console.ReadLine());

            int result = ((firstNimber + secondNimber) / thirdNimber) * fourthNimber;

            Console.WriteLine($"{result}");
        }
    }
}
