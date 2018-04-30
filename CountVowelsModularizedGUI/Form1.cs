using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * by Mark Hawes
 * Week 7
 * 
 * Count Vowels Modularized takes an input string and counts the vowels in it.
 * It mostly demonstrates the use of classes/methods to create a useful
 * and modularized vowel counter program
 */ 

namespace CountVowelsModularizedGUI
{
    public partial class CountVowelsForm : Form 
    {
        public CountVowelsForm()
        {
            InitializeComponent();
        }

        /*
         * on button press it gets the input string, then updates the 
         * output label to show how many vowels are in the string,
         * after they are counted of course.
         */
        private void StartCountButton_Click(object sender, EventArgs e)
        {
            // default text for OutputLabel
            string defaultOutputText = "Number of vowels in string: ";

            // changes the output label to the default and adds the 
            // output of the VowelCounter.CountVowels method
            // aka it counts vowels and changes final label to reflect it
            VowelOutputLabel.Text = defaultOutputText + 
                VowelCounter.CountVowels(InputTextBox.Text);
        }
    }

    class VowelCounter
    {
        /*
         * declare values as instance variables
         * has both upper and lower cases which I know I didn't need to, 
         * but I wasn't quite feeling up to making it work differently
         */
        private static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // CountVowels takes a string and counts the number of vowels 
        // it contains, then returns that counter as an int
        public static int CountVowels(string input)
        {
            // counter for number of vowels
            int numVowels = 0;

            // for every value in input string compare it to vowels
            foreach(char c in input)
            {
                if (vowels.Contains(c))
                    numVowels++;
            }
            return numVowels;
        }
    }
}
