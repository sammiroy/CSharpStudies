using System.Diagnostics.Metrics;

namespace QuestionSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init array
            char[] letters = new char[3];

            // Assign all 3 postions with a character
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter a character: ");
                letters[i] = char.Parse(Console.ReadLine());
            }

            // Display array backwards
            Console.WriteLine($"{letters[2]} {letters[1]} {letters[0]}");
        }
    }
}