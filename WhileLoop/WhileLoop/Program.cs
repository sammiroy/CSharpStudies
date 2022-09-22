namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops repeat a bunch of code until a condition is met
            // The condition could be a counter
            // The condition could be based on user input

            // Syntax
            /* 
             * while(loop condition is true)
             * {
             * Code that will continue executing while the loop condition is true
             * Something in the loop must change the condition so the loop will
             * eventuall exit
             * }
             */

            // Ask the user how many times to say "Happy Thursday!"
            // Display "Happy Thrusday" that many times!

            #region Variables
            int howManyTimes;
            int counter = 1;
            int scale = 1;
            int doubleScale = 1;
            #endregion

            #region finishedQuestions
            /*
            Console.Write("How many Happy Thursdays?: ");
            howManyTimes = int.Parse(Console.ReadLine());

            while (counter <= howManyTimes)
            {
                counter++;
                Console.WriteLine("Happy thursday!");
            }

            Console.Write("Count to what number?: ");
            howManyTimes = int.Parse(Console.ReadLine());

            // Ask the user for a number to count to
            while (scale <= howManyTimes)
            {
                Console.Write($"{scale} ");
                scale++;
            }

            Console.Write("Count to what number?: ");
            howManyTimes = int.Parse(Console.ReadLine());

            // Ask the user for a number to count to but only count even numbers
            while (doubleScale <= howManyTimes)
            {
                if (doubleScale % 2 == 0)
                {
                    Console.Write($"{doubleScale} ");
                }

                doubleScale++;
            }
            */
            #endregion
        }
    }
}