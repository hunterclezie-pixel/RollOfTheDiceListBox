/* 
Hunter Clezie 
Spring 2026
RCET2265
RollOfTheDiceListBox
github url: https://github.com/hunterclezie-pixel/RollOfTheDiceListBox.git
*/
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RollOfTheDiceListBox
{
    //Todo:
    //[]Display the results in a list box with formatted columns and headers.
    //[]The header row should show the roll result numbers 2 to 12.
    //[]The data row should show the total count of how many times each number came up.
    public partial class RollOfTheDiceListBoxForm1 : Form
    {
        public RollOfTheDiceListBoxForm1()
        {
            InitializeComponent();
        }

        //Custom Methids below here --------------------------------------------------------------

        void SetDefaults()
        {
            RollOfTheDiceLabel.Text =;
        }

        void RollDice()
        {
            Random rand = new Random(); //Constructor
            int[] rolls = new int[13]; // Array to count occurrences of each possible roll (2-12)
            string columnSeperator = "|"; // String to separate columns in the output

            Console.WriteLine("Roll Of The Dice");

            for (int i = 0; i < 1000; i++)
            {
                int n = rand.Next(2, 12 + 1); // Random number between 2 and 12
                rolls[n]++; // Increment the count for this roll
            }

            // Print the results:
            // First line is the numbers 2-12
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}".PadRight(4) + columnSeperator);
            }
            Console.WriteLine();

            // Second line is the number of times each number was rolled
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{rolls[i]}".PadRight(4) + columnSeperator);
            }
            Console.WriteLine();

            //pause
            Console.Read();
        }

        //Event Handlers below here --------------------------------------------------------------
    }
}
