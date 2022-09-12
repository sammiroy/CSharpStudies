namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init variables
            int num1, num2, temp;

            // Prompt user
            Console.Write("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            num2 = int.Parse(Console.ReadLine());

            // Test output
            Console.WriteLine($"The first number is {num1}, the second number is {num2}");

            // Swap variables
            temp = num1;
            num1 = num2;
            num2 = temp;

            // Output result
            Console.WriteLine($"The first number is {num1}, the second number is {num2}");
        }
    }
}