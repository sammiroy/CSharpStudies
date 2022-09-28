namespace NestedLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowInput, colInput, rowCount = 0, colCount;

            Console.Write("How many rows?: ");
            rowInput = int.Parse(Console.ReadLine());
            Console.Write("How many columns?: ");
            colInput = int.Parse(Console.ReadLine());

            while (rowCount < rowInput)
            {
                // Reset Column Count
                colCount = 0;

                // Draw a row
                while (colCount < colInput)
                {
                    Console.Write("* ");
                    colCount++;
                }

                // Add a new row
                Console.WriteLine();
                rowCount++;
            }

        }
    }
}