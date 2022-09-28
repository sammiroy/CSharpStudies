namespace LoopStudies1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DO WHILE DEMO
            // Post test loop
            // Code will always execute at least once

            // do
            // {
            // loop code
            // } 
            // while(condition)

            // Keep asking for numbers to add up until they enter 0 to quit. Display the sum.
            // They must enter at least one number

            int sum = 0, input;

            do
            {
                Console.Write($"Enter a number to add to the sum,(Sum currently {sum}): ");
                input = int.Parse(Console.ReadLine());
                sum += input;

            } while (input != 0);
        }
    }
}