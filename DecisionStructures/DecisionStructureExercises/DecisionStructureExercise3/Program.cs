using System.Security.Cryptography;

namespace DecisionStructureExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rock Paper Scissors vs AI

            // Init variables & random object
            Random random = new Random();

            int cChoice = random.Next(-1, 2); // The AI picks a random integer between -1 and 1
            int uChoice;

            Console.Write(
                "1. Rock\n" +
                "2. Paper\n" +
                "3. Scissors\n" +
                "Enter selection: "
                );
            uChoice = int.Parse(Console.ReadLine());

            


            
        }
    }
}