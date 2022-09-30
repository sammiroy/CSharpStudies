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
            // Non Price Variables
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
            Console.WriteLine("*** WELCOME TO URS REGISTRATION ***");

            #region Names
            // Names of user and corn
            Console.Write("What is your name?: ");
            userName = Console.ReadLine();
            Console.Write("What will you name your unicorn?: ");
            unicornName = Console.ReadLine();
            #endregion

            #region Donation
            Console.WriteLine("\n*** DONATION ***");
            // Donation Calculation
            Console.WriteLine("All sponsors are required to make a donation, what type of donation would you like to make?");
            userInput = char.Parse(Console.ReadLine().ToUpper());
            

            if(userInput == 'M'||userInput == 'U')
            {
                Console.Write("How much would you like to donate per month?: ");
                int tempDonationAmount = int.Parse(Console.ReadLine());
                donationCost = tempDonationAmount;
                if (userInput == 'M')
                {
                    Console.WriteLine("For how many months?: ");
                    int tempMonthAmt = int.Parse(Console.ReadLine());

                    donationCost = tempDonationAmount * tempMonthAmt;
                }
            } else if (userInput == 'O')
            {
                Console.Write("How much would you like to donate?: ");
                donationCost = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{donationCost}");
            #endregion

            #region Pen Accomodation
            Console.WriteLine("\n*** PEN ACCOMODATION ***");

            // Get all the pen accomodation variables
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
            Console.WriteLine(wallCost);
            wallCost += ((sideWallWidth * 12) * 4) * 2; // (Base * Height) * Price Per Square Foot, double because there are two
            Console.WriteLine(wallCost);
            wallCost += ((backWallWidth - gateWidth) * 12) * 4; ; // Add the difference to account for a smaller gate, then multiply by the price per square foot
            Console.WriteLine(wallCost);
            #endregion

            #region Gate Style
            Console.WriteLine("\n*** GATE STYLE ***");

            // Present gate options to user, use switch to determine constant value for gate pricing 
            Console.Write("What Type of gate would you like?" +
                "\nW - Wooden - $3 / sqft" +
                "\nS - Silver - $8 / sqft" +
                "\nG - Gold - $12 / sqft" +
                "\nEnter Selection: ");
            userInput = char.Parse(Console.ReadLine().ToLower());

            switch (userInput)
            {
                case 'w':
                    gatePrice = 3;
                    break;
                case 's':
                    gatePrice = 8;
                    break;
                case 'g':
                    gatePrice = 12;
                    break;
                default:
                    // Default to wood, for testing purposes 
                    gatePrice = 3;
                    break;
            }

            // Caculate gate cost 
            gateCost = (gateWidth * gateHeight) * gatePrice;//(Base * Height) * Material Price
            #endregion

            #region Gate Paint

            // if user wants to change the paints then allow them to
            Console.Write("Would you like to change gate colour (Y/N)?: ");
            userInput = char.Parse(Console.ReadLine().ToLower());
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
        }
    }
}