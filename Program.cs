// See https://aka.ms/new-console-template for more information

using static System.Console;
// Josh Ditto
// Section 4 (Group 13)
// This is a program that simulates rolling two dice, adding up their totals, and then calculating based on the number of times you roll the two dice, what the percentage is of the numbers you can roll of the total times rolled demonstrated in stars (*)
internal class Program
{
    public static void Main(string[] args)
    {
        // Initialize variables to keep track of the number of rolls and counts for each dice total
        int numrolls = 0;
        int twocounter = 0;
        int threecounter = 0;
        int fourcounter = 0;
        int fivecounter = 0;
        int sixcounter = 0;
        int sevencounter = 0;
        int eightcounter = 0;
        int ninecounter = 0;
        int tencounter = 0;
        int elevencounter = 0;
        int twelvecounter = 0;

        // Display a welcome message
        System.Console.WriteLine(""); // Blank line for readability
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine(""); // Blank line for readability

        // Ask the user for the number of rolls and read input
        System.Console.WriteLine("How many dice rolls would you like to simulate?: ");
        numrolls = int.Parse(System.Console.ReadLine()); // Convert user input from string to integer

        // Loop to simulate dice rolls
        for (int rollcount = 0; rollcount < numrolls; rollcount++)
        {
            int dicetotal = RollDice(); // Simulate a dice roll and get the total

            // Increment the appropriate counter based on the dice total
            if (dicetotal == 2)
            {
                twocounter++;
            }
            else if (dicetotal == 3)
            {
                threecounter++;
            }
            else if (dicetotal == 4)
            {
                fourcounter++;
            }
            else if (dicetotal == 5)
            {
                fivecounter++;
            }
            else if (dicetotal == 6)
            {
                sixcounter++;
            }
            else if (dicetotal == 7)
            {
                sevencounter++;
            }
            else if (dicetotal == 8)
            {
                eightcounter++;
            }
            else if (dicetotal == 9)
            {
                ninecounter++;
            }
            else if (dicetotal == 10)
            {
                tencounter++;
            }
            else if (dicetotal == 11)
            {
                elevencounter++;
            }
            else if (dicetotal == 12)
            {
                twelvecounter++;
            }
        }

        // Display the results of the simulation
        PrintResults(numrolls, twocounter, threecounter, fourcounter, fivecounter, sixcounter, sevencounter, eightcounter, ninecounter, tencounter, elevencounter, twelvecounter);

        // Goodbye message
        System.Console.WriteLine($"Thank you for using the dice throwing simulator. Goodbye!");
    }

    // Simulate rolling two dice and returning their total
    public static int RollDice() 
    {
        Random random = new Random(); // Create a new Random object to generate random numbers
        int die1 = random.Next(1, 7); // Generate a random number between 1 and 6 for the first die
        int die2 = random.Next(1, 7); // Generate a random number between 1 and 6 for the second die

        return die1 + die2; // Return the sum of the two dice
    }

    // Generate a string of stars to represent the percentage of total rolls
    public static string MakeStars(int count, int totalRolls)
    {
        int percentage = (int)((count / (double)totalRolls) * 100); // Calculate the percentage of rolls
        return new string('*', percentage); // Create and return a string with `percentage` number of stars
    }

    // Print the simulation results
    public static void PrintResults(int n, int twoc, int threec, int fourc, int fivec, int sixc, int sevenc, int eightc, int ninec, int tenc, int elevenc, int twelvec) 
    {
        // Header for the results
        System.Console.WriteLine(""); // Blank line for readability
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS"); 
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");   
        System.Console.WriteLine("Total number of rolls =  " + n + ".");
        System.Console.WriteLine(""); // Blank line for readability 

        // Print results for each dice total using the MakeStars method
        System.Console.WriteLine("2: " + MakeStars(twoc, n));
        System.Console.WriteLine("3: " + MakeStars(threec, n));
        System.Console.WriteLine("4: " + MakeStars(fourc, n));
        System.Console.WriteLine("5: " + MakeStars(fivec, n));
        System.Console.WriteLine("6: " + MakeStars(sixc, n));
        System.Console.WriteLine("7: " + MakeStars(sevenc, n));
        System.Console.WriteLine("8: " + MakeStars(eightc, n));
        System.Console.WriteLine("9: " + MakeStars(ninec, n));
        System.Console.WriteLine("10: " + MakeStars(tenc, n));
        System.Console.WriteLine("11: " + MakeStars(elevenc, n));
        System.Console.WriteLine("12: " + MakeStars(twelvec, n));
        System.Console.WriteLine(""); // Blank line for readability 
    }
}
