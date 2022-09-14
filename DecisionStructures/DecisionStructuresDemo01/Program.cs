/*
 * Basic demo of decision structures
 * 
 * Input: integer between 0 - 100
 * 
 * Outputs: if mark >= 80, output "I am proud" string
 */
namespace DecisionStructuresDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init and assign mark variable
            int mark;

            Console.Write("Enter your child's mark from 0-100: ");
            mark = int.Parse(Console.ReadLine());

            // Output message if mark is >= 80
            if (mark >= 80)
            {
                Console.WriteLine("I am proud");
            } else
            {
                Console.WriteLine("Try better next time bozo");
            }
        }
    }
}