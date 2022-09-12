namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            string name;
            int age;
            double annualPay;

            // Process user inputs
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter your annual salary: ");
            annualPay = double.Parse(Console.ReadLine());

            // Output result
            Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn ${annualPay} per year");
        }
    }
}