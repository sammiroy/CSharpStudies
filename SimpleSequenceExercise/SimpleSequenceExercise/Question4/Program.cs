namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int userInt;
            int ones;
            int tens;
            int hundreds;
            int thousands;
            int sum;

            // Get user input 
            Console.Write("Enter an integer between 1 - 1000: ");
            userInt = int.Parse(Console.ReadLine());

            // Calcualte sum of integers
            ones = userInt % 10;
            userInt = userInt / 10;
            tens = userInt % 10;
            userInt = userInt / 10;
            hundreds = userInt % 10;
            userInt = userInt / 10;
            thousands = userInt % 10;
            userInt = userInt / 10;

            sum = ones + tens + hundreds + thousands;

            // Display Sum
            Console.WriteLine(sum);

        }
    }
}