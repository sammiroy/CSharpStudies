namespace NestedLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colInput, rowInput;

            Console.Write("Enter Columns: ");
            colInput = int.Parse(Console.ReadLine());
            Console.Write("Enter Rows: ");
            rowInput = int.Parse(Console.ReadLine());   

            for (int i = 0; i < rowInput; i++)
            {
                for (int j = 0; j < colInput; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}