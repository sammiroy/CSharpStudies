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
            int playerPos = 0, aiPos = 0; // Positions
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

            #region Game loop
            // Gameplay loop
            while (loop)
            {
                // Clear screen
                Console.Clear();
                // Announce current positions

                // Draw track
                // Create track, draw players at their current positions
                for (int i = 0; i < trackLength; i++)
                {
                    Console.Write("=");// BARRIER
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < trackLength; i++)
                {
                    // Draw player at their current position
                    if (playerPos == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < trackLength; i++)
                {
                    // Draw enemy at their current position
                    if (aiPos == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < trackLength; i++)
                {
                    Console.Write("=");// BARRIER
                }
            }
            #endregion
        }
    }
}