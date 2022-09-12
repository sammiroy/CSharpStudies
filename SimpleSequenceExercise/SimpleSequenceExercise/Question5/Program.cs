namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double investAmt;
            double annualIntrs;
            double years;
            double futureInvestVal;

            // Get user input
            Console.Write("Enter investment amount: ");
            investAmt = double.Parse(Console.ReadLine());
            Console.Write("Enter annual interest rate in percentage: ");
            annualIntrs = double.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            years = double.Parse(Console.ReadLine());


            // Calculate x(1+(y/12/100))^(z*12)
            futureInvestVal = investAmt * Math.Pow(((1 + (annualIntrs) / 12 / 100)), years * 12);

            // Display Answer
            Console.WriteLine(futureInvestVal);
        }
    }
}