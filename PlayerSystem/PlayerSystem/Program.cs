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

        // Display Menu
        // Get Menu Item (C-Create/D-Delete/L-List all players/X- exit)
        // Loop until valid menu item is entered

        // Init Variables
        char menuItem;
        int num;
        string input;


        menuItem = GetMenuItem();
        num = GetValidInt("Input a positive integer: ");
        input = GetNonEmptyString("Input valid string: ");
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