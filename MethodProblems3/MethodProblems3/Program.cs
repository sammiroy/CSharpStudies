namespace MethodProblems3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSeconds(6, 8, 30));
        }

        static double GetTotal(int pennies, int nickels, int dimes, int quarters, int loonies, int toonies)
        {
            double total = 0;

            total += (0.01 * pennies);
            total += (0.5 * nickels);
            total += (0.1 * dimes);
            total += (0.25 * quarters);
            total += (1 * loonies);
            total += (2 * toonies);

            return total;
        }

        static int CalculateSeconds(int hours, int mins, int sec)
        {
            int tot = 0;

            hours *= 60;
            mins += hours;
            mins *= 60;
            sec += mins;
            tot = sec;

            return tot;
        }



    }
}