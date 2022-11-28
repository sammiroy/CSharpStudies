namespace PlayerSystemA01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //playerNumbers [44]    [22]    [33]
            //playerName    [Shane] [Bob]   [Sue]
            //playerPoints  [100]   [80]    [120]
            //Index           0      1        2

            //25 element arrays
            const int MAX_PLAYERS = 25;

            //int playerNumbers
            int[] playerNumbers = new int[MAX_PLAYERS];
            //string playerNames
            string[] playerNames = new string[MAX_PLAYERS];
            //int playerPoints
            int[] playerPoints = new int[MAX_PLAYERS];
            int playerCount = 0;//How many players currently on the team. This is the logical size of my array.


            char menuItem;
            //Keep playing until menuItem is 'X'            
            menuItem = GetMenuItem();
            while (menuItem != 'X')
            {
                ProcessMenuItem(menuItem, playerNumbers, playerNames, playerPoints, MAX_PLAYERS, ref playerCount);
                menuItem = GetMenuItem();                
            }
        }


        static void ProcessMenuItem(char menuItem, int[] playerNumbers, string[] playerNames, int[] playerPoints, int maxPlayers, ref int playerCount)
        {
            switch (menuItem)
            {
                //C - call CreatePlayer method
                case 'C':
                    CreatePlayer(playerNumbers, playerNames, playerPoints, maxPlayers, ref playerCount);
                    break;
                //D - call DeletePlayer method
                case 'D':
                    DeletePlayer(playerNumbers, playerNames, playerPoints, ref playerCount);
                    break;
                //L - call ListPlayers method
                case 'L':
                    ListPlayers(playerNumbers, playerNames, playerPoints, playerCount);
                    break;
            }
        }

        static void CreatePlayer(int[] playerNumbers, string[] playerNames, int[] playerPoints, int maxPlayers, ref int playerCount)
        {
            //is there room in the arrays?
            //XXDoes the player number already exist?XX
            //add to arrays
            //Add 1 to playerCount
            int playerNumber;
            int searchResult;

            //room for another player?
            if (playerCount < maxPlayers)
            {

                //Is that playernumber available?Decision that calls SearchForPlayerNumber method.
                playerNumber = GetPositiveInteger("Enter the players number: ");
                //if the playernumber is available, add the player. 
                //If the playernumber is not available, display a message, and do not add the player, and return to the menu(mainline).

                searchResult = SearchForPlayerNumber(playerNumbers, playerCount, playerNumber);

                if (searchResult == -1)
                {
                    playerNumbers[playerCount] = playerNumber;
                    //get valid name and add to array
                    playerNames[playerCount] = GetNonEmptyString("Enter the players name: ");
                    //get valid points and add to array
                    playerPoints[playerCount] = GetPositiveInteger("Enter the players points: ");
                    //Add 1 to playerCount
                    playerCount++;
                }
                else
                {
                    Console.WriteLine("That player number is already taken.");
                }
            }
            //if no room for another player write to screen "Team already full"
            else
            {
                Console.Write("Team already full!");
            }
        }
        //Method to search for a player number.returns an integer
        //pass in playernumbers array,player count, playernumber to delete/add
        //return the index of where the player number was found
        //if the player number is not found return -1
        static int SearchForPlayerNumber(int[] playerNumbers, int playerCount, int playerNumberToSearch)
        {
            bool found = false;
            int index = 0;
            int returnValue = -1;
            //loop through the array until the end of the logical size or you find the number
            //When/if found set found to TRUE

            while (index < playerCount && !found)
            {
                if (playerNumbers[index] == playerNumberToSearch)
                {
                    found = true;
                }
                else
                {
                    index++;
                }
            }
            //if you found the index of where it was found return it, otherwise return -1
            if (found)
            {
                returnValue = index;
            }
            return returnValue;
        }


        static void DisplayMenu()
        {
            Console.WriteLine("Please choose on of the following options:");
            Console.WriteLine("C - Create a Player");
            Console.WriteLine("D - Delete a Player");
            Console.WriteLine("L - List all Players");
            Console.WriteLine("X - Exit");
        }

        static char GetMenuItem()
        {
            string menuItem;
            //Display the menu
            DisplayMenu();
            //get input from user            
            menuItem = Console.ReadLine().ToUpper();
            //loop until user enters C,D,L,X
            while (menuItem != "C" && menuItem != "D" && menuItem != "L" && menuItem != "X")
            {
                //Error message if invalid
                Console.WriteLine("You have entered an invalid menu option :(");
                //Display menu
                DisplayMenu();
                //get input from the user
                menuItem = Console.ReadLine().ToUpper();
            }
            //return the valid menu option (C,D,L,X)
            return char.Parse(menuItem);
        }

        //Method to prompt for and return a valid, positive integer. Since we will use this method to get a valid player number AND a valid player points we will pass in the prompt as a parameter. 

        static int GetPositiveInteger(string prompt)
        {
            string input;
            int result;
            Console.Write(prompt);
            input = Console.ReadLine();

            while (!int.TryParse(input, out result) || result <= 0)
            {
                Console.WriteLine("You must enter a positive integer!");
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            return result;
        }



        //Method to prompt for a non Empty String. It will receive a prompt as a parameter.
        // string.IsNullOrEmpty(valuetocheck)     --Returns True if empty/Blank

        static string GetNonEmptyString(string prompt)
        {
            string input;
            Console.Write(prompt);
            input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Gotta give some data!");
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            return input;
        }

        //Create the method ListPlayers that will:
        //Loop throught the arrays and display all the PlayerNumbers, PlayerNames, and PLayerPoints and the count of players. Use columns.
        //                      Number  Name        Points
        //                      44      Shane       5
        //                      22      Sue         12
        //                      Player Count: 2

        static void ListPlayers(int[] playerNumbers, string[] playerNames, int[] playerPoints, int playerCount)
        {
            if (playerCount == 0)
            {
                Console.WriteLine("The team has no players!");
            }
            else
            {
                //Display column headings
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", "NUMBER", "NAME", "POINTS");
                //loop through and display the array values
                for (int index = 0; index < playerCount; index++)
                {
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}", playerNumbers[index], playerNames[index], playerPoints[index]);
                }
                Console.WriteLine($"Player Count: {playerCount}");
            }
        }



        //Create the method DeletePlayer that will ask for a player number and delete that player from the team.If the player number is not found, display a message"That player does not exist", otherwise delete the player.If the team is empty display "There are no players on the team"
        //To delete a player:
        //find the index of that player
        //copy the last player in the array into the index of the deleted player
        //decrement playerCount

        static void DeletePlayer(int[] playerNumbers, string[] playerNames, int[] playerPoints, ref int playerCount)
        {
            int playerNumberToDelete;
            int playerIndex;
            //if there are no players display "There are no players to delete"
            if (playerCount == 0)
            {
                Console.WriteLine("There are no players to delete!");
            }
            else
            {
                //get the playernumber to delete from the user
                playerNumberToDelete = GetPositiveInteger("Enter the player number to delete: ");

                //Use SearchForPlayerNumber method to find the index of the that playernumber. Remember, that method returns the index where it was found OR -1 if not found
                //if the playernumber is found store it in a variable
                playerIndex = SearchForPlayerNumber(playerNumbers, playerCount, playerNumberToDelete);
                //if the playernumber is not found display a message"Player not found"
                if (playerIndex == -1)
                {
                    Console.WriteLine("Player not found!");
                }
                else
                {
                    //copy the last playernumber, name, points into the index where the playernumber was found. 
                    playerNumbers[playerIndex] = playerNumbers[playerCount - 1];
                    playerNames[playerIndex] = playerNames[playerCount - 1];
                    playerPoints[playerIndex] = playerPoints[playerCount - 1];
                    //decrement playercount
                    playerCount--;
                }
            }
        }
    }
}

//Create a class to store a Players Number, name and points
//Create Player method will create a player object and add them to list
//Delete player Method will delete the player from the list
//Create a method to list all the players
//Add another menu option to Save the player objects to a file
//Add another menu option to load the players into a list (make sure the list is empty beofre loading)
//Create a default constructor(no parameters) and another constructor (Name,Points and Number parameters)


