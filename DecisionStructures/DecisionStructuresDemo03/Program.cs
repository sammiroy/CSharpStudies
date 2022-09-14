namespace DecisionStructuresDemo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create random variables
            Random keygen = new Random();
            int num1 = keygen.Next(1, 10);
            int num2 = keygen.Next(1, 10);

            // Swap variables
            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            // Prompt user for answer
            Console.WriteLine($"What is {num1} - {num2}?: ");
            int answer = int.Parse(Console.ReadLine());

            // Determine successs, output result
            if (num1 - num2 == answer)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("You are incorrect...");
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
        }
    }
}