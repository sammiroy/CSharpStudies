namespace DecisionStructureExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int year;
            string result;

            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());


            if((year%4 == 0 && year%100 != 0) || year%400 == 0)
            {
                result = "Yes.";
            }
            else
            {
                result = "No.";
            }

            Console.WriteLine($"Is {year} a leap year? {result}");
        }
    }
}