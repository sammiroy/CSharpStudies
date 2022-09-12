using System.Transactions;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            double radius;
            double length;
            double area;
            double volume;

            // Process user input
            Console.WriteLine("Enter cylinder radius & length");
            radius = double.Parse(Console.ReadLine());
            length = double.Parse(Console.ReadLine());

            // Process area & volume
            area = Math.Pow(radius, 2) * Math.PI;
            volume = area * length;

            // Output results
            Console.WriteLine($"The area is {area}");
            Console.WriteLine($"The volume is {volume}");
        }
    }
}