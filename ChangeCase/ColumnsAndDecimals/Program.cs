namespace ColumnsAndDecimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Columns - can be used to create alinged columns of data in a console window
            // first column 20 characters wide
            // second column 10 characters wide
            // by default data in the columns is right aligned
            // to make the data left aligned make the column width negative

            Console.WriteLine("{0, -20:0.0}{1, 10}", 100.4552, 200);
            Console.WriteLine("{0, -20:0.00}{1, 10}", 100.4552, 200);
            Console.WriteLine("{0, -20:0.000}{1, 10}", 100.4552, 200);
            Console.WriteLine("{0, -20}{1, 10}", 100.4552, 200);
            Console.WriteLine("{0, -20:C}{1, 10:C}", 100.4552, 200);




        }
    }
}