using System;

namespace _28
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int countOfKegs = int.Parse(Console.ReadLine());
            double maxKeeg = double.MinValue;
            string maxKeegModel = "";
            for (int i = 0; i < countOfKegs; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI*Math.Pow(r,2)*height;
                if (volume>maxKeeg)
                {
                    maxKeeg = volume;
                    maxKeegModel = model;
                }
            }
            Console.WriteLine($"{maxKeegModel}");
        }
    }
}
