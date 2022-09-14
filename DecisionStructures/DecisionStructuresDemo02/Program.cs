namespace DecisionStructuresDemo02
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            const int Min = 1;
            const int Max = 9;
            Random keygen = new Random();
            // Generate two random numbers between 1 & 9
            int num1 = keygen.Next(Min, Max + 1);
            int num2 = keygen.Next(Min, Max + 1);

            // Show question
            Console.Write($"What is {num1} + {num2} = ? ");

            // Receive answer
            string inputValue = Console.ReadLine();
            int answer = int.Parse(inputValue);

            // Display result
            Console.WriteLine($"{num1} + {num2} = {answer} is {(num1 + num2) == answer}");
        }
    }
}