namespace PlayerSystem;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        //playerNumbers [44]    [22]    [33]
        //playerName    [Sammi] [Evan]  [Shane]
        //playerPoints  [100]   [80]    [120]
        //index         0       1       2

        //25 element arrays
        const int MAX_PLAYERS = 25;

        int[] playerNumbers = new int[MAX_PLAYERS];

        string[] playerNames = new string[MAX_PLAYERS];

        int[] playerPoints = new int[MAX_PLAYERS];

        // Init Variables
        char menuItem;
        int playerCount = 0; // Current number of active players, this is the logical size of the array
        // Keep looping until menuItem is 'x'
        menuItem = GetMenuItem();

        // Process Menu Item
        ProcessMenuItem(menuItem, playerNumbers, playerNames, playerPoints, MAX_PLAYERS, playerCount);



    }

    static void ProcessMenuItem(char menuItem, int[] playerNumbers, string[] playerNames, int[] playerPoints, int maxPlayers, int playerCount)
    {
        switch (menuItem)
        {
            case 'c':
                CreatePlayer(playerNumbers, playerNames, playerPoints, maxPlayers, playerCount);
                break;
            case 'd':
                DeletePlayer();
                break;
            case 'l':
                ListPlayers();
                break;
        }
    }

    static void CreatePlayer(int[] playerNumbers, string[] playerNames, int[] playerPoints, int maxPlayers, int playerCount)
    {
        // Is there room in the arrays
        // (not rn) Does the player number already exist?
        // Add to arrays
        if (playerCount < maxPlayers)
        {
            // Is that player number available?


            // Player Number
            playerNumbers[playerCount] = GetValidInt("Enert a positive number for your player's number: ");

            // Player Name
            playerNames[playerCount] = GetNonEmptyString("Enter your player's name: ");

            // Player Points
            playerPoints[playerCount] = GetValidInt("Enter a positive number for your player's points: ");

            playerCount++;
        }


        // Add 1 to playerCount
        // If no room for another player write to screen "Team already full"


    }

    static void DeletePlayer()
    {

    }

    static void ListPlayers()
    {

    }

    static void DisplayMenu()
    {
        Clear();
        Write(
            "Please select one of the following options:" +
            "\nC - Create new player" +
            "\nD - Delete player" +
            "\nL - List all players" +
            "\nX - Exit" +
            "\nEnter Selection: ");
    }

    static char GetMenuItem()
    {
        // Display Menu
        DisplayMenu();

        // Get input from user
        string userInput = ReadLine().ToLower();

        // Validate Input
        while(userInput != "c" && userInput != "d" && userInput != "l" && userInput != "x")
        {
            WriteLine("Error! Invalid menu selection.");
            DisplayMenu();
            userInput = ReadLine();
        }

        // Return valid input
        char selection = char.Parse(userInput);
        return selection;
    }

    static int GetValidInt(string prompt)
    {
        Write(prompt);
        string input = ReadLine();
        int result;
        while (!int.TryParse(input, out result) || result <= 0)
        {
            Write("Error! Please try again: ");
            input = ReadLine();
        }

        return result;
    }

    static string GetNonEmptyString(string prompt)
    {
        Write(prompt);
        string input = ReadLine();

        while (string.IsNullOrEmpty(input))
        {
            Write("Error! Please try again: ");
            input = ReadLine();
        }

        return input;
    }
}