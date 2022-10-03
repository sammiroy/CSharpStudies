namespace TryParseLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TryParse - Trys to parse to a datatype
            // if it fails, TryParse returns FALSE (meaning the value cannot be parsed to that datatype)
            // if it succeeds, TryParse returns TRUE and the parsed value is sent back from TryParse through an output parameter

            string input;// User Input
            int validInput;// user input as an integer after the TryParse

            Console.Write("Please enter an integer: ");
            input = Console.ReadLine();

            if (int.TryParse(input, out validInput))
            {
                Console.WriteLine($"The value {input} could be parsed to an integer!");
            } else
            {
                Console.WriteLine($"The value {input} could NOT be parsed to an integer!");
            }
        }
    }
}