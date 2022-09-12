namespace QuestionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            int num1, num2, num3, numHigh;

            // Prompt and store 3 numbers
            Console.WriteLine("Enter three numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            // Calculate largest
            numHigh = Math.Max(num1, num2);
            numHigh = Math.Max(num1, num3);
            numHigh = Math.Max(num2, num3);

            // Output result
            Console.WriteLine(numHigh);
        }
    }
}