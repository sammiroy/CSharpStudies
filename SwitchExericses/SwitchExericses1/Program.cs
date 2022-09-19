namespace SwitchExericses1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initate Variables
            char uInput;
            double angle;

            // Assign values from user
            Console.Write(
                "[C]osine\n" +
                "[S]ine\n" +
                "[T]angent\n" +
                "Enter selection: " 
                );
            uInput = char.ToUpper(char.Parse(Console.ReadLine()));
            Console.Write("Enter desired angle: ");
            angle = double.Parse(Console.ReadLine());

            // Output calulation based on selection
            switch (uInput)
            {
                case 'C':
                    Console.WriteLine(Math.Cos(angle));
                    break;
                case 'S':
                    Console.WriteLine(Math.Sin(angle));
                    break;
                case 'T':
                    Console.WriteLine(Math.Tan(angle));
                    break;
                default:
                    Console.WriteLine("Invalid character");
                    break;
            }
        }
    }
}