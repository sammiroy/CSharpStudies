namespace SwitchExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            char input;

            // Ask user for variable assignment
            Console.Write("Enter grade (A-F): ");
            input = char.ToLower(char.Parse(Console.ReadLine()));

            // Respond based on value of "input"
            switch (input)
            {
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'b':
                    Console.WriteLine("Good");
                    break;
                case 'c':
                    Console.WriteLine("Satisfactory");
                    break;
                case 'd':
                    Console.WriteLine("Needs Improvement");
                    break;
                case 'f':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Character");
                    break;
            }
        }
    }
}