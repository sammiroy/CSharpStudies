namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for 2 numbers, display a message indicating if they are equal or not

            // Init Variables
            int num1, num2;
            string answer;

            Console.Write("Enter 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2ns number: ");
            num2 = int.Parse(Console.ReadLine());

            // The ternary operator (?) evaluates an expression and returns 1 of 2 values if the expression is true or false
            answer = (num1 == num2 ? "equal." : "not equal.");
            // Same as 
            /*
             * if (num1 == num2)
             * {
             * answer == "equal";
             * } else 
             * {
             * answer == "not equal";
             * }
             */

            Console.WriteLine($"{num1} and {num2} are {answer}");

            // Display the highest of the 2 numbers. Use a Ternary operator. Assume both numbers will be different
            Console.Write("Enter 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2ns number: ");
            num2 = int.Parse(Console.ReadLine());

            answer = (num1 > num2 ? $"{num1}" : $"{num2}");

            Console.WriteLine($"{answer} is the higher number");


        }
    }
}