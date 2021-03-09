using System;

namespace _11.RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            double Length, Width, Heigth = 0;
            Console.Write("Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Heigth = double.Parse(Console.ReadLine());
             double V = (Length * Width * Heigth) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
