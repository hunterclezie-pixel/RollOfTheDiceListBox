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
            SetDefaults();
        }

        //Custom Methids below here --------------------------------------------------------------

        void SetDefaults()
        {
            RollOfTheDiceListBox1.Items.Add("Roll Of The Dice");
        }

        void RollDice()
        {
            RollOfTheDiceListBox1.Items.Clear();
            {
                Random rand = new Random(); //Constructor
                int[] rolls = new int[13]; // Array to count occurrences of each possible roll (2-12)
                string columnSeperator = "|"; // String to separate columns in the output
                string currentLine = ""; // String to build the current line of output

                RollOfTheDiceListBox1.Items.Add("Roll Of The Dice");

                for (int i = 0; i < 1000; i++)
                {
                    int n = rand.Next(2, 12 + 1); // Random number between 2 and 12
                    rolls[n]++; // Increment the count for this roll
                }

                // First line is the numbers 2-12
                for (int i = 2; i <= 12; i++)
                {
                    currentLine += ($"{i}".PadRight(4) + columnSeperator);
                }
                RollOfTheDiceListBox1.Items.Add(currentLine);
                currentLine = ""; // Clear currentLine for the next row of data

                // Second line is the number of times each number was rolled
                for (int i = 2; i <= 12; i++)
                {
                    currentLine += ($"{rolls[i]}".PadRight(4) + columnSeperator);
                }
                RollOfTheDiceListBox1.Items.Add(currentLine);
                currentLine = ""; // Clear currentLine for the next row of data
            }
        }

        //Event Handlers below here --------------------------------------------------------------

        private void RollButton_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RollOfTheDiceListBox1.Items.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
