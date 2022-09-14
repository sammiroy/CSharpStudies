namespace QuestionFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and assign char varible
            Console.Write("Enter a character: ");
            char x = char.Parse(Console.ReadLine());

            // Print the shape
            Console.WriteLine($"{x}{x}{x}");
            Console.WriteLine("{0}{0,2}", x);
            Console.WriteLine("{0}{0,2}", x);
            Console.WriteLine("{0}{0,2}", x);
            Console.WriteLine($"{x}{x}{x}");
        }
    }
}