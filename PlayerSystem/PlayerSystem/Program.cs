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
        char menuItem = 'A';
        int playerCount = 0; // Current number of active players, this is the logical size of the array
        // Keep looping until menuItem is 'x'
        

        while(menuItem != 'x')
        {
            menuItem = GetMenuItem();
            // Process Menu Item
            ProcessMenuItem(menuItem, playerNumbers, playerNames, playerPoints, MAX_PLAYERS, ref playerCount);
        }
        



    }

    static void ProcessMenuItem(char menuItem, int[] playerNumbers, string[] playerNames, int[] playerPoints, int maxPlayers, ref int playerCount)
    {
        switch (menuItem)
        {
            case 'c':
                CreatePlayer(playerNumbers, playerNames, playerPoints, maxPlayers, ref playerCount);
                break;
            case 'd':
                DeletePlayer(playerNumbers, playerNames, playerPoints, ref playerCount);
                break;
            case 'l':
                ListPlayers(playerNumbers, playerNames, playerPoints, ref playerCount);
                break;
        }
    }

    static void CreatePlayer(int[] playerNumbers, string[] playerNames, int[] playerPoints, int maxPlayers, ref int playerCount)
    {
        // Init local variables
        int playerNumber;
        int searchResult;

        // Is there room in the arrays
        // Does the player number already exist?
        // Add to arrays
        if (playerCount < maxPlayers)
        {
            // Is that player number available? Decision that calls searchForPlayerNumber method
            // Call the method to search
            playerNumber = GetValidInt("Enter a positive number for your player's number: ");
            // If the playerNumber is available, add the player 
            // If not, display a message and do not add the player

            searchResult = SearchForPlayerNumber(playerNumbers, playerCount, playerNumber);

            if(searchResult != -1)
            {
                WriteLine("Error! Player number already exists");
                ReadLine();
            } else
            {
                // Player Number
                playerNumbers[playerCount] = playerNumber;

                // Player Name
                playerNames[playerCount] = GetNonEmptyString("Enter your player's name: ");

                // Player Points
                playerPoints[playerCount] = GetValidInt("Enter a positive number for your player's points: ");

                playerCount++;
            }
        }
        else
        {
            WriteLine("Team already full.");
        }
    }

    /// <summary>
    /// Create the method to DeletePlayer that will ask for a player number and delete that player from the team
    /// If the player does not exist write to console "Player not found", otherwise delete them
    /// If there are no players write to console "There are no players currently"
    /// TO delete a player: 
    /// Find the index of that player
    /// Copy the last player in the array into the index of the deleted player
    /// Decrement playercount
    /// </summary>
    static void DeletePlayer(int[] playerNumbers, string[] playerNames, int[] playerPoints, ref int playerCount)
    {
        int inputNum = GetValidInt("Enter desired player number: ");
        int delPlayerNumIndex;

        // Search for the player number
        delPlayerNumIndex = SearchForPlayerNumber(playerNumbers, playerCount, inputNum);

        // If theres no players
        if (playerCount == 0)
        {
            WriteLine("Error, no players currently.");
        } 
        // If the player number can be found
        else if (delPlayerNumIndex == -1)
        {
            WriteLine("Error, player does not exist.");
        } 
        // If there is a player, Delete them, decrement playerCount
        else
        {
            playerNumbers[delPlayerNumIndex] = playerNumbers[playerCount - 1];
            playerNames[delPlayerNumIndex] = playerNames[playerCount - 1];
            playerPoints[delPlayerNumIndex] = playerPoints[playerCount - 1];
            playerCount--;
            WriteLine("Player Deleted!");
        }
    }

    /// <summary>
    /// Create the method ListPlayers that will:
    /// Loop through the arrays and display all the PlayerNumbers, Names & points of each player and the total playerCount
    /// Use Columns 
    /// </summary>
    static void ListPlayers(int[] playerNumbers, string[] playerNames, int[] playerPoints, ref int playerCount)
    {
        if (playerCount == 0)
        {
            WriteLine("The team has no players!");
        }
        else
        {
            WriteLine("{0, -20}{1, -20}{2, -20}", "NUMBER", "NAME", "POINTS");
            for (int index = 0; index < playerCount; index++)
            {
                WriteLine("{0, -20}{1, -20}{2, -20}", playerNumbers[index], playerNames[index], playerPoints[index]);
            }
            WriteLine($"Player Count: {playerCount}");
        }
    }

    // METHOD to search for a player number. Returns an integer
    // Pass in playerNumbers, playerCount, playerNumbertoSearch
    // Return the index of where the player number was found
    // If the player number is not found return -1

    static int SearchForPlayerNumber(int[] playerNumbers, int playerCount, int playerNumberToSearch)
    {
        bool found = false;
        int playerIndex = -1;
        // loop through the array until the end of the logical size of the array or you find the number
        // When/if found set found to true

        for (int index = 0; index < playerCount && !found; index++)
        {
            if (playerNumbers[index] == playerNumberToSearch)
            {
                found = true;
                playerIndex = index;
            }
        }
        return playerIndex;
    }

    static void DisplayMenu()
    {
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