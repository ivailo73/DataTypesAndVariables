using System;

namespace _23.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPersons = int.Parse(Console.ReadLine());
            int courses = 0;
            while (numberOfPeople >0)
            {
                courses++;
                numberOfPeople -= capacityOfPersons;
            }            
            Console.WriteLine($"{courses}");
        }
    }
}
