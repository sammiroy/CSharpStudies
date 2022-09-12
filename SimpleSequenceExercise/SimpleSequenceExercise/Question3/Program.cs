using System.Formats.Asn1;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variable
            double length;
            double area;

            // Get user input
            Console.Write("Enter the length of the side: ");
            length = double.Parse(Console.ReadLine());

            // Calculate area
            area = (((3 * Math.Sqrt(3)) / 2) * (Math.Pow(length, 2)));

            Console.WriteLine($"The area of the hexagon is {area}");

        }
    }
}