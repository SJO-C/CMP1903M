using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{

    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            char[] vowels = "AEIOU".ToCharArray();

            //3. Number of consonants
            string consonants = "BCDFGHJKLMNPQRSTVWXYZ";
             
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }

            //Use of Regular expressions, Thanks John Brock for the Inspiration here.
            //This is done to allow for a more efficient -in theory- program.
            Regex rxSentence = new Regex(@"^\w+[A-Za-z,;'s]+[.?!]$");
            MatchCollection matches = rxSentence.Matches(input);
            Regex rxUpper = new Regex(@"[A-Z]");
            Regex rxLower = new Regex(@"[a-z]");
            Regex rxLongWord = new Regex(@"([A-Za-z]{7,})");
            Regex rxElispses = new Regex(@"(\.{3,})");
            
            //The input exists only as upper case in the scope of this loop, it is unaffected elsewhere.
            foreach(var i in input.ToUpper())
            {
                if (i == ((char)42)) { break; }//Identifies the Askerisk as the string terminator.
                else if (vowels.Contains(i)) //Checks if the current interator's value is a vowel.
                {
                    values[1]++;
                }
                else if (consonants.Contains(i)) //Same as above, jsut for consonants.
                {
                    values[2]++;
                }
                else if (i == '.' | i == '!' | i == '?')//If Typical Sentence Terminator found, add 1 to the Sentence Counter.
                                                        //Thanks Samuel Harwood for pointing out that sentences don't always end in a full stop.
                {
                    values[0]++;
                }  
            }
            
            //This Loop is for identifying the letter case via the use of Regex.
            foreach (var j in input)
            {
                //This uses a Regex to Identify Upper Case Letters.
                if (rxUpper.IsMatch(j.ToString()) == true)
                {
                    values[3]++;
                }
                //Same but for Lower Case Letters.
                else if (rxLower.IsMatch(j.ToString()) == true)
                {
                    values[4]++;
                }
            }

            //Identifies Words greater than/or equal to 7 letter in Length.
            values[5] = rxLongWord.Matches(input).Count();
            //Creates a Unique Filename for the Long Words Text File.
            string DT = DateTime.Now.ToString();
            DT = DT.Replace(":", "-");
            DT = DT.Replace("/", "_");
            DT = DT.Replace(@"\", "_");
            DT = DT.Replace(@" ", "_");
            string longWordFN = ("LongWords" + DT + ".txt");
            Console.WriteLine("\nThe file where you will find the list long words will\nbe in the directory of execution and named:\n" + longWordFN + "\n...\n");
            //Writes the Long Words File.
            var longWords = File.CreateText(longWordFN);
            foreach (var k in rxLongWord.Matches(input))
            {
                longWords.WriteLine(k);
            }
            longWords.Close();

            //Character Counter. Counts all characters and lists them in order of 1st Appearance.
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (var k in input.ToUpper().ToCharArray())
            {
                if (k == ((char)42)) { break; }
                else if (k == ((char)32)) { ; }//Ignores Spaces from the Character Count.
                
                else if (charCount.ContainsKey(k) == true) //If the character is already a key in the Dictionary it increments the key by 1.
                {
                    charCount[k]++;
                }
                else //Otherwise the Character is added to the Dictionary as a key with the initial value set to 1.
                {
                    charCount.Add(k, 1);
                }
            }

            //Outputs the Character Count.
            Console.WriteLine("Character Frequencies: ");
            foreach (char k in charCount.Keys)
            {
                Console.WriteLine(k + " " + charCount[k]);
            }
            Console.WriteLine();

            return values;
        }
    }
}




