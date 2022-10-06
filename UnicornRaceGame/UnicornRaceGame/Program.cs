 namespace UnicornRaceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            // Init Variables
            Random roll = new Random();

            string userInput;
            bool loop = true;
            int trackLength;
            int playerPos, aiPos;
            int rollResult;
            int gamesWon, gamesLost, gamesTied;
            #endregion

            // Welcome the user
            Console.WriteLine("Welcome to the Unicorn Racing Game!\n");

            // Prompt user for trackLength
            Console.Write("Please enter a track length: ");
            userInput = Console.ReadLine();

            // Validate user input
            while (!int.TryParse(userInput, out trackLength) || trackLength < 1)
            {
                Console.Clear();
                Console.WriteLine("Error: must provide an integer >0 ");
                Console.Write("Please enter a track length: ");
                userInput = Console.ReadLine();
            }


        }
    }
}