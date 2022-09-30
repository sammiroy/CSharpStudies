namespace UnicornRescueSociety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unicorn Rescue Society Sponsor Pricing 
            // Written by Samantha Roy

            #region Variables

            // Initate Variables
            // Text Variables
            char userInput;
            string userName, unicornName;

            // Price Variables 
            int donationCost = 0;
            int wallCost = 0;
            int gateCost = 0;
            int paintCost = 0;
            int mealUpgrade = 0;

            // Dimension Variables
            int sideWallWidth;
            int backWallWidth;
            int gateWidth, gateHeight, gatePrice;

            #endregion

            // Welcome the user because its rude to not greet people when you meet them
            Console.WriteLine("*** WELCOME TO URS REGISTRATION ***");

            #region Names
            // Prompt user to input both their name and the unicorn's name
            Console.Write("What is your name?: ");
            userName = Console.ReadLine();
            Console.Write("What will you name your unicorn?: ");
            unicornName = Console.ReadLine();
            #endregion

            #region Donation
            Console.WriteLine("\n*** DONATION ***");

            // Donation Calculation
            // Prompt user for donation type
            Console.Write("All sponsors are required to make a donation, what type of donation would you like to make?");
            userInput = char.Parse(Console.ReadLine().ToLower());
            
            // If the user picks M or U, askthem how much they would like to donate PER MONTH
            if(userInput == 'm'||userInput == 'u')
            {
                // If its donations in perpetuity, simply make the cost the same as the user input
                Console.Write("How much would you like to donate per month?: ");
                int tempDonationAmount = int.Parse(Console.ReadLine());
                donationCost = tempDonationAmount;

                // If the amount of months in finite, prompt the user for the desired amount of months, cost is equal to monthly donation * number of months
                if (userInput == 'm')
                {
                    Console.WriteLine("For how many months?: ");
                    int tempMonthAmt = int.Parse(Console.ReadLine());

                    donationCost = tempDonationAmount * tempMonthAmt;
                }
            } 
            // If it is a one time donation, simply set the price to the amount input into the prompt
            else if (userInput == 'o')
            {
                // Can be directly assigned to the variable as no other actions are taken
                Console.Write("How much would you like to donate?: ");
                donationCost = int.Parse(Console.ReadLine());
            }

            // Print amount donated
            Console.WriteLine($"The total donation amount is ${donationCost}.00! Thank you for your generosity!");
            #endregion

            #region Pen Accomodation
            Console.WriteLine("\n*** PEN ACCOMODATION ***");

            // Prompt user for the dimensions of the pen + gate
            Console.Write("Enter side walls width: ");
            sideWallWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter back wall width: ");
            backWallWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter gate width (Max width is back wall width): ");
            gateWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter gate height (Max 12ft): ");
            gateHeight = int.Parse(Console.ReadLine());

            // Calculate Wall prices, gate price gets calculated later
            wallCost += (backWallWidth * 12) * 4; // (Base * Height) * Price Per Square Foot
            wallCost += ((sideWallWidth * 12) * 4) * 2; // (Base * Height) * Price Per Square Foot, double because there are two
            wallCost += ((backWallWidth - gateWidth) * 12) * 4; ; // Add the difference to account for a smaller gate, then multiply by the price per square foot
            #endregion

            #region Gate Style
            Console.WriteLine("\n*** GATE STYLE ***");

            // Prompt user for desired gate material, price will be altered accordingly 
            Console.Write("What Type of gate would you like?" +
                "\nW - Wooden - $3 / sqft" +
                "\nS - Silver - $8 / sqft" +
                "\nG - Gold - $12 / sqft" +
                "\nEnter Selection: ");
            userInput = char.Parse(Console.ReadLine().ToLower());

            switch (userInput)
            {
                case 'w':
                    // $3 per square foot
                    gatePrice = 3;
                    break;
                case 's':
                    // $8 per square foot
                    gatePrice = 8;
                    break;
                case 'g':
                    // $12 per square foot
                    gatePrice = 12;
                    break;
                default:
                    // Default to wood, for testing purposes 
                    gatePrice = 3;
                    break;
            }

            // Caculate gate cost, adjusted for the material used
            gateCost = (gateWidth * gateHeight) * gatePrice; //(Base * Height) * Material Price
            #endregion

            #region Gate Paint

            // Prompt user for optional paint job
            Console.Write("\nWould you like to change gate colour (Y/N)?: ");
            userInput = char.Parse(Console.ReadLine().ToLower());

            // If user select yes, do all this junk,if not it will simply move on
            if (userInput == 'y')
            {
                Console.Write("Avalible Paints" +
                    "\n M - Mood paint (changes color based on the unicorns mood) – add $200" +
                    "\n A - Magic paint (changes color several times a day) – add $300" +
                    "\n R - Reflective paint (acts like a mirror) – add $150" +
                    "\nEnter Selection: ");
                userInput = char.Parse(Console.ReadLine().ToLower());

                // Switch for paint selection
                switch (userInput)
                {
                    case 'm':
                        paintCost = 200;
                        break;
                    case 'a':
                        paintCost = 300;
                        break;
                    case 'r':
                        paintCost = 150;
                        break;
                }
            }

            #endregion

            #region Meal Upgrades
            Console.WriteLine("\n*** MEAL UPGRADES ***");

            // Prompt user with option to upgrade the Unicorn's Meals
            Console.Write("Would you like to upgrade your unicorn's feed(Y/N)?: ");
            userInput = char.Parse(Console.ReadLine().ToLower());

            // If user input is 'y' then prompt them for their desired meal upgrade
            if(userInput == 'y')
            {
                Console.Write("Avalible meal upgrades:" +
                    "\n R - Add rainbow cookie treats($1000)" +
                    "\n S - Special appetizers($500)" +
                    "\nWhich meal upragde would you like?: ");
                userInput = char.Parse(Console.ReadLine().ToLower());
                if (userInput == 'r')
                {
                    mealUpgrade = 1000;
                } else if (userInput == 's')
                {
                    mealUpgrade = 500;
                }
            }
            #endregion

            #region The Total
            Console.WriteLine("\n*** SUMMARY ***");

            // Display Individual Cost
            Console.WriteLine(
                $"\nDonor: {userName}" +
                $"\nUnicorn Name: {unicornName}" +
                $"\nDonated Amount: ${donationCost}" +
                $"\nWall Cost: ${wallCost}" +
                $"\nGate Cost: ${gateCost}"
                );

            // Determine result of paint & meal cost
            if(paintCost == 0)
            {
                Console.WriteLine("Paint Cost: Original, No charge");
            } else
            {
                Console.WriteLine($"Paint Cost: ${paintCost}");
            }

            if(mealUpgrade == 0)
            {
                Console.WriteLine("Meal Upgrade: None, No charge");
            } else
            {
                Console.WriteLine($"Meal Uprgade: ${mealUpgrade}");
            }

            int total = donationCost + wallCost + gateCost + paintCost + mealUpgrade;

            //Display Total Cost
            Console.WriteLine($"{userName}, the total cost of your sponsorship of {unicornName} is ${total} ");
            #endregion
        }
    }
}