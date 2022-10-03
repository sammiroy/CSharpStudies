namespace TryParseValidationLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte age;
            string input;

            Console.Write("What is your age?: ");
            input = Console.ReadLine();

            // Not operator allows the loop to continue to ask if the age is invalid for a byte
            while( !byte.TryParse(input, out age) || age < 0 || age > 140)
            {
                Console.Write($"{input} is a ridiculous value for an age! What is you ACTUAL age?: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Your age is {age}");
            

        }
    }
}