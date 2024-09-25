using OOP_lab1_TTriangle;

namespace OOP_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TTriangle triangle = new TTriangle(3.5312, 3.653, 6.51);

            Console.WriteLine($"Side A: {triangle.ASide}, Side B: {triangle.BSide}, Side C: {triangle.CSide}");

            Console.WriteLine($"Perimeter of triangle: {triangle.GetPerimeter()}");

            Console.WriteLine($"Area of triangle: {triangle.GetArea()}");

            Console.ReadKey();
        }
    }
}
