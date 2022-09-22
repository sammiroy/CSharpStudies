namespace LoopProblems1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            int desiredLoops;
            int powSum = 0;
            int valCount = 0;

            Console.Write("Enter value: ");
            desiredLoops = int.Parse(Console.ReadLine());

            // Add the sum of the squares up to the desired value
            while (desiredLoops >= valCount)
            {
                // Init variables
                int tempNum;
                tempNum = valCount;

                // Square the value and add it to the final sum
                tempNum = tempNum * tempNum;
                powSum += tempNum;

                // Increment Counter
                valCount++;
            }

            Console.WriteLine(powSum);
        }
    }
}