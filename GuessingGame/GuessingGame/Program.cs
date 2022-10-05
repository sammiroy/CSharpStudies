namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init Random
            Random random = new Random();

            // Init variables
            string userInput;
            int desiredRounds, roundCount=0;
            int secretNumber, randomCeiling=1;

            

            // Get valid round count
            Console.Write("How many rounds would you like to play?: ");
            userInput = Console.ReadLine();
            while(!int.TryParse(userInput, out desiredRounds))
            {
                Console.Write("Invalid input, How many rounds would you like to play?: ");
                userInput = Console.ReadLine();
            }
            desiredRounds = int.Parse(userInput);
            Console.Clear();

            // Get valid difficulty
            Console.Write(
                "Which difficult would you like to play?" +
                "\nE - Easy, 1-100" +
                "\nC - Challenging, 1-10,000" +
                "\nX - Extreme, 1-1,000,000" +
                "\nEnter choice: "
                );
            userInput = Console.ReadLine().ToLower();
            while(userInput != "e" && userInput != "c" && userInput !="x")
            {
                Console.Write("Invalid input, please try again: ");
                userInput = Console.ReadLine().ToLower();
                Console.WriteLine(userInput);
            }
            switch (userInput)
            {
                case "e":
                    randomCeiling = 101;
                    break;
                case "c":
                    randomCeiling = 10001;
                    break;
                case "x":
                    randomCeiling = 1000001;
                    break;
            }

            while (roundCount < desiredRounds)
            {
                roundCount++;
                secretNumber = random.Next(1, randomCeiling);
                Console.Write(secretNumber);
            }
            // Game Loop
            //   Generate Random Number
            //   Round loop
            //     Get A valid guess
            //     Evaluate guess

            
        }
    }
}