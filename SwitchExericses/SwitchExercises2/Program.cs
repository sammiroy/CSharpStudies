namespace SwitchExercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init variables
            double num1, num2;
            char input;
            bool loop = true;

            // Assign variables by user input
            Console.Write("Enter a number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = double.Parse(Console.ReadLine());

            while (loop)
            {
                // Prompt user for menu option
                Console.Write(
                    $"1. {num1} + {num2}\n" +
                    $"2. {num1} - {num2}\n" +
                    $"3. {num1} x {num2}\n" +
                    $"4. {num1} / {num2}\n" +
                    $"5. {num1} mod {num2}\n" +
                    $"6. Quit\n" +
                    $"Enter selection: "
                    );
                input = char.Parse(Console.ReadLine());

                switch (input)
                {
                    case '1':
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case '2':
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case '3':
                        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                        break;
                    case '4':
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    case '5':
                        Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
                        break;
                    case '6':
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
        }
    }
}