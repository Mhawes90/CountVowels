using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CountVowelsForm());
        }
    }
}
